   M S B A M L   `   `   `  ����J  FAccountsMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AccountsMonitorAccountsMonitor  5   	       AccountsMonitor.Settings   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AccountsMonitor     5   	   -   5          � Title$+  %Настройки аккаунтов��5   	    � WindowStartupLocation$ CenterScreen=�6%    � WindowStyle$
 None=�6J   ���	#FF666666 � SizeToContent$ WidthAndHeight=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   5      �� 5      $��* �6   5      .+�5   
   � -   5        ���	#FF3E3E3E.+�5      �� $+��%Настройки аккаунтов��6   $��0q�62   $��0q�6=   $��Center=�6I   $��Center=�6f   $��16(�6�   $��Italic$�6�   ���	#FFD4D4D46�   5      �� 5      $��10q�6   $��1��6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $*��$Имя владельца счета��6   $��Italic$�62   
�������6E   �� 5      $I��CУкажите пути к файлам для считывания��6   $��Italic$�6C   
�������$��38,0,0,0q�6i   5      �� 5   
   -   5         ��Name$ AccountsList��5      $ Vertical=�6+   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� -   5        $%��Добавить аккаунт��5      $	��117��60   ���	#FF424242���	#FFF9F9F9$��0q�6�   $��24��6�   �� 5      -   5        $'��!Закрыть Настройки��5      $	��126��62   ���	#FF424242���	#FFF9F9F9$��10,0,0,0q�6�   $��24��6�   5      5      5       5!      