   M S B A M L   `   `   `  ����G  CLIBRARY_lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LIBRARY_lite.windowsLIBRARY_lite.windows  5          LIBRARY_lite.windows.auth   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      4local"clr-namespace:LIBRARY_lite.windows     5        � Title$  Авторизация��5       � SizeToContent$ Height=�6   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � $��Center=�6   $��Center=�6#   $��10q�6@    � RowDefinitions 5
      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5      �� -   5         ��Name$ FirstLaunchMessage��5   )   $��0��6   $��25(�6   $����Вы впервые запустили Учет Книг. Придумайте логин и пароль для пользователя с правами администратора��5      $
��Wrap=�5      $��10q�6   �� 5      $��1��6   $��Center=�6   .+�5      �� $��25(�6   $��
Логин��6   $
��Wrap=�6*   $��10, 0q�6>   �� 5      -   5         ��Name$ LoginBox��5      $��25(�6    �� TextWrapping$
 Wrap=�6-   $��10q�6A   $��5q�6M   $	��300��5      $	��500��6%    �� 	MaxLength$ 20��64   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��25(�6   $��Пароль��6   $
��Wrap=�6,   $��10, 0q�6@   $��Center=�6O   �� 5      -   5        	 ��Name$	 PassVisible��5      $��2��6.   $��20(�6;   $��Показать��6I   $
��Left=�6\   $��5q�5      $��10, 0q�6   6!   5      � 5      .+�5      �� -   5        $ HiddenPasswordBox��5      $��25(�67   $
��Wrap=�6E   $��10q�6Y   
 �� Padding$
 5q�6e   $	��300��6q   $	��500��6�   $��consolas)�5      �� 5      -   5        $ PasswordBox��5      $��25(�6/   $
 Wrap=�6=   $��10q�6Q   $��5q�6]   $	��300��6i   $	��500��6x   
������ 
������ $��consolas)�5       $ 20��61   5!      5#      �� 5%      -   5        $��2��5%      $��20(�6   $��
Войти��6&   $��Center=�66   $��10q�5&      $��10q�6   $	��200��6   6-   5'      5(      