   M S B A M L   `   `   `  ����N  JVp_Semester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:Vp_Semester_Project.AdminPages.AdminStudentsPages1Vp_Semester_Project.AdminPages.AdminStudentsPages  5      B    <Vp_Semester_Project.AdminPages.AdminStudentsPages.AddStudent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:Vp_Semester_Project.AdminPages.AdminStudentsPages     5        N� Title$  
AddStudent��5	       � 	Resources 5       �� MergedDictionaries �� Source(  "System.Windows.Controls.DatePicker �� 
TargetType �� 	Resources �� Property �� Value:  4System.Windows.Controls.Primitives.DatePickerTextBox�� 5   
    5      �� 5      $f `D:\1_UNI\Programming\C#\Vp_Semester_Project\Vp_Semester_Project\Dictionaries\InternalStyles.xaml?�6%   %R  '        '  �     �� 5      "  6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 4��69   5      5      5      �� 5      "  6   .�5      ��  � ��$ SELECT A DATE��6)   �� 5       � ��$ 12(�6-   �� 5       �@��
IsReadOnly . 6/   5      5      .��5"      �    InternalPage#��[  6   .+�5%   
   �� $��ENTER STUDENT DATA��6   $
��Left=�6-   $	��Top=�6H   $��	60,20,0,0q�6`   $
��0,10q�6s   $��30(�6�   $
��Bold"�6�   �� 5'   
     
MainBorder#��[ 6   $��	0,0,0,-40q�65   ._�5(      � $��40q�6   $��Stretch=�6   $��Stretch=�6=   $	��700��6Y    � ColumnDefinitions 5*      �� 5+      $	��55* �6'   �� 5,      $
��188* �6'   	 � RowDefinitions	 5.      �� 5/      $��55 �6$   �� 50      $��55 �6$   �� 51      $��55 �6$   �� 52      $��55 �6$   �� 53      $��55 �6$   �� 54      $��55 �6$   .+�57      �� $
��Name��6     AddMainBorderLabel#��[ 6'   $��0��6S   $��0��6c   �� 58      $��Father Name��6   #��[ 6.   $��0��6[   $��1��6k   �� 59      $	��DOB��6   #��[ 6'   $��0��6S   $��2��6c   �� 5:      $��Email��6   #��[ 6)   $��0��6U   $��3��6e   �� 5;      $��Address��6   #��[ 6+   $��0��6W   $��4��6g   �� 5>      -   5        
 ��Name$
 	NameInput��5>        AddMainBorderTextBox#��[ 6-   $��1��6[   $��0��6k   �� 5?      -   5        $
 FatherNameInput��5?      #��[ 63   $��1��6a   $��1��6q     5@      -   5          Name$ DOBInput��5@   �   $��Stretch=�6   $��Center=�6;   $��1��6V   $��2��6f   
���   �$��1q�6�   $��10,7,0,0q�6�   
�������$��30��6�   �� 5A      -   5        $
 
EmailInput��5A      #��[ 6.   $��1��6\   $��3��6l   �� 5B      -   5        $
 AddressInput��5B      #��[ 60   $��1��6^   $��4��6n   �� 5D      -   5         ��Name$ message��5D      $��Stretch=�6-   $
��Wrap=�6L   $��Bottom=�6`   $��0��6{   $��2��6�   $��5��6�   $��16(�6�    �� Padding$	 5,2q�6�   |�. $��0,0,152,7.8q�6�   �� 5F      -   5         ��Name$ 
addStudent��5F        
adusButton#��[ 6-   $��ADD STUDENT��6Q   $��Right=�6g   $��1��6�   $��5��6�   $��Bottom=�6�   $��	0,0,0,5.8q�6�   5H      5I      5J      5K      