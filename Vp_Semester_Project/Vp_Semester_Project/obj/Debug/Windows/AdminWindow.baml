   M S B A M L   `   `   `  ����N  JVp_Semester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Vp_Semester_ProjectVp_Semester_Project  5   	   %    Vp_Semester_Project.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Vp_Semester_Project     5   	     � Title$  AdminWindow��5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ CanMinimize=�6B   $
��1300��6[   $	��700��6h    � WindowStyle$
 None=�6u    � 	Resources 5
       �� MergedDictionaries �� Source   
topButtons �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value�� 5   
    5      �� 5      $f `D:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Dictionaries\InternalStyles.xaml?�6%   %$  &	        �� 5      " ��6'   .�5      ��  � ��$	 20��6+   �� 5       � ��$	 20��6*   �� 5       � ��$
	 Bold"�6/   �� 5       � ��
	 �����6/   �� 5       � ��	 �#7333816/   �� 5       � ��	 5      �� 5      "
 ��6*   .R�5      �� #��z��6%   $��0q�6f   $ 2��6z   ��6O   Z� ._�5   "   �� $��Center=�63   $��Center=�6P   5      5      5       5      P� 5        �@J�IsMouseOver . . �5!      ��  � ��
	 ����67   5"      5$      5&      .��5)      �  � ColumnDefinitions 5*   
   �� 5+      $
��100* �6   �� 5,      $
��549* �6   .+�50   
   ]� $��1��6   $	��Top=�6$   $��Stretch=�6<   .+�52      ]� $��50��6   $��Right=�6#   $	��0,3q�6?   .+�54      �� -   5        $��-��54      #��[  6%   6I   �� 56      -   5        $��X��56      #��[  6%   6J   58      59      �� 5<   
   $��0��6   $��Stretch=�6"   $��Stretch=�6@   ���#733381.+�5?      ]� $
��Left=�6   $��50��63   $	��Top=�6?   .+�5A      �� 
�������$��2q�6-   $
��Left=�6A   $��35��6\   $	��Top=�6h   $��35��6�   $ 	10,0,10,0��6�   $��8,8,0,0q�6�   ��5B      �� 5C       �� ImageSource$/ )/Images/1920x1080 Technology Computer.jpg��6%   5E      �� 5G      $��
ADMIN AREA��6   $��Center=�6-   $��20,0,0,0q�6H   $��18(�6Z   
�������6h   5H      �� 5L      -   5         ��Name$	 nav��5L      $��Stretch=�6&   $	��650��6D   $��	0,130,0,0q�6Q   .+�5O      �� -   5         ��Name$ dashboardButton��5O        SideBarButton#��[ 62   $��	DASHBOARD��6Y   6m   �� 5Q      -   5        $ notificationButton��5Q      #��[ 65   $��NOTIFICATION��6\   6s   �� 5S      -   5        $ studentsButton��5S      #��[ 61   $��STUDENTS��6Y   6l   �� 5U      -   5        $ teachersButton��5U      #��[ 61   $��TEACHERS��6Y   6l   �� 5W      -   5        $ classesButton��5W      #��[ 60   $��CLASSES��6X   6j   �� 5Y      -	   5        $ subjectsButton��5Y      #��[ 61   $��COURSES��6Y   6k   �� 5[      -
   5        $ settingsButton��5[      #��[ 61   $��SETTINGS��6Y   6l   5^      5a       � 5e   
   -   5          �Name$ 	PageFrame��5e      $��Stretch=�6#   $��Stretch=�6A   $��0,26,0,0q�6]     � NavigationUIVisibility$ Hidden=�6o   $��1��6�   5i      5j      