   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows  %    LIBRARY_lite.windows.BOOKwindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:LIBRARY_lite.windows       � Title$  Учет книг��$	��600��$	��550��$
��1000��$
��1200�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $
��auto ���  � ColumnDefinitions �� $
��auto ��� .+�� $��0��$��2�����#fefefe �� $
��auto ��� $
��auto ��� $
��auto ��� �� $
��auto �.+��� -    ��Name$ emp_name��$��0��$��25(�$��10, 5q�$��Анохина С.В.��$��Center=�$��Center=��� -   $ emp_role��$��1��$��25(�$
��Bold"�$��10, 5q�$ ��Администратор��$��Center=�$
��Left=��� -    ��Name$ edit_button��$��2��$��25(�$(��"Мои учетные данные��$
��Left=�$��10, 5q�$��5q�$��Center=��� $��3�� �� Orientation$ 
Horizontal=�.+��� $��1��$��20(�$��10, 5, 0, 10q�$$��Срок выдачи книг��$��Center=��� -    ��Name$ bl_term_box��$��20(�$��10, 5q�$��5q�$��50�� �� 	MaxLength$ 2��$��Center=�$y�	Collapsed=��� -   $ bl_term_block��$��20(�$��5q�	 �� Padding$	 5q�$��Center=�$
��Bold"��� -   $��4��$��Right=�$��25(�$-��'Сменить пользователя��$��10, 5q�$��5q�� $��1��$��1�����#555 �� $
��auto ��� .+��� $��0��$
��Left=�$y�	Collapsed=�$��Disabled=�$��Hidden=�.���� $ 
Horizontal=�.+��� $ 
Horizontal=����#eee$��10q�.+��� $��25(�$��10, 5q�$��Приход № 545645��$��Center=�$
��Left=�$	��210���� $��25(�$	��2.5q�$��5q�$��Center=����� $��15��$��15��.+��� $��2��
���  ��	
 �� X1$
 0��	 �� X2$ 15��	 �� Y1$ 0��	 �� Y2$ 15���� $��2��
���  ��$
 0��$ 15��$ 15��$ 0�� � -     �Name$ frame��$��1��$��10, 10, 10, 10q�  � NavigationUIVisibility$ Hidden=�� $��1��$��0�����#777.+��� $��5q�.+��� -   $��25(�$��Сотрудники��$��10, 5q�$��5q��� -	   $��25(�$��Читатели��$��10, 5q�$��5q��� -
   $��25(�$��Авторы��$��10, 5q�$��5q��� -   $��25(�$��Издательства��$��10, 5q�$��5q��� -   $��25(�$��
Книги��$��10, 5q�$��5q��� -   $��25(�$��Выдача��$��10, 5q�$��5q��� -   $��25(�$��
Утеря��$��10, 5q�$��5q��� -   $��25(�$��Статистика��$��10, 5q�$��5q�