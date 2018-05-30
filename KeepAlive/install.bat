@echo off
set /p var=是否要安装 WCF 服务(Y/N):
if "%var%" == "y" (goto install) else (goto batexit)

:install
call C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe KeepAlive.exe
pause

:batexit
exit