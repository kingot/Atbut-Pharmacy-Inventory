   M S B A M L   `   `   `  ���� I  ERentalSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RentalSoftwareRentalSoftware  [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms     RentalSoftware.MakeASale   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:RentalSoftware     T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  Lforms@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms  w sTelerik.Windows.Controls.DataVisualization, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o	 kTelerik.Windows.Controls.GanttView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.GridView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l hTelerik.Windows.Scheduling.Core, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7{ wTelerik.Windows.Documents.Proofing.RadGridView, Version=2016.1.112.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Qtelerik1http://schemas.telerik.com/2008/xaml/presentation
   	 
       -     � Title$   ��$	��770��$
��1282��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �    � WindowState$ Normal=�)   "RightWindowCommandsOverlayBehavior$ Never=�   	TitleCaps .  *   #WindowButtonCommandsOverlayBehavior$ Never=�    NonActiveWindowTitleBrush# �    � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�	 � 	Resources	    AlternatingListViewItemStyle
 �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%Y   &	       �� "
 �� P�  �@��AlternationIndex$ 1��. ���  � ��
 �����.���  � RowDefinitions �� $��10 �$��30���� $	��100 ��� �� �� ��  � ColumnDefinitions �� $	��200 ��� $	��200 �.+��� $��2�����	#FFF4F4F5$��0,116,-882,-2q�$��4��
���   �$��2���� $��2�����	#FFF4F4F5$��0,0,-882,53.95q�
���   �$��3���� $��Select Customer��$��0��$��1��$
��Left=�$��21.94,0,0,-1.8q�$��16(� J� RenderTransformOrigin$ -1.957,3.333&�$
��45.8��$��Bottom=��� -    ��Name$ Customer��$��1��$��1��$	��278��$��Right=�$��-41.5,0,-36.5,10.467q� �� SelectedValuePath$ Id��*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Select Customer��$��16(�$��Arial)�
�����p� �� 
IsReadOnly . $��39��$��Bottom=��� -    ��Name$	 Pos��$��2��$��0,-10,-884,0q�$
��Wrap=�$��24(�$��48.033��$��1��$	��Top=����	#FFDEDEDE�� -   $ 	Discount1��$��1��$��Right=�$��24��$��0,0,-751,132q�$��5��$
��Wrap=�$��Discount ₵��$��Bottom=�$��86��$��16(�$��Arial)��� -   $ 	SubTotal1��$��1��$��Right=�$��0,34,-681,0q�$��5��$
��Wrap=�$��SubTotal ₵��$	��106��$��20(�$
��Bold"�$��Arial)�$��31��$	��Top=��� -   $ Total1��$��1��$��Right=�$��0,70,-681,0q�$��5��$
��Wrap=�$��	Total ₵��$��68��$��31��$	��Top=�$��20(�$
��Bold"�$��Arial)��� -    ��Name$ Discount��$��1��$��Right=�$��30��$��18(�$��Arial)�$��0,0,-849,132q�$��4��$��Bottom=�$��98��$��2��$
 0.00��$
��Left=�*  $MahApps.Metro.Controls.NumericUpDown  -     Name$ SubTotal��   
IsReadOnly . $��1��$��Right=�$��0,0,-849,97q�$��5��$	��168�����	#FF150D0D���	#FF66FF39$
 0.00��$��18(�$��Arial)�$��30��$��Bottom=�$
��Left=�  -	   $ Total��$��1�� . $��Right=�$��0,68,-849,0q�$��5��$	��168��$��30��$	��Top=����	#FF251D1D���	#FFF11600$��18(�$��Arial)�$
 0.00��$
��Left=��� -
    ��Name$ PreviewOnly��$��Preview Only��$��1��$��Right=�$��33��$��0,0,-519,10q�$��5��$��Bottom=�$	��116��$��12(�$ 	0.5,0.508&��� -   $ 	SavedOnly��$��Print & Save Only��$��1��$��Right=�$��33��$��0,0,-651,10q�$��5��$��Bottom=�$	��127��$��12(��� -   $ Cancel��$��Cancel��$��1��$��Right=�$��33��$��0,0,-849,10q�$��5��$��Bottom=�$��88��$��12(��� -    ��Name$ 	OrderList��$��2��$��3��$��2��$��0��$��0,105,-874,50q�$	��319��$��14(� �� AlternationCount$ 2��#��[ $��Normal"�$ �� IsSynchronizedWithCurrentItem$ FalseY� �� View �� .P��� -   ListItem��$��Drug Description��  �� Width$	  350��! �� DisplayMemberBinding! �� *
ItemName+�� -   ListQuantity��$��Quantity��$	  250��! �� *
Quantity+�� -   ListUnitPrice��$��
Unit Price��$	  250��! �� *	UnitPrice+�� -   ListTotalCost��$��
Total Cost��$	  250��! �� *Total+�� -   " ��Name$" label��$��Bill To Address:��$��34��$��20,0,29,148q�$��4��$��Bottom=�$��16(�$
��Bold"�$��Arial)�$��2���� -   # ��Name$
# list��$��22,0,-36,29q�$��5��$��2�����	#FFF4F4F5$��Arial)�$��14(����	#FF2E1313$��1q��� $��Start Selling��$��0��$��2��$
��Left=�$��20,55,0,67.45q�$��16(�$ -1.957,3.333&�$��114.5���� $��Drug Name *��$��1��$��2��$
��Left=�$��	61,28,0,0q�$��14(�$ -1.957,3.333&�$��92��$��17��$	��Top=�$
��Bold"��� $��
Quantity *��$��1��$��2��$
��Left=�$��272,27,-143,0q�$��14(�$ -1.957,3.333&�$��72��$��20��$	��Top=�$
��Bold"��� $��
Unit Price��$��1��$��2��$��398,27,-277,0q�$��14(�$ -1.957,3.333&�$��20��$	��Top=�$
��Bold"��� $��
Total Cost��$��1��$��2��$
��Left=�$��543,27,-417,0q�$��14(�$ -1.957,3.333&�$��75��$��20��$	��Top=�$
��Bold"��� -   $ ItemName��$��160,51,-36,67q�$��2��$ Select Drug Name��$   HasText$ .  . $��18(�$��Segoe UI)�$��Center=�$��2��$��40��  -   $ Quantity��$��1��$��0,51,-164,67q�$��2��$��Right=�$	��123��$��18(�$��Segoe UI)�$��Center=�$��40���� -   $ 	UnitPrice��% �� 
IsReadOnly% . $��1��$��0,51,-304,67q�$��2��$��Right=�$	��136��$
 0.00��$��18(�$��Segoe UI)�$��Center=�$��40���� -   $ 	TotalCost��% . $��1��$��0,51,-445,67q�$��2��& �� TextWrapping$
& Wrap=�$��Right=�$	��136��$��18(�$��Segoe UI)�$��Center=�$��40���� -   $ AddItem��$��Add Item��$��1��$��Right=�$��0,50,-704,70q�$��2��$	��107��$��16(�$
��Bold"�$ 
0.028,0.63&��� $��	Avail Qty��$��1��$��2��$
��Left=�$��685,27,-559,0q�$��14(�$ -1.957,3.333&�$��75��$��20��$	��Top=�$
��Bold"��� -   $ AvailQty��% . $��1��$��0,51,-586,67q�$��2��$
& Wrap=�$��Right=�$	��136��$��18(�$��Segoe UI)�$��Center=����	#FFEEE318$��40���� -   $ 
RemoveItem��$��Remove Drug��$��1��$
��Left=�$��882,118,-849,0q�$��4��$	��Top=�$	��168��$��30��$��14(��� -   $ Percent��$��1��$��Right=�$��30��$��18(�$��Arial)�$��0,0,-651,132q�$��4��$��Bottom=�$��66��$��2��$
 0.00��$
��Left=��� -   $	 Per��$��1��$��Right=�$��24��$��0,0,-591,132q�$��5��$
��Wrap=�$��Disc %��$��Bottom=�$��60��$��16(�$��Arial)��� -   $ ResetAll��$��Make New Sale��$��1��$
��Left=�$��709,118,-676,0q�$��4��$	��Top=�$	��168��$��30��$��14(��� -   $ NewCustomer��$��Add New Customer��$��1��$
��Left=�$��243,51,-164,0q�$��1��$	��Top=�$	��122��$��39��$��10(��� -   $ SaveO��$��	Save Only��$��1��$��Right=�$��33��$��0,0,-756,10q�$��5��$��Bottom=�$	��100��$��12(�