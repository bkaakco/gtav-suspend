   M S B A M L   `   `   `  ���� H  DGTA V Suspend, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GTA_V_SuspendGTA_V_Suspend      GTA_V_Suspend.About   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:GTA_V_Suspend     -   $	��698��$	��403��  � 	Resources     FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 StandartButton1 �� 
TargetType �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value N� EnterActions	 �� To g� Duration �� TargetProperty N� ExitActions��%  &	        &	 N     &	 c     &	 x     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     �� .���  � �� �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  � ��
 ���� ��  � �� �	#FFB4D6C7��  � �� �� " ��.R��� #��z��$��1q�#��z��$ 6��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver .  �� .���� .���� $ 	#FFB4D6C7X�$ 	0:0:0.200D�$2 ,(Button.BorderBrush).(SolidColorBrush.Color)� �� .���� .���� $ 	#FF707070X�$ 	0:0:0.200D�$2 ,(Button.BorderBrush).(SolidColorBrush.Color)�.��� -    �Name$ GridM�����	#FF4B4B4B.+��� -   $�� ��$
��Left=�$��	35,12,0,0q�$	��Top=�$��30��$��30��$��20(���Z� ��Z� ����  �� ImageSource$ Resources/Back.png�� j� TileMode$
 Tile=����� " ��.���  � �� �	#FF8C8C8C��  � �� �� " ��.R��� #��z��#��z��#��z��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ���  � �� �	#FF787878��  � �� �	#33F02828��  � ��$ 2q�P� 
 � {� .  . ���  � �� �	#FF646464�� -    ��Name$ 
LabelAbout��$��	Hakkında��$��	75,10,0,0q�$	��Top=�$��16(�
�������$
��Left=���Z� �� -    ��Name$ Border1��$��	75,80,0,0q�$��78��$	��587�����	#FF4E4E4E$
��Left=�$	��Top=�$ 10��._�� -   $ Grid1��.+��� -   $ LabelVersion��$��0.9 Beta��$
��Left=�$��	10,10,0,0q�$	��Top=�
�������$��13.333(���Z� �� -   $ LabelVersionDate��$��
14.09.2021��$
��Left=�$��	10,40,0,0q�
�������$��13.333(�$��28��$	��Top=���Z� �� -	   $ Border2��$��
75,210,0,0q�$��97��$	��587�����	#FF4E4E4E$
��Left=�$	��Top=�$ 10��._�� -
   $ Grid2�� � ColumnDefinitions �� $
��262* ��� $
��325* �.+��� -    ��Name$ LogoBk��$��
20,10,0,34q�$%��Resources/BKAAKCO_B_LOGO_48.png��$
��None=�$
��Left=�$��48�� J� OpacityMask �� $% Resources/BKAAKCO_B_LOGO_48.png�� j� Stretch$
 None=��� -   $ LabelBk��$��bkaakco��$��	14,0,0,10q����	#FFC8C8C8$
��Left=�$��61��$��Center=�$��Center=�$��26��$��Bottom=��� -    ��Name$ 
ButtonSite��$
��Site��$
��Left=�$��	8,36,0,35q�$��14(�#��� 
 $��55��$��1���� -   $ ButtonGitHub��$��GitHub��$
��Left=�$��
98,36,0,35q�$��14(�#��� 
 $��76��$��1���� -   $ 	LabelMail��$��bkaakco@gmail.com��$��100,34,0,34q����	#FFC8C8C8$
��Left=�$	��145��$��Center=�$��Center=�$��14(��� -   $ LabelVersionHeader��$��Sürüm��$
��Left=�$��	75,50,0,0q�$	��Top=�$��14(����	#FFE6E6E6��Z� �� -   $ LabelProducerHeader��$��	Yapımcı��$
��Left=�$��
75,180,0,0q�$	��Top=�$��14(����	#FFE6E6E6��Z� 