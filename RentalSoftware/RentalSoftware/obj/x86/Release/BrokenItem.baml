   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware      RentalSoftware.BrokenItem   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  -     � Title$   ��$	��400��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFF1F1F1.+��  � RowDefinitions �� $��49.802 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��1��$��Select Drug Name * ��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��16(��� -    ��Name$ BrokenItemName��$��1��$��1��$	��264��$
��Left=�$��5,0,0,5q� �� 
IsEditable . *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug��$��16(�$��Arial)�
�����p��� $��Quantity Expired * ��$��Right=�$��Bottom=�$��0,0,5,4q�$��2��$��0��$��16(�*  $MahApps.Metro.Controls.NumericUpDown  -   	  Name$	 BrokenQuantity��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��2��$ Quantity Expired��$��16(�$��Arial)�
�����p��� -   
 ��Name$
 Comment��$��1��$	��346��$
��Left=�$��Bottom=�$��5,0,0,5q�$��3�� �� TextWrapping$
 Wrap=�$ Leave a comment��$��16(�$��Arial)�   ClearTextButton . 
�����p�$��87��$ �� HorizontalScrollBarVisibility$ Disabled=�" �� VerticalScrollBarVisibility$
 Auto=��� $��4��$	��264��$
��Wrap=�$��14(�$��1��$��
7,3,192,38q�PNPlease note that, the quantity Expired will be deducted from Drug total stock.�� -   $
��Save��#���   
�������$��16(�$
��Save��$��4��$��1��$��	5,46,0,-1q�$
��Left=�$	��102��$
��Bold"���   AccentColorBrush3#���  
���   �$��0,0,0,10q�$��2���� -    ��Name$ Broken��$��Record Expiry Drugs��$��10,0,231,10q����	#FFF7F3F3$��18(�$��2���� -    ��Name$ 
CancelTask��$��Cancel��$��1��$��174,46,194,-1q�$��4��$��16(�$
��Bold"����	#FFD6D5D5