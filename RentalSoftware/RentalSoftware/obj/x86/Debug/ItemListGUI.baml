   M S B A M L   `   `   `  ����I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  5   	        RentalSoftware.ItemListGUI   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RentalSoftware     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   w sTelerik.Windows.Controls.DataVisualization, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GanttView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l
 hTelerik.Windows.Scheduling.Core, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7{ wTelerik.Windows.Documents.Proofing.RadGridView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Qtelerik1http://schemas.telerik.com/2008/xaml/presentation
    	 
      5   	   -   5          � Title$   ��5
      $	��600��6      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6    � WindowState$ Normal=�5      )   "RightWindowCommandsOverlayBehavior$ Never=�6,      	TitleCaps .  *   #WindowButtonCommandsOverlayBehavior$ Never=�5          NonActiveWindowTitleBrush# �   5       � WindowStartupLocation$ CenterScreen=�6Y    � 	Resources 5      ��%    5      .��5      � $��0,0,22,0q�6   	 � RowDefinitions	 5   
   �� 5      $��10 �6   $��30��6(   �� 5      $	��100 �6   �� 5      
 � ColumnDefinitions
 5   
   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5       $	��150 �6   �� 5!      $	��150 �6   �� 5"      $	��150 �6   .+�5&   
   �� $��0��6   $��1��6%   .+�5'      �� $��40��6   $��40��5(        MetroCircleButtonStyle#���  5)      .��5*      �� $��18��6   $��16��5+      ��5,      �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5-      !� 5.       j� Stretch$
 Fill=�6&     
appbar_add !� Visual# �  65   50      51      �� 53      -   5         ��Name$ NewItem��53   -   $��Add New Drug��6   $��12(�6>   $��Microsoft YaHei UI)�6M   $��5q�6m   $��Stretch=�6y   $��0q�54       � Cursor$
 Hand��60     BlackColorBrush#���  6>   $��50��6n   ��6   Z� ��6{   Z� 6�   55      �� 57   
   $��1��6   $��1��6%   .+�58      �� $��40��59      #���  5:      $��	60,0,51,0q�67   .��5;      �� $��18��6   $��16��5<      ��5=      �� *
Foreground+ �� *FindAncestor+" �� 5>      !� 5?      $
 Fill=�6&     appbar_edit# �  65   5A      5B      �� 5C      -   5        $
 Edit��5C   1   $��Edit/Update Drug��6   $��12(�6?   $��Microsoft YaHei UI)�6N   $��5,5,0,5q�6n   $��Stretch=�6�   $��0q�5D      $
 Hand��60   #���  5E      $��50��6F   ��5D      Z� ��5E   S   Z� 6j   5F      �� 5H   
   $��3��6   $��1��6%   .+�5I      �� $��40��6   $��40��5J      #���  5K      .��5L      �� $��18��6   $��16��5M      ��5N      �� *
Foreground+ �� *FindAncestor+" �� 5O      !� 5P      $
 Fill=�6&     appbar_layer_add# �  65   5R      5S      �� 5U      -   5        $ ItemCategory��5U   6   $��Add New Drug Category��6   $��12(�6L   $��Microsoft YaHei UI)�6[   $��5q�6{   $��Stretch=�6�   $��0q�5V      $
 Hand��60   #���  5W      $��50��6F   ��5V      Z� ��5W   S   Z� 6j   5X      �� 5[   
   $��4��6   $��149,0,-149,0q�6%   $��1��6;   .+�5\      �� $��40��6   $��40��5]      #���  5^      .��5_      �� $��18��6   $��16��5`      ��5a      �� *
Foreground+ �� *FindAncestor+" �� 5b      !� 5c      $
 Fill=�6&     appbar_close# �  65   5e      5f      �� 5h      -   5        $ Delete��5h   ,   $��Delete Drug��6   $��12(�6<   $��Microsoft YaHei UI)�6K   $��5q�6k   $��Stretch=�6w   $��0q�5i      $
 Hand��60   #���  6>   $��50��6n   ��6   Z� ��6{   Z� 6�   5j      �� 5n   
   $��4��6   $��1��6%   .+�5o      �� $��40��6   $��40��5p      #���  5q      .��5r      �� $��18��6   $��16��5s      ��5t      �� *
Foreground+ �� *FindAncestor+" �� 5u      !� 5v      $
 Fill=�6&     appbar_refresh# �  65   5x      5y      �� 5{      -   5        $ Refresh��5{   (   $��Refresh��6   $��12(�69   $��Microsoft YaHei UI)�6H   $��5q�6h   $��Stretch=�6t   $��0q�5|      $
 Hand��60   #���  6>   $��50��6n   ��6   Z� ��6{   Z� 6�   5}      �� 5�   
   $��5��6   $��2��6)   $��
0,0,-289,0q�66   .+�5�      * 	 $Telerik.Windows.Controls.RadGridView  -   5          Name$ ItemView��5�   #   ; 	 5Telerik.Windows.Controls.GridView.GridViewDataControl   AutoGenerateColumns .    HorizontalGridLinesBrush �	#FF1D1D21   ShowSearchPanel .    ColumnWidth? 	 9Telerik.Windows.Controls.GridView.GridViewLengthConverter$ * 5�      $��14(�6'      
IsReadOnly . 8 	 2Telerik.Windows.Controls.GridView.BaseItemsControl   AlternationCount$ 2��5�         AlternateRowBackground
 �����   IsFilteringAllowed .     CanUserReorderColumns .     DragElementAction$
 None=�5�   A      ShowGroupPanel .  *  $Telerik.Windows.Controls.DataControl$   IsSynchronizedWithCurrentItem$ FalseY�5�   g   +  %Telerik.Windows.Controls.RadDataPager  5�      -   5          Name$ Datab��5�   #   $��Bottom=�62       PageSize$  15��6M   !   Source! 6[   �� *Items+" �� ElementName$" ItemView��5�      �� 5�   
   $��2��6   $��	5,0,196,0q�6%   $��2��68   $��1��6L   .+�5�      �� $��40��6   $��40��5�      #���  5�      .��5�      �� $��18��6   $��16��5�      ��5�      �� *
Foreground+ �� *FindAncestor+" �� 5�      !� 5�      $
 Fill=�6&   # �  65   5�      5�      �� 5�      -	   5        $ 
ReturnItem��5�   ,   $��RETURN ITEM��6   $��12(�6@   $��Microsoft YaHei UI)�6O   $��5,5,0,5q�6o   $��Stretch=�6�   $��0q�5�      $
 Hand��65   #���  5�      $��50��6;   ��5�      Z� ��5�   H   Z� 6_   5�      5�      5�      