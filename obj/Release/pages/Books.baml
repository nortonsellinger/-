   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LIBRARY_lite.pagesLIBRARY_lite.pages      LIBRARY_lite.pages.Books   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:LIBRARY_lite.pages       N� Title$  Books��.��� 
������� � RowDefinitions �� $��1* �.+�� $��0�� �� $
��auto ��� .+�� $��0�� �� $
��auto ���  � ColumnDefinitions �� $
��auto ��� .+��� $��0��$��0�� �� Orientation$ 
Horizontal=�$��5q�.+��� -    ��Name$ book_header��$��25(�$��
Книги��$��5q�$��Center=��� -   $��25(�$��Добавить��$��10, 5q�$��5q�$��Center=�� $��1��$��2�� �� $
��auto ��� $
��auto � �� $
��auto ��� �� .+��� $��0��$��20(�$��
Поиск��$��5q�$��Center=��� -    ��Name$ search_s��$��1��$��20(�$��5q�$��Center=� �� 	MaxLength$ 13���� $��2��$ 
Horizontal=�.+��� $��20(�$��
Год с:��$��5q�$��Center=��� -   $ 
year_start��$��20(�$��5q�$��Center=�$��60��$�� ��$ 4�� �� TextAlignment$ Center=��� $��20(�$��по:��$��5q�$��Center=��� -   $ year_end��$��20(�$��5q�$��Center=�$��60��$�� ��$ 4��$ Center=�&   System.Windows.Controls.DataGrid  -     Name$ BooksDG��$��1��	   AutoGenerateColumns	 .  $��20(�
   
IsReadOnly
 . ��.  ���#555   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 ISBN��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1*    MinWidth$	 150Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ISBN+  $ Название��$ 3* $	 200Q� �� *
BookName+   ElementStyle �� .���  �� Property � �� �� Value$
 Wrap=�  $ 
Автор��$ 3* $	 200Q� �� *AUTHORS.AuthorName+ �� .���  � ��$
 Wrap=�  $ Издательство��$ 3* $	 150Q� �� *PUBLISHERS.PublisherName+ �� .���  � ��$
 Wrap=�  $ Год издания��$ 1* $	 125Q� �� *
PublDate+  $ Количество��$ 1* $	 120Q� �� *
Quantity+4  .System.Windows.Controls.DataGridTemplateColumn  $  ��$	 150Q�   CellTemplate �� .R��� -   $ ��Редактировать��