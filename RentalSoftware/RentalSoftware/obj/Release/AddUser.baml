   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware      RentalSoftware.AddUser   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  -     � Title$   ��$	��410��$	��700��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowStartupLocation$ CenterScreen=� � 
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
��Auto � � ColumnDefinitions �� $��* ��� $��2* �.+��� $��First Name *��$��Right=�$��Bottom=�$��0,0,5,11q�$��2��$��0��$��16(��� -    ��Name$ 	FirstName��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��2��*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 
First Name��$��18(�$��Arial)�   ClearTextButton . 
�����p��� $��
Last Name ��$��Right=�$��Bottom=�$��0,0,5,11q�$��3��$��0��$��16(��� -   $ LastName��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��3��$ 	Last Name��$��18(�$��Arial)� . 
�����p��� $��
Username *��$��Right=�$��Bottom=�$��0,0,5,11q�$��4��$��0��$��16(��� -   $ Username��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��4��$ Username��$��18(�$��Arial)� . 
�����p��� -   $��New Password *��$��Right=�$��Bottom=�$��0,0,5,10q�$��5��$��0��$��16(�G� -   	 G�Name$	 Password��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��5��$ New Password��$��18(�$��Arial)� . 
�����p��� $��Confirm Password *��$��Right=�$��Bottom=�$��0,0,5,11q�$��6��$��0��$��16(�G� -   $	 ConfirmPassword��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��6��$ Confirm Password��$��18(�$��Arial)� . 
�����p��� $��Select User Role *��$��Right=�$��Bottom=�$��0,0,5,10q�$��7��$��0��$��16(��� -   
 ��Name$

 User��$��1��$	��264��$
��Left=�$��Bottom=�$��5,0,0,5q�$��7�� �� 
IsReadOnly . $ Select User Role��$��18(�$��Arial)�
�����p��� -	   $
��Save��#���   
�������$��16(�$
��Save��$��10��$��1��$��
10,1,0,-43q�$
��Left=�$	��102��$
��Bold"���   AccentColorBrush3#���  
���   �$��0,0,0,10q�$��2���� -
    ��Name$ 
AddNewUser��$��Add New User��$��10,0,231,10q����	#FFF7F3F3$��18(�$��2���� -    ��Name$ Cancel��$��Cancel��$��1��$��169,2,185,-43q�$��10��$��16(�$
��Bold"����	#FFD6D5D5