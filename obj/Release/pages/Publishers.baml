   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LIBRARY_lite.pagesLIBRARY_lite.pages  #    LIBRARY_lite.pages.Publishers   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:LIBRARY_lite.pages       N� Title$  
Publishers��.��� 
������� � RowDefinitions �� $
��Auto ��� .+�� $��0�� � ColumnDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $��0��$��0�� �� Orientation$ 
Horizontal=�$��5q�.+��� -    ��Name$ publ_header��$��25(�$��Издательства��$��5q�$��Center=��� -   $��25(�$��Добавить��$��10, 5q�$��5q�$��Center=��� $��2��$��20(�$��
Поиск��$��5q�$��Center=��� -   $��3��$��20(�$��10, 5q�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ PublishersDG��$��1��   AutoGenerateColumns .  $��20(�   
IsReadOnly . ��.     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Название��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 2*    MinWidth$	 200Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *PublisherName+4  .System.Windows.Controls.DataGridTemplateColumn  $	  ��$	 150Q�   CellTemplate �� .R��� -   $ ��Редактировать��