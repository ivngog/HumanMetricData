   M S B A M L   `   `   `  ����J  FHumanMetricData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HumanMetricDataHumanMetricData  5   	        HumanMetricData.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:HumanMetricData     5   	     � Title$
  MyDB��5   	   $	��441��6   $	��590��6#    � 
ResizeMode$ NoResize=�6/    � WindowStartupLocation$ CenterScreen=�6E   
���   � � AllowsTransparency$
 True��5	       � WindowStyle$
 None=�66   .��5      � $��12(�6   $
��Auto��6%   $��10q�62   
���   � � ColumnDefinitions 5   
   �� 5      $	��37* �6   �� 5      $
��533* �6   .+�5   
   �� $��-11,-8,-10,-9q�6   
���   �$��2��6?   .@�5      �� -   5         ��Name$ 	ClientApp��5   &   $��Client��6   $��Right=�69    J� Opacity$	 0.5Q�6U   .��5      �    MainWin_Img#��[  6    5      �� 5      $	��88* �6+   �� 5      $	��37* �6+   �� 5      $	��70* �6+    � RowDefinitions 5      �� 5      $	��50* �6(   �� 5      $	��50* �6(   �� 5      $	��50* �6(   �� 5       $	��50* �6(   �� 5!      $	��20* �6(   �� 5"      $	��25* �6(   �� 5#      $	��25* �6(   �� 5$      $	��91* �6(   �� 5%      $	��48* �6(   .+�5'      �� $��Enter to Client Data��6   $��4��6;   
�������$��Normal"�6[   $	 0.8Q�6o   $
��Left=�6}   $��Center=�6�   $	��129��6�   $��1��6�   $��2��6�   $��32��6�   �� 5(      $��Login:��6   $��5��6-   
�������$��	200,4,0,1q�6M   $��0,0,0,0q�6`   $
��Left=�6r   $��50��6�   �� 5*      -   5        	 ��Name$	 LoginToClient��5*      
 � ToolTip$
 Enter your Username��65   $��5��6S   $��1��6`   $��Center=�6q   $	 0.5Q�6�   $��25��6�   $��16(�6�    �� TextAlignment$
 Left=�6�   $��Center=�6�    �� TextWrapping$
 Wrap=�6�   
���   �
�������6  �� 5+      $��	Password:��6   $��6��60   
�������$
��Left=�6P   $��	200,4,0,1q�6k   $��56��6~   $��0,0,0,0q�6�   $��Stretch=�6�   $��Stretch=�6�   �� 5,      -   5        $	 PswdToClient��5,      $
 Enter your Password��64   $��6��6R   $��1��6_   $��Center=�6p   $	 0.5Q�6�   $��25��6�   $��16(�6�   $
 Left=�6�   $��Center=�6�   $
 Wrap=�6�   
���   �
�������6  �� 5-      -   5        $��Enter��5-      $��5��6.   $��2��6;   $��2��6K   $
��Left=�6\   $��Center=�6w   $��10,0,0,0q�6�   ���	#FFB8B8B8
���   �$��Black"�50      $��0q�51      $��45��52      $��45��53      $��16(�54      $	 0.5Q�6    � 	Resources 55       �� 
TargetType �� Property �� Value��%^   '��       �� 56      " ��6$   .�57   "   ��  �@��CornerRadius$ 3��6A   58      59      5:      �� 5;      -   5         ��Name$ CloseWin��5;      $��8��6/   $��2��6<   $
��Left=�6L   $��Center=�6g   $��25��6�   $��25��6�   $��0,0,0,0q�6�   ���	#FF2408084  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Default=�6�   $	 0.8Q�6�   $
 Close��6  $��	170,0,0,0q�6.    	btn_Close#��[ 6A  5>      5?      �� 5B      -   5        $ openApp��5B   (   $��Settings��6   $��Right=�69   $	 0.5Q�6U   .��5C      � #��[  6    5D      �� 5E      $	��88* �6+   �� 5F      $	��37* �6+   �� 5G      $	��70* �6+    5I      �� 5J      $	��50* �6(   �� 5K      $	��50* �6(   �� 5L      $	��50* �6(   �� 5M      $	��50* �6(   �� 5N      $	��20* �6(   �� 5O      $	��25* �6(   �� 5P      $	��25* �6(   �� 5Q      $	��91* �6(   �� 5R      $	��48* �6(   .+�5T      �� $��Enter to Settings��6   $��4��68   
�������$��Normal"�6X   $	 0.8Q�6l   $
��Left=�6z   $��Center=�6�   $	��129��6�   $��1��6�   $��2��6�   $��32��6�   �� 5U      $��Login:��6   $��5��6-   
�������$��	200,4,0,1q�6M   $��0,0,0,0q�6`   $
��Left=�6r   $��50��6�   �� 5W      -   5        $	 LoginToSettings��5W      $��login��67   $��5��6D   $��1��6Q   $��Center=�6b   $	 0.5Q�6}   $��25��6�   $��16(�6�   $
 Left=�6�   $��Center=�6�   $
 Wrap=�6�   
���   �
�������6  �� 5X      $��	Password:��6   $��6��60   
�������$
��Left=�6P   $��	200,4,0,1q�6k   $��56��6~   $��0,0,0,0q�6�   $��Stretch=�6�   $��Stretch=�6�   �� 5Y      -   5        $	 PswdToSettings��5Y      $��Password��66   $��6��6F   $��1��6S   $��Center=�6d   $	 0.5Q�6   $��25��6�   $��16(�6�   $
 Left=�6�   $��Center=�6�   $
 Wrap=�6�   
���   �
�������6  �� 5Z      -	   5        $��Enter��5Z      $��5��6-   $��2��6:   $��2��6J   $
��Left=�6[   $��Center=�6v   $��10,0,0,0q�6�   ���	#FFB8B8B8
���   �$��Black"�5]      $��0q�5^      $��45��5_      $��45��5`      $��16(�5a      $	 0.5Q�6    5b      ��%^   '��       �� 5c      " ��6$   .�5d   "   ��  �@��CornerRadius$ 3��6A   5e      5f      5g      �� 5h      -
   5        $ Close��5h      $��8��6,   $��2��69   $
��Left=�6I   $��Center=�6d   $��25��6   $��25��6�   $��0,0,0,0q�6�   ���	#FF240808$ Default=�6�   $	 0.8Q�6�   $
 Close��6  $��	170,0,0,0q�6+  #��[ 6>  5k      5l      5o      5q      5r      