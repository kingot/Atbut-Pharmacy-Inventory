   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware      RentalSoftware.Dashboard   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  w sTelerik.Windows.Controls.DataVisualization, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GanttView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l
 hTelerik.Windows.Scheduling.Core, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7{ wTelerik.Windows.Documents.Proofing.RadGridView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Qtelerik1http://schemas.telerik.com/2008/xaml/presentation
    	 
      -     � Title$   ��$	��600��$
��1000��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowState$ 	Maximized=�)   "RightWindowCommandsOverlayBehavior$ Never=�   	TitleCaps .  *   #WindowButtonCommandsOverlayBehavior$ Never=�    NonActiveWindowTitleBrush# �      RightWindowCommands +  %MahApps.Metro.Controls.WindowCommands  .@��� -    ��Name$ welcome��$��16(����	#FFFDEA2Dd� $��Preferences��$��18(�	 � Cursor$
	 Hand��
 d� 	IsChecked
 ��  �� ElementName$ Flyout�� �� Path$ IsOpen��� -    ��Name$ logout��$��16(�$��Logout��   Flyouts +  %MahApps.Metro.Controls.FlyoutsControl  -     Name$ FlyoutsControl��.@�#  MahApps.Metro.Controls.Flyout  -     Name$ Flyout��   Position$ Right=�   AreAnimationsEnabled .    Header$ Preferences and Settings��   IsPinned .  $	��300��   Theme$ Inverse=�.���� $	��Top=�$��Center=�.+��� -   $ AddItemCategory��$	��300��$
	 Hand��$��12(�$��40����Z� .��Add Drug Category�� -   $ RecordBrokenItem��$	��300��$
	 Hand��$��12(�$��40����Z� .��Record Expiry Drug�� #���   $��2���� $�� Company Settings��$��18(�$��Center=�$��35���� #���   $��2���� -   $ UpdateCompanyInfo��$	��300��$
	 Hand��$��12(�$��40����Z� .��Update Company Details�� -	   $ 
AddNewUser��$	��300��$
	 Hand��$��12(�$��40����Z� .��Add New User�� -
   $ ResetPassword��$	��300��$
	 Hand��$��12(�$��40����Z� .��Reset password.��� ���	#FFF1F1F1 � ColumnDefinitions �� $��9* ��� $	��23* �.+�� $��Center=�$��Center=� K� ZIndex$	 100��$��96,14,96,15q�$��2�� � RowDefinitions �� $	��150 �$��30���� $	��150 ��� $	��150 �$��30���� $	��150 ��� $	��150 �$��30���� $	��150 � �� $	��200 ��� $	��200 ��� $	��200 ��� $	��200 �.+���   AccentColorBrush4#���  $��4��$��Stretch=�$��5��$��4��$��
-5,146,5,0q��� $��0��$��0��$��SALES AND CUSTOMERS��$
��Bold"�$��14(�$��0,0,0,10q�#���   $��4��#���  �� $��2��$��0��$��INVENTORY AND REPORT��$
��Bold"�$��14(�$��0,0,0,10q�#���   $��4��#���  �� $��0��$��1��.+��� $��60��$��60��  MetroCircleButtonStyle#���  .���� $��32��$��32������ *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask !�  j� Stretch$
 Fill=�  appbar_book_list !� Visual# �  �� -   $ 	MakeASale��$��Make a sale��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
	 Hand��  BlackColorBrush#���  $��60����Z� ��Z� �� $��1��$��1��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_graph_line_up# �  �� -   $ SaleHistory��$��Today Sales��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
	 Hand��$��60��#���  ��Z� ��Z� �� $��2��$��1��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_user_add# �  �� -   $ AddNewCustomer��$��Add New Customer��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
	 Hand��$��60��#���  ��Z� ��Z� �� $��3��$��1��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_people_multiple# �  �� -   $ CustomerList��$��Customer List��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
	 Hand��$��60��#���  ��Z� ��Z� �� $��0��$��3��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  
appbar_add# �  �� -   $ 
AddNewItem��$��Add New Drugs��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$��60��$
	 Hand��#���  ��Z� ��Z� �� $��1��$��3��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=� 	 appbar_cabinet_files# � 	 �� -   $ Items��$��
Drugs List��$��12(�$��Microsoft YaHei UI)�$��0,5,0,10q�$��Stretch=�$��0q�$
	 Hand��$��60��#���  ��Z� ��Z� �� $��2��$��3��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=� 
 appbar_graph_bar# � 
 �� -   $ SalesReport��$��Sales Report��$��12(�$��Microsoft YaHei UI)�$��0,5,0,10q�$��Stretch=�$��0q�$
	 Hand��$��60��#���  ��Z� ��Z� �� $��3��$��3��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=��� -   $ ItemsStatusReport��$��Coming Soon��$��12(�$��Microsoft YaHei UI)�$��0,5,0,10q�$��Stretch=�$��0q�$
	 Hand��$��60��#���  ��Z� ��Z� �� $��4��$��0��$��PURCHASING AND VENDORS��$
��Bold"�$��14(�$��0,3,0,7q�#���   $��4��#���  �� $��0��$��5��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_cabinet_in# �  �� -   $ RecieveItems��$��Recieve Drugs��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$��60��$
	 Hand��#���  ��Z� ��Z� �� $��1��$��5��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_currency_cent# �  �� -   $ PurchaseOrder��$��Purchase Order��$��12(�$��Microsoft YaHei UI)�$��0,5,0,10q�$��Stretch=�$��0q�$
	 Hand��$��60��#���  ��Z� ��Z� �� $��2��$��5��.+��� $��60��$��60��#���  .���� $��32��$��32������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_people_status# �  �� -   $ Vendors��$��Vendors��$��12(�$��Microsoft YaHei UI)�$��0,5,0,10q�$��Stretch=�$��0q�$
	 Hand��$��60��#���  ��Z� ��Z� �� $��Stretch=�$��Bottom=�$��16(�$��2��.@��� -    ��Name$ 
ActiveUser�����	#FFFDEA2D��   MetroStatusBarSeparator#��[ �� -   $ 
statusTime��