# Today
Just a stupid simple utility that traverses a directory structure looking for folders ending in "TODAY".  Matching folders are renamed to "MM-DD - TODAY".

I use this for long running projects with due dates organized into different folders.  I like to keep an up-to-date TODAY folder in each project folder, so I can quickly compare the current date in a way that's visually consistent with the other folders.

# e.g.
```
/ project-thing
    / 02-24 - TODAY
    / 02-28 - TPS Report
    / 03-24 - TPX Report
/ another-project-thing
    / 02-24 - TODAY
    / 02-25 - BOB PLAN
/ today.exe
```

Running **today.exe** on 02/25/2025 would result in this:

```
/ project-thing
    / 02-25 - TODAY
    / 02-28 - TPS Report
    / 03-24 - TPX Report
/ another-project-thing
    / 02-25 - TODAY
    / 02-25 - BOB PLAN
/ today.exe
```