   M S B A M L   `   `   `  ����G  CstudentTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectGroup2ProjectGroup2  5   	   !    ProjectGroup2.wpfAddStudent   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectGroup2     5   	   -   5          �Name$  wpfAddStudents��5   	    � Title$ Add Student to Group��5   	   $��402.128��6&   $��894.68��67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��221* �6   �� 5      $
��223* �6   .+�5   
   �� $��Group Name:��6   $
��Left=�6&   $��	27,35,0,0q�6A   $	��Top=�6T   $	��113��6l   $��26��6x   $��14(�6�   �� 5   
   -   5         ��Name$ lblGroup��5      $�� ��6"   $
��Left=�6-   $��
151,37,0,0q�6H   $	��Top=�6\   $	��392��6t   $��14(�6�   $��2��6�   �� 5   
   $��Select Student to Add:��6   $
��Left=�61   $��	29,75,0,0q�6L   $	��Top=�6_   $��14(�6w   �� 5   
   -   5         ��Name$ btnClose��5      $��Close��6#   $
��Left=�63   $��366,334,0,0q�6N   $	��Top=�6c   $��79��6{   $��14(�6�   $��2��6�   �� 5   
   -   5        $ 	btnRemove��5      $��Remove ��6$   $
��Left=�66   $��23��6Q   $��362,221,0,0q�6]   $	��Top=�6r   $��80��6�   $��14(�6�   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgAllStudents��5      $	��230��6*   $��35,110,121,0q�67   $	��Top=�6M      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Student Names to Add��6C   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 10* 6a   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *	sFullName+6a   5        5   
   -   5        $ dgStudentsInGroup��5      $
��Left=�6.   $	��230��6I   $��44.5,110,0,0q�6V   $	��Top=�6l    .  $	��286��6�   $��1��6�    5        5      $ Student Names in Group��6C   $		 10* 6c   
 6%   �� *	sFullName+6c   5      �� 5   
   $��Current Group List:��6   $
��Left=�6.   $��27��6I   $��41.5,70,0,0q�6U   $	��Top=�6j   $	��259��6�   $��14(�6�   $��1��6�   �� 5    
   -   5        $ btnAdd��5       $	��Add��6!   $
��Left=�6/   $��22��6J   $��360,192,0,0q�6V   $	��Top=�6k   $��78��6�   $��14(�6�   6�   5"      5#      