   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	       RentalSoftware.ReturnItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��400��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   � $��
0,10,0,-10q�6    � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $	��73* �6    �� 5      $
��129* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5      �� $��2��6   $��Select Drug Name * ��6%   $��Right=�6@   $��Bottom=�6\   $��	0,0,455,6q�6w   $��16(�6�   $��2��6�   $��19��6�   $	��144��6�   �� 5#      -   5         ��Name$ ReturnItemName��5#      $��2��6.   $��1��6<   $	��274��6L   $
��Left=�6X   $��18,9,0,3q�5$      $��18(�5%      $��Arial)�6$   
�����p�$��2��5&   -   $��44��6>    �� 
IsReadOnly . 6J   �� 5(      $��Quantity Return * ��6   $��Right=�62   $��Bottom=�6N   $��
0,0,455,48q�5)      $��4��6,   $��0��69   $��16(�6I   $��2��6W   $��19��6k   $	��131��6w   *  $MahApps.Metro.Controls.NumericUpDown  5*      -   5          Name$ QuantityReturn��5*   %   $��1��6=   $	��274��6N   $
��Left=�6Z   $��Bottom=�5+      $��	18,0,0,35q�62   $��4��6E   *  $MahApps.Metro.Controls.TextBoxHelper	   	Watermark$	 Quantity Return��5,      $��18(�6J   $��Arial)�6X   
�����p�$��44��5-   -   5/      �� 51      $��4��6   $
��Wrap=�6%   $��14(�69   $��1��6G   $��20,46,171,54q�6W   $��2��6m   JHPlease note that, the quantity return will be added to item total stock.53      �� 59      -   5        $
��Save��59   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��5��6u   $��1��6�   $��
20,18,0,10q�6�   $
��Left=�6�   $	��105��6�   $
��Bold"�6�   6�   �� 5:        AccentColorBrush3#���  6   
���   �$��
0,-10,0,19q�6R   $��2��6f   �� 5;      -   5        
 ��Name$
 return��5;      $��Return Drug to Store��6$   $��10,-10,231,19q�6C   ���	#FFF7F3F3$��18(�6q   $��2��6   �� 5<      -   5         ��Name$ 
CancelTask��5<      $��Cancel��6)   $��1��6:   $��194,18,171,10q�6J   $��5��6a   $��16(�6n   $
��Bold"�6|   ���	#FFD6D5D56�   5=      5?      5@      