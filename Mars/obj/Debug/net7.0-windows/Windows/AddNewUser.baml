   M S B A M L   `   `   `  ����?  ;Mars, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Mars.WindowsMars.Windows  5   	       Mars.Windows.AddNewUser   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ,localclr-namespace:Mars.Windows     5   	     � Title$<  6Добавить нового пользователя��5   	   $	��450��6.   $	��300��6;    � 
ResizeMode$ NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]   ���#313338 � 	Resources 5	       �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%�  '��       �� 5
   
   " ��6   .�5      ��  � �� �#4CAF506+   �� 5       � ��
 �����6+   �� 5       � ��$ 5q�6'   �� 5       � ��$ 10q�6(   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 0q�60    5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      ��  � �� �#45a04963   5      5      5      .��5      � .+�5   
   �� .+�5      �� $%��Имя пользователя��6   
�������6/   �� 5      -   5        
 ��Name$
 txtUsername��5      �� 5      $��Пароль��6   
�������6%   �� 5      -   5        $
 txtPassword��5      �� 5      $��Полное имя��6   
�������6)   �� 5      -   5        $
 txtFullname��5      �� 5       $%��Тип пользователя��6   
�������6/   �� 5!      -   5         ��Name$ cmbUserType��5!       �� DisplayMemberPath$ Usertypename��6,    �� SelectedValuePath$ Id��6M   ��5"      �� *
Usertype+�� 5#      -   5        $/��)Добавить пользователя��5#      $��	0,190,0,0q�6M   5$      5%      5&      