@echo off
set /p var=是否要卸载 WCF服务(Y/N):
if "%var%" == "y" (goto uninstall) else (goto batexit)

:uninstall
call C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /u KeepAlive.exe
pause

:batexit
exit