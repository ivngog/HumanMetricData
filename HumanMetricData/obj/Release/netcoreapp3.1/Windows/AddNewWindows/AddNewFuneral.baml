   M S B A M L   `   `   `  ���� J  FHumanMetricData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:HumanMetricData.Windows.AddNewWindows%HumanMetricData.Windows.AddNewWindows  9    3HumanMetricData.Windows.AddNewWindows.AddNewFuneral   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Elocal3clr-namespace:HumanMetricData.Windows.AddNewWindows       � Title$  AddNewFuneral��$	��350��$	��800�� � WindowStyle$ SingleBorderWindow=� � 
ResizeMode$ NoResize=�$��16(� � WindowStartupLocation$ CenterScreen=�$��Times New Roman)�.���  � ColumnDefinitions �� $	��50* ��� $
��213* ��� $	��94* ��� $	��239 ��� $��8* ��� $
��196* � � RowDefinitions �� $��5* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��* ��� $
��0.5* ��� $
��5.5* ��� $
��0.5* �.+��� -    ��Name$ AddNewFuneralRecord��$'��!Add new record to Funeral journal��$
��Bold"�$��0��$��6��$��Center=�$��Center=�$��Center=�$��28���� -   $ ActiveRecord��$
��A/R:��$��2��$
��Left=�$��0,0,0,0q�$��32��$��Center=�$��18��$��Stretch=�$��Center=�$��10,0,0,0q��� $��2��$��1,0,1,0q�$��1��$��Center=�$��20���� -   $
 from��$��of date:��$��2��$��2��$��Center=�$��Center=�$��0,0,0,0q�$��19��$��86��$��Center=�$��Stretch=�(  "System.Windows.Controls.DatePicker  $��2��$��3��$��2,0,0,0q�$
��Left=�$��Center=�$��Center=�$��Stretch=�$��22��$	��114�� � 	Resources :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType	 �� Property
 �� Value��%:   '        �� "  .��� 	 �@��
IsReadOnly$

 True���� -   $ dateOfDeath��$��Date of death:��$��4��$��0��$��2��$��Center=�$
��Left=�$��Center=�$��0,0,0,0q�$��18��$��10,0,0,0q�$
��Left=�  $��4��$��1��$��0,0,0,0q�$��Center=�$��Right=�$��23��$	��112�� ��%:   '        �� "  .��� 	 �@��
IsReadOnly$

 True���� -   $ Birtday��$��Birth date:��$��6��$��0��$��2��$��Center=�$��0,0,0,0q�$��Center=�$��18��$
��Left=�$��10,0,0,0q�$
��Left=�  $��6��$��0��$��2��$��Right=�$��Center=�$��Center=�$��Center=�$��0,0,0,0q�$��22��$	��112�� ��%:   '        �� "  .��� 	 �@��
IsReadOnly$

 True���� -   $ DateOfFuneral��$��Date of funeral:��$��8��$��0��$��2��$��Center=�$��0,0,0,0q�$��Center=�$��18��$
��Left=�$��10,0,0,0q�$
��Left=�  $��8��$��0��$��2��$��Right=�$��Center=�$��Center=�$��Center=�$��0,0,0,0q�$��22��$	��112�� ��%:   '        �� "  .��� 	 �@��
IsReadOnly$

 True���� -   $ 	FirstName��$��
First Name��$��4��$��2��$��Center=�$��Center=�$��0,0,5,0q�$��Stretch=�$��Center=�$��18��$��82���� -   $ LastName��$��	Last Name��$��6��$��2��$��Center=�$��Center=�$��0,0,5,0q�$��Stretch=�$��Center=�$��19��$��80���� -	   $ 
Patronymic��$��
Patronymic��$��8��$��2��$��Center=�$��Center=�$��0,0,5,0q�$��Stretch=�$��Center=�$��18��$��84���� $��4��$��3��$��Center=�$��Center=�$��1,0,1,0q�$��20���� $��6��$��3��$��Center=�$��Center=�$��1,0,1,0q�$��20���� $��8��$��3��$��Center=�$��Center=�$��1,0,1,0q�$��20���� -
   $ PlaceOfFuneral��$��Place of funeral:��$��12��$��0��$��2��$��Center=�$��Stretch=�$��Center=�$��0,0,5,0q�$
��Left=�$��18��$��10,0,0,0q��� $��12��$��1��$��3��$��Center=�$��Center=�$��	119,0,1,0q�$��20���� -   $
 SNCD��$C��=Серия и № свидетельства о смерти:��$��10��$��0��$��3��$
��Left=�$��10,0,0,0q�$��0,0,0,0q�$��Center=�$	��262��$��Center=�]� $��10��$��2��$��2��$��25,0,1,0q�$��Center=�$��Stretch=�.+��� $��12��$��3��$��Stretch=�$��Center=�$��40���� $��12��$��3��$��Stretch=�$��Center=��� -   $ FuneralDirector��$��Funeral Director��$��14��$��0��$��6��$��Center=�$��0,0,0,0q�$��Center=�$��18���� -   $ FuneralService��$'��!The funeral service was performed��$��16��$��0��$��2��$��0,0,0,0q�$��15,0,0,4q�$��2���� $��16��$��2��$��2��$��0,0,0,4q�$��2���� -   $ Notes��$��Notes��$��18��$��0��$��2��$��0,0,0,0q�$��15,0,0,0q�$��Center=�$��18���� $��18��$��2��$��4��$��0,0,20,4q�$��2���� $��14��$��0��$��7��$��6�����	#FFD8D8D8$��1,1,1,1q�$��	10,0,10,3q�]� $��21��$��0��$��6��$��Center=�$��0,3,0,7q�$��3��$��Stretch=�.+��� $
��Save��$��0,0,5,0q��� $��Close��]� $��2��$��5��$��11��$��7,5,10,5q�.+��� $��2��$��4��$��11��$��3��$��1,1,1,1q����	#FFD8D8D8$��1,1,1,1q�._��� -    ��Name$ 	OpenImage������ -   IMG��