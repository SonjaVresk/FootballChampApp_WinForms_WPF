   M S B A M L   `   `   `  ����E  ANogometWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NogometWPF.WindowsNogometWPF.Windows  5   	   =#clr-namespace:NogometWPF.PropertiesNogometWPF.Properties  5   	   -    'NogometWPF.Windows.PlayersOnFiledWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NogometWPF.Windows     5   	   5props#clr-namespace:NogometWPF.Properties     5   	   -   5          �Name$  PlayersOnFielddWin��5   	    � Title$ PlayersOnFiledWindow��5
   	   $	��450��6&   $	��800��63    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � -   5         �Name$ gField��5      ��5   
   �� 5       �� ImageSource$ /Images/fieldF.png��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5!   
   �� -   5         ��Name$ 	pnlNavBar��5!   F   $��0��6   $��0��6"   $��3��62   ���#08313A �� Orientation$ 
Horizontal=�6n   .+�5"      �� -   5        	 ��Name$	 btnBack��5"      $
��Left=�6&   ���#5CD85A
 � Cursor$

 Hand��6V   $��14(�6d   $��15q�5#      $��5q�6!   $
��Bold"�6-   .��5$      �� $��/Images/back.png��6   $��30��62   $��30��6>   5%      5&      �� 5'   
   $��0��6   $��3��6"   ���#08313A.+�5(      �� -   5         ��Name$ lblCode��5(      ���#5CD85A$��20(�6:   $��	0 15 0 15q�6H   $��Center=�6[   $��Center=�6v   5)      �� 5*   
   $��0��6   $��4��6"   ���#08313A.+�5+      �� -   5        $ 
lblOppCode��5+      ���#5CD85A$��20(�6=   $��	0 15 0 15q�6K   $��Center=�6^   $��Center=�6y   5,      �� 5-   
   $��0��6   $��5��6"   $��3��62   ���#08313A6F   �� 50   
   -   5        $ 	pnlGoalie��50   2   $��1��6   $��0��6"   $��Center=�51      $��5q�60   �� 52   
   -   5        $ pnlDefender��52   2   $��1��6   $��1��6"   $��Center=�53      $��5q�60   �� 54   
   -	   5        $ pnlMidfield��54   2   $��1��6   $��2��6"   $��Center=�55      $��5q�60   �� 56   
   -
   5        $ 
pnlForward��56   2   $��1��6   $��3��6"   $��Center=�57      $��5q�60   �� 58   
   -   5        $ pnlForwardOp��58   2   $��1��6   $��4��6"   $��Center=�59      $��5q�60   �� 5:   
   -   5        $ pnlMidfieldOp��5:   2   $��1��6   $��5��6"   $��Center=�5;      $��5q�60   �� 5<   
   -   5        $ pnlDefenderOp��5<   2   $��1��6   $��6��6"   $��Center=�5=      $��5q�60   �� 5>   
   -   5        $ pnlGoalieOp��5>   2   $��1��6   $��7��6"   $��Center=�5?      $��5q�60   5A      5B      