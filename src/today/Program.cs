using System;
using System.IO;
using System.Text.RegularExpressions;

namespace today
{
   class Program
   {
      static void Main(string[] args)
      {
         var source = args.Length > 0 ? args[0] : Environment.CurrentDirectory;

         TodaySubdirectories(new DirectoryInfo(source));
      }

      private static void TodaySubdirectories(DirectoryInfo directory)
      {
         foreach (var d in directory.GetDirectories())
         {
            if (IsTodayTarget(d, out var format))
               TodayDirectory(directory,d, format);
            else
               TodaySubdirectories(d);
         }
      }

      private static bool IsTodayTarget(DirectoryInfo directory, out string format)
		{
			const string pattern = "(today)";

			var match = Regex.Match(directory.Name, pattern, RegexOptions.IgnoreCase);

			format = match.Success ? match.Groups[1].Value : default;

			return match.Success;
		}

      private static void TodayDirectory(DirectoryInfo parent, DirectoryInfo source, string today)
      {
	      var folder = $"{DateTime.Today:MM-dd} - {today}";

	      if (string.Equals(folder, source.Name, StringComparison.OrdinalIgnoreCase))
		      return;

			var target = Path.Combine(parent.FullName, folder);
         source.MoveTo(target);
      }
   }
}
