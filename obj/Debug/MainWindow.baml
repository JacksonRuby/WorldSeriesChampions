   M S B A M L   `   `   `  ����O  KWorldSeriesChampions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WorldSeriesChampionsWorldSeriesChampions  5   	   %    WorldSeriesChampions.MainWindow   5
      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WorldSeriesChampions     5   	     � Title$  World Series Champions��5   	   $	��400��6(   $	��800��65   $	��400��6A   $	��800��6Q   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��.7* �6   6+   �� 5      6   �� 5      $	��.7* �6   6+   �� 5      6   �� 5      $	��.7* �6   6+   �� 5      6   .+�5"   
   �� $��Winning Team��6   $��20(�6'   $��Center=�5#      $��Bottom=�6-   �� 5$   
   $��	Years Won��6   $��20(�6$   $��2��62   $��Center=�5%      $��Bottom=�6-   �� 5'   
   -   5        $��	cmboTeams��5'      $��30(�6$   $��10q�62   $��1��6>   $��Center=�5(      ��5)      �� *
AllTeams+ �� SelectedIndex 5*      �� *AllTeamsSelectedIndex+ �� Mode$ TwoWay=��� 5,   
   -   5        $��cmboYearsWon��5,      $��30(�6'   $��10q�65   $��2��6A   $��1��6Q   $��Center=�5-      ��5.      �� *
YearsWon+ 5/      �� *YearsWonSelectedIndex+$ TwoWay=��� 51   
   $��Loser��6   $��20(�6    $��2��6.   $��0��6;   $��2��6K   $��Center=�52      $��Bottom=�6-   �� 53   
   $��Final Result��6   $��20(�6'   $��4��65   $��0��6B   $��2��6R   $��Center=�54      $��Bottom=�6-   �� 57   
   -   5        $��lblLoser��57      $��30(�6    $��3��6.   $��0��6;   $��2��6K   $	��Top=�59      $��Center=�63   ��58      �� *
LosingTeam+59   3   �� 5:   
   -   5        $��lblScore��5:      $��30(�6    $��5��6.   $��0��6;   $��2��6K   $	��Top=�5<      $��Center=�63   ��5;      �� *Score+5<   3   5>      5@      