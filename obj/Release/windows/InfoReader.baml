   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows  %    LIBRARY_lite.windows.InfoReader   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:LIBRARY_lite.windows       � Title$.  (Информация о читателе��$	��450��$	��800��$	��800�� � WindowStartupLocation$ CenterOwner=����#ccc.��� $��0, 10q� � RowDefinitions �� $
��auto ��� .+��� $��0��.+��� -    ��Name$ reader��$��25(�$��10, 0, 10, 10q�$��читатель��$��Center=��� $��0��$��20(�$!��История выдачи��$
��10,5q�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ 
BookLendDG��$��1��   AutoGenerateColumns .  $��20(�   
IsReadOnly .    RowStyle ��  �� 
TargetType)  #System.Windows.Controls.DataGridRow"  	 �� Triggers	 �� 
 �� Binding
 �� *status+ �� Value returned.a���  �� Property � �� �� Value �#efe�� 
 �� *status+	 taken.a���  � �� �#fee   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Дата выдачи��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1*    MinWidth$	 130Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
LendDate+ �� StringFormat$ 
dd.MM.yyyy��  $ Вернуть до��$ 1* $	 130Q� �� *ExpReturnDate+$ 
dd.MM.yyyy��  $ Возвращено��$ 1* $	 100Q� �� *ActualReturnDate+$ 
dd.MM.yyyy��4  .System.Windows.Controls.DataGridTemplateColumn  $ 
Книги��$ 2* $	 125Q�   CellTemplate �� .R��� .+�  $ booksdg��$��15(� .  .  ���� *BOOK_SETS.BOOK_SET_CONTENTS+ �� "  	 �� 
 �� *status+ returned.a���  � �� �#efe�� 
 �� *status+	 taken.a���  � �� �#fee�� 
 �� *status+ lost.a���  � �� �#ddd   $	 200Q�$ 1*  �� .R��  � Orientation$ 
Horizontal=�.+��� $��5q����� *
BOOKS.ISBN+�� $
��Wrap=�$��5q����� *
ReturnDate+$ 
dd.MM.yyyy���� $
��Wrap=�$��5q�$
��Bold"����� *BOOKS.BookName+�� $
��Wrap=�$��5q����� *BOOKS.AUTHORS.AuthorName+�� $
��Wrap=�$��5q�$��	Underline{����� *EMPLOYEES.EmployeeName+  $ Библиотекарь��$ 2* $	 150Q� �� *EMPLOYEES.EmployeeName+   ElementStyle �� .���  � ��$
 Wrap=�