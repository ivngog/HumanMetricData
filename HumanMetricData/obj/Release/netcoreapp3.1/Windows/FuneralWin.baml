   M S B A M L   `   `   `  ���� J  FHumanMetricData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HumanMetricData.WindowsHumanMetricData.Windows  (    "HumanMetricData.Windows.FuneralWin   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:HumanMetricData.Windows       � Title$  
FuneralWin��$	��800��$
��1300��$��Microsoft Sans Serif)�$��16(�.���  � ColumnDefinitions �� $��30 ��� $
��123* ��� $	��69* ��� $
��180* ��� $
��123* ��� $	��37* ��� $
��102* ��� $
��158* ��� $	��30* ��� $
��225* ��� $
��225* � � RowDefinitions �� $	��55* ��� $	��24* ��� $��6* ��� $	��24* ��� $��6* ��� $	��24* ��� $��6* ��� $	��24* ��� $
��126* ��� $	��10* ��� $
��350* ��� $	��50* �.+��� $��FUNERAL JOURNAL��$��0��$��11��$��5,15,5,5q� �� TextAlignment$ Center=�$��24(�$
��Bold"��� $��Active Record:��$��1��$��1��$��Center=�$��0,0,0,0q�$��	10,0,69,0q�$
��Left=�$��Center=�$��2��$��18���� $��2��$��Center=�$��Center=�$��
0,55,179,0q�$��2��$��2���� $��of date:��$��3��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��10,0,0,0q�$��26��(  "System.Windows.Controls.DatePicker  $��3��$��2��$��1��$��Center=�$��0,0,0,0q�$��
81,0,101,0q�   SelectedDateFormat$ Short=�$��Center=�$��Center=�$��23���� $1��+The series and number of death certificate:��$��2��$��1��$��10,6,0,0q�$��3��$
��Left=�$��0,0,0,0q�$��Center=�$
��Left=�$��2���� $��3��$��3��$��	130,0,0,0q�$��2��$��Center=�$��Center=�$
��Left=�$��Center=�$��47���� $
��№:��$��3��$��4��$
��Left=�$��30��$��0,0,0,0q� � UseLayoutRounding$
 True��$��Center=�$
��Left=�$��Center=�$��6,0,0,0q�$��18���� $��2��$��4��$��	37,6,10,6q�$��3��$��2���� $��Place of funeral:��$��4��$��1��$��3��$��
10,6,179,0q�$��0,0,0,0q�$��Center=�$��Stretch=�$��2���� $��5��$��2��$��4��$��	10,0,10,0q�$��Center=��� $��Date of death:��$��3��$��6��$��2��$
��Left=�$��Center=�$��Center=�$��0,0,0,0q�  $��2��$��7��$��2��$��	36,6,30,6q�$��3��$��0,0,0,0q�$��Center=�$��Center=�$��Center=�$��Stretch=��� $��Date of funeral:��$��5��$��5��$��3��$��37,0,0,0q�$��Center=�$
��Left=�$��0,0,0,0q�$	��133��$
��Left=�  $��5��$��7��$��36,0,2,0q�$��Center=�$��0,0,0,0q�$��Center=�$��Center=�$��22��&   System.Windows.Controls.DataGrid  $��10��$��5,5,5,5q�$��11���� $��6��$��1��$��7��$��3��$
��Left=� �� Orientation$ Vertical=�$��LeftToRight=�$��0,6,0,0q�$	��785��.+��� $��0��$��0��$��The deceased person��$��Center=��� $��1��$��0��$��
First Name��$
��Left=�$��
10,0,0,-28q��� $	��560��$��0,0,15,0q�$��25��$��Center=��� $��	Last Name��$��	10,1,0,-7q�$
��Left=�$��5,5,5,5q�$	��Top=�$
��Left=��� $��Center=�$	��560��$��25��$��
0,-20,15,0q��� $��
Patronymic��$
��Left=�$��
10,0,0,-25q��� $��Center=�$	��560��$��25��$��0,0,15,0q��� $��Burial place:��$
��Left=�$��
10,0,0,-25q��� $��Center=�$	��560��$��25��$��0,0,15,0q���    
btn_Search#��[  $��85��$��Right=�$��85��$��Bottom=�$��0,-98,20,20q�4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Default=�   IsRequiredForForm$
 True��	 � Cursor$
	 Hand��
 � ToolTip$
 Search��$��0,0,0,0q��� ���	#FFD8D8D8$��6��$��1��$��7��$��3��$
��Left=�$��0,6,0,0q�$	��780��$	��150���� $��0��$��8��$��3��$��9��$	��220��$��65,38,54,15q�$ 
Horizontal=�$��Center=�$��Stretch=�$	��352��.+��� ���	#FFD8D8D8$��1,1,1,1q�$��0��$��8��$��2��$��9��$
��Left=�$	��352��$	��219���� $��11��$��1��$��10��$��Stretch=�$��Center=�$��0,0,0,2q�.+��� -    ��Name$ AddNew��$
 Add new record��$��40��$��40��  btn_Add#��[ $��Center=�$��
-129,6,0,1q�$��0,0,0,0q��� -   $
 Edit��$
 Edit Record��$��40��$��40��  btn_Edit#��[ $��Center=�$��-40,-41,0,5q�$��Bottom=�$��0,0,0,0q��� -   $ Delete��$
 Delete record��$��40��$��40��  
btn_Delete#��[ $��Center=�$��
47,-45,0,5q�$��Bottom=�$��0,0,0,0q��� -   $ 
SendToWord��$
 Send report to Word��$��40��$��40��  
btn_ToWord#��[ $��Center=�$��131,-45,0,5q�$��Bottom=�$��0,0,0,0q�