   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	   #    RentalSoftware.AddCompanyInfo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$   ��5	      $	��500��6   $	��700��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6*    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�6<   .��5      � ���	#FFF1F1F1.+�5   
   �  � RowDefinitions 5      �� 5      $��49.802 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5      �� $��1��6   $��Company Name *��6%   $��Right=�6;   $��Bottom=�6W   $��
0,0,5,16.7q�6r   $��16(�6�   �� 5#      -   5         ��Name$ CompanyName��5#      $��1��6+   $��1��69   $	��264��6I   $
��Left=�6U   $��5,0,0,5q�5$      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Company Name��5%      $��16(�6F   $��Arial)�6T   
�����p�5&      �� 5(      $��Phone *��6   $��Right=�6'   $��Bottom=�6C   $��
0,0,5,16.7q�5)      $��2��6,   $��0��69   $��16(�6I   �� 5*      -   5        $ Phone��5*      $��1��6%   $	��264��66   $
��Left=�6B   $��Bottom=�5+      $��5,0,0,5q�62   $��2��6C   $ Phone Number(s)��5,      $��16(�6J   $��Arial)�6X   
�����p�.��5.      5/      �� 50      $��Address ��6   $��Right=�6(   $��Bottom=�6D   $��0,0,4,40q�51      $��3��6*   $��0��67   $��16(�6G   �� 52      -   5        $ Address��52      $��1��6(   $	��346��69   $
��Left=�6E   $��Bottom=�53      $��5,0,0,5q�62   $��3��6C    �� TextWrapping$
 Wrap=�6�   $ Address��54      $��16(�6B   $��Arial)�6P   	   ClearTextButton	 . 
�����p�$��87��55   [   $
 �� HorizontalScrollBarVisibility$
 Disabled=�6g   " �� VerticalScrollBarVisibility$
 Auto=�6�   �� 58      $��Terms and Conditons ��6   $��Right=�64   $��Bottom=�6P   $��	0,0,4,-32q�59      $��6��6+   $��0��68   $��16(�6H   �� 5:      -   5        $ Terms��5:      $��1��6&   $	��346��67   $
��Left=�6C   $��Bottom=�5;      $��	3,0,0,-65q�62   $��6��6E   $
 Wrap=�6�   $# Terms and Conditions of Sales��5<      $��16(�6X   $��Arial)�6f   	 . 
�����p�$��87��5=   [   $
 Disabled=�6g   $
 Auto=�6�   �� 5B      -   5        $
��Save��5B   �   #���   6   
�������$��16(�6X   $
��Save��6f   $��6��6u   $��1��6�   $��29,111,0,-121q�6�   $
��Left=�6�   $��86��6�   $
��Bold"�6�   6�   �� 5C        AccentColorBrush3#���  6   
���   �$��0,0,0,10q�6R   $��2��6d   �� 5D      -   5         ��Name$ Company��5D      $��Update Company Details��6%   $��10,0,231,10q�6F   ���	#FFF7F3F3$��18(�6r   $��2��6�   �� 5E      -   5         ��Name$ 
CancelTask��5E      $��Cancel��6)   $��1��6:   $��197,111,185,-121q�6J   $��6��6d   $��16(�6q   $
��Bold"�6   ���	#FFD6D5D56�   5F      5H      5I      