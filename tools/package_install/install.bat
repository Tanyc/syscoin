@set path=%path%;%cd%\myadb
@set PACKAGE_NAME=ddz3_sina_changba.apk
@set FULL_PACKAGE_NAME=com.boyaa.lordland.changba

@echo ��������ж��...
adb uninstall %FULL_PACKAGE_NAME%

@echo ����ִ�а�װ����ɧ��...
adb install %cd%\%PACKAGE_NAME%