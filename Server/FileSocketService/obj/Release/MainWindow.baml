   M S B A M L   `   `   `  ���� B  >Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ServiceService  O KRRQMSkin, Version=1.0.8.0, Culture=neutral, PublicKeyToken=8f999a2ed33dcd585(clr-namespace:RRQMSkin;assembly=RRQMSkinRRQMSkin     Service.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Service     9rrqm(clr-namespace:RRQMSkin;assembly=RRQMSkin       � Title$  	服务器��  RRQMSkin.RRQMWindow   TitleContent$ 	服务器��$	��800��$	��600��   CornerRadius$ 5�� � WindowStartupLocation$ CenterScreen=���
� .���  � Color$ 	#FFA610EC�� � Offset$ 1Q�� $ 	#FF17A0EE��.���  � RowDefinitions �� $
��Auto ��� .+�o� $��2��
������ .@�m� $��设置�� m� Command �� *SettingWindowsCommand+�� $��	服务器��$��1��$��3q�.���  �� $
��auto ��� .+���  �� Orientation$ 
Horizontal=�.+��� $	����$'��!/Service;component/Font/#iconfont)�$��50(�$��Center=����� *ServiceIconForeground+	 � ToolTip	 �� $ Vertical=�.+��� $
��0,10q����� *Tip1+�� $
��0,10q����� *Tip2+�� $
��0,10q����� *Tip3+  RRQMSkin.CorrugatedButton  $��40��$��Center=�$��Center=�$��90��$��5q�$��开启服务器��$��15(����� *CreatServiceCommand+  $��40��$��Center=�$��Center=�$��90��$��5q�$��关闭服务器��$��15(����� *CloseServiceCommand+�� $��Center=�$	��300��.+��� $��3q�.+��� $ 
Horizontal=�.+��� $��最大下载速度：��$��12(��� $��12(����� *MaxDownloadSpeed+
 �� StringFormat$	
 0Kb����  � Minimum$ 1Q� � Maximum$ 102400Q� � Value �� *MaxDownloadSpeed+�� $��3q�.+��� $ 
Horizontal=�.+��� $��最大上传速度：��$��12(��� $��12(����� *MaxUploadSpeed+$	
 0Kb���� $ 1Q�$ 102400Q� �� IsSnapToTickEnabled .  �� *MaxUploadSpeed+� $��1�� � ColumnDefinitions �� �� $��3 ���  �� $��2* ��� $��* �.+��� $	��3,5q�
������  �� DisplayMemberPath$
 Name�� �� SelectedItem �� *SelectedClient+���� *ClientItems+�� 
������ $��Stretch=�$��1��$��Stretch=�� $��2��.+��� 
������ $��1��$	��3,5q�$ FileInfo.FileName������ *ClientDownloadFiles+ �� Mode$ OneWay=�� $��2��$��3�� �� $
��auto ��� .+��� $ 
Horizontal=�.+��� $��允许下载��$��Center=�$��5q� d� 	IsChecked �� *AllowDownload+�� $��允许上传��$��Center=�$��5q� �� *AllowUpload+  RRQMSkin.InputBox  
������    TipText"  RRQMSkin.TipTextBoxConverter$! 选中客户端发送消息 $��Center=�$	��200��$��5q����� *ServiceSendText+  $��发送��$��5q�$��60��$��30��$��Center=�$��Center=����� *ServiceSendCommand+�� $��1��
������ $��3q�" �� VerticalScrollBarVisibility$ Visible=� �� TextWrapping$
 Wrap=����� *ServiceMessageBoxText+$ TwoWay=�