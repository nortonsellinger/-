   M S B A M L   `   `   `  ����G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LIBRARY_lite.pagesLIBRARY_lite.pages  5      !    LIBRARY_lite.pages.BookLoss   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:LIBRARY_lite.pages     5        N� Title$  BookLoss��5	      .��5
      � 
������� � RowDefinitions 5      �� 5      $
��Auto �6   �� 5      .+�5      � $��5q�6	    � ColumnDefinitions 5      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5      �� -   5         ��Name$ loss_header��5      $��0��6   $��25(�64   $��
Утеря��6B   $��5q�6O   $��Center=�6Z   �� 5      $��1��6   $��20(�6   $��
Поиск��6-   $��20, 5, 5, 5q�6:   $��Center=�6O   �� 5      -   5        $��2��5      $��20(�6   $��10, 5q�6+   $��Center=�6T   �� 5      $��3��6    �� Orientation$ 
Horizontal=�6    .+�5      �� -   5        $��20(�5      $��	дата:��6   $��10, 5q�6+   $
��10,5q�6;   $��Center=�5      �� 5      $��20(�6   $��с��6   $��5q�6'   $��Center=�62   �� 5      -   5         ��Name$ 
date_start��5      $��20(�6"   $��5q�60   $��5q�6<    �� 	MaxLength$ 10��6G   $��Center=�5      $	��100��6!   6N   �� 5      $��20(�6   $
��по��6   $��5q�6(   $��Center=�63   �� 5       -   5        $ date_end��5       $��20(�6    $��5q�6.   $��5q�6:   $ 10��6E   $��Center=�5!      $	��100��6!   6N   �� 5"      -   5        $��20(�5"      $��за все время��6'   $��10, 5q�6>   $
��10,5q�6N   $��Center=�5#      5$      5%      &   System.Windows.Controls.DataGrid  5&      -   5          Name$ 
BookLossDG��5&      $��1��6!      AutoGenerateColumns .  $��20(�6J   	   
IsReadOnly	 . ��.  
   Columns
 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Читатель��6      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6+      MinWidth$	 150Q�66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *READERS.ReaderName+  5*      $ Дата утери��6   $ 1* 6-   $	 130Q�68    6G   �� *
LossDate+ �� StringFormat$ 
dd.MM.yyyy��4  .System.Windows.Controls.DataGridTemplateColumn  5+      $ 
Книга��6   $ 4* 6,   $	 250Q�67      CellTemplate 5,      �� 5-      .R�5.   	   �  � Orientation$ 
Horizontal=�6   .+�5/   
   �� $��10, 5q�60   ��6   �� *
BOOKS.ISBN+60   �� 50   
   $
��Wrap=�64   $��10, 5q�6H   ��6   �� *BOOKS.BookName+6H   �� 51   
   $
��Wrap=�6>   $��10, 5q�6R   ��6   �� *BOOKS.AUTHORS.AuthorName+6R   �� 52   
   $
��Wrap=�6D   $��10, 5q�6X   ��6   �� * BOOKS.PUBLISHERS.PublisherName+6X   �� 53   
   $��10, 5q�64   ��6   �� *BOOKS.PublDate+64   54   
   55   	   57        58      $ Библиотекарь��6   $ 2* 6/   $	 200Q�6:    6I   �� *EMPLOYEES.EmployeeName+   ElementStyle 59      �� 5:      .�5;   	   ��  �� Property � �� �� Value$
 Wrap=�62   5<   	   5>      5G      5H      5I      