   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	       RentalSoftware.AddUser   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��410��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6+    � WindowStartupLocation$ CenterScreen=�5
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
��Auto �6     � ColumnDefinitions 5      �� 5       $��* �6#   �� 5!      $��2* �6#   .+�5%      �� $��First Name *��6   $��Right=�6,   $��Bottom=�6H   $��0,0,5,11q�5&      $��2��6*   $��0��67   $��16(�6G   �� 5'      -   5         ��Name$ 	FirstName��5'      $��1��6*   $	��264��6;   $
��Left=�6G   $��Bottom=�5(      $��5,0,0,5q�62   $��2��6C   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 
First Name��5)      $��18(�6E   $��Arial)�6S      ClearTextButton . 
�����p�5*   D   �� 5.      $��
Last Name ��6   $��Right=�6*   $��Bottom=�6F   $��0,0,5,11q�5/      $��3��6*   $��0��67   $��16(�6G   �� 50      -   5        $ LastName��50      $��1��6)   $	��264��6:   $
��Left=�6F   $��Bottom=�51      $��5,0,0,5q�62   $��3��6C   $ 	Last Name��52      $��18(�6D   $��Arial)�6R    . 
�����p�53   D   �� 57      $��
Username *��6   $��Right=�6*   $��Bottom=�6F   $��0,0,5,11q�58      $��4��6*   $��0��67   $��16(�6G   �� 59      -   5        $ Username��59      $��1��6)   $	��264��6:   $
��Left=�6F   $��Bottom=�5:      $��5,0,0,5q�62   $��4��6C   $ Username��5;      $��18(�6C   $��Arial)�6Q    . 
�����p�5<   D   �� 5@      -   5        $��New Password *��5@      $��Right=�6.   $��Bottom=�6J   $��0,0,5,10q�5A      $��5��6*   $��0��67   $��16(�6G   6U   G� 5B      -   5        	 G�Name$	 Password��5B      $��1��6-   $	��264��6>   $
��Left=�6J   $��Bottom=�5C      $��5,0,0,5q�62   $��5��6C   $ New Password��5D      $��18(�6G   $��Arial)�6U    . 
�����p�5E   D   �� 5J      $��Confirm Password *��6   $��Right=�62   $��Bottom=�6N   $��0,0,5,11q�5K      $��6��6*   $��0��67   $��16(�6G   G� 5M      -   5        $	 ConfirmPassword��5M      $��1��64   $	��264��6E   $
��Left=�6Q   $��Bottom=�5N      $��5,0,0,5q�62   $��6��6C   $ Confirm Password��5O      $��18(�6K   $��Arial)�6Y    . 
�����p�5P   D   �� 5S      $��Select User Role *��6   $��Right=�62   $��Bottom=�6N   $��0,0,5,10q�5T      $��7��6*   $��0��67   $��16(�6G   �� 5V      -   5        
 ��Name$

 User��5V      $��1��6%   $	��264��66   $
��Left=�6B   $��Bottom=�5W      $��5,0,0,5q�62   $��7��6C    �� 
IsReadOnly . $ Select User Role��5X      $��18(�6K   $��Arial)�6Y   
�����p�5Y      �� 5]      -	   5        $
��Save��5^   0   #���   5]      
�������$��16(�6X   $
��Save��6f   $��10��6u   $��1��6�   $��
10,1,0,-43q�6�   $
��Left=�5^      $	��102��6<   $
��Bold"�6H   6Z   �� 5_        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 5`      -
   5         ��Name$ 
AddNewUser��5`      $��Add New User��6(   $��10,0,231,10q�6?   ���	#FFF7F3F3$��18(�6k   $��2��6y   �� 5a      -   5         ��Name$ Cancel��5a      $��Cancel��6%   $��1��66   $��169,2,185,-43q�6F   $��10��6]   $��16(�6k   $
��Bold"�6y   ���	#FFD6D5D56�   5b      5d      5e      