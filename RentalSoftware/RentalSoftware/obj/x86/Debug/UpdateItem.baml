   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	       RentalSoftware.UpdateItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��400��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5       �� $��1��6   $��Category * ��6%   $��Right=�68   $��Bottom=�6T   $��
0,0,5,16.7q�6o   $��16(�6�   �� 5!      -   5         ��Name$ UpdateCategory��5!      $��1��6/   $��1��6=   $	��264��6M   $
��Left=�6Y   $��5,0,0,5q�5"      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug Category��5#      $��16(�6N   $��Arial)�6\   
�����p� �� MaxDropDownHeight$ 1��5$   -   $	 �� IsSynchronizedWithCurrentItem$
	 TrueY�6C   
 �� 
IsReadOnly
 . 6�   �� 5'      $��Drug Name * ��6   $��Right=�6,   $��Bottom=�6H   $��
0,0,5,16.7q�5(      $��2��6,   $��0��69   $��16(�6I   �� 5)      -   5         ��Name$ UpdateItemName��5)      $��1��6/   $	��264��6@   $
��Left=�6L   $��Bottom=�5*      $��5,0,0,5q�62   $��2��6C   $ 	Drug Name��5+      $��16(�6D   $��Arial)�6R      ClearTextButton . 
�����p�5,   D   �� 5/      $��Description��6   $��Right=�6+   $��Bottom=�6G   $��0,0,2,39q�50      $��3��6*   $��0��67   $��16(�6G   �� 51      -   5        $ UpdateItemDescription��51      $��1��66   $	��346��6G   $
��Left=�6S   $��Bottom=�52      $��5,0,0,5q�62   $��3��6C    �� TextWrapping$
 Wrap=�6�   $ Drug Description��53      $��16(�6K   $��Arial)�6Y    . 
�����p�$��87��54   [   $ �� HorizontalScrollBarVisibility$ Disabled=�6g   " �� VerticalScrollBarVisibility$
 Auto=�6�   �� 58      $��Unit Price * ��6   $��Right=�6-   $��Bottom=�6I   $��
0,0,5,16.7q�59      $��4��6,   $��0��69   $��16(�6I   *  $MahApps.Metro.Controls.NumericUpDown  5:      -   5          Name$ UpdateUnitPrice��5:   %   $��1��6>   $	��264��6O   $
��Left=�6[   $��Bottom=�5;      $��5,0,0,5q�62   $��4��6C   $ 
Unit Price��5<      $��16(�6E   $��Arial)�6S   
�����p�5@      �� 5B      $��Quantity * ��6   $��5��6+   $��0��68   $��
0,0,5,16.7q�6H   $��Right=�6\   $��Bottom=�6x   $��16(�6�     5D      -   5        $ UpdateItemQuantity��5D   %   $��1��6A   $	��264��6Q   $
��Left=�6]   $��Bottom=�5E      $��5,0,0,5q�62   $��5��6C   $ Quantity��5F      $��16(�6C   $��Arial)�6Q   
�����p�5I      �� 5L      -   5        $
��Save��5L   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��7��6u   $��1��6�   $��5,1,0,10q�6�   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   6�   �� 5M        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 5N      -   5         ��Name$
 Item��5N      $��Update Drug Information��6"   $��10,0,231,10q�6D   ���	#FFF7F3F3$��18(�6p   $��2��6~   �� 5O      -	   5         ��Name$ UpdateCancel��5O      $��Cancel��6+   $��1��6<   $��160,3,194,10q�6L   $��7��6b   $��16(�6o   $
��Bold"�6}   ���	#FFD6D5D56�   5P      5R      5S      