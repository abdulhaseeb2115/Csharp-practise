   M S B A M L   `   `   `  ����N  JVp_Semester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Vp_Semester_Project.WindowsVp_Semester_Project.Windows  5   	   /    )Vp_Semester_Project.Windows.TeacherWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Vp_Semester_Project.Windows     5   	     � Title$  TeacherWindow��5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ CanMinimize=�6D   $
��1300��6]   $	��700��6j    � WindowStyle$
 None=�6w    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $e _D:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Dictionaries\StudentStyles.xaml?�6%   %    5      .��5      � $��0q�6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $	��640 �6   .+�5   
   � $��0��6   
���� ��$��Stretch=�60   $��0q�6N   $��Stretch=�6Y    � ColumnDefinitions 5      �� 5      $
��249* �6#   �� 5      $
��351* �6#   �� 5      $
��700* �6#   .+�5       ]� $��	0,0,2.8,0q�6   .+�5!      �� $��Center=�6   $
��Left=�64   $��	20,0,10,0q�6O   $��45��6b   $��45��6n   	 �� CornerRadius$	 	10,0,10,0��6y   
�������$��2q�6�   ��5"      �� 5#      
 �� ImageSource$n
 hD:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Images\1920x1080 Technology Computer.jpg��6%   5%      �� 5&      $��TEACHER PORTAL��6   $��18(�61   
�������$��0q�6R   $��Center=�6^   5'      �� 5*      $��1��6   $
��Left=�6%   $��Center=�6@   $��
10.2,5,0,5q�6[   
�������$��2q�6�    �� Padding$
 10,3q�6�   $	 8��6�   $��50��6�   $	��185��6�   ._�5+      �� $��Stretch=�6   .+�5,      ]� .+�5-      �� $
��ID :��6       	TopLabels#��[  6/   $��50��6R   �� 5.      -   5         ��Name$ 	teacherId��5.       #��[  64   5/      ]� 50      .+�51      �� $��Name :��6    #��[  61   $��50��6T   �� 52      -   5        $ teacherName��52       #��[  66   53      54      55      ]� 58      $��2��6   $��Right=�6(   $��0,0,10,0q�6D   .+�5:      �� -   5         ��Name$ dashboardButton��5:      $��	Dashboard��62     
TopButtons#��[ 6F   6j   �� 5<      -   5        $ notificationButton��5<      $��Add Notification��65   #��[ 6P   6t   �� 5>      -   5        $ attendanceButton��5>      $��Upload Attendance��63   #��[ 6O   6s   �� 5@      -   5        $ marksButton��5@      $��Upload Marks��6.   #��[ 6E   6i   �� 5B      -   5        $ settingsButton��5B      $��Settings��61   #��[ 6D   6h   �� 5D      -   5        $ logoutButton��5D      $��Logout��6/   #��[ 6@   6e   5E      5H       � 5J   
   -	   5          �Name$ 	PageFrame��5J      $��1��6#     � NavigationUIVisibility$ Hidden=�60   $��Stretch=�6P   $��Stretch=�6n   5K      5L      