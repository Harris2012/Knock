@echo off
set /p var=�Ƿ�Ҫ��װ WCF ����(Y/N):
if "%var%" == "y" (goto install) else (goto batexit)

:install
call C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe KeepAlive.exe
pause

:batexit
exit