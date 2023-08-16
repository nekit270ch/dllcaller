@echo off
csc /nologo /out:example.exe ..\dllcaller.cs example.cs
pause > nul