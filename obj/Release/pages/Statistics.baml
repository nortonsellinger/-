   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LIBRARY_lite.pagesLIBRARY_lite.pages  #    LIBRARY_lite.pages.Statistics   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:LIBRARY_lite.pages       N� Title$  
Statistics��.��� 
������� � RowDefinitions �� $
��Auto ��� .+��� $��0��.+��� $��0��$��25(�$��Статистика��$��10q�$��Center=��  � Orientation$ 
Horizontal=�$��
0,0, 0, 10q�.+��� -   $��20(�$��за неделю��$��10, 5q�$
��10,5q�$��Center=��� -   $��20(�$��за месяц��$��10, 5q�$
��10,5q�$��Center=��� -   $��20(�$��за год��$��10, 5q�$
��10,5q�$��Center=��� -   $��20(�$��за все время��$��10, 5q�$
��10,5q�$��Center=���  �� Orientation$ 
Horizontal=�.+��� -   $��20(�$ ��другой период:��$��10, 5q�$
��10,5q�$��Center=��� $��20(�$��с��$��5q�$��Center=��� -    ��Name$ 
date_start��$��20(�$��5q�$��5q� �� 	MaxLength$ 10��$��Center=�$	��100���� $��20(�$
��по��$��5q�$��Center=��� -   $ date_end��$��20(�$��5q�$��5q�$ 10��$��Center=�$	��100��� $��1�� �� �� $
��auto ��� �� $
��auto ��� .+��� $��1��$��5��
���   �$��Stretch=�$��5q��� $��3��$��5��
���   �$��Stretch=�$��5q�� $��0��$��
0, 0, 0, 5q� �� $
��auto ��� .+��� $��0��$ 
Horizontal=�.+��� $��0��$��20(�$8��2Самые востребованные книги��$
��10,5q�$��Center=��� -   $��20(�$��10, 5q�$��5q�$��50��$ 3���� $��0��$��20(�$��количество��$	��0,5q�$��Center=��� $��1��.��&   System.Windows.Controls.DataGrid  -	     Name$ BooksDG��$��1��   AutoGenerateColumns .  $��20(�   
IsReadOnly . ��.  ���#555	   CanUserSortColumns	 .  
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 ISBN��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1*    MinWidth$	 150Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ISBN+  $ Название��$ 3* $	 200Q� �� *
BookName+   ElementStyle �� .���  �� Property � �� �� Value$
 Wrap=�  $ 
Автор��$ 3* $	 200Q� �� *AUTHORS.AuthorName+ �� .���  � ��$
 Wrap=�  $ Издательство��$ 3* $	 150Q� �� *PUBLISHERS.PublisherName+ �� .���  � ��$
 Wrap=�  $ Год издания��$ 1* $	 125Q� �� *
PublDate+� $��2��$	��0,5q� �� $
��auto ��� .+��� $��0��$ 
Horizontal=�.+��� $��0��$��20(�$2��,Самые активные читатели��$
��10,5q�$��Center=��� -
   $��20(�$��10, 5q�$��5q�$��50��$ 3���� $��0��$��20(�$��количество��$	��0,5q�$��Center=��� $��1��.��  -   $ 	ReadersDG��$��1�� .  $��20(� . 	 .  
   $ ФИО��$ 3* $	 200Q� �� *
ReaderName+  $ Дата рождения��$ 2* $	 160Q� �� *	BirthDate+ �� StringFormat$ 
dd.MM.yyyy��  $ Телефон��$ 2* $	 160Q� �� *PhoneNumber+$
 8{0}��� $��4��$	��0,5q� �� $
��auto ��� .+��� $��0��$ 
Horizontal=�.+��� $��0��$��20(�$>��8Самые продуктивные сотрудники��$
��10,5q�$��Center=��� -   $��20(�$��10, 5q�$��5q�$��50��$ 3���� $��0��$��20(�$��количество��$	��0,5q�$��Center=��� $��1��.��  -   $ EmployeesDG��$��1�� .  $��20(� . 	 .  
 4  .System.Windows.Controls.DataGridTemplateColumn  $ ФИО��$	 200Q�$ 2*    CellTemplate �� .R��� $
��Wrap=����� *EmployeeName+