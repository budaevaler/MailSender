   M S B A M L   `   `   `  ����E  AMailSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MailSender
MailSender  5   	   #    MailSender.View.SaveEmailView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0ignorehttp://www.galasoft.ch/ignore     5   	   &vclr-namespace:MailSender     5   	     � DataContext  5	   	   �� *Main+   Locator �� Source# [  .��5
      � $��0 30 0 0q�60   $	��140��6B     6   �� *CurrentEmail+ � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��25 �6   �� 5      $��25 �6    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��150 �6   .+�5   
   �� $
��Wrap=�6   $	��Id:��6(   �� 5   
   $��1��6   $
��Wrap=�6!   $��Email:��65   �� 5   
   $��2��6   $
��Wrap=�6!   $��Имя:��65   �� 5   
   -   5        $��1��5       �� TextWrapping$
 Wrap=�6"   .��6W   ��5      �� 5       �� Path$ Id�6    �� Mode$ TwoWay=�6$    �� ValidatesOnExceptions .  �� ValidatesOnDataErrors . 	 �� NotifyOnValidationError	 . 
 �� UpdateSourceTrigger$
 PropertyChanged=�6�    �� ValidationRules 5         MailSender.DemoValidator  5      5       .��5!      5"      �� 5#   
   -   5        $��1��5#      $��1��6"   $
 Wrap=�6/   ��6C   �� *Value+$ TwoWay=�	 .  . $
 PropertyChanged=�6�   �� 5$   
   $��1��6   $��2��6"   $
 Wrap=�60   ��6D   �� *Name+$ TwoWay=�$
 PropertyChanged=��� 5%   
   $��Сохранить��6   $
��Bold"�6%   $��4��67   $��2��6D   $��22��5&   .   $	��140��6:   ��5%   X   �� *DataContext.SaveMailCommand+ �� RelativeSource ��  �� AncestorType$ UserControlL���5&      �� 6:   �� 5'   
   $��Удалить��6   $
��Bold"�6#   $��5��65   $��2��6B   $��22��5(   .   $	��140��6:   ��5'   V   �� *DataContext.DeleteMailCommand+ �� $ UserControlL���5(      �� 6:   5)      5*      