   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	       RentalSoftware.SalePerson   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   -   5          � Title$   ��5	   	   $	��600��6   $
��1000��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6,    � WindowState$ 	Maximized=�5
      )   "RightWindowCommandsOverlayBehavior$ Never=�6/   *   #WindowButtonCommandsOverlayBehavior$ Never=�5          NonActiveWindowTitleBrush# �   5         RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5         ��Name$ welcome��5   &   $��16(�6   ���	#FFFDEA2D6P   d� 5      $��Preferences��6   $��18(�61    � Cursor$
 Hand��5   ?   	 d� 	IsChecked	 6	   �� 
 �� ElementName$
 Flyout�� �� Path$ IsOpen�6?   �� 5      -   5         ��Name$ logout��5      $��16(�6%   $��Logout��63   6D   5      .��5      � ���	#FFF1F1F1 � ColumnDefinitions 5   
   �� 5      $
��279* �6   �� 5      $
��545* �6   �� 5      $
��168* �6   .+�5   
   � $��Center=�6   $��Center=�6*    K� ZIndex$	 100��6G   $��96,14,96,15q�6Z   $��3��6o    � RowDefinitions 5       �� 5"      $	��150 �6    $��30��6-   �� 5#      $	��150 �6    �� 5$      $	��150 �6    $��30��6-   �� 5%      $	��150 �6    �� 5&      $	��150 �6    $��30��6-   �� 5'      $	��150 �6     5*      �� 5+      $	��200 �6#   �� 5,      $	��200 �6#   �� 5-      $	��200 �6#   �� 5.      $	��200 �6#   .+�55      ��   AccentColorBrush4#���  6   $��4��6C   $��Stretch=�6N   $��1��6j   $��4��6w   $��	0,146,0,0q�6�   �� 56      $��0��6   $��0��6%   $��SALES AND CUSTOMERS��65   $
��Bold"�6P   $��14(�6b   $��0,0,0,10q�6p   #���   57      $��4��65   #���  58      �� 5;      $��0��6   $��1��6)   .+�5<      �� $��60��6   $��60��5=        MetroCircleButtonStyle#���  5>      .��5?      �� $��32��6    $��32��5@      ��5A      �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5B      !� 5C       j� Stretch$
 Fill=�6*     appbar_creditcard !� Visual# �  69   5E      5F      �� 5H      -   5        $ 	MakeASale��5H   0   $��Make a sale��6   $��12(�6C   $��Microsoft YaHei UI)�6R   $��5q�6r   $��Stretch=�6~   $��0q�5I      $
 Hand��60     BlackColorBrush#���  6>   $��60��6n   ��6   Z� ��6{   Z� 6�   5J      �� 5L      $��1��6   $��1��6)   $��2��66   $��
10,0,190,0q�6J   .+�5M      �� $��60��6   $��60��5N      #���  5O      .��5P      �� $��32��6    $��32��5Q      ��5R      �� *
Foreground+ �� *FindAncestor+" �� 5S      !� 5T      $
 Fill=�6*     appbar_user_add# �  69   5V      5W      �� 5X      -   5        $ AddNewCustomer��5X   4   $��Add New Customer��6   $��12(�6L   $��Microsoft YaHei UI)�6[   $��5q�6{   $��Stretch=�6�   $��0q�5Y      $
 Hand��60   $��60��6>   #���  6J   ��6   Z� ��6y   Z� 6�   5Z      �� 5\      $��2��6   $��1��6)   $��2��66   $��
10,0,190,0q�6J   .+�5^      �� $��60��6   $��60��5_      #���  5`      .��5a      �� $��32��6    $��32��5b      ��5c      �� *
Foreground+ �� *FindAncestor+" �� 5d      !� 5e      $
 Fill=�6*     appbar_tiles_sixteen# �  69   5g      5h      �� 5j      -   5        $ CustomerList��5j   1   $��Customer List��6   $��12(�6G   $��Microsoft YaHei UI)�6V   $��5q�6v   $��Stretch=�6�   $��0q�5k      $
 Hand��60   $��60��6>   #���  6J   ��6   Z� ��6y   Z� 6�   5l      5q      �� 5w   
   $��Stretch=�6   $��Bottom=�62   $��16(�6M   $��3��6[   .@�5x      �� -   5         ��Name$ 
ActiveUser��5x      ���	#FFFDEA2D60   �� 5y        MetroStatusBarSeparator#��[ 6   �� 5z      -   5        $
 time��5z      5|      5}      5~      