   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	   $    RentalSoftware.AddItemCategory   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$   ��5	   	   $	��400��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5      �� $��1��6   $��Category Name * ��6%   $��Right=�6=   $��Bottom=�6Y   $��0,0,9,9q�6t   $��16(�6�   �� 5      -   5         ��Name$ CategoryName��5      $��1��6,   $��1��6:   $	��264��6J   $
��Left=�6V   $��5,0,0,5q�5      *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$ Category Name��5       $��18(�6G   $,��&Segoe UI, Lucida Sans Unicode, Verdana)�6U   
�����p�5!      �� 5$      $��Category Description * ��6   $��Right=�67   $��Bottom=�6S   $��	0,0,10,43q�5%      $��2��6+   $��0��68   $��16(�6H   �� 5&      -   5        $ CategoryDescription��5&      $��1��64   $	��387��6E   $
��Left=�6Q   $��Bottom=�5'      $��5,0,0,5q�62   $��2��6C   $	��100��6Q   $��18(�5(      $,��&Segoe UI, Lucida Sans Unicode, Verdana)�6&   $ Category Description��6Z    . 
�����p�	 �� TextWrapping$
	 Wrap=�5)   [   "
 �� VerticalScrollBarVisibility$

 Auto=�6o   �� 5.      -   5        $
��Save��5.   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��7��6u   $��1��6�   $��5,1,0,10q�6�   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   6�   �� 5/        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 50      -   5         ��Name$ AddCategory��50      $��Add New Drug Category��6)   $��10,0,231,10q�6I   ���	#FFF7F3F3$��18(�6u   $��2��6�   �� 51      -   5         ��Name$ Cancel��51      $��Cancel��6%   $��1��66   $��160,3,194,10q�6F   $��7��6\   $��16(�6i   $
��Bold"�6w   ���	#FFD6D5D56�   52      54      55      