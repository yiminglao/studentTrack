   M S B A M L   `   `   `  ����G  CstudentTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectGroup2ProjectGroup2  5   	   &     ProjectGroup2.wpfMoreGroupDetail   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectGroup2     5   	     � Title$  More Group Detail��5   	   $��533.777��6#   $��558.368��64   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgAssignment��5
         AutoGenerateColumns .  $
��Left=�6E   $��87��6`   $��	10,10,0,0q�6l   $	��Top=�6   $	��532��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Group ID��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	groupId+6S     5      $ Assignment ID��6F   $ 2* 6]    6%   �� *assignmentId+6]     5      $
 Date��6_   $ 4* 6m    6%   �� *
createDate+ �� StringFormat$ 
yyyy-mm-dd��6m     5      $ Assignment Name��6>   $ 8* 6W    6%   �� *name+6W     5      $ description��6>   $ 8* 6S    6%   �� *desc+6S   5      �� 5   
   -   5         ��Name$ btnAddtoGroup��5      $��Add Assignment to Group��6(   $
��Left=�6J   $��237,105,0,0q�6e   $	��Top=�6z   $	��171��6�   $��32��6�   �� 5   
   -   5        $��View Students Score��5      $
��Left=�6/   $��
43,105,0,0q�6J   $	��Top=�6^   $	��171��6v   $��32��6�   6�     5   
   -   5        $ dgstudentsScore��5       .  $
��Left=�6H   $	��342��6c   $��
10,152,0,0q�6p   $	��Top=�6�   $	��330��6�    5        5      $ 
Student ID��6C   $ 4* 6W    6%   �� *	studentId+6W     5      $ 
First Name��6C   $ 4* 6W    6%   �� *	FirstName+6W     5      $ 	Last Name��6B   $ 4* 6U    6%   �� *
LastName+6U     5      $ Grade��6?   $ 4* 6N    6%   �� *grade+6N   5      �� 5   
   -   5        $��Close��5      $
��Left=�6!   $��434,105,0,0q�6<   $	��Top=�6Q   $��67��6i   $��32��6t   6�   �� 5   
   $��Update Student��6   $
��Left=�6+   $	��338��6F   $��345,156,0,0q�6S   $	��Top=�6h   $	��197��6�   .��5      � $
��Left=�6   $	��258��6.   $��10,10,-2.2,0q�6;   $	��Top=�6Q   $	��177��6i   .+�5       �� $��Student ID:��6   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\   �� 5!      -   5        	 ��Name$	 lblSid��5!      $�� ��6(   $
��Left=�63   $��	79,10,0,0q�6N   $	��Top=�6a   �� 5"      $��First Name:��6   $
��Left=�6.   $��	10,36,0,0q�6I   $	��Top=�6\   �� 5#      -   5        $	 lblFName��5#      $�� ��6*   $
��Left=�65   $��	79,36,0,0q�6P   $	��Top=�6c   �� 5$      $��
Last Name:��6   $
��Left=�6-   $��	10,62,0,0q�6H   $	��Top=�6[   �� 5%      -   5        $	 lblLName��5%      $�� ��6*   $
��Left=�65   $��	79,62,0,0q�6P   $	��Top=�6c   �� 5&      $��Grade:��6   $
��Left=�6)   $��	29,93,0,0q�6D   $	��Top=�6W   �� 5'      -	   5        
 ��Name$
 tbGrade��5'      $
��Left=�6+   $��23��6F   $��	79,96,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $��78��6�   5*      5+      �� 5,   
   -
   5        $
��Edit��5,      $
��Left=�6    $��360,451,0,0q�6;   $	��Top=�6P   $��67��6h   $��32��6s   6   �� 5-   
   -   5        $
��Save��5-      $
��Left=�6    $��457,451,0,0q�6;   $	��Top=�6P   $��67��6h   $��32��6s   6   5/      50      