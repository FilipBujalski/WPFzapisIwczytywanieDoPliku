   M S B A M L   `   `   `  ����  danexml    danexml.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��400��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��5q�6h   .+�5      �� -   5        $	��120��5      $��30��6$   $��Zapisz��60   $��5q�6A   6L   �� 5      -   5        $	��120��5      $��30��6$   $��Wczytaj��60   $��5q�6B   6M   �� 5      -   5        $	��120��5      $��30��6$   $��Dodaj��60   $��5q�6@   6K   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PracownicyLista��5         AutoGenerateColumns$ False��6,   $��Stretch=�6H   $��Stretch=�6f   $��1��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ Imię��6%    63   �� *Imie+  5      $ Nazwisko��6%    67   �� *
Nazwisko+  5      $ Zarobki��6%    66   �� *	Zarobki+	 �� StringFormat$	 {0} zł��  5       $ Data zatrudnienia��6%    6@   �� *Data_zatrudnienia+$	 {0:dd.MM.yyyy}��  5!      $ Data zwolnienia��6%    6>   �� *Data_zwolnienia+$	 {0:dd.MM.yyyy}��5#      5$      5%      