   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LIBRARY_lite.pagesLIBRARY_lite.pages  "    LIBRARY_lite.pages.Employees   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:LIBRARY_lite.pages       N� Title$  	Employees��.��� 
������� � RowDefinitions �� $
��Auto ��� .+�� $��0��$��5q� �� $
��auto ��� $
��auto � � ColumnDefinitions �� �� .+��� $��0��$��0�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ emps_header��$��25(�$��Сотрудники��$��5q�$��Center=��� -    ��Name$ 
add_button��$��25(�$��Добавить��$��10, 5q�$��5q�$��Center=��� $��0��$��1��$ 
Horizontal=�$��Right=�.+��� -   $��25(�$��Удаленные��$��10, 5q�$��5q�$��Center=��� -   $ delete_button��$��25(�$��Удалить��$��10, 5q�$��5q�$��Center=�� $��1��$��0�� �� $
��auto ��� .+��� $��0��$��20(�$��
Поиск��$��5q�$��Center=��� -   $��1��$��20(�$��10, 5q�$��Center=��� -   $ employee_error��$��1��$��1��$��15(�$��5q�$��Right=�$y�	Collapsed=�&   System.Windows.Controls.DataGrid  -     Name$ EmployeesDG��$��1��   AutoGenerateColumns .  $��20(�   
IsReadOnly . 	   SelectionMode$	 Extended=���.  
   Columns
 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��   MinWidth$	 200Q�   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*    CellTemplate �� .R��� $
��Wrap=����� *EmployeeName+  $ 
Логин��$	 200Q�$ 1*  �� .R��� $
��Wrap=����� *ELogin+  $ Пароль��$	 200Q�$ 1*  �� .R��� -   $#��Показать пароль��