   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  #    RentalSoftware.AddCompanyInfo   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls    � Title$   ��$	��500��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFF1F1F1.+��  � RowDefinitions �� $��49.802 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��1��$��Company Name *��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��16(��� -    ��Name$ CompanyName��$��1��$��1��$	��264��$
��Left=�$��5,0,0,5q�*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Company Name��$��16(�$��Arial)�
�����p��� $��Phone *��$��Right=�$��Bottom=�$��
0,0,5,16.7q�$��2��$��0��$��16(��� -   $ Phone��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��2��$ Phone Number(s)��$��16(�$��Arial)�
�����p�.���� $��Address ��$��Right=�$��Bottom=�$��0,0,4,40q�$��3��$��0��$��16(��� -   $ Address��$��1��$	��346��$
��Left=�$��Bottom=�$��5,0,0,5q�$��3�� �� TextWrapping$
 Wrap=�$ Address��$��16(�$��Arial)�	   ClearTextButton	 . 
�����p�$��87��$
 �� HorizontalScrollBarVisibility$
 Disabled=�" �� VerticalScrollBarVisibility$
 Auto=��� $��Terms and Conditons ��$��Right=�$��Bottom=�$��	0,0,4,-32q�$��6��$��0��$��16(��� -   $ Terms��$��1��$	��346��$
��Left=�$��Bottom=�$��	3,0,0,-65q�$��6��$
 Wrap=�$# Terms and Conditions of Sales��$��16(�$��Arial)�	 . 
�����p�$��87��$
 Disabled=�$
 Auto=��� -   $
��Save��#���   
�������$��16(�$
��Save��$��6��$��1��$��29,111,0,-121q�$
��Left=�$��86��$
��Bold"���   AccentColorBrush3#���  
���   �$��0,0,0,10q�$��2���� -    ��Name$ Company��$��Update Company Details��$��10,0,231,10q����	#FFF7F3F3$��18(�$��2���� -    ��Name$ 
CancelTask��$��Cancel��$��1��$��197,111,185,-121q�$��6��$��16(�$
��Bold"����	#FFD6D5D5