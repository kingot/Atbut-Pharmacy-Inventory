   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware      RentalSoftware.ReturnItem   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  -     � Title$   ��$	��400��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFF1F1F1.+�� $��
0,10,0,-10q� � RowDefinitions �� $��49.802 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $	��73* ��� $
��129* � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��2��$��Select Drug Name * ��$��Right=�$��Bottom=�$��	0,0,455,6q�$��16(�$��2��$��19��$	��144���� -    ��Name$ ReturnItemName��$��2��$��1��$	��274��$
��Left=�$��18,9,0,3q�$��18(�$��Arial)�
�����p�$��2��$��44�� �� 
IsReadOnly . �� $��Quantity Return * ��$��Right=�$��Bottom=�$��
0,0,455,48q�$��4��$��0��$��16(�$��2��$��19��$	��131��*  $MahApps.Metro.Controls.NumericUpDown  -     Name$ QuantityReturn��$��1��$	��274��$
��Left=�$��Bottom=�$��	18,0,0,35q�$��4��*  $MahApps.Metro.Controls.TextBoxHelper	   	Watermark$	 Quantity Return��$��18(�$��Arial)�
�����p�$��44���� $��4��$
��Wrap=�$��14(�$��1��$��20,46,171,54q�$��2��JHPlease note that, the quantity return will be added to item total stock.�� -   $
��Save��#���   
�������$��16(�$
��Save��$��5��$��1��$��
20,18,0,10q�$
��Left=�$	��105��$
��Bold"���   AccentColorBrush3#���  
���   �$��
0,-10,0,19q�$��2���� -   
 ��Name$
 return��$��Return Drug to Store��$��10,-10,231,19q����	#FFF7F3F3$��18(�$��2���� -    ��Name$ 
CancelTask��$��Cancel��$��1��$��194,18,171,10q�$��5��$��16(�$
��Bold"����	#FFD6D5D5