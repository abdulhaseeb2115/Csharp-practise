   M S B A M L   `   `   `  ����N  JVp_Semester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:Vp_Semester_Project.AdminPages.AdminSubjectsPages1Vp_Semester_Project.AdminPages.AdminSubjectsPages  5      C    =Vp_Semester_Project.AdminPages.AdminSubjectsPages.ViewSubject   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:Vp_Semester_Project.AdminPages.AdminSubjectsPages     5        N� Title$  ViewSubject��5	       � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `D:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Dictionaries\InternalStyles.xaml?�6%   %    5      .��5      �    InternalPage#��[  6   .+�5   
   �� -   5         ��Name$ 
courseName��5      $
��Left=�6'   $	��top=�6B   $��60,20q�6Z   $��18(�6i   $��	10,6,10,0q�6w   $	��200��6�   $��40��6�    �� Text$ Select a Course��6�    �� 
IsEditable .  �� 
IsReadOnly . $��2��6�   $��1��6�   $��2q�6�   
���   � �� DisplayMemberPath$
 Name��6$  	 �� SelectedValuePath$	 Id��6?  6X  �� 5   
   -   5        
 ��Name$
 	foundData��5      $y�Hidden=�6$     
MainBorder#��[ 68   $��	0,0,0,-50q�6\   ._�5      � $��30q�6   $	��300��6   $��Center=�6+    � RowDefinitions 5      �� 5      $��55 �6$   �� 5      $��40 �6$   �� 5      $��50 �6$   �� 5      $��40 �6$   �� 5      $��50 �6$   �� 5      $��40 �6$   �� 5       $��50 �6$   �� 5!      $��40 �6$   �� 5"      $��50 �6$   .+�5(      �� $��COURSE DATA��6     MainBorderLabel#��[ 6.   $��0��6W   $��Center=�6e   $
��Left=�6�   $��30(�6�   $��SemiBold"�6�   $
��10,0q�5)      $��40��6"   $��0q�6/   �� 5.      $��ID��6   #��[ 6%   $��0��6N   $��1��6^   $��0q�6l   �� 50      -   5         ��Name$ IdOutput��50      #��[ 6*   $��2��6S   �� 54      $
��Name��6   #��[ 6'   $��3��6P   $��0q�6^   �� 55      -   5        $ 
NameOutput��55      #��[ 6,   $��4��6U   �� 59      $��	CreditHrs��6   #��[ 6,   $��5��6U   $��0q�6c   �� 5:      -   5        $ CreditHrsOutput��5:      #��[ 61   $��6��6Z   �� 5<      $��Prerequisites��6   #��[ 60   $��7��6Y   $��0q�6g   �� 5=      -   5        $ PrerequisitesOutput��5=      #��[ 65   $��8��6^   5@      5A      �� 5E   
   -   5        $
 noData��5E   %   $y�Hidden=�6   #��[ 65   ._�5G      �� -   5        $��noDataLabel��5G      #��[ 6'   $��0��6P   $��0��6`   $��2��6m   $��2��6�   $	��Top=�6�   $��	0,10,5,10q�6�   $��30(�6�   $��SemiBold"�6�   $��Center=�5H      $
��10,0q�6:   $
��Auto��6I   $��0q�6X   5I      5M      5N      