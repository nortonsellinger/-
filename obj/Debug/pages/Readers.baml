   M S B A M L   `   `   `  ����G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LIBRARY_liteLIBRARY_lite  5           LIBRARY_lite.pages.Readers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:LIBRARY_lite     5        N� Title$  Readers��5	       � 	Resources 5
      ��%    5      .��5      � 
������� � RowDefinitions 5      �� 5      $
��Auto �6   �� 5      .+�5      � $��0��6	   $��5q�6    5      �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��0��6    �� Orientation$ 
Horizontal=�6-   $
��Left=�6F   .+�5      �� -   5         ��Name$ readers_header��5      $��25(�6(   $��Читатели��66   $��5q�6F   $��Center=�6Q   �� 5      -   5         ��Name$ 
add_button��5   .   $��25(�6   $��Добавить��6   $��10, 5q�5      $��5q�6   $��Center=�6:   5      �� 5       $��0��6   $��1��6   $ 
Horizontal=�6-   $��Right=�6F   .+�5!      �� -   5        $��25(�5!      $��Удаленные��6   $��10, 5q�5"      $��5q�6   $��Center=�6>   �� 5#      -   5        $ delete_button��5#   -   $��25(�6   $��Удалить��6   $��10, 5q�5$      $��5q�6   $��Center=�6=   5%      � 5&      $��1��6
   $��0��6    5'      �� 5(      $
��auto �6   �� 5)      .+�5+      �� $��0��6   $��20(�6    $��
Поиск��6.   $��5q�6;   $��Center=�6F   �� 5,      -   5        $��1��5,      $��20(�6   $��10, 5q�6,   $��Center=�6W   5-      �� 5/      -   5        $ reader_error��5/   ,   $��1��6   $��1��6   $��15(�6B   $��5q�50      $��Right=�6   $y�	Collapsed=�6*   51      &   System.Windows.Controls.DataGrid  57      -   5          Name$ 	ReadersDG��57      $��1��6      AutoGenerateColumns .  $��20(�6I   	   
IsReadOnly	 . ��.  
   Columns
 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6      Width5  /System.Windows.Controls.DataGridLengthConverter$ 3* 6&      MinWidth$	 200Q�61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
ReaderName+   ElementStyle 5;      �� 5<      .�5=   	   ��  �� Property � �� �� Value$
 Wrap=�62   5>   	   5@        5A      $ Дата рождения��6   $ 2* 60   $	 160Q�6;    6J   �� *	BirthDate+ �� StringFormat$ 
dd.MM.yyyy��  5B      $ Телефон��6   $ 2* 6*   $	 160Q�65    6D   �� *PhoneNumber+$
 8{0}��4  .System.Windows.Controls.DataGridTemplateColumn  5C      $  ��6   $	 150Q�6'      CellTemplate 5D      �� 5E      .R�5F   	   �� .+�5G   
   �� -   5        $ ��Редактировать��5G      6)   �� 5H   
   -	   5        $��История��5H      6#   5I   
   5J   	   5L      5N      5S      5T      