   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	       RentalSoftware.BrokenItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��400��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5      �� $��1��6   $��Select Drug Name * ��6%   $��Right=�6@   $��Bottom=�6\   $��
0,0,5,16.7q�6w   $��16(�6�   �� 5!      -   5         ��Name$ BrokenItemName��5!      $��1��6/   $��1��6=   $	��264��6M   $
��Left=�6Y   $��5,0,0,5q�5"       �� 
IsEditable . *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug��5#      $��16(�6E   $��Arial)�6S   
�����p�5$   -   �� 5&      $��Quantity Expired * ��6   $��Right=�63   $��Bottom=�6O   $��0,0,5,4q�5'      $��2��6)   $��0��66   $��16(�6F   *  $MahApps.Metro.Controls.NumericUpDown  5(      -   5        	  Name$	 BrokenQuantity��5(   %   $��1��6=   $	��264��6N   $
��Left=�6Z   $��Bottom=�5)      $��5,0,0,5q�62   $��2��6C   $ Quantity Expired��5*      $��16(�6K   $��Arial)�6Y   
�����p�5-      �� 5.      -   5        
 ��Name$
 Comment��5.      $��1��6(   $	��346��69   $
��Left=�6E   $��Bottom=�5/      $��5,0,0,5q�62   $��3��6C    �� TextWrapping$
 Wrap=�6   $ Leave a comment��50      $��16(�6J   $��Arial)�6X      ClearTextButton . 
�����p�$��87��51   [   $ �� HorizontalScrollBarVisibility$ Disabled=�6g   " �� VerticalScrollBarVisibility$
 Auto=�6�   �� 53      $��4��6   $	��264��6&   $
��Wrap=�62   $��14(�6F   $��1��6T   $��
7,3,192,38q�6d   PNPlease note that, the quantity Expired will be deducted from Drug total stock.55      �� 5;      -   5        $
��Save��5;   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��4��6u   $��1��6�   $��	5,46,0,-1q�6�   $
��Left=�6�   $	��102��6�   $
��Bold"�6�   6�   �� 5<        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 5=      -   5         ��Name$ Broken��5=      $��Record Expiry Drugs��6$   $��10,0,231,10q�6B   ���	#FFF7F3F3$��18(�6n   $��2��6|   �� 5>      -   5         ��Name$ 
CancelTask��5>      $��Cancel��6)   $��1��6:   $��174,46,194,-1q�6J   $��4��6a   $��16(�6n   $
��Bold"�6|   ���	#FFD6D5D56�   5?      5A      5B      