   M S B A M L   `   `   `  ���� J  FHumanMetricData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HumanMetricData.WindowsHumanMetricData.Windows  +    %HumanMetricData.Windows.CristeningWin   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:HumanMetricData.Windows       � Title$  CristeningWin��$	��800��$
��1300��$��Microsoft Sans Serif)�$��16(�.���  � ColumnDefinitions �� $��30 ��� $
��123* ��� $	��69* ��� $
��180* ��� $
��123* ��� $	��37* ��� $
��102* ��� $
��158* ��� $	��30* ��� $
��225* ��� $
��225* � � RowDefinitions �� $	��55* ��� $
��0.1* ��� $��6* ��� $	��24* ��� $��6* ��� $	��24* ��� $��6* ��� $	��24* ��� $
��126* ��� $	��10* ��� $
��417* ��� $	��50* �.+��� -    ��Name$ NameOfJournal��$��CRISTENING JOURNAL��$��0��$��11��$��5,15,5,5q� �� TextAlignment$ Center=�$��24(�$
��Bold"��� $��Active Record:��$��5��$��6��$��Center=�$��0,0,0,0q�$��
10,0,139,0q�$
��Left=�$��Center=�$��2��$��18���� -    ��Name$ activeRecord��$��7��$��5��$��Center=�$��Center=�$��Center=�$��Stretch=�$��21,0,0,0q��� $��Date:��$��6��$��3��$��Center=�$��Center=�$��0,0,0,0q�$��10,0,0,0q�$��26��$
��Left=�$��Center=�(  "System.Windows.Controls.DatePicker  -     Name$ arDate��$��7��$��3��$��Center=�$��0,0,0,0q�$��Center=�$��Center=�$��23��$��Stretch=�$��21,0,0,0q��� $1��+The series and number of birth certificate:��$��2��$��1��$��10,6,0,0q�$��3��$
��Left=�$��0,0,0,0q�$��Center=�$
��Left=�$��2���� -   $ documentNumber��$��2��$��3��$��
132,6,10,6q�$��3��$��3���� $��Place of registration:��$��4��$��1��$��3��$��
10,6,179,0q�$��0,0,0,0q�$��Center=�$��Stretch=�$��2���� -   $ 
placeOfReg��$��5��$��2��$��4��$��	45,0,10,0q�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ CristeningTable��$��10��$��5,5,5,5q�$��11���� $��6��$��1��$��7��$��3��$
��Left=� �� Orientation$ Vertical=�$��LeftToRight=�$��0,6,0,0q�$	��785��.+��� $��0��$��0��$��Baptized��$��Center=��� $��1��$��0��$��
First Name��$
��Left=�$��
10,0,0,-28q��� -   $ 	firstName��$	��560��$��0,0,15,0q�$��25��$��Center=��� $��	Last Name��$��	10,1,0,-7q�$
��Left=�$��5,5,5,5q�$	��Top=�$
��Left=��� -   $ lastName��$��Center=�$	��560��$��25��$��
0,-20,15,0q��� $��
Patronymic��$
��Left=�$��
10,0,0,-25q��� -	   $ 
patronymic��$��Center=�$	��560��$��25��$��0,0,15,0q��� -
      
btn_Search#��[  $��85��$��Right=�$��85��$��Bottom=�$��0,-88,20,20q�	 � ToolTip$	 Search��$��0,0,0,0q��� ���	#FFD8D8D8$��6��$��1��$��7��$��3��$
��Left=�$��0,6,0,0q�$	��780��$	��150���� ���	#FFD8D8D8$��1,1,1,1q�$��0��$��9��$��2��$��9��$��Center=�$��Center=�$	��351��$	��215���� -   
 ��Name$
 Photo��$��0��$��9��$��2��$��9��$��Stretch=�$��Stretch=�$��0,0,2,0q�$	��336��$	��202���� $��11��$��1��$��10��$��Center=�$��Center=�.+��� -    ��Name$ AddNew��$	 Add new record��$��40��$��40��  btn_Add#��[ $��Center=�$��
-129,6,0,1q�$��0,0,0,0q��� -   $
 Edit��$	 Edit Record��$��40��$��40��  btn_Edit#��[ $��Center=�$��-40,-41,0,5q�$��Bottom=�$��0,0,0,0q��� -   $ Delete��$	 Delete record��$��40��$��40��  
btn_Delete#��[ $��Center=�$��
47,-45,0,5q�$��Bottom=�$��0,0,0,0q��� -   $ 
SendToWord��$	 Send report to Word��$��40��$��40��  
btn_ToWord#��[ $��Center=�$��131,-45,0,5q�$��Bottom=�$��0,0,0,0q�