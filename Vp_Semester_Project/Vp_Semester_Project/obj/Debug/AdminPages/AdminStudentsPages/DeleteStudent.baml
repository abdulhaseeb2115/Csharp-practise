   M S B A M L   `   `   `  ����N  JVp_Semester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:Vp_Semester_Project.AdminPages.AdminStudentsPages1Vp_Semester_Project.AdminPages.AdminStudentsPages  5      E    ?Vp_Semester_Project.AdminPages.AdminStudentsPages.DeleteStudent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:Vp_Semester_Project.AdminPages.AdminStudentsPages     5        N� Title$  DeleteStudent��5	       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `D:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Dictionaries\InternalStyles.xaml?�6%   %    5      .��5      �    InternalPage#��[  6   .+�5   
   ]� $��Right=�6   $	��Top=�60   $��80,30q�6H   .+�5      �� -   5         ��Name$ 
InputRegNo��5        SearchBarTextBox#��[ 6*   $��0,0,10,0q�6T   �� 5      -   5         ��Name$ search��5        
adusButton#��[ 6%   $��SEARCH��6I   $��0q�6p   5      �� 5   
   -   5         ��Name$ 	foundData��5      $y�Hidden=�6$     
MainBorder#��[ 68   $��	0,0,0,-50q�6\   ._�5       � $��40q�6   $	��660��6   $��Center=�6+    � ColumnDefinitions 5"      �� 5#      $
��110* �6'   �� 5$      $
��135* �6'   �� 5%      $	��15* �6'   �� 5&      $
��120* �6'   �� 5'      $
��290* �6'    � RowDefinitions 5*      �� 5+      $��55 �6$   �� 5,      $��50 �6$   �� 5-      $��55 �6$   �� 5.      $��55 �6$   �� 5/      $��55 �6$   �� 50      $��55 �6$   .+�55      �� $��STUDENT DATA��6     MainBorderLabel#��[ 6/   $��0��6X   $��0��6h   $��2��6u   $	��Top=�6�   $��0,10,0,0q�6�   $��30(�6�   $��SemiBold"�6�   $��Center=�56      $
��10,0q�6:   $��40��6I   $��0q�6V   �� 58      $��	Serial No��6   #��[ 6,   $��0��6U   $��2��6e   $��0q�6s   �� 59      $��Reg No��6   #��[ 6)   $��0��6R   $��3��6b   $��0q�6p   �� 5:      $��Class��6   #��[ 6(   $��0��6Q   $��4��6a   $��0q�6o   �� 5>      -   5        	 ��Name$	 SerialNoOutput��5>      #��[ 60   $��1��6Y   $��2��6i   �� 5?      -   5        $	 RegNoOutput��5?      #��[ 6-   $��1��6V   $��3��6f   �� 5@      -   5        $	 ClassOutput��5@      #��[ 6-   $��1��6V   $��4��6f   �� 5C      $
��Name��6   #��[ 6'   $��3��6P   $��2��6`   $��0q�6n   �� 5D      $��Father Name��6   #��[ 6.   $��3��6W   $��3��6g   $��0q�6u   �� 5G      -   5        $	 
NameOutput��5G      #��[ 6,   $��4��6U   $��2��6e   �� 5H      -   5        $	 FatherNameOutput��5H      #��[ 62   $��4��6[   $��3��6k   �� 5L      -	   5        $ delete��5L      #��[ 6)   $��DELETE��6M   $��5��6^   $��4��6k   $��Center=�6{   $��Right=�6�   6�   �� 5N      -
   5        
 ��Name$
 message��5N      $
��Left=�6-   $
��Wrap=�6H   $��Center=�6\   $��5��6w   $��0��6�   $��4��6�   $��14(�6�   5P      5Q      �� 5U   
   -   5        $ noData��5U   %   $y�Hidden=�6   #��[ 65   ._�5V      �� -   5        $��noDataLabel��5V      #��[ 6'   $��0��6P   $��0��6`   $��2��6m   $��2��6�   $	��Top=�6�   $��	0,10,5,10q�6�   $��30(�6�   $��SemiBold"�6�   $��Center=�6�   $
��10,0q�6  $
��Auto��6  $��0q�6!  5W      5Z      5[      