   M S B A M L   `   `   `  ����G  CstudentTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectGroup2ProjectGroup2  5   	   "    ProjectGroup2.wpfGroupUpdate   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectGroup2     5   	   -   5          � Title$  Update Group��5   	   $	��300��6   $��532.666��6+    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ NoResize=�6`   .��5	      � .+�5
   
   �� -   5         ��Name$ bntClear��5
      $��Clear��6#   $
��Left=�63   $��27��6N   $��289,221,0,0q�6Z   $	��Top=�6o   $��59��6�   $��16(�6�    � Cursor$
 Hand��6�    � ToolTip$ Reset the Form��6�   �� 5   
   -   5        $ btnSave��5      $
��Save��6"   $
��Left=�61   $��27��6L   $��367,221,0,0q�6X   $	��Top=�6m   $��60��6�   $��16(�6�   $
 Hand��6�   $ Save and Close the Window��6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��27��6N   $��443,221,0,0q�6Z   $	��Top=�6o   $��60��6�   $��16(�6�   $
 Hand��6�   $ Close the Window��6�   6�   �� 5   
   -   5         ��Name$ label��5      $��*New Group Name: ��6   $
��Left=�6;   $��33��6V   $��	21,15,0,0q�6b   $	��Top=�6u   $	��169��6�   $��16(�6�   �� 5   
   -   5        $ label1��5      $��Subject/Description:��6    $
��Left=�6?   $��
21,109,0,0q�6Z   $	��Top=�6n   $��30��6�   $	��166��6�   $��16(�6�   �� 5   
   -   5        $ label2��5      $��*Instructional Date:��6    $
��Left=�6?   $��29��6Z   $��	21,62,0,0q�6f   $	��Top=�6y   $	��145��6�   $��16(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.35Q�6$   �� 5      T� 5      	 T� Y$	 -0.327Q�6)   5      5      �� 5   
   -   5        $ label3��5      $��Schedule/Time:��6    $
��Left=�69   $��33��6T   $��
21,162,0,0q�6`   $	��Top=�6t   $	��124��6�   $��16(�6�   �� 5   
   -	   5        
 ��Name$
 txtGroupName��5      $
��Left=�6(   $��25��6C   $��
192,15,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��311��6�   ���	#FF01040E���	#FFDADAD3$ IBeam��6�   $��16(�6�   $ Enter Name of Group��6�   �� 5   
   -
   5        $
 
txtSubject��5      $
��Left=�6&   $��25��6A   $��192,114,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��311��6�   ���	#FF01040E���	#FFDADAD3$ IBeam��6�   $��16(�6�   $. (Enter the Subject or a short Description��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dteDate��5      $
��Left=�6&   $��25��6A   $��
192,66,0,0q�6M   $	��Top=�6a   $	��114��6y   ���	#FF000408   SelectedDateFormat$ Short=�6�   $" Enter the Group's Start Date��6�   $ Arrow��6�   �� 5   
   -   5        $ label3_Copy��5      $��
* Required��6%   $
��Left=�6:   $��27��6U   $��
21,221,0,0q�6a   $	��Top=�6u   $��69��6�   ���	#FF0004086�   �� 5   
   -   5         ��Name$ cboxHour��5      $
��Left=�6%   $��192,162,0,0q�6@   $	��Top=�6U   $��40��6m   $��25��6x   6�   �� 5    
   -   5        $ cboxMin��5       $
��Left=�6$   $��247,162,0,0q�6?   $	��Top=�6T   $��42��6l   $��25��6w   6�   5$      5%      