   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware      RentalSoftware.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  -     � Title$   ��$	��350��$	��525��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterScreen=�    NonActiveWindowTitleBrush# �    � 	Resources   TransparentStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value��%�   &	       �� " ��.���  � ��
 � � ���  � �� �� "	 ��.R��� #���   ._��� $��Center=�$��Center=�
 P�  �@J�IsMouseOver . . ���  � ��# �   .��� ���	#FFF1F1F1.+�� .+��� .+���  �� Orientation$ 
Horizontal=�$	��Top=�$��Center=��� $ 
Horizontal=�$	��Top=�$��Stretch=����	#FF2D4F1D$��1���� $	��150��$	��600��$��Center=�$��Center=�$��0q�.+��� $��Center=�$��30(�$��
-95,0,0,10q�#���   $��	ExtraBold"�$��Yu Gothic UI Semibold)�Login�� $��Center=�$��14(�$��30,0,0,5q�#���   $
��Bold"��� $�STAFF-MEMBER LOGIN PANEL���� $ 
Horizontal=�$��0,0,0,5q�$��Center=�.+��� $��35��$��35��  MetroCircleButtonStyle#���  .���� $��16��$��16������  �� Path$ 
Foreground� �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask !�  j� Stretch$
 Fill=�  appbar_user !� Visual# �  �� -   $��Username��$	��230��$��Center=� � ToolTip$ Enter User name��$��18(�$��Normal"�*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Enter Username��$��0���� $ 
Horizontal=�$��0,0,0,5q�$��Center=�.+��� $��35��$��35��#���  .���� $��16��$��16������ $ 
Foreground� �� *FindAncestor+" �� !� $
 Fill=�  appbar_lock# �  G� -   $��Password��$	��230��$��Stretch=�$ Enter Password��$��18(�$��Normal"�$ Enter Password��$��1���� $ 
Horizontal=�$��0,0,0,5q�.+��� $��15(�$	��100��$��	10,0,20,0q��� -   $��Sign in�� �� 	IsDefault . $	��230��$��30��
�������$��Arial)�$��	-96,0,0,0q�$��16(�#���   $��2��#��[  � Cursor$
 Hand���� $��Center=�$��15(�$��	underline{�$��	-5,0,0,10q�#���   $
��Bold"�$��Yu Gothic UI Semibold)�$ Warning!��Enter correct credentials!�� $��Stretch=�$��Bottom=�.@��� .��Developed by: Net Consult�� �� -    ��Name$
 comp��