   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	   #    RentalSoftware.ChangePassword   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   
   $	��400��6   $	��700��6       AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6,    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5      �� $��1��6   $��Username * ��6%   $��Right=�68   $��Bottom=�6T   $��
0,0,5,16.7q�6o   $��16(�6�   �� 5!      -   5         ��Name$ Username��5!      $��1��6(   $��1��66   $	��264��6F   $
��Left=�6R   $��5,0,0,5q�5"      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Username��5#      $��18(�6B   $,��&Segoe UI, Lucida Sans Unicode, Verdana)�6P   
�����p�5$      �� 5&      $��New Password * ��6   $��Right=�6/   $��Bottom=�6K   $��
0,0,5,16.7q�5'      $��2��6,   $��0��69   $��16(�6I   G� 5(      -   5         G�Name$ NewPassword��5(      $��1��6/   $	��264��6@   $
��Left=�6L   $��Bottom=�5)      $��5,0,0,5q�62   $��2��6C   $ New Password��5*      $��18(�6G   $,��&Segoe UI, Lucida Sans Unicode, Verdana)�6U   
�����p�5-      �� 5/      $��Confirm New Password * ��6   $��Right=�67   $��Bottom=�6S   $��
0,0,5,16.7q�50      $��3��6,   $��0��69   $��16(�6I   G� 51      -   5        $ ConfirmNewPassword��51      $��1��66   $	��264��6G   $
��Left=�6S   $��Bottom=�52      $��5,0,0,5q�62   $��3��6C   $ Confirm New Password��53      $��18(�6O   $,��&Segoe UI, Lucida Sans Unicode, Verdana)�6]   
�����p�56      �� 58      $��4��6   $	��264��6&   $
��Wrap=�62   $��14(�6F   $��1��6T   $��
5,1,194,46q�6d   $��2��6x   31Please make sure you keep your password secretly.5:      �� 5@      -   5        $
��Save��5@   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��4��6u   $��1��6�   $��	5,46,0,-1q�6�   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   6�   �� 5A        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 5B      -   5        	 ��Name$	 change��5B      $��Reset or Change Password��6$   $��10,0,231,10q�6G   ���	#FFF7F3F3$��18(�6s   $��2��6�   �� 5C      -   5        
 ��Name$
 
CancelTask��5C      $��Cancel��6)   $��1��6:   $��174,46,194,-1q�6J   $��4��6a   $��16(�6n   $
��Bold"�6|   ���	#FFD6D5D56�   5D      5F      5G      