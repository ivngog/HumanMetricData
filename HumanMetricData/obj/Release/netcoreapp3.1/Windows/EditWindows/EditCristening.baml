   M S B A M L   `   `   `  ���� J  FHumanMetricData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HumanMetricData.Windows.EditWindows#HumanMetricData.Windows.EditWindows  8    2HumanMetricData.Windows.EditWindows.EditCristening   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:HumanMetricData.Windows.EditWindows       � Title$  EditCristening��$	��600��$	��800�� � WindowStyle$ SingleBorderWindow=� � 
ResizeMode$ NoResize=�$��16(� � WindowStartupLocation$ CenterScreen=�$��Times New Roman)�.���  � ColumnDefinitions �� $	��50* ��� $	��99* ��� $
��107* ��� $	��224 ��� $
��124* ��� $
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
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $��3* ��� $
��0.5* ��� $
��0.5* ��� $��5* ��� $��1* �.+��� -    ��Name$ EditCristeningRecord��$*��$Add new record to cristening journal��$
��Bold"�$��0��$��6��$��Center=�$��Center=�$��Center=�$��28���� -   $ ActiveRecord��$
��A/R:��$��2��$
��Left=�$��0,0,0,0q�$��32��$��Center=�$��18��$��Stretch=�$��Center=�$��14,0,0,0q��� -    ��Name$ txt_ActiveRecord��$��2��$��1,0,1,0q�$��1��$��Center=�$��20���� -   $
 from��$��of date:��$��2��$��2��$
��Left=�$��Center=�$��0,0,0,0q�$��19��$��85��$��Center=�$��Stretch=�$��15,0,0,0q�(  "System.Windows.Controls.DatePicker  -     Name$ date_RecordNumber��$��2��$��3��$��2,0,0,0q�$
��Left=�$��Center=�$��Center=�$��Stretch=�$��22��$	��114��	 � 	Resources	 :  4System.Windows.Controls.Primitives.DatePickerTextBox
 �� 
TargetType �� Property �� Value��%:   '        �� "
  .���  �@��
IsReadOnly$
 True���� -   $ dateOfCristening��$��Date of cristening:��$��4��$��0��$��2��$��Center=�$
��Left=�$��Center=�$��0,0,0,0q�$��18��$��10,0,3,0q�  -   $ date_Committing��$��6��$��0��$��2��$��0,0,0,0q�$��Center=�$��Center=�$��23��$	��112��	 ��%:   '        �� "
  .���  �@��
IsReadOnly$
 True���� -   $ Birtday��$��Birth date:��$��8��$��0��$��2��$��Center=�$��0,0,0,0q�$��Center=�$��18��$
��Left=�$��10,0,3,0q�  -	   $ 
date_Birth��$��10��$��0��$��2��$��Center=�$��Center=�$��Center=�$��Center=�$��0,0,0,0q�$��22��$	��112��	 ��%:   '        �� "
  .���  �@��
IsReadOnly$
 True���� -
   $ 	FirstName��$��
First Name��$��4��$��2��$
��Left=�$��Center=�$��0,0,5,0q�$��Stretch=�$��Center=�$��18��$��82��$��15,0,0,0q��� -   $ LastName��$��	Last Name��$��6��$��2��$
��Left=�$��Center=�$��0,0,5,0q�$��Stretch=�$��Center=�$��19��$��80��$��15,0,0,0q��� -   $ 
Patronymic��$��
Patronymic��$��8��$��2��$
��Left=�$��Center=�$��0,0,5,0q�$��Stretch=�$��Center=�$��18��$��84��$��15,0,0,0q��� -   $ txt_FirstName��$��4��$��3��$��Center=�$��Center=�$��1,0,1,0q�$��20���� -   $ txt_LastName��$��6��$��3��$��Center=�$��Center=�$��1,0,1,0q�$��20���� -   $ txt_Patronymic��$��8��$��3��$��Center=�$��Center=�$��1,0,1,0q�$��20���� -   $ PlaceOfregistration��$��Place of reg:��$��10��$��2��$��Center=�$��Stretch=�$��Center=�$��0,0,5,0q�$
��Left=�$��18��$��90��$��15,0,0,0q��� -   $ txt_PlaceOfReg��$��10��$��3��$��Center=�$��Center=�$��1,0,1,0q�$��20���� -   $
 SNBS��$G��AСерия и № свидетельства о рождении:��$��12��$��0��$��4��$
��Left=�$��10,0,0,0q�$��0,0,0,0q�$��Center=�$	��262���� -   $ txt_BirthCertificate��$��12��$��3��$��Stretch=�$��Center=�$��25,0,0,0q��� $��14��$��0��$��10��$��6��$��1,1,1,1q����	#FFC3C3C3$��	10,1,10,1q��� -   $ Parents��$��Parents��$��14��$��0��$��6��$��Center=�$��27��$��Center=��� -   $ FathersInitials��$��Father's initials:��$��16��$��0��$��2��$��10,0,0,0q�$��Center=�$��28���� -   $ txt_FIinitials��$��16��$��2��$��2��$��0,0,10,0q�$��Center=�$��20���� -   $ MothersInitials��$$��Инициалы матери:��$��20��$��0��$��2��$��10,0,0,0q�$��Center=�$��28���� -   $ txt_MIinitials��$��20��$��2��$��2��$��0,0,10,0q�$��Center=�$��20���� -   $ FatherBdate��$ ��Дата рождения:��$��16��$��4��$��Center=�$��28��$��5,0,0,0q�$��0,0,0,0q� � IsSharedSizeScope$
 True��$��Center=�$
��Left=�  -   $ date_Father��$��15��$��5��$��	10,3,20,0q�$��0,0,0,0q�$��2��	 ��%:   '        �� "
  .���  �@��
IsReadOnly$
 True���� -   $ FAddress��$��Address:��$��18��$��4��$��Center=�$��Center=�$��0,0,0,0q�$��6,0,0,0q�$
��Left=��� -   $ txt_AddressFather��$��18��$��4��$��2��$��Center=�$��	72,0,20,0q�  -   $ date_Mother��$��19��$��5��$��	10,3,20,4q�$��0,0,0,0q�$��3��	 ��%:   '        �� "
  .���  �@��
IsReadOnly$
 True���� -   $ MAddress��$��Address:��$��22��$��4��$��Center=�$��Center=�$��0,0,0,0q�$��6,0,0,0q�$
��Left=��� -   $ txt_MotherAddress��$��22��$��4��$��2��$��Center=�$��	72,0,20,0q��� -    $ MotherBdate��$��Birth date:��$��20��$��4��$��Center=�$��5,0,0,0q�$��28��$��0,0,0,0q�$��Center=�$
��Left=��� -!   $ 	PassportF��$!��Passport series and number:��$��18��$��0��$��3��$��0,0,0,0q�$��Center=�$��Center=�$��18��$��15,0,0,0q�$
��Left=�$	��179��]� $��18��$��2��$��2��$��	66,0,10,0q�$��Center=�$��20��.+��� -"   $ txt_FatherPassport��$��Stretch=�$��Center=��� -#   $ 	PassportM��$!��Passport series and number:��$��22��$��0��$��3��$��0,0,0,0q�$��Center=�$��Center=�$��18��$��14,0,5,0q�$
��Left=�]� $��22��$��2��$��2��$��	66,0,10,0q�.+��� -$   $ txt_MotherPassport��$��Stretch=�$��Center=��� $��24��$��0��$��10��$��6��$��1,1,1,1q����	#FFC3C3C3$��	10,1,10,1q��� -%   $ 
Recipients��$��
Recipients��$��24��$��0��$��6��$��Center=�$��27��$��Center=��� -&   $ Recipients1Init��$��Recipient's 1 initials:��$��26��$��0��$��3��$��10,0,0,0q�$��Center=�$��28���� -'   $ txt_R1initials��$��26��$��2��$��2��$��	25,0,10,0q�$��Center=�$��20���� -(   $ Recipients2Init��$&�� ФИО восприемника:��$��30��$��0��$��3��$��10,0,0,0q�$��Center=�$��28��$
��Left=��� -)   $ txt_R2Iinitials��$��30��$��2��$��2��$��	25,0,10,0q�$��Center=�$��20���� -*   $ R1Bdate��$ ��Дата рождения:��$��26��$��4��$��Center=�$��28��$��5,0,0,0q�$��0,0,0,0q�$
 True��$��Center=�$
��Left=�  -+   $ date_R1Birth��$��26��$��5��$��	10,3,20,0q�$��0,0,0,0q�$��2��	 ��%:   '        �� "
  .���  �@��
IsReadOnly$
 True���� -,   $ 	R1Address��$��Address:��$��28��$��4��$��Center=�$��Center=�$��0,0,0,0q�$��6,0,0,0q�$
��Left=��� --   $ txt_R1Address��$��28��$��4��$��2��$��Center=�$��	72,0,20,0q�  -.   $ date_R2Birth��$��29��$��5��$��	10,3,20,4q�$��0,0,0,0q�$��3��	 ��%:   '        �� "
  .���  �@��
IsReadOnly$
 True���� -/   $ 	R2Address��$��Address:��$��32��$��4��$��Center=�$��Center=�$��0,0,0,0q�$��6,0,0,0q�$
��Left=��� -0   $ txt_R2Address��$��32��$��4��$��2��$��Center=�$��	72,0,20,0q��� -1   $ R2Bdate��$��Birth date:��$��30��$��4��$��Center=�$��5,0,0,0q�$��28��$��0,0,0,0q�$��Center=�$
��Left=��� -2   $ 
PassportR1��$!��Passport series and number:��$��28��$��0��$��3��$��0,0,0,0q�$��Center=�$��Center=�$��18��$��15,0,0,0q�$
��Left=�$	��179��]� $��28��$��2��$��2��$��	66,0,10,0q�$��Center=�$��20��.+��� -3   $ txt_R1Passport��$��Stretch=�$��Center=��� -4   $ 
PassportR2��$!��Passport series and number:��$��32��$��0��$��3��$��0,0,0,0q�$��Center=�$��Center=�$��18��$��15,0,5,0q�$
��Left=�]� $��32��$��2��$��2��$��	66,0,10,0q�.+��� -5   $ txt_R2Passport��$��Stretch=�$��Center=��� -6   $ Baptizer��$��The Baptizer��$��34��$��0��$��6��$��Center=�$��0,0,0,0q�$��Center=��� -7   $ BaptizerInitizls��$��Baptizer's initials��$��36��$��0��$��2��$��0,0,0,0q�$��15,0,0,0q��� -8   $ txt_performedSacrament��$��36��$��2��$��2���� -9   $ Notes��$��Notes��$��38��$��0��$��2��$��0,0,0,0q�$��15,0,0,0q�$��Center=��� -:   $ 	txt_Notes��$��38��$��2��$��4��$��0,0,20,0q��� $��34��$��0��$��6��$��6�����	#FFD8D8D8$��1,1,1,1q�$��Stretch=�$��Stretch=�$��	10,0,10,0q�]� $��41��$��0��$��6��$��Center=�$��Stretch=�.+��� -;   $
��Save��$��0,0,5,0q��� $��Close��]� $��2��$��4��$��11��$��2��$��	50,5,50,5q�.+��� $��2��$��4��$��11��$��2��$��1,1,1,1q����	#FFD8D8D8$��1,1,1,1q�._��� -<    ��Name$ 	OpenImage������ -=   IMG�� j� Stretch$ Uniform=�