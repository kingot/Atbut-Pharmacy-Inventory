   M S B A M L   `   `   `  ����  RentalSoftware     RentalSoftware.AddCustomer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��400��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5       �� $��1��6   $��Full Name *��6%   $��Right=�68   $��Bottom=�6T   $��
0,0,5,16.7q�6o   $��16(�6�   �� 5!      -   5         ��Name$ FullName��5!      $��1��6(   $��1��66   $	��380��6F   $
��Left=�6R   $��5,0,0,5q�5"      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 	Full Name��5#      $��18(�6D   $��Normal"�6R   $��Arial)�6f      ClearTextButton . 
�����p�5$   D   �� 5(      $��Phone Number *��6   $��Right=�6.   $��Bottom=�6J   $��0,0,4,9q�5)      $��3��6)   $��0��66   $��16(�6F   �� 5*      -   5        $ Phone��5*      $��1��6&   $	��264��67   $
��Left=�6C   $��Bottom=�5+      $��5,0,0,5q�62   $��3��6C   $ Phone Number��5,      $��18(�6G   $��Arial)�6U    . 
�����p�5-   D   �� 52      $��Email��6   $��Right=�6%   $��Bottom=�6A   $��0,0,5,9q�53      $��4��6)   $��0��66   $��16(�6F   �� 55      -   5        $ Email��55      $��1��6&   $	��264��67   $
��Left=�6C   $��Bottom=�56      $��5,0,0,5q�62   $��4��6C   $ Email��57      $��18(�6@   $��Arial)�6N    . 
�����p�58   D   �� 5<      $��Address��6   $��5��6'   $��0��64   $��0,0,5,36q�6D   $��Right=�6V   $��Bottom=�6r   $��16(�6�   �� 5=      -   5        $ Address��5=      $��1��6(   $	��380��68   $
��Left=�6D   $��80��6_   $��Bottom=�5>      $��5,0,0,5q�62   $��5��6C   $ Address��5?      $��18(�6B   $��Arial)�6P   	 �� TextWrapping$
	 Wrap=�6c    . 
�����p�"
 �� VerticalScrollBarVisibility$

 Auto=�5@   [   �� 5E      -   5        $
��Save��5F   0   #���   5E      
�������$��16(�6X   $
��Save��6f   $��7��6u   $��1��6�   $��5,1,0,10q�6�   $
��Left=�5F      $	��102��6<   $
��Bold"�6H   6Z   �� 5G        AccentColorBrush3#���  6   
���   �$��0,0,0,20q�6R   $��2��6d   �� 5H      -   5         ��Name$ AddNewCustomer��5H      $��Add New Customer��6,   $��10,0,231,20q�6G   ���	#FFF7F3F3$��18(�6s   $��2��6�   �� 5I      -   5         ��Name$ Cancel��5I      $��Cancel��6%   $��1��66   $��160,3,194,10q�6F   $��7��6\   $��16(�6i   $
��Bold"�6w   ���	#FFD6D5D56�   5J      5L      5M      