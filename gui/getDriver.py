import os
import sys
import win32api
import win32con
from webdriver_manager.microsoft import EdgeChromiumDriverManager
if hasattr(sys, 'frozen'):
    application_path = os.path.dirname(sys.executable)
else:
    application_path = os.path.dirname(os.path.abspath(__file__))
try:
    driver_path = EdgeChromiumDriverManager().install()
    f = open(f'{application_path}\\driver.txt', 'w', encoding='utf-8')
    f.write(driver_path)
    f.close()
    win32api.MessageBox(0, "初始化成功", "提示", win32con.MB_ICONASTERISK)
except:
    win32api.MessageBox(0, "初始化失败，请关闭VPN或检测网络再重新执行", "提示", win32con.MB_ICONASTERISK)