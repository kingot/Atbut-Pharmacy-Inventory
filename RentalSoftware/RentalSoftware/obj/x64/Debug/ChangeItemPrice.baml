   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	   $    RentalSoftware.ChangeItemPrice   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��400��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5      �� $��1��6   $��Select Drug Name *��6%   $��Right=�6?   $��Bottom=�6[   $��
0,0,5,16.7q�6v   $��16(�6�   �� 5!      -   5         ��Name$ ItemName��5!      $��1��6)   $��1��67   $	��264��6G   $
��Left=�6S   $��5,0,0,5q�5"       �� 
IsEditable . *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug��5#      $��18(�6E   $,��&Segoe UI, Lucida Sans Unicode, Verdana)�6S   
�����p�	 J� 	AllowDrop	 . 5$   ?   �� 5&      $��New Unit Price *��6   $��Right=�60   $��Bottom=�6L   $��
0,0,5,16.7q�5'      $��2��6,   $��0��69   $��16(�6I   *  $MahApps.Metro.Controls.NumericUpDown  5(      -   5        
  Name$
 NewUnitPrice��5(   %   $��1��6;   $	��264��6L   $
��Left=�6X   $��Bottom=�5)      $��5,0,0,5q�62   $��2��6C   $  New Unit Price��5*      $��18(�6J   $,��&Segoe UI, Lucida Sans Unicode, Verdana)�6X   
�����p�5-      �� 53      -   5        $
��Save��53   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��7��6u   $��1��6�   $��5,1,0,10q�6�   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   6�   �� 54        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 55      -   5         ��Name$ PriceChange��55      $��Change Drug Unit Price��6)   $��10,0,231,10q�6J   ���	#FFF7F3F3$��18(�6v   $��2��6�   �� 56      -   5         ��Name$ 
CancelTask��56      $��Cancel��6)   $��1��6:   $��160,3,194,10q�6J   $��7��6`   $��16(�6m   $
��Bold"�6{   ���	#FFD6D5D56�   57      59      5:      