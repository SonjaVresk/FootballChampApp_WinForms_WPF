   M S B A M L   `   `   `  ����E  ANogometWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NogometWPF.WindowsNogometWPF.Windows  5   	   =#clr-namespace:NogometWPF.PropertiesNogometWPF.Properties  5   	   )    #NogometWPF.Windows.SelectTeamWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NogometWPF.Windows     5   	   5props#clr-namespace:NogometWPF.Properties     5   	   -   5          �Name$  SelectTeamWin��5   	    � Title$ SelectTeamWindow��5
   	    � WindowStartupLocation$ CenterScreen=�5   
   ��5      
� 5   
    
� GradientOrigin$ 0.5,0.5&�6    
� Center$ 0.5,0.5&�67    
� RadiusX$ 1Q�6H    
� RadiusY$ 1Q�6T   .��5      �  � Color$ 	LimeGreen��6    � Offset$	 0.0Q�6-   � 5      $ #1A5653��6   $	 0.6Q�6+   5      .��5      � -   5        	 �Name$	 gSelectTeam��5      .+�5   
   �� -   5        
 ��Name$
 btnSettings��5      $	��Top=�6&   $��Right=�6>   $��30��5      $��30��6   $��20q�6(    � Cursor$
 Hand��64   
������ $��0q�6[   .��5      �� .+�5      �� $��/Images/settings.png��6   5      5      � 5!   
   -   5        $	 gTeam��5!      $��Center=�6   $��Center=�6;   ���#107869 � RowDefinitions 5"      �� 5#      $
��Auto �6    �� 5$      $��* �6    .+�5'      �� $��0��6   $��0��6&   $��40q�66   .+�5(      �� %   NogometWPF.Properties.Resources   odaberiteReprezentaciju#��Z 6   $
��Bold"�6V   $��18(�6h   $��0 0 0 15q�6v   ���#5CD85A$��Center=�6�   $��Center=�6�   �� 5*       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5+      �� -   5         ��Name$ cboxFirstTeam��5+      $��10q�66   $��10q�6C   $	��150��6O   $
 Hand��6^   5,      5-      �� 5/      $��2��6   $��2��6&   $��20q�6:   .+�50      �� -   5        $
 btnSave��50         spremi#��Z 6*   $��14(�6V   $
��Bold"�6d   $	��100��6v   $��	0 20 0 20q�6�   ���#9ACD32$��15q�51   2   $
 Hand��6U   52      53      55      56      