   M S B A M L   `   `   `  ���� G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows      LIBRARY_lite.windows.auth   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:LIBRARY_lite.windows       � Title$  Авторизация�� � SizeToContent$ Height=�$	��800�� � WindowStartupLocation$ CenterScreen=�.��� $��Center=�$��Center=�$��10q� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto �.+��� -    ��Name$ FirstLaunchMessage��$��0��$��25(�$����Вы впервые запустили Учет Книг. Придумайте логин и пароль для пользователя с правами администратора��$
��Wrap=�$��10q��� $��1��$��Center=�.+��� $��25(�$��
Логин��$
��Wrap=�$��10, 0q��� -    ��Name$ LoginBox��$��25(� �� TextWrapping$
 Wrap=�$��10q�$��5q�$	��300��$	��500�� �� 	MaxLength$ 20����  �� Orientation$ 
Horizontal=�.+��� $��25(�$��Пароль��$
��Wrap=�$��10, 0q�$��Center=��� -   	 ��Name$	 PassVisible��$��2��$��20(�$��Показать��$
��Left=�$��5q�$��10, 0q�� .+��� -   $ HiddenPasswordBox��$��25(�$
��Wrap=�$��10q�
 �� Padding$
 5q�$	��300��$	��500��$��consolas)��� -   $ PasswordBox��$��25(�$
 Wrap=�$��10q�$��5q�$	��300��$	��500��
������ 
������ $��consolas)�$ 20���� -   $��2��$��20(�$��
Войти��$��Center=�$��10q�$��10q�$	��200��