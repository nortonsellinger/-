   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows  &     LIBRARY_lite.windows.AddBookLend   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:LIBRARY_lite.windows       � Title$  Выдача книг�� � SizeToContent$ WidthAndHeight=�$	��800��$
��1000�� � WindowStartupLocation$ CenterOwner=�.���  � RowDefinitions �� �� $
��auto � � ColumnDefinitions �� �� .+��� $��0��$��2��$	��800��.���  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��10q�.+��  �� $
��auto ��� .+��� $��20(�$��Читатель��$	��0,5q��� -   $��1��$��20(�$��
10, 5, 0 5q�&   System.Windows.Controls.DataGrid  -     Name$ 	ReadersDG��$��1��   AutoGenerateColumns .  $��20(�   
IsReadOnly . $	��400��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 ФИО��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 3*    MinWidth$	 200Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
ReaderName+   ElementStyle �� .���  �� Property � �� �� Value$
 Wrap=�  $	 Дата рождения��$
 2* $	 160Q� �� *	BirthDate+ �� StringFormat$ 
dd.mm.yyyy��  $	 Телефон��$
 2* $	 160Q� �� *PhoneNumber+4  .System.Windows.Controls.DataGridTemplateColumn  $	  ��$	
 100    CellTemplate �� .R��� -   $��Выбрать���� -    ��Name$ readererror��$��15(�$'��!Выберите читателя��$y�	Collapsed=�$
��0, 5q��� $��1��$��5�����#777$��Stretch=� �� ResizeBehavior$ PreviousAndNext=��� $��2��$��10q�.+��  �� $
��auto ��� .+��� $��0��$��20(�$��
Книги��$	��0,5q�$��Center=��� -   $��1��$��20(�$��
10, 5, 0 5q�  -   $ books��   SelectionMode$ Extended=�$	��400�� .   .  �� IsTextSearchEnabled .   �� IsTextSearchCaseSensitive .  $��20(�   $
	 ISBN��$
 2* $	 145Q� �� *ISBN+  $	 Название��$
 3* $	 130Q� �� *
BookName+ �� .���  � ��$
 Wrap=�  $	 
Автор��$
 2* $	 100Q� �� *AUTHORS.AuthorName+ �� .���  � ��$
 Wrap=�  $	 Издательство��$
 2* $	 120Q� �� *PUBLISHERS.PublisherName+ �� .���  � ��$
 Wrap=�  $	 Год издания��$
 1* $	 130Q� �� *
PublDate+  $	  ��$	
 100  �� .R��� -   $��Добавить���� -   $ booklackerror��$��15(�$!��Выберите книги��$y�	Collapsed=�$
��0, 5q��� $��3��$��5�����#777$��Stretch=�$ PreviousAndNext=��� $��4��
���   �$	��2.5q�$��10q����#eee._��� $��10q�.+���  �� Orientation$ 
Horizontal=�.+��� $
��Bold"�$��20(�$��Читатель:��$	��0,5q�$��Center=��� -	   $ reader��$��20(�$y�	Collapsed=�$��5q�$��Center=��� -
   $ booklist��$
��Bold"�$��20(�$!��Книги к выдаче:��$��0, 10, 0, 5q�$��Center=�  -   $ bookstogive��$ Extended=� .   . $��20(�   $
	 ISBN��$
 2* $	 145Q� �� *ISBN+  $	 Название��$
 3* $	 130Q� �� *
BookName+ �� .���  � ��$
 Wrap=�  $	 
Автор��$
 2* $	 100Q� �� *AUTHORS.AuthorName+ �� .���  � ��$
 Wrap=�  $	 Издательство��$
 2* $	 120Q� �� *PUBLISHERS.PublisherName+ �� .���  � ��$
 Wrap=�  $	 Год издания��$
 1* $	 130Q� �� *
PublDate+  $	  ��$	
 100  �� .R��� -   $��Удалить���� $ 
Horizontal=�.+��� $
��Bold"�$��20(�$��Дата выдачи:��$
��0,10q�$��Center=��� -    ��Name$ lenddate��$��20(�$	��110��$��5q�$��5q�$��Center=��� -   $ 	dateerror��$��20(�$y�	Collapsed=�$'��!Неправильная дата��$��Center=�$��5q��� $ 
Horizontal=�.+��� $
��Bold"�$��20(�$3��-Ожидаемая дата возврата:��$	��0,5q�$��Center=��� -   $ 
returndate��$��20(�$��5q�$��Center=�� $��2��$��2�� �� �� �� -   $��1��$��0��$��Сохранить��$��10q�$��20(��� -   $��1��$��1��$��Отмена��$��10q�$��20(�