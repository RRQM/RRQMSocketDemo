   M S B A M L   `   `   `  ���� B  >Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Service.ViewsService.Views  O KRRQMSkin, Version=1.0.8.0, Culture=neutral, PublicKeyToken=8f999a2ed33dcd585(clr-namespace:RRQMSkin;assembly=RRQMSkinRRQMSkin Q MRRQMSocket, Version=1.0.6.0, Culture=neutral, PublicKeyToken=a9db37c9b0783a15;,clr-namespace:RRQMSocket;assembly=RRQMSocket
RRQMSocket !    Service.Views.SettingWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:Service.Views     9rrqm(clr-namespace:RRQMSkin;assembly=RRQMSkin     C
rrqmSocket,clr-namespace:RRQMSocket;assembly=RRQMSocket       RRQMSkin.RRQMWindow    
ResizeMode$  NoResize=� � Title$ 设置��$	��450��$	��650�� � WindowStartupLocation$ CenterScreen=�   WindowStyle$ 
ToolWindow=�.��� $��Center=� � RowDefinitions �� �� $��70 �.+�� $��40,0,0,0q�.+���  �� Orientation$ Vertical=�.+��� $ 
Horizontal=�.+��� $	��IP:��$��10,0,0,0q��� $	��120������ *	ServiceIP+�� $��Port:��$��10,0,0,0q��� $��50������ *ServicePort+�� $��10,0,0,0q�$��自动检测活性��$��Center=� d� 	IsChecked �� *IsAutoCheckAlive+�� $ 
Horizontal=�$
��0,10q�.+��� $��线程托管数量��$
��10,5q��� $��62������ *CustomThreadNumber+�� $
��0,10q�$ 
Horizontal=�.+��� $��快速上传��$��10,0,0,0q�$��Center=� �� *IsFsatTransmission+�� $��心跳模式��$��10,0,0,0q�$��Center=� �� *HeartbeatEnable+�� $��断点续传��$��10,0,0,0q�$��Center=� �� *BreakpointResume+�� $��非阻塞休眠时间：��$��10,0,0,0q��� $��56������ *	SleepTime+�� $
��0,10q�$ 
Horizontal=�.+��� $��	密钥：��  RRQMSkin.InputBox     TipText"  RRQMSkin.TipTextBoxConverter$! 默认为空则是试用版 $	��462������ *
LicenceKey+�� $
��0,10q�$ 
Horizontal=�.+��� $!��默认文件接收位置：��  $! 文件夹必须以'\'结尾 $	��354������ *ServiceReceiveDir+  RRQMSkin.CorrugatedButton  $��1��$��保存��$��Center=�$��Center=�$	��100��$��10q����� *SaveCommand+