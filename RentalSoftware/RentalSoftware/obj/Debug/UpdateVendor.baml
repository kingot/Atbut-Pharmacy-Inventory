   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	   !    RentalSoftware.UpdateVendor   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$   ��5	   	   $	��530��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
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
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5       $��* �6#   �� 5!      $��2* �6#   .+�5#      �� $��1��6   $��Company Name *��6%   $��Right=�6;   $��Bottom=�6W   $��
0,0,5,16.7q�6r   $��16(�6�   �� 5$      -   5         ��Name$ UpdateCompanyName��5$      $��1��61   $��1��6?   $	��264��6O   $
��Left=�6[   $��5,0,0,5q�5%      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Company Name��5&      $��18(�6F   $��Normal"�6T   $��Arial)�6h      ClearTextButton . 
�����p�5'   D   �� 5,      $��First Name *��6   $��Right=�6,   $��Bottom=�6H   $��
0,0,5,16.7q�5-      $��2��6,   $��0��69   $��16(�6I   �� 5.      -   5        $ UpdateFirstName��5.      $��1��60   $	��264��6A   $
��Left=�6M   $��Bottom=�5/      $��5,0,0,5q�62   $��2��6C   $ 
First Name��50      $��18(�6E   $��Arial)�6S    . 
�����p�51   D   �� 55      $��
Last Name ��6   $��Right=�6*   $��Bottom=�6F   $��
0,0,5,16.7q�56      $��3��6,   $��0��69   $��16(�6I   �� 57      -   5        $ UpdateLastName��57      $��1��6/   $	��264��6@   $
��Left=�6L   $��Bottom=�58      $��5,0,0,5q�62   $��3��6C   $ 	Last Name��59      $��18(�6D   $��Arial)�6R    . 
�����p�5:   D   �� 5>      $��City ��6   $��Right=�6%   $��Bottom=�6A   $��
0,0,5,16.7q�5?      $��4��6,   $��0��69   $��16(�6I   �� 5@      -   5        $ 
UpdateCity��5@      $��1��6+   $	��264��6<   $
��Left=�6H   $��Bottom=�5A      $��5,0,0,5q�62   $��4��6C   $
 City��5B      $��18(�6?   $��Arial)�6M    . 
�����p�5C   D   �� 5G      $��Phone Number *��6   $��Right=�6.   $��Bottom=�6J   $��
0,0,5,16.7q�5H      $��5��6,   $��0��69   $��16(�6I   �� 5I      -   5        $ UpdatePhone��5I      $��1��6,   $	��264��6=   $
��Left=�6I   $��Bottom=�5J      $��5,0,0,5q�62   $��5��6C   $ Phone Number��5K      $��18(�6G   $��Arial)�6U    . 
�����p�5L   D   �� 5Q      $��Email��6   $��Right=�6%   $��Bottom=�6A   $��
0,0,5,16.7q�5R      $��6��6,   $��0��69   $��16(�6I   �� 5T      -   5        $ UpdateEmail��5T      $��1��6,   $	��264��6=   $
��Left=�6I   $��Bottom=�5U      $��5,0,0,5q�62   $��6��6C   $ Email��5V      $��18(�6@   $��Arial)�6N    . 
�����p�5W   D   �� 5[      $��Address��6   $��7��6'   $��0��64   $��
0,0,5,16.7q�6D   $��Right=�6X   $��Bottom=�6t   $��16(�6�   �� 5\      -   5        $ UpdateAddress��5\      $��1��6.   $	��380��6>   $
��Left=�6J   $��80��6e   $��Bottom=�5]      $��5,0,0,5q�62   $��7��6C   $ Address��5^      $��18(�6B   $��Arial)�6P   	 �� TextWrapping$
	 Wrap=�6c    . 
�����p�"
 �� VerticalScrollBarVisibility$

 Auto=�5_   [   �� 5d      -   5        $
��Save��5e   0   #���   5d      
�������$��16(�6X   $
��Save��6f   $��10��6u   $��1��6�   $��
10,1,0,-43q�6�   $
��Left=�5e      $	��102��6<   $
��Bold"�6H   6Z   �� 5f        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 5g      -	   5         ��Name$ UpdaterVendor��5g      $��Update Vendor Information��6+   $��10,0,231,10q�6O   ���	#FFF7F3F3$��18(�6{   $��2��6�   �� 5h      -
   5         ��Name$ Cancel��5h      $��Cancel��6%   $��1��66   $��169,2,185,-43q�6F   $��10��6]   $��16(�6k   $
��Bold"�6y   ���	#FFD6D5D56�   5i      5k      5l      