   M S B A M L   `   `   `  ����   RentalSoftware     RentalSoftware.AddCustomer   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  -     � Title$   ��$	��400��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFF1F1F1.+��  � RowDefinitions �� $��49.802 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��1��$��Full Name *��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��16(��� -    ��Name$ FullName��$��1��$��1��$	��380��$
��Left=�$��5,0,0,5q�*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 	Full Name��$��18(�$��Normal"�$��Arial)�   ClearTextButton . 
�����p��� $��Phone Number *��$��Right=�$��Bottom=�$��0,0,4,9q�$��3��$��0��$��16(��� -   $ Phone��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��3��$ Phone Number��$��18(�$��Arial)� . 
�����p��� $��Email��$��Right=�$��Bottom=�$��0,0,5,9q�$��4��$��0��$��16(��� -   $ Email��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��4��$ Email��$��18(�$��Arial)� . 
�����p��� $��Address��$��5��$��0��$��0,0,5,36q�$��Right=�$��Bottom=�$��16(��� -   $ Address��$��1��$	��380��$
��Left=�$��80��$��Bottom=�$��5,0,0,5q�$��5��$ Address��$��18(�$��Arial)�	 �� TextWrapping$
	 Wrap=� . 
�����p�"
 �� VerticalScrollBarVisibility$

 Auto=��� -   $
��Save��#���   
�������$��16(�$
��Save��$��7��$��1��$��5,1,0,10q�$
��Left=�$	��102��$
��Bold"���   AccentColorBrush3#���  
���   �$��0,0,0,20q�$��2���� -    ��Name$ AddNewCustomer��$��Add New Customer��$��10,0,231,20q����	#FFF7F3F3$��18(�$��2���� -    ��Name$ Cancel��$��Cancel��$��1��$��160,3,194,10q�$��7��$��16(�$
��Bold"����	#FFD6D5D5