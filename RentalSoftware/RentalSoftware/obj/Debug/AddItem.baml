   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	       RentalSoftware.AddItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��470��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
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
0,0,5,16.7q�6o   $��16(�6�   �� 5!      -   5         ��Name$ Category��5!      $��1��6)   $��1��67   $	��264��6G   $
��Left=�6S   $��5,0,0,5q�5"      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug Category��5#      $��16(�6N   $��Arial)�6\   
�����p� �� 
IsReadOnly . 5$   F   �� 5'      $��2��6   $��0��6%   $��Vendor ��65   $��Right=�6D   $��Bottom=�6`   $��
0,0,5,16.7q�6{   $��16(�6�   �� 5(      -   5        $ Vendor��5(      $��2��6'   $��1��65   $	��264��6E   $
��Left=�6Q   $��5,0,0,5q�5)      $ Select Vendor��5*      $��16(�6G   $��Arial)�6U   
�����p� . 5+   F   �� 5.      $��Drug Name * ��6   $��Right=�6,   $��Bottom=�6H   $��0,0,5,4q�5/      $��3��6)   $��0��66   $��16(�6F   �� 50      -   5        	 ��Name$	 ItemName��50      $��1��6)   $	��264��6:   $
��Left=�6F   $��Bottom=�51      $��5,0,0,5q�62   $��3��6C   $ 	Drug Name��52      $��16(�6D   $��Arial)�6R   
   ClearTextButton
 . 
�����p�53   D   �� 56      $��Description��6   $��Right=�6+   $��Bottom=�6G   $��0,0,2,39q�57      $��4��6*   $��0��67   $��16(�6G   �� 58      -   5        $	 ItemDescription��58      $��1��60   $	��346��6A   $
��Left=�6M   $��Bottom=�59      $��5,0,0,5q�62   $��4��6C    �� TextWrapping$
 Wrap=�6�   $ Drug Description��5:      $��16(�6K   $��Arial)�6Y   
 . 
�����p�$��87��5;   [   $ �� HorizontalScrollBarVisibility$ Disabled=�6g   " �� VerticalScrollBarVisibility$
 Auto=�6�   �� 5?      $��Unit Price * ��6   $��Right=�6-   $��Bottom=�6I   $��0,0,4,7q�5@      $��5��6)   $��0��66   $��16(�6F   *  $MahApps.Metro.Controls.NumericUpDown  5A      -   5          Name$ 	UnitPrice��5A   %   $��1��68   $	��264��6I   $
��Left=�6U   $��Bottom=�5B      $��5,0,0,5q�62   $��5��6C   $ 
Unit Price��5C      $��16(�6E   $��Arial)�6S   
�����p�5G      �� 5I      $��	Quantity ��6   $��6��6)   $��0��66   $��
0,0,5,16.7q�6F   $��Right=�6Z   $��Bottom=�6v   $��16(�6�     5K      -   5        $ ItemQuantity��5K   %   $��1��6;   $	��264��6K   $
��Left=�6W   $��Bottom=�5L      $��5,0,0,5q�62   $��6��6C   $ Quantity��5M      $��16(�6C   $��Arial)�6Q   
�����p�5P      �� 5S      -   5        $
��Save��5S   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��7��6u   $��1��6�   $��5,1,0,10q�6�   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   6�   �� 5T        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 5U      -	   5         ��Name$ 
AddNewItem��5U      $��Add New Drug��6(   $��10,0,231,10q�6?   ���	#FFF7F3F3$��18(�6k   $��2��6y   �� 5V      -
   5         ��Name$ Cancel��5V      $��Cancel��6%   $��1��66   $��160,3,194,10q�6F   $��7��6\   $��16(�6i   $
��Bold"�6w   ���	#FFD6D5D56�   5W      5Y      5Z      