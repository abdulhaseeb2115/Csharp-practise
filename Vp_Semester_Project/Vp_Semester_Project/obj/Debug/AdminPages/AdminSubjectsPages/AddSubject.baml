   M S B A M L   `   `   `  ����N  JVp_Semester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:Vp_Semester_Project.AdminPages.AdminSubjectsPages1Vp_Semester_Project.AdminPages.AdminSubjectsPages  5      B    <Vp_Semester_Project.AdminPages.AdminSubjectsPages.AddSubject   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:Vp_Semester_Project.AdminPages.AdminSubjectsPages     5        N� Title$  
AddSubject��5	       � 	Resources 5
       �� MergedDictionaries �� Source(  "System.Windows.Controls.DatePicker �� 
TargetType �� 	Resources �� Property �� Value:  4System.Windows.Controls.Primitives.DatePickerTextBox�� 5   
    5      �� 5      $f `D:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Dictionaries\InternalStyles.xaml?�6%   %R  '        '  �     �� 5      "  6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 4��69   5      5      5      �� 5      "  6   .�5      ��  � ��$ SELECT A DATE��6)   �� 5       � ��$ 12(�6-   �� 5       �@��
IsReadOnly . 6/   5      5      .��5!      �    InternalPage#��[  6   .+�5$   
   �� $��ENTER COURSE DATA��6   $
��Left=�6,   $	��Top=�6G   $��	60,20,0,0q�6_   $
��0,10q�6r   $��30(�6�   $
��Bold"�6�   �� 5&   
     
MainBorder#��[ 6   $��	0,0,0,-40q�65   ._�5'      � $��30q�6   $��Stretch=�6   $��Stretch=�6=   $	��350��6Y    � ColumnDefinitions 5)      �� 5*      $��2* �6'   �� 5+      $��3* �6'   	 � RowDefinitions	 5-      �� 5.      $��55 �6$   �� 5/      $��55 �6$   �� 50      $��55 �6$   �� 51      $��55 �6$   .+�53      �� $
��Name��6     AddMainBorderLabel#��[ 6'   $��0��6S   $��0��6c   �� 54      $��
Credit Hrs��6   #��[ 6-   $��0��6Z   $��1��6j   �� 55      $��Prerequisites��6   #��[ 61   $��0��6]   $��2��6m   �� 56      -   5        
 ��Name$
 	NameInput��56        AddMainBorderTextBox#��[ 6-   $��1��6[   $��0��6k   �� 57      -   5        $
 CreditHrsInput��57      #��[ 62   $��1��6`   $��1��6p   �� 58      -   5        $
 PrerequisitesInput��58      #��[ 66   $��1��6d   $��2��6t   �� 5>      -   5         ��Name$ message��5>      $��Stretch=�6-   $
��Wrap=�6L   $��Bottom=�6`   $��0��6{   $��2��6�   $��3��6�   $��16(�6�    �� Padding$	 5,2q�6�   |�. $��0,0,152,7.8q�6�   �� 5@      -   5         ��Name$ 
addStudent��5@        
adusButton#��[ 6-   $��
ADD COURSE��6Q   $��Right=�6f   $��1��6�   $��3��6�   $��Bottom=�6�   $��	0,0,0,5.8q�6�   5B      5C      5D      5E      