   M S B A M L   `   `   `  ����M  IWpfPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfPasswordManagerWpfPasswordManager  5   	   '    !WpfPasswordManager.RegisterWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfPasswordManager     5   	     � Title$  RegisterWindow��5   	   $	��225��6    $	��300��6-   .��5	      �� ���#121317.+�5
   
   �� 
�������$��Center=�6'   $��	Agency FB)�6D   $��20(�6[   $��40��6i    �� Padding$ 6q�6u   Create an Account6�   � 5   
    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6     � ColumnDefinitions 5      �� 5      $	��125 �6#   �� 5      $	��175 �6#   .+�5      �� 
�������$��	Agency FB)�6+   $��16(�6B   $��Right=�6P   $ 0 5 10 0q�6l   
User Name:6�   �� 5      -   5        $��usernameField��5   &   $��1��6   $��25��6;   $��0q�6G   $	��130��6[   $
��Left=�6g   $��5 3 5 0q�6�   �� 5      $��1��6   
�������$��	Agency FB)�68   $��16(�6O   $��Right=�6]   $ 0 5 10 0q�6y   	Password:6�   G� 5      -   5        $��passwordField��5   7   $��1��6   $��1��6'   $��25��6L   $��0q�6X   $	��130��6l   $
��Left=�6x   $��5 3 5 0q�6�   �� 5      $��2��6   
�������$��	Agency FB)�68   $��16(�6O   $��Right=�6]   $ 0 5 10 0q�6y   Confirm Password:6�   G� 5      -   5        $��confirmPasswordField��5   7   $��2��6   $��1��6'   $��25��6S   $��0q�6_   $	��130��6s   $
��Left=�6   $��5 3 5 0q�6�   �� 5      -   5        $��3��5   2   $��1��6?   
�������$��25��6b   ���#e04a32$	��130��6�   $
��Left=�6�   $��0q�6�   $��	Agency FB)�6�   $��16(�6�   .��6�   
Register6�   5      5      5      