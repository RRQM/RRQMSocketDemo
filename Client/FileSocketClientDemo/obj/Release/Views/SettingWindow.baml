   M S B A M L   `   `   `  ���� A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.ViewsClient.Views  O KRRQMSkin, Version=1.0.8.0, Culture=neutral, PublicKeyToken=8f999a2ed33dcd585(clr-namespace:RRQMSkin;assembly=RRQMSkinRRQMSkin Q MRRQMSocket, Version=1.0.6.0, Culture=neutral, PublicKeyToken=a9db37c9b0783a15;,clr-namespace:RRQMSocket;assembly=RRQMSocket
RRQMSocket      Client.Views.SettingWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:Client.Views     9rrqm(clr-namespace:RRQMSkin;assembly=RRQMSkin     C
rrqmSocket,clr-namespace:RRQMSocket;assembly=RRQMSocket       RRQMSkin.RRQMWindow    
ResizeMode$  NoResize=� � Title$ 设置��$	��450��$	��650�� � WindowStartupLocation$ CenterScreen=�   WindowStyle$ 
ToolWindow=�.��� $��Center=� � RowDefinitions �� �� $��70 �.+�� $��40,0,0,0q�.+���  �� Orientation$ Vertical=�.+��� $ 
Horizontal=�.+��� $	��IP:��$��10,0,0,0q��� $	��120������ *
ClientIP+�� $��Port:��$��10,0,0,0q��� $��50������ *
ClientPort+�� $
��0,10q�$ 
Horizontal=�.+��� $��自动接收��$��Center=�$��10,0,0,0q� d� 	IsChecked �� *IsAutoReceive+�� $
��0,10q�$ 
Horizontal=�.+��� $!��默认文件接收位置：��  RRQMSkin.InputBox     TipText"  RRQMSkin.TipTextBoxConverter$! 文件夹必须以'\'结尾 $	��354������ *ClientReceiveDir+  RRQMSkin.CorrugatedButton  $��1��$��保存��$��Center=�$��Center=�$	��100��$��10q����� *SaveCommand+