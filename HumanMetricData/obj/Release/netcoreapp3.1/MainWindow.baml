   M S B A M L   `   `   `  ���� J  FHumanMetricData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HumanMetricDataHumanMetricData       HumanMetricData.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:HumanMetricData       � Title$
  MyDB��$	��441��$	��590�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�
���   � � AllowsTransparency$
 True�� � WindowStyle$
 None=�.��� $��12(�$
��Auto��$��10q�
���   � � ColumnDefinitions �� $	��37* ��� $
��533* �.+��� $��-11,-8,-10,-9q�
���   �$��2��.@��� -    ��Name$ 	ClientApp��$��Client��$��Right=� J� Opacity$	 0.5Q�.���    MainWin_Img#��[   �� $	��88* ��� $	��37* ��� $	��70* � � RowDefinitions �� $	��50* ��� $	��50* ��� $	��50* ��� $	��50* ��� $	��20* ��� $	��25* ��� $	��25* ��� $	��91* ��� $	��48* �.+��� $��Enter to Client Data��$��4��
�������$��Normal"�$	 0.8Q�$
��Left=�$��Center=�$	��129��$��1��$��2��$��32���� $��Login:��$��5��
�������$��	200,4,0,1q�$��0,0,0,0q�$
��Left=�$��50���� -   	 ��Name$	 LoginToClient��
 � ToolTip$
 Enter your Username��$��5��$��1��$��Center=�$	 0.5Q�$��25��$��16(� �� TextAlignment$
 Left=�$��Center=� �� TextWrapping$
 Wrap=�
���   �
��������� $��	Password:��$��6��
�������$
��Left=�$��	200,4,0,1q�$��56��$��0,0,0,0q�$��Stretch=�$��Stretch=��� -   $	 PswdToClient��$
 Enter your Password��$��6��$��1��$��Center=�$	 0.5Q�$��25��$��16(�$
 Left=�$��Center=�$
 Wrap=�
���   �
��������� -   $��Enter��$��5��$��2��$��2��$
��Left=�$��Center=�$��10,0,0,0q����	#FFB8B8B8
���   �$��Black"�$��0q�$��45��$��45��$��16(�$	 0.5Q� � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -    ��Name$ CloseWin��$��8��$��2��$
��Left=�$��Center=�$��25��$��25��$��0,0,0,0q����	#FF2408084  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Default=�$	 0.8Q�$
 Close��$��	170,0,0,0q�  	btn_Close#��[ �� -   $ openApp��$��Settings��$��Right=�$	 0.5Q�.��� #��[   �� $	��88* ��� $	��37* ��� $	��70* � �� $	��50* ��� $	��50* ��� $	��50* ��� $	��50* ��� $	��20* ��� $	��25* ��� $	��25* ��� $	��91* ��� $	��48* �.+��� $��Enter to Settings��$��4��
�������$��Normal"�$	 0.8Q�$
��Left=�$��Center=�$	��129��$��1��$��2��$��32���� $��Login:��$��5��
�������$��	200,4,0,1q�$��0,0,0,0q�$
��Left=�$��50���� -   $	 LoginToSettings��$��login��$��5��$��1��$��Center=�$	 0.5Q�$��25��$��16(�$
 Left=�$��Center=�$
 Wrap=�
���   �
��������� $��	Password:��$��6��
�������$
��Left=�$��	200,4,0,1q�$��56��$��0,0,0,0q�$��Stretch=�$��Stretch=��� -   $	 PswdToSettings��$��Password��$��6��$��1��$��Center=�$	 0.5Q�$��25��$��16(�$
 Left=�$��Center=�$
 Wrap=�
���   �
��������� -	   $��Enter��$��5��$��2��$��2��$
��Left=�$��Center=�$��10,0,0,0q����	#FFB8B8B8
���   �$��Black"�$��0q�$��45��$��45��$��16(�$	 0.5Q� ��%9   '��       �� " ��.���  �@��CornerRadius$ 3���� -
   $ Close��$��8��$��2��$
��Left=�$��Center=�$��25��$��25��$��0,0,0,0q����	#FF240808$ Default=�$	 0.8Q�$
 Close��$��	170,0,0,0q�#��[ 