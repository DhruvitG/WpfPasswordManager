   M S B A M L   `   `   `  ����M  IWpfPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfPasswordManagerWpfPasswordManager  5   	   -    'WpfPasswordManager.AccountDetailsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfPasswordManager     5   	     � Title$  AccountDetailsWindow��5   	   $	��275��6&   $	��300��63   .��5	      �� ���#121317.+�5
   
   �� 
�������$��40��6'   $��Center=�63   $��	Agency FB)�6P   $��20(�6g    �� Padding$ 5q�6u   Account Details6�   � 5   
    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6     � ColumnDefinitions 5      �� 5      $	��125 �6#   �� 5      $	��175 �6#   .+�5      �� 
�������$��Right=�6+   $��16(�6G   $��	Agency FB)�6U   $ 0 5 10 0q�6l   Title:6�   �� 5      -   5        $��
titleField��5   &   $��1��6   $��25��68   $��0q�6D   $	��130��6X   $
��Left=�6d   $��5 3 5 0q�6   �� 5      $��1��6   
�������$��Right=�68   $��16(�6T   $��	Agency FB)�6b   $ 0 5 10 0q�6y   
User Name:6�   �� 5      -   5        $��usernameField��5   4   $��1��6   $��1��6$   $��25��6I   $��0q�6U   $	��130��6i   $
��Left=�6u   $��5 3 5 0q�6�   �� 5      $��2��6   
�������$��Right=�68   $��16(�6T   $��	Agency FB)�6b   $ 0 5 10 0q�6y   	Password:6�   �� 5      -   5        $��textPasswordField��5   3   $��2��6   $��1��6#   $y�Hidden=�6L   $��25��6`   $��0q�6l   $	��130��6�   $
��Left=�6�   $��5 3 5 0q�6�   G� 5      -   5        $��passwordField��5   7   $��2��6   $��1��6'   $��25��6L   $��0q�6X   $	��130��6l   $
��Left=�6x   $��5 3 5 0q�6�   �� 5      -   5        $��passwordCheckBox��5   4   $��3��6   $��1��6$   
�������$��14(�6y   $��	Agency FB)�6�   $��5q�6�   $��1q�6�   ���#e04a32.��6�   Show Password6�   �� 5      -   5        $��4��5   0   $��1��6=   $��60��6M   $
��Left=�6X   ���#e04a32
�������$��0q�6�   .��6�   Cancel6�   �� 5       -   5        $��4��5    .   $��1��6;   $��60��6K   $��20 0 0 0q�6V   ���#e04a32
�������$��0q�6�   .��6�   Save6�   5!      5"      5$      