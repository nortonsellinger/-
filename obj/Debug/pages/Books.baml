   M S B A M L   `   `   `  ����G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LIBRARY_lite.pagesLIBRARY_lite.pages  5          LIBRARY_lite.pages.Books   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:LIBRARY_lite.pages     5        N� Title$  Books��5      .��5	      � 
������� � RowDefinitions 5
      �� 5      $��1* �6   .+�5      � $��0��6	    5      �� 5      $
��auto �6   �� 5      .+�5      � $��0��6
    5      �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5      �� 5      $
��auto �6   �� 5      .+�5      �� $��0��6   $��0��6    �� Orientation$ 
Horizontal=�6.   $��5q�6G   .+�5      �� -   5         ��Name$ book_header��5      $��25(�6&   $��
Книги��64   $��5q�6A   $��Center=�6L   �� 5      -   5        $��25(�5      $��Добавить��6   $��10, 5q�5      $��5q�6   $��Center=�69   5      � 5       $��1��6   $��2��6    5!      �� 5"      $
��auto �6   �� 5#      $
��auto �6    5%      �� 5&      $
��auto �6   �� 5'      �� 5(      .+�5*      �� $��0��6   $��20(�6!   $��
Поиск��6/   $��5q�6<   $��Center=�6G   �� 5+      -   5         ��Name$ search_s��5+      $��1��6!   $��20(�61   $��5q�6?   $��Center=�5,   	    �� 	MaxLength$ 13��6$   �� 5-      $��2��6   $ 
Horizontal=�6"   .+�5.      �� $��20(�6   $��
Год с:��6    $��5q�6.   $��Center=�69   �� 5/      -   5        $ 
year_start��5/      $��20(�6$   $��5q�62   $��Center=�51      $��60��6#   $�� ��6.   $ 4��67    �� TextAlignment$ Center=�6E   �� 52      $��20(�6   $��по:��6    $��5q�6+   $��Center=�66   �� 53      -   5        $ year_end��53      $��20(�6"   $��5q�60   $��Center=�55      $��60��6#   $�� ��6.   $ 4��67   $ Center=�6E   56      57      58      &   System.Windows.Controls.DataGrid  5:      -   5          Name$ BooksDG��5:      $��1��6   	   AutoGenerateColumns	 .  $��20(�6H   
   
IsReadOnly
 . ��.  ���#555   Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$
 ISBN��6      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6(      MinWidth$	 150Q�63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *ISBN+  5>      $ Название��6   $ 3* 6,   $	 200Q�67    6F   �� *
BookName+   ElementStyle 5?      �� 5@   	   .�5A   
   ��  �� Property � �� �� Value$
 Wrap=�63   5B   
   5D        5E      $ 
Автор��6   $ 3* 6)   $	 200Q�64    6C   �� *AUTHORS.AuthorName+ 5F      �� 5G   	   .�5H   
   ��  � ��$
 Wrap=�63   5I   
   5K        5L      $ Издательство��6   $ 3* 60   $	 150Q�6;    6J   �� *PUBLISHERS.PublisherName+ 5M      �� 5N   	   .�5O   
   ��  � ��$
 Wrap=�63   5P   
   5R        5S      $ Год издания��6   $ 1* 6/   $	 125Q�6:    6I   �� *
PublDate+  5T      $ Количество��6   $ 1* 6.   $	 120Q�69    6H   �� *
Quantity+4  .System.Windows.Controls.DataGridTemplateColumn  5U      $  ��6   $	 150Q�6(      CellTemplate 5V      �� 5W   	   .R�5X   
   �� -   5        $ ��Редактировать��5X      6)   5Y   
   5[      5]      5^      5�      5�      