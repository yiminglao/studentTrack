   M S B A M L   `   `   `  ����G  CstudentTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectGroup2ProjectGroup2  5   	   $    ProjectGroup2.wpfStudentDetail   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectGroup2     5   	   -   5          � Title$  Student list��5   	   $��357.551��6   $��638.189��6/    � 
ResizeMode$ NoResize=�6?   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgStudentList��5
      $
��Left=�6*   $��0��6E   $	��Top=�6U      AutoGenerateColumns .  $	��227��6�   $��8,39,0,0q�6�   $	��609��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6?      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *index+6K     5      $ 
Student ID��6C   $ 1* 6W    6%   �� *	studentId+6W     5      $ 	FirstName��6C   $ 2* 6V    6%   �� *	firstName+6V     5      $ LastName��6B   $ 2* 6T    6%   �� *
lastName+6T     5      $ 
GradeLevel��6D   $ 1* 6X    6%   �� *
gradeLevel+6X     5      $ Educator_id��6D   $ 1* 6Y    6%   �� *
educatorId+6Y   5      �� 5   
   $��Students List��6   $��Center=�6(   $��233,0,238,0q�6E   $	��Top=�6Z   $��34��6r   $	��161��6~   $��16(�6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ btnAddStudent��5      $��Add Student��6(   $
��Left=�6>   $��
10,282,0,0q�6Y   $	��Top=�6m   $	��131��6�   $��28��6�   6�   �� 5   
   -   5        $ btndelStudent��5      $��delete Student��6(   $
��Left=�6A   $��146,282,0,0q�6\   $	��Top=�6q   $	��131��6�   $��28��6�   6�   �� 5   
   -   5        $ btnEditStudent��5      $��Edit Student��6)   $
��Left=�6@   $��282,282,0,0q�6[   $	��Top=�6p   $	��131��6�   $��28��6�   6�   �� 5   
   -   5        $ 
btnStudent��5      $��View Student Detail��6%   $
��Left=�6C   $��418,282,0,0q�6^   $	��Top=�6s   $	��131��6�   $��28��6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��554,282,0,0q�6N   $	��Top=�6c   $��63��6{   $��28��6�   6�   5      5      