   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware      RentalSoftware.AddItem   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  -     � Title$   ��$	��470��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFF1F1F1.+��  � RowDefinitions �� $��49.802 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��1��$��Category * ��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��16(��� -    ��Name$ Category��$��1��$��1��$	��264��$
��Left=�$��5,0,0,5q�*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug Category��$��16(�$��Arial)�
�����p� �� 
IsReadOnly . �� $��2��$��0��$��Vendor ��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��16(��� -   $ Vendor��$��2��$��1��$	��264��$
��Left=�$��5,0,0,5q�$ Select Vendor��$��16(�$��Arial)�
�����p� . �� $��Drug Name * ��$��Right=�$��Bottom=�$��0,0,5,4q�$��3��$��0��$��16(��� -   	 ��Name$	 ItemName��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��3��$ 	Drug Name��$��16(�$��Arial)�
   ClearTextButton
 . 
�����p��� $��Description��$��Right=�$��Bottom=�$��0,0,2,39q�$��4��$��0��$��16(��� -   $	 ItemDescription��$��1��$	��346��$
��Left=�$��Bottom=�$��5,0,0,5q�$��4�� �� TextWrapping$
 Wrap=�$ Drug Description��$��16(�$��Arial)�
 . 
�����p�$��87��$ �� HorizontalScrollBarVisibility$ Disabled=�" �� VerticalScrollBarVisibility$
 Auto=��� $��Unit Price * ��$��Right=�$��Bottom=�$��0,0,4,7q�$��5��$��0��$��16(�*  $MahApps.Metro.Controls.NumericUpDown  -     Name$ 	UnitPrice��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��5��$ 
Unit Price��$��16(�$��Arial)�
�����p��� $��	Quantity ��$��6��$��0��$��
0,0,5,16.7q�$��Right=�$��Bottom=�$��16(�  -   $ ItemQuantity��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��6��$ Quantity��$��16(�$��Arial)�
�����p��� -   $
��Save��#���   
�������$��16(�$
��Save��$��7��$��1��$��5,1,0,10q�$
��Left=�$	��102��$
��Bold"���   AccentColorBrush3#���  
���   �$��0,0,0,10q�$��2���� -	    ��Name$ 
AddNewItem��$��Add New Drug��$��10,0,231,10q����	#FFF7F3F3$��18(�$��2���� -
    ��Name$ Cancel��$��Cancel��$��1��$��160,3,194,10q�$��7��$��16(�$
��Bold"����	#FFD6D5D5