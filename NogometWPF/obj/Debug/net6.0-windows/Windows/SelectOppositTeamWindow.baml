   M S B A M L   `   `   `  ����E  ANogometWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NogometWPF.WindowsNogometWPF.Windows  5   	   =#clr-namespace:NogometWPF.PropertiesNogometWPF.Properties  5   	   0    *NogometWPF.Windows.SelectOppositTeamWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NogometWPF.Windows     5   	   5props#clr-namespace:NogometWPF.Properties     5   	   -   5          �Name$  SelectOppositTeamWin��5   	    � Title$ SelectOppositTeamWindow��5
   	    � WindowStartupLocation$ CenterScreen=�5   	   ��5      
� 5   
    
� GradientOrigin$ 0.5,0.5&�6    
� Center$ 0.5,0.5&�67    
� RadiusX$ 1Q�6H    
� RadiusY$ 1Q�6T   .��5      �  � Color$ 	LimeGreen��6    � Offset$	 0.0Q�6-   � 5      $ #1A5653��6   $	 0.6Q�6+   5      .��5      � -   5        	 �Name$	 gSelectOppositTeam��5      .+�5   
   �� -   5        
 ��Name$
 btnSettings��5      $	��Top=�6&   $��Right=�6>   $��30��5      $��30��6   $��20q�6(    � Cursor$
 Hand��64   
������ $��0q�6[   .��5      �� .+�5      �� $��/Images/settings.png��6   5      5      � 5   
   -   5        $	 gTeam��5      $��Center=�6   $��Center=�6;   ���#107869 J� Opacity$	 0.8Q�6k    � RowDefinitions 5      �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $��* �6     � ColumnDefinitions 5%      �� 5&      $��* �6#   �� 5'      $��* �6#   .+�5*      �� $��0��6   $��0��6&   $��10q�66   ���#08313A.+�5+      �� %   NogometWPF.Properties.Resources   odabranaReprezentacija#��Z 6   $
��Bold"�6U   $��18(�6g   $��	0 10 0 15q�6u    �� Padding$ 10q�6�   ���#5CD85A$��Center=�6�   $��Center=�6�   �� 5,       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5-      �� -   5         ��Name$ lblFirstTeam��5-      $��40q�62   $��20q�6>   $��Center=�6K   ���#08313A���#D1E8A1$��20(�6�   $	 0.6Q�6�   5.      �� 5/      -   5        $
 btnDetails1��5/      $��30��62   $��30��6>   ���#D1E8A1$��0q�6^   $��0 5 20 0q�50   <   .��51      �� $��/Images/info.png��6    52      53      54      �� 56      $��0��6   $��1��6&   $��10q�66   ���#08313A.+�57      ��    odaberiteProtivnika#��Z 6   $
��Bold"�6R   $��18(�6d   $��	0 10 0 15q�6r   $ 10q�6�   ���#5CD85A$��Center=�6�   $��Center=�6�   �� 58      $ 
Horizontal=�6   $��Center=�66   .+�59      �� -   5         ��Name$ cboxSecondTeam��59      $��10q�67   $��48q�6D   $	��130��6P   5:      �� 5;      -   5        $
 btnDetails2��5;      $��30��62   $��30��6>   ���#D1E8A1$��0q�6^   $��0 0 20 0q�5<   =   .��5=      �� $��/Images/info.png��6    5>      5?      5@      �� 5A      $��1��6   $��2��6&   .+�5B      �� -	   5        $
 btnShowResult��5B         prikaziRezultat#��Z 60   $��Center=�6e   $��Center=�6�   $��10q�6�   $��10q�6�   $
 Hand��5C      
������ $��15(�6@   $��SemiBold"�6N   5E      �� 5F      -
   5        $ 	lblResult��5F      ���#D1E8A1$��Center=�6@   $��0q�5G      $��25(�6#   $��40��61   5H      5I      �� 5J      $��2��6   $��0��6&   $��30q�66   $	 0.8Q�6B   $��Right=�5K      .+�5L      �� -   5        $
 btnBack��5L         nazad#��Z 6*   $��16(�6U   $
��Bold"�6c   $	��100��6u   $��	0 30 0 30q�6�   ���#9ACD32$��15q�5M   2   6?   5N      �� 5O      $��2��6   $��2��6&   $��30q�66   $	 0.8Q�6B   $
��Left=�5P      .+�5Q      �� -   5        $
 btnSave��5Q         spremi#��Z 6*   $��16(�6V   $
��Bold"�6d   $	��100��6v   $��	0 30 0 30q�6�   ���#9ACD32$��15q�5R   2   6?   5S      5T      � 5U   
   -   5         �Name$ progressBar��5U      $	��150��6+   $��30��67   $��5q�6C   $y�Hidden=�5V      
���   �$��2q�6=   5W      5X      