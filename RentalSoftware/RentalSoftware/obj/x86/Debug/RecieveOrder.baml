   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	   !    RentalSoftware.RecieveOrder   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$   ��5	   	   $	��470��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5       $��* �6#   �� 5!      $��2* �6#   .+�5#      �� $��1��6   $��Select Drug Name * ��6%   $��Right=�6@   $��0,1,5,17q�6\   $��16(�6n   �� 5$      -   5         ��Name$
 Item��5$      $��1��6%   $��1��62   $	��264��6B   $
��Left=�6N   $��5,0,0,5q�5%      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug Name��5&      $��16(�6J   $��Arial)�6X   
�����p� �� 
IsEditable . 5'   h   �� 5*      $��2��6   $��0��6%   $��Vendor *��65   $��Right=�6E   $��Bottom=�6a   $��
0,0,5,16.7q�6|   $��16(�6�   �� 5+      -   5        $ Vendor��5+      $��2��6'   $��1��64   $	��264��6D   $
��Left=�6P   $��5,0,0,5q�5,       . $ Select Vendor��5-      $��16(�6G   $��Arial)�6U   
�����p�5.   -   �� 51      $��Unit Price ��6   $��Right=�6+   $��Bottom=�6G   $��
0,0,5,16.7q�52      $��5��6,   $��0��69   $��16(�6I   �� 53      -   5        	 ��Name$	 PurchaseUnitPrice��53      $��1��61   $	��264��6B   $
��Left=�6N   $��Bottom=�54      $��5,0,0,5q�62   $��5��6C   $��16(�55      $��Arial)�6%   
�����p�.��58      59      �� 5;      $��Quantity Purchased��6   $��6��62   $��0��6?   $��
0,0,5,16.7q�6O   $��Right=�6c   $��Bottom=�6   $��16(�6�   �� 5=      -   5        $	 PurchaseQuantity��5=      $��1��60   $	��264��6@   $
��Left=�6L   $��Bottom=�5>      $��5,0,0,5q�62   $��6��6C   $��16(�5?      $��Arial)�6%   
�����p�.��5@   ,   5B      �� 5D      $��Total Cost ₵��6   $��7��6,   $��0��69   $��0,0,5,9q�6I   $��Right=�6Z   $��Bottom=�6v   $��16(�6�   �� 5E      -   5        $	 	TotalCost��5E      $��1��6*   $	��264��6;   $
��Left=�6G   $��Bottom=�5F      $��5,0,0,5q�62   $��7��6C   $��24(�5G      $��Arial)�6&   $��Normal"�69   
 �� 
IsReadOnly
 . 
�����p�5H      �� 5L      $��Quantity Recieveing *��6   $��8��65   $��0��6B   $��0,0,4,8q�6R   $��Right=�6c   $��Bottom=�6   $��16(�6�   *  $MahApps.Metro.Controls.NumericUpDown  5N      -   5          Name$ QuantityRecieve��5N   %   $��1��6>   $	��264��6N   $
��Left=�6Z   $��Bottom=�5O      $��5,0,0,5q�62   $��8��6C   $��16(�5P      $��Arial)�6%   
�����p�5S      �� 5U      -   5        $
��Save��5U   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��9��6u   $��1��6�   $��	5,8,0,-43q�6�   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   �� 5V        AccentColorBrush3#���  6   
���   �$��0,0,0,20q�6R   $��2��6d   �� 5W      -   5         ��Name$ RecievOrder��5W      $%��Recieve Purchase Order to Store��6)   $��10,0,231,20q�6S   ���	#FFF7F3F3$��18(�6   $��2��6�   �� 5X      -	   5         ��Name$ Cancel��5X      $��Cancel��6%   $��1��66   $��160,10,194,-43q�6F   $��9��6^   $��16(�6k   $
��Bold"�6y   ���	#FFD6D5D56�   5Y      5[      5\      