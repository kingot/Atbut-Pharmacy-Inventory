   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  !    RentalSoftware.RecieveOrder   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls    � Title$   ��$	��470��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFF1F1F1.+��  � RowDefinitions �� $��49.802 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��1��$��Select Drug Name * ��$��Right=�$��0,1,5,17q�$��16(��� -    ��Name$
 Item��$��1��$��1��$	��264��$
��Left=�$��5,0,0,5q�*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Drug Name��$��16(�$��Arial)�
�����p� �� 
IsEditable . �� $��2��$��0��$��Vendor *��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��16(��� -   $ Vendor��$��2��$��1��$	��264��$
��Left=�$��5,0,0,5q� . $ Select Vendor��$��16(�$��Arial)�
�����p��� $��Unit Price ��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��5��$��0��$��16(��� -   	 ��Name$	 PurchaseUnitPrice��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��5��$��16(�$��Arial)�
�����p�.���� $��Quantity Purchased��$��6��$��0��$��
0,0,5,16.7q�$��Right=�$��Bottom=�$��16(��� -   $	 PurchaseQuantity��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��6��$��16(�$��Arial)�
�����p�.���� $��Total Cost ₵��$��7��$��0��$��0,0,5,9q�$��Right=�$��Bottom=�$��16(��� -   $	 	TotalCost��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��7��$��24(�$��Arial)�$��Normal"�
 �� 
IsReadOnly
 . 
�����p��� $��Quantity Recieveing *��$��8��$��0��$��0,0,4,8q�$��Right=�$��Bottom=�$��16(�*  $MahApps.Metro.Controls.NumericUpDown  -     Name$ QuantityRecieve��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��8��$��16(�$��Arial)�
�����p��� -   $
��Save��#���   
�������$��16(�$
��Save��$��9��$��1��$��	5,8,0,-43q�$
��Left=�$	��102��$
��Bold"���   AccentColorBrush3#���  
���   �$��0,0,0,20q�$��2���� -    ��Name$ RecievOrder��$%��Recieve Purchase Order to Store��$��10,0,231,20q����	#FFF7F3F3$��18(�$��2���� -	    ��Name$ Cancel��$��Cancel��$��1��$��160,10,194,-43q�$��9��$��16(�$
��Bold"����	#FFD6D5D5