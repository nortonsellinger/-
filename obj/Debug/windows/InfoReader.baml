   M S B A M L   `   `   `  ����G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows  5   	   %    LIBRARY_lite.windows.InfoReader   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:LIBRARY_lite.windows     5   	     � Title$.  (Информация о читателе��5   	   $	��450��6'   $	��800��67   $	��800��6G    � WindowStartupLocation$ CenterOwner=�6V   ���#ccc.��5	      � $��0, 10q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��6   .+�5      �� -   5         ��Name$ reader��5      $��25(�6(   $��10, 0, 10, 10q�66   $��читатель��6M   $��Center=�6]   �� 5      $��0��6   $��20(�6(   $!��История выдачи��66   $
��10,5q�6L   $��Center=�6Z   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
BookLendDG��5   !   $��1��6      AutoGenerateColumns .  $��20(�6Q      
IsReadOnly .    RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   	 �� Triggers	 5      �� 5      
 �� Binding
 6&   �� *status+ �� Value returned6A   .a�5      ��  �� Property � �� �� Value �#efe6;   5      �� 5      
 6&   �� *status+	 taken6A   .a�5      ��  � �� �#fee6;   5      5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата выдачи��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6:      MinWidth$	 130Q�6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6T   �� *
LendDate+ �� StringFormat$ 
dd.MM.yyyy��  5"      $ Вернуть до��6%   $ 1* 69   $	 130Q�6D    6S   �� *ExpReturnDate+$ 
dd.MM.yyyy��  5#      $ Возвращено��6%   $ 1* 69   $	 100Q�6D    6S   �� *ActualReturnDate+$ 
dd.MM.yyyy��4  .System.Windows.Controls.DataGridTemplateColumn  5$      $ 
Книги��6)   $ 2* 68   $	 125Q�6C      CellTemplate 5%      �� 5&      .R�5'      �� .+�5(   "     $ booksdg��6+   $��15(�6p    .  .  ��6<   �� *BOOK_SETS.BOOK_SET_CONTENTS+ 5*   &   �� 5+   *   "  60   	 5,   .   �� 5-   2   
 6>   �� *status+ returned6Y   .a�5.   6   ��  � �� �#efe6S   5/   3   �� 50   2   
 6>   �� *status+	 taken6Y   .a�51   6   ��  � �� �#fee6S   52   3   �� 53   2   
 6>   �� *status+ lost6Y   .a�54   6   ��  � �� �#ddd6S   55   3   57   +    59   &     5:   *   $	 200Q�6A   $ 1* 6P    5;   .   �� 5<   2   .R�5=   6   �  � Orientation$ 
Horizontal=�6@   .+�5>   :   �� $��5q�6`   ��6D   �� *
BOOKS.ISBN+6`   �� 5?   :   $
��Wrap=�6y   $��5q�6�   ��6D   �� *
ReturnDate+$ 
dd.MM.yyyy��6�   �� 5@   :   $
��Wrap=�6d   $��5q�6x   $
��Bold"�6�   ��6D   �� *BOOKS.BookName+6�   �� 5A   :   $
��Wrap=�6n   $��5q�6�   ��6D   �� *BOOKS.AUTHORS.AuthorName+6�   �� 5B   :   $
��Wrap=�6l   $��5q�6�   $��	Underline{�6�   ��6D   �� *EMPLOYEES.EmployeeName+6�   5C   7   5D   3   5F   +   5H   #   5I      5J      5L        5M      $ Библиотекарь��6%   $ 2* 6;   $	 150Q�6F    6U   �� *EMPLOYEES.EmployeeName+   ElementStyle 5N      �� 5O      .�5P      ��  � ��$
 Wrap=�6G   5Q      5S      5U      5V      5W      