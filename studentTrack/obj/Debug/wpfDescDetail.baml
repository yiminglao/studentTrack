   M S B A M L   `   `   `  ����G  CstudentTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectGroup2ProjectGroup2  5   	   !    ProjectGroup2.wpfDescDetail   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectGroup2     5   	   -   5          � Title$  Assignment Detail��5   	   $��404.695��6#   $��757.348��64    � 
ResizeMode$ NoResize=�6D   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgDesc��5
         AutoGenerateColumns .  $
��Left=�6?   $	��277��6Z   $��	10,44,0,0q�6g   $��0��6z   $	��Top=�6�   $	��731��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Source ID��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
sourceId+6U     5      $
 Date��6Z   $ 4* 6h    6%   �� *sDate+ �� StringFormat$ 
yyyy-mm-dd��6h     5      $ Assignment Name��6>   $ 8* 6W    6%   �� *name+6W     5      $ description��6E   $ 8* 6Z    6%   �� *description+6Z   5      �� 5   
   $��Assignment List��6   $
��Left=�6*   $��
318,10,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        	 ��Name$	 
btDescEdit��5      $
��Edit��6%   $
��Left=�64   $��190,333,0,0q�6O   $	��Top=�6d   $	��131��6|   $��28��6�   6�   �� 5   
   -   5        $	 	btDescdel��5      $��delete��6$   $
��Left=�65   $��336,333,0,0q�6P   $	��Top=�6e   $	��131��6}   $��28��6�   6�   �� 5   
   -   5        $	 btnClose��5      $��Close��6#   $
��Left=�63   $��483,333,0,0q�6N   $	��Top=�6c   $	��131��6{   $��28��6�   6�   5      5      