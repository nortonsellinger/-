   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows  '    !LIBRARY_lite.windows.EditBookLend   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:LIBRARY_lite.windows       � Title$2  ,Продление / возврат книг�� � SizeToContent$ WidthAndHeight=�$	��800��$
��1000�� � WindowStartupLocation$ CenterOwner=�.���  � RowDefinitions �� �� $
��auto � � ColumnDefinitions �� �� .+��� $��0��$��2��$	��800��.���  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��4��
���   �$	��2.5q�$��10q����#eee._��� $��10q�.+���  �� Orientation$ 
Horizontal=�.+��� $
��Bold"�$��20(�$��Читатель:��$	��0,5q�$��Center=��� -    ��Name$ reader��$��20(�$��5q�$��Center=��� $
��Bold"�$��20(�$*��$Возвращенные книги:��$��0, 10, 0, 5q�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ returnedbooks��   SelectionMode$ Extended=�	   AutoGenerateColumns	 .  
   
IsReadOnly
 . $��20(���.  $	��400��   RowStyle ��  �� 
TargetType)  #System.Windows.Controls.DataGridRow"  .���  �� Property � �� �� Value �#efe   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 ISBN��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*    MinWidth$	 145Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
BOOKS.ISBN+  $ Название��$ 3* $	 130Q� �� *BOOKS.BookName+   ElementStyle �� .���  � ��$
 Wrap=�  $ 
Автор��$ 2* $	 100Q� �� *BOOKS.AUTHORS.AuthorName+ �� .���  � ��$
 Wrap=�  $ Издательство��$ 2* $	 140Q� �� * BOOKS.PUBLISHERS.PublisherName+ �� .���  � ��$
 Wrap=�  $ Год издания��$ 1* $	 150Q� �� *BOOKS.PublDate+�� $
��Bold"�$��20(�$"��Выданные книги:��$��0, 10, 0, 5q�$��Center=�  -   $ 
givenbooks��$ Extended=�	 .  
 . $��20(���.  $	��400�� �� "  .���  � �� �#fee   $
 ISBN��$ 2* $	 150Q� �� *
BOOKS.ISBN+  $ Название��$ 3* $	 130Q� �� *BOOKS.BookName+ �� .���  � ��$
 Wrap=�  $ 
Автор��$ 2* $	 100Q� �� *BOOKS.AUTHORS.AuthorName+ �� .���  � ��$
 Wrap=�  $ Издательство��$ 2* $	 140Q� �� * BOOKS.PUBLISHERS.PublisherName+ �� .���  � ��$
 Wrap=�  $ Год издания��$ 1* $	 130Q� �� *BOOKS.PublDate+4  .System.Windows.Controls.DataGridTemplateColumn  $  ��$	 100Q�   CellTemplate �� .R��� -   $��Возврат���� $
��Bold"�$��20(�$*��$Возвращаемые книги:��$��0, 10, 0, 5q�$��Center=�  -   $ returningbooks��$ Extended=�	 .  
 . $��20(���.  $	��400��   $
 ISBN��$ 2* $	 150Q� �� *
BOOKS.ISBN+  $ Название��$ 3* $	 130Q� �� *BOOKS.BookName+ �� .���  � ��$
 Wrap=�  $ 
Автор��$ 2* $	 100Q� �� *BOOKS.AUTHORS.AuthorName+ �� .���  � ��$
 Wrap=�  $ Издательство��$ 2* $	 140Q� �� * BOOKS.PUBLISHERS.PublisherName+ �� .���  � ��$
 Wrap=�  $ Год издания��$ 1* $	 150Q� �� *BOOKS.PublDate+  $  ��$	 100Q� �� .R��� -   ���� $��20(�$%��Отменить возврат��$
��Wrap=��� $ 
Horizontal=�.+��� $
��Bold"�$��20(�$��Дата выдачи:��$
��0,10q�$��Center=��� -   $ lenddate��$��20(�$��5q�$��Center=��� $ 
Horizontal=�.+��� $
��Bold"�$��20(�$3��-Ожидаемая дата возврата:��$	��0,5q�$��Center=��� -    ��Name$ 
returndate��$��20(�$��5q�$��5q�$��Center=�$	��110�� �� 	MaxLength$ 10���� -	   $ returndateerror��$��15(�$'��!Неправильная дата��$y�	Collapsed=�$
��0, 5q�$��Center=��� $ 
Horizontal=�.+��� $
��Bold"�$��20(�$ ��Дата возврата:��$
��0,10q�$��Center=��� -
   $ actreturndate��$��20(�$��5q�$��Center=�� $��2��$��2�� �� �� �� -   $��1��$��0��$��Сохранить��$��10q�$��20(��� -   $��1��$��1��$��Отмена��$��10q�$��20(�