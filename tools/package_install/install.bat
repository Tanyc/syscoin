@set path=%path%;%cd%\myadb
@set PACKAGE_NAME=ddz3_sina_changba.apk
@set FULL_PACKAGE_NAME=com.boyaa.lordland.changba

@echo 正在完整卸载...
adb uninstall %FULL_PACKAGE_NAME%

@echo 正在执行安装，请骚等...
adb install %cd%\%PACKAGE_NAME%