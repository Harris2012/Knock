@echo off
set /p var=�Ƿ�Ҫж�� WCF����(Y/N):
if "%var%" == "y" (goto uninstall) else (goto batexit)

:uninstall
call C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /u KeepAlive.exe
pause

:batexit
exit