   M S B A M L   `   `   `  ����E  ANogometWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NogometWPF.WindowsNogometWPF.Windows  5   	   =#clr-namespace:NogometWPF.PropertiesNogometWPF.Properties  5   	   &     NogometWPF.Windows.PlayerDetails   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NogometWPF.Windows     5   	   5props#clr-namespace:NogometWPF.Properties     5   	   -   5          �Name$  PlayerDetailsWin��5   	    � Title$ PlayerDetails��5
   	   $	��500��5   	   $	��350��6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � ���#08313A � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   $	��150��6)   �� 5      $��* �6   $	��150��6)   .+�5   
   �� $��0��6   $��0��6"   $��0q�62   $��Right=�6=   .+�5      �� -   5         ��Name$ imgPPic��5      $��/Images/user.png��6%   $��70��6?   $��70��6K   $��20 20 40 20q�6V   6m   5      �� 5   
   $��0��6   $��1��6"   $��40 40 20 20q�62   $
��Left=�6G   .+�5       �� -   5        $ 
imgCaptain��5       $��/Images/captain (1).png��6(   $��30��6I   $��30��6U   $y�Hidden=�5!      5"      �� 5#   
   $��1��6   $��2��6"   $��0q�66   .+�5$      �� -   5         ��Name$ lblPName��5$      $��Center=�6&   $��20q�6C   $��20(�6P   ���#5CD85A6^   5%      �� 5&   
   $��2��6   $��0��6"   $��0q�63   ���#1A5653.+�5'      �� $	��No.��6   $��Right=�6"   $��20q�6>   $��15(�6K   ���#5CD85A6Y   5(      �� 5)   
   $��2��6   $��1��6"   $��0q�63   ���#1A5653.+�5*      �� -   5        $ 
lblPNumber��5*      $
��Left=�6(   $��20q�6C   $��15(�6P   ���#D1E8A16^   5+      �� 5,   
   $��3��6   $��0��6"   $��0q�63   .+�5-      �� %   NogometWPF.Properties.Resources   pozicija#��Z 6   $��Right=�6B   $��20q�6^   $��15(�6k   ���#5CD85A6y   5.      �� 5/   
   $��3��6   $��1��6"   $��0q�63   .+�50      �� -   5        $ lblPPosition��50      $
��Left=�6*   $��20q�6E   $��15(�6R   ���#D1E8A16`   51      �� 52   
   $��4��6   $��0��6"   $��0q�63   ���#1A5653.+�53      ��    
brojGolova#��Z 6   $��Right=�6D   $��20q�6`   $��15(�6m   ���#5CD85A6{   54      �� 55   
   $��4��6   $��1��6"   $��0q�63   ���#1A5653.+�56      �� -   5        $ 	lblPGoals��56      $
��Left=�6'   $��20q�6B   $��15(�6O   ���#D1E8A16]   57      �� 58   
   $��5��6   $��0��6"   $��0q�63   .+�59      �� 	   zutihKartona#��Z	 6   $��Right=�6F   $��20q�6b   $��15(�6o   ���#5CD85A6}   5:      �� 5;   
   $��5��6   $��1��6"   $��0q�63   .+�5<      �� -   5        $ lblPYellowCards��5<      $
��Left=�6-   $��20q�6H   $��15(�6U   ���#D1E8A16c   5=      5B      5C      