   M S B A M L   `   `   `  ���� J  FHumanMetricData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HumanMetricData.WindowsHumanMetricData.Windows  (    "HumanMetricData.Windows.WeddingWin   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:HumanMetricData.Windows       � Title$  
WeddingWin��$	��800��$
��1300��$��Microsoft Sans Serif)�$��16(�.���  � ColumnDefinitions �� $��30 ��� $
��123* ��� $	��69* ��� $
��180* ��� $
��123* ��� $	��37* ��� $
��102* ��� $
��158* ��� $	��30* ��� $
��225* ��� $
��225* � � RowDefinitions �� $	��55* ��� $	��24* ��� $��6* ��� $	��24* ��� $��6* ��� $	��24* ��� $��6* ��� $	��24* ��� $
��126* ��� $	��10* ��� $
��417* ��� $	��50* �.+��� $��WEDDING JOURNAL��$��0��$��11��$��5,15,5,5q� �� TextAlignment$ Center=�$��24(�$
��Bold"��� $��Active Record:��$��1��$��1��$��Center=�$��0,0,0,0q�$��	10,0,69,0q�$
��Left=�$��Center=�$��2��$��18���� $��2��$��Center=�$��Center=�$��
0,55,179,0q�$��2��$��2���� $��date of:��$��3��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��
10,0,107,0q�$��26��(  "System.Windows.Controls.DatePicker  $��3��$��1��$��Center=�$��0,0,0,0q�$��	90,0,90,0q�   SelectedDateFormat$ Short=�$��Center=�$��Center=�$��23��$��2���� $8��2The series and number of the marriage certificate:��$��2��$��1��$��10,6,0,0q�$��3��$
��Left=�$��0,0,0,0q�$��Center=�$
��Left=�$	��349��$��2���� $��2��$��3��$��	179,6,0,0q�$��2��$��2���� $
��№:��$��3��$��5��$
��Left=�$��30��$��0,0,0,0q� � UseLayoutRounding$
 True��$��Center=�$
��Left=�$��Center=�$��6,0,0,0q�$��18���� $��2��$��5��$��37,6,0,0q�$��2��$��2���� $��Place of registration:��$��4��$��1��$��3��$��
10,6,179,0q�$��0,0,0,0q�$��Center=�$��Stretch=�$��2���� $��4��$��2��$��3��$��45,6,0,0q�$��Center=�$��2���� $��Date of registration:��$��4��$��5��$��3��$��5,6,0,0q�$��Center=�$
��Left=�$��0,0,0,0q�$	��140��$
��Left=�$��2��  $��5��$��7��$��	15,0,32,0q�$��Center=�$��0,0,0,0q�$��Center=�$��Center=�$��2��$��22��&   System.Windows.Controls.DataGrid  $��10��$��5,5,5,5q�$��11���� $��6��$��1��$��7��$��3��$
��Left=� �� Orientation$ Vertical=�$��LeftToRight=�$��0,6,0,0q�$	��785��.+��� $��0��$��0��$��Getting maried��$��Center=��� $��1��$��0��$��
First Name��$
��Left=�$��
10,0,0,-28q��� $	��560��$��0,0,15,0q�$��25��$��Center=��� $��	Last Name��$��	10,1,0,-7q�$
��Left=�$��5,5,5,5q�$	��Top=�$
��Left=��� $��Center=�$	��560��$��25��$��
0,-20,15,0q��� $��
Patronymic��$
��Left=�$��
10,0,0,-25q��� $��Center=�$	��560��$��25��$��0,0,15,0q���    
btn_Search#��[  $��85��$��Right=�$��85��$��Bottom=�$��0,-88,20,20q�4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Default=�   IsRequiredForForm$
 True��	 � Cursor$
	 Hand��
 � ToolTip$
 Search��$��0,0,0,0q��� ���	#FFD8D8D8$��6��$��1��$��7��$��3��$
��Left=�$��0,6,0,0q�$	��780���� $��1��$��8��$��2��$��8��$	��224��$��5,0,10,0q�$	��220��.+��� ���	#FFD8D8D8$��1,1,1,1q�$��1��$��8��$��2��$��8��$	��224��$��Stretch=�$��Stretch=�$	��217���� $��1��$��10��$��8��$	��224��$��-8,0,5,0q�$	��220��.+��� ���	#FFD8D8D8$��1,1,1,1q�$��1��$��10��$��8��$	��224��$��Stretch=�$��-8,0,5,0q�$��Stretch=�$	��220���� $��11��$��1��$��10��$��Stretch=�$��Center=�$��0,0,0,2q�.+��� -    ��Name$ AddNew��$
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