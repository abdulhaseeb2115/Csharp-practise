   M S B A M L   `   `   `  ����N  JVp_Semester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:Vp_Semester_Project.AdminPages.AdminTeachersPages1Vp_Semester_Project.AdminPages.AdminTeachersPages  5      E    ?Vp_Semester_Project.AdminPages.AdminTeachersPages.DeleteTeacher   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:Vp_Semester_Project.AdminPages.AdminTeachersPages     5        N� Title$  DeleteTeacher��5	       � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `D:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Dictionaries\InternalStyles.xaml?�6%   %    5      .��5      �    InternalPage#��[  6   .+�5   
   ]� $��Right=�6   $	��Top=�60   $��80,30q�6H   .+�5      �� -   5         ��Name$ 
InputRegNo��5        SearchBarTextBox#��[ 6*   $��0,0,10,0q�6T   �� 5      -   5         ��Name$ search��5        
adusButton#��[ 6%   $��SEARCH��6I   $��0q�6p   5      �� 5   
   -   5         ��Name$ 	foundData��5      $y�Hidden=�6$     
MainBorder#��[ 68   $��	0,0,0,-50q�6\   ._�5      � $��40q�6   $	��660��6   $��Center=�6+    � ColumnDefinitions 5!      �� 5"      $
��120* �6'   �� 5#      $
��140* �6'   �� 5$      $	��15* �6'   �� 5%      $
��120* �6'   �� 5&      $
��290* �6'    � RowDefinitions 5)      �� 5*      $��55 �6$   �� 5+      $��50 �6$   �� 5,      $��55 �6$   �� 5-      $��55 �6$   �� 5.      $��55 �6$   �� 5/      $��55 �6$   .+�54      �� $��TEACHER DATA��6     MainBorderLabel#��[ 6/   $��0��6X   $��0��6h   $��2��6u   $	��Top=�6�   $��0,10,0,0q�6�   $��30(�6�   $��SemiBold"�6�   $��Center=�55      $
��10,0q�6:   $��40��6I   $��0q�6V   �� 58      $��ID��6   #��[ 6%   $��0��6N   $��2��6^   $��0q�6l   �� 59      $��Qualification��6   #��[ 60   $��0��6Y   $��3��6i   $��0q�6w   �� 5<      -   5        	 ��Name$	 IDOutput��5<      #��[ 6*   $��1��6S   $��2��6c   �� 5=      -   5        $	 QualificationOutput��5=      #��[ 65   $��1��6^   $��3��6n   �� 5B      $
��Name��6   #��[ 6'   $��3��6P   $��2��6`   $��0q�6n   �� 5C      $��Father Name��6   #��[ 6.   $��3��6W   $��3��6g   $��0q�6u   �� 5F      -   5        $	 
NameOutput��5F      #��[ 6,   $��4��6U   $��2��6e   �� 5G      -   5        $	 FatherNameOutput��5G      #��[ 62   $��4��6[   $��3��6k   �� 5K      -   5        $ delete��5K      #��[ 6)   $��DELETE��6M   $��5��6^   $��4��6k   $��Center=�6{   $��Right=�6�   6�   �� 5M      -	   5        
 ��Name$
 message��5M      $
��Left=�6-   $
��Wrap=�6H   $��Center=�6\   $��5��6w   $��0��6�   $��4��6�   $��14(�6�   5O      5P      �� 5T   
   -
   5        $ noData��5T   %   $y�Hidden=�6   #��[ 65   ._�5U      �� -   5        $��noDataLabel��5U      #��[ 6'   $��0��6P   $��0��6`   $��2��6m   $��2��6�   $	��Top=�6�   $��	0,10,5,10q�6�   $��30(�6�   $��SemiBold"�6�   $��Center=�6�   $
��10,0q�6  $
��Auto��6  $��0q�6!  5V      5Y      5Z      