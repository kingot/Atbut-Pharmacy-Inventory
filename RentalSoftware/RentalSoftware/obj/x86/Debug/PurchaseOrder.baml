   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	   "    RentalSoftware.PurchaseOrder   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��470��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5       �� $��1��6   $��Select Drug Name * ��6%   $��Right=�6@   $��Bottom=�6\   $��
0,0,5,16.7q�6w   $��16(�6�   �� 5!      -   5         ��Name$
 Item��5!      $��1��6%   $��1��62   $	��264��6B   $
��Left=�6N   $��5,0,0,5q�5"      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug Name��5#      $��16(�6J   $��Arial)�6X   
�����p� �� 
IsEditable . 5$   h   �� 5'      $��2��6   $��0��6%   $��Vendor *��65   $��Right=�6E   $��Bottom=�6a   $��
0,0,5,16.7q�6|   $��16(�6�   �� 5(      -   5        $ Vendor��5(      $��2��6'   $��1��64   $	��264��6D   $
��Left=�6P   $��5,0,0,5q�5)       . $ Select Vendor��5*      $��16(�6G   $��Arial)�6U   
�����p�5+   -   �� 5.      $��Unit Price * ��6   $��Right=�6-   $��Bottom=�6I   $��
0,0,5,16.7q�5/      $��5��6,   $��0��69   $��16(�6I   *  $MahApps.Metro.Controls.NumericUpDown  50      -   5        	  Name$	 	UnitPrice��50   %   $��1��68   $	��264��6I   $
��Left=�6U   $��Bottom=�51      $��5,0,0,5q�62   $��5��6C   $ 
Unit Price��52      $��16(�6E   $��Arial)�6S   
�����p�56      �� 58      $��Quantity * ��6   $��6��6+   $��0��68   $��
0,0,5,16.7q�6H   $��Right=�6\   $��Bottom=�6x   $��16(�6�     5:      -   5        $	 ItemQuantity��5:   %   $��1��6;   $	��264��6K   $
��Left=�6W   $��Bottom=�5;      $��5,0,0,5q�62   $��6��6C   $ Quantity��5<      $��16(�6C   $��Arial)�6Q   
�����p�5?      �� 5A      $��Total Cost ₵��6   $��7��6,   $��0��69   $��0,0,5,9q�6I   $��Right=�6Z   $��Bottom=�6v   $��16(�6�   �� 5B      -   5        
 ��Name$
 	TotalCost��5B      $��1��6*   $	��264��6;   $
��Left=�6G   $��Bottom=�5C      $��5,0,0,5q�62   $��7��6C   $��24(�5D      $��Arial)�6&   $��Normal"�69    �� 
IsReadOnly . 
�����p�5E      �� 5H      -   5        $
��Save��5H   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��7��6u   $��1��6�   $��
5,59,0,-48q�6�   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   6�   �� 5I        AccentColorBrush3#���  6   
���   �$��0,0,0,20q�6R   $��2��6d   �� 5J      -   5         ��Name$ MakePurchaseOrder��5J      $��Make a Purchase Order��6/   $��10,0,231,20q�6O   ���	#FFF7F3F3$��18(�6{   $��2��6�   �� 5K      -	   5         ��Name$ Cancel��5K      $��Cancel��6%   $��1��66   $��160,61,194,-48q�6F   $��7��6^   $��16(�6k   $
��Bold"�6y   ���	#FFD6D5D56�   5L      5N      5O      