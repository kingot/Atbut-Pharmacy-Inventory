   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware       RentalSoftware.ItemListGUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  w sTelerik.Windows.Controls.DataVisualization, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GanttView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l
 hTelerik.Windows.Scheduling.Core, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7{ wTelerik.Windows.Documents.Proofing.RadGridView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Qtelerik1http://schemas.telerik.com/2008/xaml/presentation
    	 
      -     � Title$   ��$	��660��$
��1290��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowState$ Normal=�)   "RightWindowCommandsOverlayBehavior$ Never=�   	TitleCaps .  *   #WindowButtonCommandsOverlayBehavior$ Never=�    NonActiveWindowTitleBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�	 � 	Resources	 ��%    .��� 
 � RowDefinitions
 �� $��10 �$��30���� $	��100 ���  � ColumnDefinitions �� $	��200 ��� $	��200 ��� $	��200 ��� $	��200 ��� $	��200 �.+��� $��0��$��1��.+��� $��40��$��40��  MetroCircleButtonStyle#���  .���� $��18��$��16������ *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask !�  j� Stretch$
 Fill=�  
appbar_add !� Visual# �  �� -    ��Name$ NewItem��$��Add New Drug��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q� � Cursor$
 Hand��  BlackColorBrush#���  $��50����Z� ��Z� �� $��1��$��1��.+��� $��40��$��40��#���  .���� $��18��$��16������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_edit# �  �� -   $
 Edit��$��Edit/Update Drug��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
 Hand��#���  $��50����Z� ��Z� �� $��3��$��1��.+��� $��40��$��40��#���  .���� $��18��$��16������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_layer_add# �  �� -   $ ItemCategory��$��Add New Drug Category��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
 Hand��#���  $��50����Z� ��Z� �� $��4��$��201,0,-201,0q�$��1��.+��� $��40��$��40��#���  .���� $��18��$��16������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_close# �  �� -   $ Delete��$��Delete Drug��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
 Hand��#���  $��50����Z� ��Z� �� $��4��$��1��.+��� $��40��$��40��#���  .���� $��18��$��16������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�  appbar_refresh# �  �� -   $ Refresh��$��Refresh��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
 Hand��#���  $��50����Z� ��Z� �� $��5��$��2��$��
0,0,-289,0q�.+�* 	 $Telerik.Windows.Controls.RadGridView  -     Name$ ItemView��; 	 5Telerik.Windows.Controls.GridView.GridViewDataControl   AutoGenerateColumns .    HorizontalGridLinesBrush �	#FF1D1D21   ShowSearchPanel .    ColumnWidth? 	 9Telerik.Windows.Controls.GridView.GridViewLengthConverter$ * $��14(�   
IsReadOnly . 8 	 2Telerik.Windows.Controls.GridView.BaseItemsControl   AlternationCount$ 2��   AlternateRowBackground
 �����   IsFilteringAllowed .     CanUserReorderColumns .     DragElementAction$
 None=�   ShowGroupPanel .  *  $Telerik.Windows.Controls.DataControl$   IsSynchronizedWithCurrentItem$ FalseY�+  %Telerik.Windows.Controls.RadDataPager  -      Name$  Datab��$��Bottom=�!   PageSize$! 17��"   Source" �� *Items+# �� ElementName$# ItemView���� $��2��$��	5,0,196,0q�$��2��$��1��.+��� $��40��$��40��#���  .���� $��18��$��16������ *
Foreground+ �� *FindAncestor+" �� !� $
 Fill=�# �  �� -	   $ 
ReturnItem��$��RETURN ITEM��$��12(�$��Microsoft YaHei UI)�$��5q�$��Stretch=�$��0q�$
 Hand��#���  $��50����Z� ��Z� 