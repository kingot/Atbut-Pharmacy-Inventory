   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  !    RentalSoftware.UpdateVendor   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls    � Title$   ��$	��530��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFF1F1F1.+��  � RowDefinitions �� $��49.802 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��1��$��Company Name *��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��16(��� -    ��Name$ UpdateCompanyName��$��1��$��1��$	��264��$
��Left=�$��5,0,0,5q�*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Company Name��$��18(�$��Normal"�$��Arial)�   ClearTextButton . 
�����p��� $��First Name *��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��2��$��0��$��16(��� -   $ UpdateFirstName��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��2��$ 
First Name��$��18(�$��Arial)� . 
�����p��� $��
Last Name ��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��3��$��0��$��16(��� -   $ UpdateLastName��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��3��$ 	Last Name��$��18(�$��Arial)� . 
�����p��� $��City ��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��4��$��0��$��16(��� -   $ 
UpdateCity��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��4��$
 City��$��18(�$��Arial)� . 
�����p��� $��Phone Number *��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��5��$��0��$��16(��� -   $ UpdatePhone��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��5��$ Phone Number��$��18(�$��Arial)� . 
�����p��� $��Email��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��6��$��0��$��16(��� -   $ UpdateEmail��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��6��$ Email��$��18(�$��Arial)� . 
�����p��� $��Address��$��7��$��0��$��
0,0,5,16.7q�$��Right=�$��Bottom=�$��16(��� -   $ UpdateAddress��$��1��$	��380��$
��Left=�$��80��$��Bottom=�$��5,0,0,5q�$��7��$ Address��$��18(�$��Arial)�	 �� TextWrapping$
	 Wrap=� . 
�����p�"
 �� VerticalScrollBarVisibility$

 Auto=��� -   $
��Save��#���   
�������$��16(�$
��Save��$��10��$��1��$��
10,1,0,-43q�$
��Left=�$	��102��$
��Bold"���   AccentColorBrush3#���  
���   �$��0,0,0,10q�$��2���� -	    ��Name$ UpdaterVendor��$��Update Vendor Information��$��10,0,231,10q����	#FFF7F3F3$��18(�$��2���� -
    ��Name$ Cancel��$��Cancel��$��1��$��169,2,185,-43q�$��10��$��16(�$
��Bold"����	#FFD6D5D5