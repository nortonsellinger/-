   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows  #    LIBRARY_lite.windows.EditBook   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:LIBRARY_lite.windows       � Title$-  'Редактирование книги�� � SizeToContent$ Height=�$	��800�� � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� �� .+��� $��0��$��0��$��10q�.+��� $��20(�$
��ISBN��$	��0,5q��� -    ��Name$ newisbn��$��20(�$��5q�$	��0,5q��� -    ��Name$ 	isbnerror��$��15(�$��Введите ISBN��$y�	Collapsed=��� $��1��$��2��$��10q�.+��� $��20(�$��Название��$	��0,5q��� -   $ newname��$��20(�$��5q�$	��0,5q��� -   $ 	nameerror��$��15(�$%��Введите название��$y�	Collapsed=��� $��2��$��0��$��10q�.+��  �� $
��auto ��� .+��� $��0��$��20(�$��
Автор��$��0,0,10,5q�$��Center=��� -   $��1��$��20(�$
��0, 5q�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ 	AuthorsDG��$��1��	   AutoGenerateColumns	 .  $��20(�
   
IsReadOnly
 . $	��600��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1*    CellTemplate �� .R��� $
��Wrap=����� *
AuthorName+  $	 100  �� .R��� -   $��Выбрать���� -   $ author��$��20(�$
��0,10q��� -	   $ authorerror��$��15(�$#��Выберите автора��$��0, 10q�$y�	Collapsed=��� $��2��$��1��$��10q�.+��  �� $
��auto ��� .+��� $��0��$��20(�$��Издательство��$��0,0,10,5q�$��Center=��� -
   $��1��$��20(�$
��0, 5q�$��Center=�  -   $ PublishersDG��$��1��	 .  $��20(�
 . $	��600��   $ 1*  �� .R��� $
��Wrap=����� *PublisherName+  $	 100  �� .R��� -   $��Выбрать���� -   $ 	publisher��$��20(�$
��0,10q��� -   $ 	publerror��$��15(�$/��)Выберите издательство��$��0, 10q�$y�	Collapsed=�� $��0��$��1�� �� �� .+��� $��0��$��10q�.+��� $��20(�$��Год издания��$	��0,5q��� -   $ newyear��$��20(�$��5q�$	��0,5q��� -   $ 	yearerror��$��15(�$*��$Введите год издания��$y�	Collapsed=��� $��1��$��10q�.+��� $��20(�$��Количество��$	��0,5q��� -   $ newquantity��$��20(�$��5q�$	��0,5q� �� 	MaxLength$ 4���� -   $ quantityerror��$��15(�$)��#Введите количество��$y�	Collapsed=��� -   $��5��$��0��$��Сохранить��$��10q�$��20(��� -   $��6��$��1��$��Отмена��$��10q�$��20(�