   M S B A M L   `   `   `  ����M  IWpfPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfPasswordManagerWpfPasswordManager  5   	   $    WpfPasswordManager.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfPasswordManager     5   	     � Title$  LoginWindow��5   	   $	��275��6   $	��400��6*   .��5
      �� ���#121317.+�5   
   �� $��Center=�6   $��24(�61   
������� �� Padding$ 	0 10 0 10q�6R   $��	Agency FB)�6f   SIGN IN TO PASSWORD MANAGER6�   � 5   
   $��Center=�6    � 	Resources 5       �� 
TargetType �� Property �� Value��%R   '��       �� 5      " ��6   .�5      ��  � ��$ 16(�61   5      5       � RowDefinitions 5      �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6     � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      $	��100 �6#   .+�5      �� 
�������$��Right=�6+   $ 0 0 10 0q�6G   $��	Agency FB)�6Z   $��16(�6q   
User Name:6�   �� 5      -   5        $��usernameTextBox��5      $��1��6-   $	��100��6=   $��25��6I   $��0q�6U   $��5 3 5 0q�6i   6}   �� 5      $��1��6   
�������$��Right=�68   $ 0 0 10 0q�6T   $��	Agency FB)�6g   $��16(�6~   	Password:6�   G� 5      -   5        $��passwordBox��5      $��1��6-   $��1��6:   $	��100��6J   $��25��6V   $��0q�6b   $��5 3 5 0q�6v   6�   �� 5      -   5        $��2��5   ,   $��1��69   ���#e04a32
�������$��25��6q   $��0q�6}   $��	Agency FB)�6�   $��16(�6�   .��6�   Login6�   5       �� 5!   
   $��Center=�6   
�������$��10q�6D   $��	Agency FB)�6P   No Account?6t   �� 5"   
   -   5        $	��100��5"   +   ���#e04a32
�������$��25��6_   $��0q�6k   $��	Agency FB)�6   $��16(�6�   .��6�   
Register6�   5%      5&      