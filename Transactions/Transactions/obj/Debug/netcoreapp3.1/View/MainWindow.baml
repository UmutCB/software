   M S B A M L   `   `   `  ����G  CTransactions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TransactionsTransactions  5   	   +clr-namespace:TransactionsTransactions  5   	   A%clr-namespace:Transactions.PropertiesTransactions.Properties  5   	       Transactions.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Transactions     5   	   *sysclr-namespace:Transactions     5   	   4CC%clr-namespace:Transactions.Properties     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)   .��5      � $��0,0,0,20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 grd��5         AutoGenerateColumns$ False��6       GridLinesVisibility$
 None=�6Z      CanUserAddRows$
 true��6u    �� SelectedItem$ 0��6�   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   $��
4,20,480,0q�6�   ��6<   �� *Users+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        item��'   !Transactions.Properties.Resources	   gridExpense,  &System.Windows.Controls.DataGridColumn
   Header#
 Z	 5   3      Width5  /System.Windows.Controls.DataGridLengthConverter$	 140 6y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6`   �� *Item+6y     5      -   5        	price��   	gridPrice#
 Z 5   4    6_   �� *Amount+5      ]� 5   
   $��0,22,250,200q�6   $��70��6*   .+�5      o� $	��Top=�6   .@�5      m� -   5           _Load#��Z 5      .@�5      m� #��Z 6   5      5      5      � 5   
   $��200,0,0,200q�6   $��Center=�6$   $��Bottom=�6A   .+�5       �� -   5         ��Name$ 	addButton��5       $��40��6@   $��30��6K   $��0,140,300,0q�6W   $��Center=�6l   $��Bottom=�6�      	addButton#��Z 6�   6�   �� 5!      -   5        $ deleteButton��5!      $��40��6F   $��30��6Q   $��0,140,200,0q�6]   $��Stretch=�6r   $��Right=�6�      deleteButton#��Z 6�   6�   �� 5"      $��
10,100,0,0q�6   $
��Left=�6,   $	��Top=�6G      Expense#��Z 6_   6�   �� 5#      -   5         ��Name$ txtItem��5#      $
��Left=�6'   $��
0,119,0,29q�6B   $��70��6V   $��Center=�6b   $��22��6}   �� 5$      $��
80,100,0,0q�6   $	��Top=�6,   $
��Left=�6D      Price#��Z 6_   6�   �� 5%      -   5        $��	txtAmount��5%   R   $��22��6   $
��Left=�6#   $��
70,119,0,0q�6>   $	��Top=�6c   $��70��6{   ��6�   ��  �� ElementName$
 User�� �� Path$ SelectedItem.Item�5&      5'      5(      