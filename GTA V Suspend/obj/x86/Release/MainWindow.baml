   M S B A M L   `   `   `  ���� H  DGTA V Suspend, Version=0.9.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:GTA_V_Suspend.PropertiesGTA_V_Suspend.Properties      GTA_V_Suspend.MainWindow   ,p&clr-namespace:GTA_V_Suspend.Properties  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  MainW�� � Title$ GTA V Suspend��$	��460��$	��750�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=����	#FF464646.��� -    �Name$ GridM�����	#FF4B4B4B.+��� $��99��$��	59,70,0,0q�$	��Top=�$
��Left=�$	��626�� �� CornerRadius$ 10�����	#FF4E4E4E._�� -   $ Grid1�� � ColumnDefinitions �� ��  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 20Q�	   Color$	 	#FF3737FF��
   Opacity$	
 0.1Q�   	Direction$	 270Q�   RenderingBias$ Quality=�   ShadowDepth$ 3Q�.+��� -    ��Name$ LabelPidHeader��$��PID (İşlem kimliği):��$��0,5,10,0q�$	��Top=� J� RenderTransformOrigin$ -0.895,1.298&����	#FFE6E6E6$��29��$��0q�$��Right=�$	��190��$��Right=�&   System.Windows.Media.TextOptions   TextRenderingMode$ 	ClearType=���Z� �� -   $ LabelStatusHeader��$��Durum:��$��	0,35,10,0q�$	��Top=�$ -0.895,1.298&����	#FFE6E6E6$��29��$��Right=�$��Right=�$	��107����Z� �� -   $ LabelTimeHeader��$��Askıda geçen süre:��$��	0,65,10,0q�$ -0.895,1.298&����	#FFE6E6E6$��Right=�$	��125��$��Right=�$��29��$	��Top=���Z� �� -   $ 	LabelTime��$
��0 sn��$
��Left=�$��	10,65,0,0q�$	��Top=����	#FFF0F0F0$��29��$��56��$��1���� -   $ LabelStatus��$��Askıya alma bekleniyor.
��$
��Left=�$��	10,35,0,0q�$	��Top=����	#FFF0F0F0$��29��$	��293��$��1���� -	   $ LabelPid��$��Yok.
��$
��Left=�$��10,5,0,0q�$	��Top=����	#FFF0F0F0$��29��$	��293��$��1���� $	��163��$��
59,198,0,0q�$	��Top=�$
��Left=�$	��626��$ 10�����	#FF4E4E4E._�� -
   $ Grid3�� �� ��    $ 20Q�$	 	#FF3737FF��$	
 0.1Q�$	 270Q�$ Quality=�$ 3Q�.+��� -    ��Name$ ButtonSuspend��$��
Askıya al��$��241,20,-72,0q�$ 	ClearType=�$	��Top=�$	��144��$��46�����	#FF232323$��20(�$��1q�$
��Left=�   $ 15Q�$	 	#FF646464��$	 270Q�$ Quality=�$	
 0.1Q�$ 3Q�����  �� 
TargetType" ��.���  �� Property � �� �� Value �	#FF8C8C8C��  � ��$ 2q���  � �� �	#33FF2828��  � �� ��  �� 
TargetType" ��.R��� #��z��#��z��#��z��$ 6��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �	#FF787878��  � �� �	#33F02828��  � ��$ 3q�P�  � {� .  . ���  � �� �	#FF646464�� -   $ ButtonResume��$��Sürdür��$��
241,0,0,20q�$ 	ClearType=�$��20(����	#FF232323$
��Left=�$	��144�����	#3328FF28$��2��$��46��$��Bottom=�   $	 	#FF646464��$ 15Q�$	 270Q�$	
 0.1Q�$ Quality=�$ 3Q����� " ��.���  � �� �	#FF8C8C8C��  � ��$ 2q���  � �� �	#3328FF28��  � �� �� " ��.R��� #��z��#��z��#��z��$ 6��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � �� �	#FF787878��  � �� �	#3328F028��  � ��$ 3q��� -   $ ButtonSettings��$�� ��$��	59,10,0,0q�$ 	ClearType=�$	��Top=�$��30��$��30�����	#FF232323$��20(�$��1q�$
��Left=���Z� ����  �� ImageSource$ Resources/Settings.png�� j� TileMode$
 Tile=�   $ 15Q�$	 	#FF646464��$	 270Q�$ Quality=�$	
 0.1Q�$ 3Q����� " ��.���  � �� �	#FF8C8C8C��  � �� �� " ��.R��� #��z��#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � �� �	#FF787878��  � �� �	#33F02828��  � ��$ 2q�P�  � {� .  . ���  � �� �	#FF646464�� -   $ ButtonAbout��$�� ��$��
103,10,0,0q�$ 	ClearType=�$	��Top=�$��30��$��30��$��20(�$��1q�$
��Left=���Z� ���� $ Resources/About.png��$
 Tile=�   $ 15Q�$	 	#FF646464��$	 270Q�$ Quality=�$	
 0.1Q�$ 3Q����� " ��.���  � �� �	#FF8C8C8C��  � �� �� " ��.R��� #��z��#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � �� �	#FF787878��  � �� �	#33F02828��  � ��$ 2q�P�  � {� .  . ���  � �� �	#FF646464