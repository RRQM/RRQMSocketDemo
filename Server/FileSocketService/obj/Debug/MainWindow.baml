   M S B A M L   `   `   `  ����  FileSocketServiceDemo&     FileSocketServiceDemo.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      O KRRQMSkin, Version=2.0.7.0, Culture=neutral, PublicKeyToken=1691c0176f5d64c0$controls若汝棋茗_Controls  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      "windows若汝棋茗_Windows  5        � Title$  	服务器��5      $	��800��5	      $	��600��5
      !  RRQMSkin.Windows.RRQMWindow   TitleContent$ 	服务器��5       � WindowStartupLocation$ CenterScreen=�5      ��5      
� 5   
   .��5      �  � Offset$ 1Q�6    � Color$ 	#FFA610EC��6&   � 5      $ 	#FF17A0EE��6   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6   $��3q�6    $��	服务器��6+   .��5      �  5      �� 5      $
��auto �6$   �� 5      .+�5       ��  �� Orientation$ 
Horizontal=�6   .+�5!      �� $	����6    $��Center=�60   $'��!/Service;component/Font/#iconfont)�6K   $��50(�6z   ��5"       �� *ServiceIconForeground+ � ToolTip 5#      �� 5$      $ Vertical=�6)   .+�5%   "   �� $
��0,10q�6B   ��6,   �� *Tip1+6B   �� 5&   "   $
��0,10q�6B   ��6,   �� *Tip2+6B   �� 5'   "   $
��0,10q�6B   ��6,   �� *Tip3+6B   5(      5*      (  "RRQMSkin.Controls.CorrugatedButton  5+      $��开启服务器��60   $��40��6@   $��90��6L   $��5q�6W   $��Center=�6b   $��Center=�5,   0   $��15(�5.   0   ��5-   0   �� *CreatServiceCommand+5.   0     5/      $��关闭服务器��60   $��40��6@   $��90��6L   $��5q�6W   $��Center=�6b   $��Center=�50   0   $��15(�52   0   ��51   0   �� *CloseServiceCommand+52   0   53      � 54      $��1��6    55      �� 56      $��2* �6(   �� 57      $��* �6(   .+�59      �� $	��3,5q�6   
������  �� DisplayMemberPath$
 Name��6D      ListBoxStyle#���   5<      ��5:      �� *ClientItems+	 �� SelectedItem	 5;      �� *SelectedClient+5<      � 5>      $��2��6   $��3��6(    5?      �� 5@      $
��auto �6,   �� 5A      .+�5C      �� $ 
Horizontal=�6%   .+�5D      �� $��允许下载��6'   $��5q�66   $��Center=�6A   
 d� 	IsChecked
 5E   '   �� *AllowDownload+�� 5F      $��允许上传��6'   $��5q�66   $��Center=�6A   
 5G   '   �� *AllowUpload+   RRQMSkin.Controls.InputBox  5H      $	��200��5I   0   $��5q�6<   $��Center=�6G   
������    TipText"  RRQMSkin.TipTextBoxConverter$! 选中客户端发送消息 6�   ��5H   0   �� *ServiceSendText+5I   �     5J      $��发送��68   $��30��6E   $��60��6Q   $��5q�6\   $��Center=�6g   $��Center=�5K   8   ��5L   8   �� *ServiceSendCommand+5M      �� 5N      $��1��5O   "   $��3q�6/   
������  �� TextWrapping$
 Wrap=�6S   " �� VerticalScrollBarVisibility$ Visible=�6g   ��5N   "   �� *ServiceMessageBoxText+ �� Mode$ TwoWay=�5O   g   5P      5Q      5S      5T      5V      5W      