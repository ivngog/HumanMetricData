   M S B A M L   `   `   `  ����J  FHumanMetricData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HumanMetricData.WindowsHumanMetricData.Windows  5   	   +    %HumanMetricData.Windows.MainAppWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:HumanMetricData.Windows     5   	     � Title$  Human metric data��5   	   $	��800��6#   $
��1300��60    � WindowStyle$ SingleBorderWindow=�6=    � 
ResizeMode$ NoResize=�6^    � Icon$" ../Images/Icons/1lerc2tu.png��6t   $��16(�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��19* �6    � RowDefinitions 5   
   �� 5      $��6* �6   �� 5      $
��215* �6   .+�5   
   o� -   5         o�Name$
 menu��5      $��0��6   .@�5      m� -   5         m�Name$
 file��5      $
��Auto��6%   $��22��62   $��_File��6>   .@�5      m� -   5        $ 
itm_OpenDb��5      $��Open database file��6/   m� 5      -   5        $ itm_OpenJournals��5      $��Set puth to Journals��65   5      m� 5      $��Journals��6   .@�5      m� -   5        $ 
Cristening��5      $��
Cristening��6/   6C   m� 5      -   5        $ Funeral��5      $��Funeral��6,   6=   m� 5      -   5        $ Wedding��5      $��Wedding��6,   6=   5      m� 5      $��Language��6   .@�5      m� -   5        $	 Rus��5      $��Ru��6(   64   m� 5      -	   5        $	 Eng��5      $��En��6(   64   5      5!      �� 5"   
   -
   5        	 ��Name$	 MainContent��5"      $��1��6.   .��5#      �� $
��Fill=�6Y   ��6   �� *ImageSource+   Main_Picture
 �� Source#
 [  6Y   5$      5-      5.      