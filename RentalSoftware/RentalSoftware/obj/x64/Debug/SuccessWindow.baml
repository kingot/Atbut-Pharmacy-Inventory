   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	   "    RentalSoftware.SuccessWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	      $	��205��6   $	��350��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6*    � WindowState$ Normal=�5
       � WindowStartupLocation$ CenterScreen=�6,      	TitleCaps .     WindowTitleBrush
 � � �    NonActiveWindowTitleBrush# �   5       � 
ResizeMode$ NoResize=�6V   )   "OverrideDefaultWindowCommandsBrush$ Black��6l   .��5      � ���	#FFF1F1F1.+�5   
   � 	 � RowDefinitions	 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    
 � ColumnDefinitions
 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5      �� -   5         ��Name$ SuccessMessage��5      $��Center=�60   $��Bottom=�6M   $��2��5       $��2��6%   $��16(�69   $
��Wrap=�6G   �� 5"      -   5        $
��Save��5"   �   
��� � �
�������$��16(�6;   $��OK��6I   $��4��6V   $��1��6c   $��	5,46,0,-1q�6s   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   6�   �� 5#      
��� � �
���   �$��0,0,0,17q�64   $��2��6F   �� 5$      -   5         ��Name$ error��5$      $��Success Message��6#   $��10,0,162,10q�6=   ���	#FFF7F3F3$��18(�6i   $��2��6w   5&      5(      5)      