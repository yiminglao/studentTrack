   M S B A M L   `   `   `  ����G  CstudentTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectGroup2ProjectGroup2  5   	   "    ProjectGroup2.wpfGroupDetail   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectGroup2     5   	   -   5          � Title$  Group Detail��5   	   $��370.408��6   $��607.494��6/    � 
ResizeMode$ NoResize=�6?   .��5	      � .+�5   
   �� -   5         ��Name$ btnDelGroup��5      $��Delete Group��6&   $
��Left=�6=   $��92��6X   $��196,302,0,9.8q�6d   6{   �� 5   
   -   5        $ btnEditGroup��5      $��
Edit Group��6'   $
��Left=�6<   $��92��6W   $��91,302,0,9.8q�6b   6x   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��92��6N   $��304,302,0,9.8q�6Z   6q   �� 5   
   -   5        $ btnGroupDetail��5      $��More Group Detail��6)   $
��Left=�6E   $	��129��6`   $��411,302,0,9.8q�6m   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgGroupList��5         AutoGenerateColumns .  $
��Left=�6E   $	��277��6`   $��	10,10,0,0q�6m   $	��Top=�6�   $	��581��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Instructional Date��6I      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *groupSStartDate+6e     5      $ 
Group Name��6C   $ 1* 6W    6%   �� *	groupName+6W     5      $ Subjec/Description��6C   $ 1* 6_    6%   �� *	groupDesc+6_     5      $ Schedule/Time��6H   $ 1* 6_    6%   �� *groupStartTime+6_   5      5      5      