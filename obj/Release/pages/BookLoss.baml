   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LIBRARY_lite.pagesLIBRARY_lite.pages  !    LIBRARY_lite.pages.BookLoss   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:LIBRARY_lite.pages       N� Title$  BookLoss��.��� 
������� � RowDefinitions �� $
��Auto ��� .+�� $��5q� � ColumnDefinitions �� $
��auto ��� $
��auto ��� �� $
��auto �.+��� -    ��Name$ loss_header��$��0��$��25(�$��
Утеря��$��5q�$��Center=��� $��1��$��20(�$��
Поиск��$��20, 5, 5, 5q�$��Center=��� -   $��2��$��20(�$��10, 5q�$��Center=��� $��3�� �� Orientation$ 
Horizontal=�.+��� -   $��20(�$��	дата:��$��10, 5q�$
��10,5q�$��Center=��� $��20(�$��с��$��5q�$��Center=��� -    ��Name$ 
date_start��$��20(�$��5q�$��5q� �� 	MaxLength$ 10��$��Center=�$	��100���� $��20(�$
��по��$��5q�$��Center=��� -   $ date_end��$��20(�$��5q�$��5q�$ 10��$��Center=�$	��100���� -   $��20(�$��за все время��$��10, 5q�$
��10,5q�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ 
BookLossDG��$��1��   AutoGenerateColumns .  $��20(�	   
IsReadOnly	 . ��.  
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Читатель��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*    MinWidth$	 150Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *READERS.ReaderName+  $ Дата утери��$ 1* $	 130Q� �� *
LossDate+ �� StringFormat$ 
dd.MM.yyyy��4  .System.Windows.Controls.DataGridTemplateColumn  $ 
Книга��$ 4* $	 250Q�   CellTemplate �� .R��  � Orientation$ 
Horizontal=�.+��� $��10, 5q����� *
BOOKS.ISBN+�� $
��Wrap=�$��10, 5q����� *BOOKS.BookName+�� $
��Wrap=�$��10, 5q����� *BOOKS.AUTHORS.AuthorName+�� $
��Wrap=�$��10, 5q����� * BOOKS.PUBLISHERS.PublisherName+�� $��10, 5q����� *BOOKS.PublDate+  $ Библиотекарь��$ 2* $	 200Q� �� *EMPLOYEES.EmployeeName+   ElementStyle �� .���  �� Property � �� �� Value$
 Wrap=�