   M S B A M L   `   `   `  ����E  ANogometWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:NogometWPF.UserControlsNogometWPF.UserControls  5      =#clr-namespace:NogometWPF.PropertiesNogometWPF.Properties  5      +    %NogometWPF.UserControls.SettingsWinUC   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:NogometWPF.UserControls     5      5props#clr-namespace:NogometWPF.Properties     5      -   5          >�Name$  
SettingsUC��5      .��5      � -   5         �Name$ gSelectChampLangUC��5      $��Center=�6'   $��Center=�6D   ���#08313A$y�Visible=�5   $    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"   $��40q�62   .+�5      �� %   NogometWPF.Properties.Resources   odaberitePrvenstvo#��Z 6   $
��Bold"�5      $��18(�6*   $��0 0 0 15q�68   ���#5CD85A$��Center=�5   .   $��Center=�6K   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      	� -   5         	�Name$ 
rbtnFemale��5         zensko#��Z 62   $��15(�5      $��10q�6,   ���#D1E8A168   	� 5       -   5        $ rbtnMale��5          musko#��Z 60   $��15(�5!      ���#D1E8A1$��10q�6A   5"      5#      �� 5$   
   $��0��6   $��1��6"   $��40q�62   .+�5%      �� 	   odaberiteJezik#��Z	 6   $
��Bold"�5&      $��18(�6*   $��0 0 0 15q�68   ���#5CD85A$��Center=�5'   -   $��Center=�6J   �� 5(      $ 
Horizontal=�6   .+�5)      	� -   5        $ rbtnEng��5)      	
   en#��Z
 6/   $��15(�5*      $��10q�6,   ���#D1E8A168   	� 5+      -   5        $ rbtnCro��5+      	   hr#��Z 6/   $��15(�5,      ���#D1E8A1$��10q�6A   5-      5.      �� 5/   
   $��1��6   $��2��6"   $��40q�66   ���#1A5653.+�50      ��    odaberiteVelicinuEkrana#��Z 6   $
��Bold"�51      $��18(�6*   $��0 0 0 15q�68    �� Padding$ 0 10 0 0q�6J   ���#5CD85A$��Center=�52   -   $��Center=�6J   �� 53      $ 
Horizontal=�6   $��Center=�62   .+�54      	� -   5        $ rbSize1��54      $��700/700��6/   $��15(�6A    d� 	IsChecked$
 TrueY�55      ���#D1E8A1$��10q�56   3   	� 57      -   5        $ rbSize2��57      $��1000/750��6/   $��15(�6B   ���#D1E8A1$��10q�58   3   	� 59      -	   5        $ rbSize3��59      $��1450/800��6/   $��15(�6B   ���#D1E8A1$��10q�5:   3   5;      5<      �� 5>   
   $��2��6   $��2��6"   $��10q�66   .+�5?      �� -
   5         ��Name$ btSave��5?         spremi#��Z 6%   $��14(�5@      $
��Bold"�6#   $	��100��65   $��
0 20 10 20q�6A   ���#9ACD32$��10q�5A   *   $��Center=�67   5B      5C      �� 5E   
   -   5        $ btnClose��5E      $��1��6#   $��5q�64   $	��Top=�5F      $��Right=�6)   $��20��5G      $��20��6   
������ $��0q�6A   .��5I      �� .+�5J      �� $��/Images/close.png��6   5K      5L      5M      5N      