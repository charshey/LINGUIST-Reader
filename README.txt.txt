Clare Harshey
CSCI-A590
12/8/17
Final Project

****************
LINGUIST Reader
****************

This program is meant to provide a Windows application to view and save issues of the LINGUIST List. The design has been updated since storyboarding. Changes listed below:

- browse and read windows collapsed into one; most of the functionality is the same and since users are reading from locally saved issues in this version, it would have been implementing the same thing twice. 
- no dialog box for editing comments and saving issue; that functionality is embedded in the larger browse form.
- readers can view all bookmarked issues from one button in the browse form.

There are still some things that have not been completely ironed out in this version. Major bugs listed below:
- checking/unchecking all areas results in slow, flashing re-populating of the preview panel. 

This program pulls its data from the Issues folder, which is located inside the Debug folder from which the program is running. For your convenience, there is a copy of the Issues folder located in the root folder as well. 

Please note that the html issues in the Issues folder must have an accompanying file named "xx-xxxx_files", where xx-xxxx is the title of the html file. This folder contains images necessary to view the issue in the web browser.

The issues folder is where a saved.txt file will be stored (if one is needed). This file contains the data on any issues that have non-default comments or bookmarks. This allows for state persistence, so the user's interaction with issues is still there when the program is started again. A missing saved.txt file will mean all the issues will be un-bookmarked and have no user comments.

There is a documentation Help file located in the root folder. Help/index.html will show class structure of this application's code. A pdf user guide is also available in the root folder.

Thanks and enjoy!

