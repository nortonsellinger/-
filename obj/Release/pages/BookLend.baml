   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LIBRARY_lite.pagesLIBRARY_lite.pages  !    LIBRARY_lite.pages.BookLend   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:LIBRARY_lite.pages       N� Title$  BookLend��.��� 
������� � RowDefinitions �� $
��Auto ��� .+�� $��0�� �� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto ��� .+��� $��0�� �� Orientation$ 
Horizontal=�$��5q�.+��� -    ��Name$ lend_header��$��25(�$��Выдача��$��5q�$��Center=��� -    ��Name$ 
add_button��$��25(�$��Добавить��$��10, 5q�$��5q�$��Center=��� -   $��1��$��25(�$,��&Показать список книг��$��Right=�$��10, 5q�$��10, 5q�$��Center=��� $��1��$��2��$ 
Horizontal=�.+��� -   $ 
all_button��$��20(�$��все��$��Right=����#fff$��10, 5q�$��10, 5q�$��Center=�$��2q�
���   ��� -   $ taken_button��$��20(�$��выданные��$��Right=����#fee$��10, 5q�$��10, 5q�$��Center=�$��2q�
������ �� -   $ returned_button��$��20(�$��возвращенные��$��Right=����#efe$��10, 5q�$��10, 5q�$��Center=�$��2q�
������ � $��2��$��2�� �� $
��auto ��� $
��auto � �� $
��auto ��� �� $
��auto �.+��� $��0��$��20(�$��
Поиск��$��5q�$��Center=��� -    ��Name$ search_s��$��1��$��20(�$��5q�$��Center=��� $��2��$ 
Horizontal=�.+��� $��2��$��20(�$��Дата выдачи с:��$��5q�$��Center=��� -   $ 
date_start��$��3��$��20(�$��5q�$��Center=�$�� �� �� 	MaxLength$ 10��$	��110�� �� TextAlignment$ Center=��� $��2��$��20(�$��по:��$��5q�$��Center=��� -	   $ date_end��$��3��$��20(�$��5q�$��Center=�$�� ��$ 10��$	��110��$ Center=��� -
   $��20(�$��за все время��$��10, 5q�$
��10,5q�$��Center=�&   System.Windows.Controls.DataGrid  -   	  Name$	 BooksLendDG��$��1��
   AutoGenerateColumns
 .  $��20(�   
IsReadOnly . ��.     RowStyle ��  �� 
TargetType)  #System.Windows.Controls.DataGridRow"   �� Triggers ��  �� Binding �� *status+ �� Value returned.a���  �� Property � �� �� Value �#efe��  �� *status+	 taken.a���  � �� �#fee��  �� *status+ lost.a���  � �� �#ddd   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Читатель��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*    MinWidth$	 150Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *READERS.ReaderName+   ElementStyle �� .���  � ��$
 Wrap=�  $ Дата выдачи��$	 130 $	 130Q� �� *
LendDate+ �� StringFormat$ 
dd.MM.yyyy��  $ Вернуть до��$	 120 $	 130Q� �� *ExpReturnDate+$ 
dd.MM.yyyy��  $ Возвращено��$	 130 $	 130Q� �� *ActualReturnDate+$ 
dd.MM.yyyy��4  .System.Windows.Controls.DataGridTemplateColumn  $ 
Книги��$ 5* $	 250Q�   
Visibility$ 	Collapsed=�   CellTemplate �� .R��� .+�  $	 booksdg��$��15(� . 
 .  ���� *BOOK_SETS.BOOK_SET_CONTENTS+ �� "   ��  �� *status+ returned.a���  � �� �#efe��  �� *status+	 taken.a���  � �� �#fee��  �� *status+ lost.a���  � �� �#ddd   $	 200Q�$ 1*  �� .R��  � Orientation$ 
Horizontal=�.+��� $��5q����� *
BOOKS.ISBN+�� $
��Wrap=�$��5q����� *
ReturnDate+$ 
dd.MM.yyyy���� $
��Wrap=�$��5q�$
��Bold"����� *BOOKS.BookName+�� $
��Wrap=�$��5q����� *BOOKS.AUTHORS.AuthorName+�� $
��Wrap=�$��5q�$��	Underline{����� *EMPLOYEES.EmployeeName+  $ Библиотекарь��$ 2* $	 150Q� �� *EMPLOYEES.EmployeeName+ �� .���  � ��$
 Wrap=�  $  ��$
 1.5* $	 150Q� �� .R��  �� �� .+��� -   $��0������ $��20(�$)��#Продление / возврат��$
��Wrap=�$��Stretch=����� " ��.���  � y�$ 	Collapsed=� ��  �� *status+	 taken.a���  � y�$ Visible=��� -   $��1������ $��20(�$��
Утеря��$
��Wrap=�$��Stretch=����� " ��.���  � y�$ 	Collapsed=� ��  �� *status+	 taken.a���  � y�$ Visible=�