   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LIBRARY_liteLIBRARY_lite       LIBRARY_lite.pages.Readers   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:LIBRARY_lite       N� Title$  Readers�� � 	Resources ��%    .��� 
������� � RowDefinitions �� $
��Auto ��� .+�� $��0��$��5q� �� $
��auto ��� $
��auto � � ColumnDefinitions �� �� .+��� $��0��$��0�� �� Orientation$ 
Horizontal=�$
��Left=�.+��� -    ��Name$ readers_header��$��25(�$��Читатели��$��5q�$��Center=��� -    ��Name$ 
add_button��$��25(�$��Добавить��$��10, 5q�$��5q�$��Center=��� $��0��$��1��$ 
Horizontal=�$��Right=�.+��� -   $��25(�$��Удаленные��$��10, 5q�$��5q�$��Center=��� -   $ delete_button��$��25(�$��Удалить��$��10, 5q�$��5q�$��Center=�� $��1��$��0�� �� $
��auto ��� .+��� $��0��$��20(�$��
Поиск��$��5q�$��Center=��� -   $��1��$��20(�$��10, 5q�$��Center=��� -   $ reader_error��$��1��$��1��$��15(�$��5q�$��Right=�$y�	Collapsed=�&   System.Windows.Controls.DataGrid  -     Name$ 	ReadersDG��$��1��   AutoGenerateColumns .  $��20(�	   
IsReadOnly	 . ��.  
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 3*    MinWidth$	 200Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
ReaderName+   ElementStyle �� .���  �� Property � �� �� Value$
 Wrap=�  $ Дата рождения��$ 2* $	 160Q� �� *	BirthDate+ �� StringFormat$ 
dd.MM.yyyy��  $ Телефон��$ 2* $	 160Q� �� *PhoneNumber+$
 8{0}��4  .System.Windows.Controls.DataGridTemplateColumn  $  ��$	 150Q�   CellTemplate �� .R��� .+��� -   $ ��Редактировать���� -	   $��История��