   M S B A M L   `   `   `  ����  
MailSender#    MailSender.View.EmailInfoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5      "ignorehttp://www.ignore.com  5      $
��Auto��5   D   $
��Auto��6R     � DataContext  6   �� *Main+   Locator �� Source# [  .��5      � $��1,0,-1,0q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .  (System.Windows.Interactivity.Interaction   Triggers 5   
   /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      /  )GalaSoft.MvvmLight.Command.EventToCommand     Command 6&   �� *ReadAllMailsCommand+5      .+�5   
   �� $
��Wrap=�6    �� TextAlignment$ Center=�5      $-��'Получатели сообщений��6)   $
��Bold"�6E   �� 5   
   -   5         ��Name$ btnloadallemails��5      $'��!Отобразить данные��6+   $��3��5      $
��Bold"�5      $	��140��5       ��5!      �� *ReadAllMailsCommand+&   System.Windows.Controls.DataGrid  5"   
   $	��500��6   $��2��6   	   AutoGenerateColumns	 .  
   
IsReadOnly
 .  �� SelectedItem 6,   �� *CurrentEmail+��5#      �� *Emails+   Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6G   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 60   �� *Id+6G     5'      $ 
Почта��6%   $
 Auto 6N    64   �� *Value+6N     5(      $# Имя отправителя��6%   $	 318 6W    6>   �� *Name+6W   5*      �� 5+   
   $
��Left=�6   $��10,7,0,0q�6/   $��1��6A   $
��Wrap=�5,      $!��Поиск по имени:��6%   $	��Top=�6<   $	��231��5-      �� 5.   
   $
��Left=�6   $��30��6-   $��	120,7,7,7q�69   $��1��5/       �� TextWrapping$
 Wrap=�6   $	��Top=�50      $	��310��6'   ��5.   L   �� *
FilterName+ �� UpdateSourceTrigger$ PropertyChanged=�.��50   3    51        52      $ TextChanged��6!   . 53         6*   �� *FilterCommand+   CommandParameter 6M   �� *
FilterName+6w   54      .��55   &   56      57      58      