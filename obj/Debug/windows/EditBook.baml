   M S B A M L   `   `   `  ����G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows  5   	   #    LIBRARY_lite.windows.EditBook   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:LIBRARY_lite.windows     5   	     � Title$-  'Редактирование книги��5   	    � SizeToContent$ Height=�6&   $	��800��6=    � WindowStartupLocation$ CenterOwner=�6L    � 
ResizeMode$ NoResize=�6p   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6"   $��10q�62   .+�5      �� $��20(�6   $
��ISBN��6&   $	��0,5q�62   �� 5      -   5         ��Name$ newisbn��5      $��20(�6'   $��5q�65   $	��0,5q�6A   6�   �� 5      -   5         ��Name$ 	isbnerror��5      $��15(�6+   $��Введите ISBN��69   $y�	Collapsed=�6M   5      �� 5   
   $��1��6   $��2��6"   $��10q�66   .+�5      �� $��20(�6   $��Название��6&   $	��0,5q�66   �� 5      -   5        $ newname��5      $��20(�6'   $��5q�65   $	��0,5q�6A   6N   �� 5      -   5        $ 	nameerror��5      $��15(�6+   $%��Введите название��69   $y�	Collapsed=�6Q   5      �� 5    
   $��2��6   $��0��6"   $��10q�62   .+�5!      �  5"      �� 5#      $
��auto �6'   �� 5$      .+�5&      �� $��0��6   $��20(�6,   $��
Автор��6:   $��0,0,10,5q�6G   $��Center=�6Y   �� 5'      -   5        $��1��5'      $��20(�6*   $
��0, 5q�68   $��Center=�6b   5(      &   System.Windows.Controls.DataGrid  5)      -   5          Name$ 	AuthorsDG��5)      $��1��6*   	   AutoGenerateColumns	 .  $��20(�6S   
   
IsReadOnly
 . $	��600��5*         Columns 5+      4  .System.Windows.Controls.DataGridTemplateColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6-      CellTemplate 5-      �� 5.      .R�5/   "   �� $
��Wrap=�6H   ��6,   �� *
AuthorName+6H   50      52        53      $	 100 6-    54      �� 55      .R�56   "   �� -   5        $��Выбрать��56   )   6;   57      59      5;      �� 5<      -   5        $ author��5<      $��20(�6(   $
��0,10q�66   �� 5T      -	   5        $ authorerror��5T      $��15(�6-   $#��Выберите автора��6;   $��0, 10q�6R   $y�	Collapsed=�6a   5U      �� 5V   
   $��2��6   $��1��6"   $��10q�62   .+�5W      �  5X      �� 5Y      $
��auto �6'   �� 5Z      .+�5\      �� $��0��6   $��20(�6,   $��Издательство��6:   $��0,0,10,5q�6N   $��Center=�6`   �� 5]      -
   5        $��1��5]      $��20(�6*   $
��0, 5q�68   $��Center=�6e   5^        5_      -   5        $ PublishersDG��5_      $��1��6-   	 .  $��20(�6V   
 . $	��600��5`       5a        5b      $ 1* 6-    5c      �� 5d      .R�5e   "   �� $
��Wrap=�6K   ��6,   �� *PublisherName+6K   5f      5h        5i      $	 100 6-    5j      �� 5k      .R�5l   "   �� -   5        $��Выбрать��5l   )   6;   5m      5o      5q      �� 5r      -   5        $ 	publisher��5r      $��20(�6+   $
��0,10q�69   �� 5�      -   5        $ 	publerror��5�      $��15(�6+   $/��)Выберите издательство��69   $��0, 10q�6V   $y�	Collapsed=�6e   5�      � 5�   
   $��0��6   $��1��6    5�      �� 5�      �� 5�      .+�5�      �� $��0��6   $��10q�6)   .+�5�      �� $��20(�6   $��Год издания��6*   $	��0,5q�6=   �� 5�      -   5        $ newyear��5�      $��20(�6+   $��5q�69   $	��0,5q�6E   5�   =   �� 5�      -   5        $ 	yearerror��5�      $��15(�6/   $*��$Введите год издания��6=   $y�	Collapsed=�6X   5�      �� 5�      $��1��6   $��10q�6)   .+�5�      �� $��20(�6   $��Количество��6*   $	��0,5q�6<   �� 5�      -   5        $ newquantity��5�      $��20(�6/   $��5q�6=   $	��0,5q�6I    �� 	MaxLength$ 4��6V   5�   I   �� 5�      -   5        $ quantityerror��5�      $��15(�63   $)��#Введите количество��6A   $y�	Collapsed=�6[   5�      5�      �� 5�   
   -   5        $��5��5�      $��0��6   $��Сохранить��6.   $��10q�6B   $��20(�6N   6\   �� 5�   
   -   5        $��6��5�      $��1��6   $��Отмена��6.   $��10q�6?   $��20(�6K   6Y   5�      5�      