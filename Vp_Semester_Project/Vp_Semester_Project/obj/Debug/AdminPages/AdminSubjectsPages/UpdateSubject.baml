   M S B A M L   `   `   `  ����N  JVp_Semester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:Vp_Semester_Project.AdminPages.AdminSubjectsPages1Vp_Semester_Project.AdminPages.AdminSubjectsPages  5      E    ?Vp_Semester_Project.AdminPages.AdminSubjectsPages.UpdateSubject   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:Vp_Semester_Project.AdminPages.AdminSubjectsPages     5        N� Title$  UpdateSubject��5	       � 	Resources 5
       �� MergedDictionaries �� Source(  "System.Windows.Controls.DatePicker �� 
TargetType �� 	Resources �� Property �� Value:  4System.Windows.Controls.Primitives.DatePickerTextBox�� 5   
    5      �� 5      $f `D:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Dictionaries\InternalStyles.xaml?�6%   %R  '        '  �     �� 5      "  6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 4��69   5      5      5      �� 5      "  6   .�5      ��  � ��$ SELECT A DATE��6)   �� 5       � ��$ 12(�6-   �� 5       �@��
IsReadOnly . 6/   5      5      .��5!      �    InternalPage#��[  6   .+�5$   
   �� -   5         ��Name$ 
courseName��5$      $
��Left=�6'   $	��top=�6B   $��60,20q�6Z   $��18(�6i   $��	10,6,10,0q�6w   $	��200��6�   $��40��6�   	 �� Text$	 Select a Course��6�   
 �� 
IsEditable
 .  �� 
IsReadOnly . $��2��6�   $��1��6�   $��2q�6�   
���   � �� DisplayMemberPath$
 Name��6$   �� SelectedValuePath$ Id��6?  6X  �� 5'   
   -   5         ��Name$ 	foundData��5'   %   $y�Hidden=�6     
MainBorder#��[ 68   $��	0,0,0,-40q�6\   ._�5(      � $��30q�6   $��Stretch=�6   $��Stretch=�6=   $	��350��6Y    � ColumnDefinitions 5*      �� 5+      $��2* �6'   �� 5,      $��3* �6'    � RowDefinitions 5.      �� 5/      $��55 �6$   �� 50      $��55 �6$   �� 51      $��55 �6$   �� 52      $��55 �6$   �� 53      $��55 �6$   �� 54      $��55 �6$   �� 55      $��55 �6$   .+�5;      �� $��ENTER COURSE DATA��6   $
��Left=�64   $	��Top=�6O   $��	15,-4,0,0q�6g   $
��0,10q�6z   $��30(�6�   $
��Bold"�6�   $��0��6�   $��0��6�   $��2��6�   �� 5?      $��ID��6     AddMainBorderLabel#��[ 6%   $��0��6Q   $��2��6a   �� 5@      -   5        $��IdOutput��5@      #��[ 6(   $��1��6T   $��2��6d   �� 5C      $
��Name��6   #��[ 6'   $��0��6S   $��3��6c   �� 5D      -   5        $��
nameOutput��5D      #��[ 6*   $��1��6V   $��3��6f   �� 5H      $��
Credit Hrs��6   #��[ 6-   $��0��6Z   $��4��6j   �� 5I      $��Prerequisites��6   #��[ 61   $��0��6]   $��5��6m   �� 5J      -   5         ��Name$ CreditHrsInput��5J        AddMainBorderTextBox#��[ 62   $��1��6`   $��4��6p   �� 5K      -   5        $ PrerequisitesInput��5K      #��[ 66   $��1��6d   $��5��6t   �� 5Q      -   5         ��Name$ message��5Q      $��Stretch=�6-   $
��Wrap=�6L   $��Bottom=�6`   $��0��6{   $��2��6�   $��6��6�   $��16(�6�    �� Padding$	 5,2q�6�   |�. $��0,0,152,7.8q�6�   �� 5S      -   5         ��Name$ 	addCourse��5S        
adusButton#��[ 6,   $��UPDATE COURSE��6P   $��Right=�6h   $��1��6�   $��6��6�   $��Bottom=�6�   $��	0,0,0,5.8q�6�   5U      5V      �� 5Y   
   -	   5        $ noData��5Y   %   $y�Hidden=�6   #��[ 65   ._�5[      �� -
   5        $��noDataLabel��5[        MainBorderLabel#��[ 6'   $��0��6P   $��0��6`   $��2��6m   $��2��6�   $	��Top=�6�   $��	0,10,5,10q�6�   $��30(�6�   $��SemiBold"�6�   $��Center=�5\      $
��10,0q�6:   $
��Auto��6I   $��0q�6X   5]      5a      5b      