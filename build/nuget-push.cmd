setlocal EnableDelayedExpansion

del /f /q *.nupkg
call nuget-pack.cmd

"C:\Program Files\nuget\nuget.exe" push FastMem.x64.Windows.?.?.*.nupkg %1
