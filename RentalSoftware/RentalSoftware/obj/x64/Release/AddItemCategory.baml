   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  $    RentalSoftware.AddItemCategory   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls    � Title$   ��$	��400��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFF1F1F1.+��  � RowDefinitions �� $��49.802 ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��1��$��Category Name * ��$��Right=�$��Bottom=�$��0,0,9,9q�$��16(��� -    ��Name$ CategoryName��$��1��$��1��$	��264��$
��Left=�$��5,0,0,5q�*  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$ Category Name��$��18(�$,��&Segoe UI, Lucida Sans Unicode, Verdana)�
�����p��� $��Category Description * ��$��Right=�$��Bottom=�$��	0,0,10,43q�$��2��$��0��$��16(��� -   $ CategoryDescription��$��1��$	��387��$
��Left=�$��Bottom=�$��5,0,0,5q�$��2��$	��100��$��18(�$,��&Segoe UI, Lucida Sans Unicode, Verdana)�$ Category Description�� . 
�����p�	 �� TextWrapping$
	 Wrap=�"
 �� VerticalScrollBarVisibility$

 Auto=��� -   $
��Save��#���   
�������$��16(�$
��Save��$��7��$��1��$��5,1,0,10q�$
��Left=�$	��102��$
��Bold"���   AccentColorBrush3#���  
���   �$��0,0,0,10q�$��2���� -    ��Name$ AddCategory��$��Add New Drug Category��$��10,0,231,10q����	#FFF7F3F3$��18(�$��2���� -    ��Name$ Cancel��$��Cancel��$��1��$��160,3,194,10q�$��7��$��16(�$
��Bold"����	#FFD6D5D5