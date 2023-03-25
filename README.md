# MAUI_PulldownRefresh
## What is this?
A simple MAUI Blazor application to demonstrate how to implement a PullDown refresh scheme
## Possible enhancements
As the RefreshView is created at the MainPage.xaml level then all pages will show the Pulldown UI when the page is pulled. It'd be nice to implement a way to disable the RefreshView on pages that don't require this functionality.
## Notes
The RefreshView isn't enabled in Windows, so on that platform this will do nothing.
