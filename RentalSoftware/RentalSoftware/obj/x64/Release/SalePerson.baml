   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware      RentalSoftware.SalePerson   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  -     � Title$   ��$	��600��$
��1000��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowState$ 	Maximized=�)   "RightWindowCommandsOverlayBehavior$ Never=�*   #WindowButtonCommandsOverlayBehavior$ Never=�    NonActiveWindowTitleBrush# �      RightWindowCommands +  %MahApps.Metro.Controls.WindowCommands  .@��� -    ��Name$ welcome��$��16(����	#FFFDEA2Dd� $��Preferences��$��18(� � Cursor$
 Hand��	 d� 	IsChecked	 �� 
 �� ElementName$
 Flyout�� �� Path$ IsOpen��� -    ��Name$ logout��$��16(�$��Logout��.��� ���	#FFF1F1F1 � ColumnDefinitions �� $
��279* ��� $
��545* ��� $
��168* �.+�� $��Center=�$��Center=� K� ZIndex$	 100��$��96,14,96,15q�$��3�� � RowDefinitions �� $	��150 �$��30���� $	��150 ��� $	��150 �$��30���� $	��150 ��� $	��150 �$��30���� $	��150 � �� $	��200 ��� $	��200 ��� $	��200 ��� $	��200 �.+���   AccentColorBrush4#���  $��4��$��Stretch=�$��1��$��4��$��	0,146,0,0q��� $��0��$��0��$��SALES AND CUSTOMERS��$
��Bold"�$��14(�$��0,0,0,10q�#���   $��4��#���  �� $��0��$��1��.+��� $��60��$��60��  MetroCircleButtonStyle#���  .���� $��32��$��32������ *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask !�  j� Stretch$
 Fill=�  appbar_creditcard !� Visual# �  �� -   $ 	MakeASale��$��Make a sale��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
 Hand��  BlackColorBrush#���  $��60����Z� ��Z� �� $��1��$��1��$��2��$��
10,0,190,0q�.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_user_add# �  �� -   $ AddNewCustomer��$��Add New Customer��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
 Hand��$��60��#���  ��Z� ��Z� �� $��2��$��1��$��2��$��
10,0,190,0q�.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_tiles_sixteen# �  �� -   $ CustomerList��$��Customer List��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
 Hand��$��60��#���  ��Z� ��Z� �� $��Stretch=�$��Bottom=�$��16(�$��3��.@��� -    ��Name$ 
ActiveUser�����	#FFFDEA2D��   MetroStatusBarSeparator#��[ �� -   $
 time��