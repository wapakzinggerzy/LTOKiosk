   M S B A M L   `   `   `  ����C  ?LTOKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LTOKiosk.ViewsLTOKiosk.Views  5      /clr-namespace:LTOKiosk.ClassLTOKiosk.Class  5      9!clr-namespace:LTOKiosk.ViewModelsLTOKiosk.ViewModels  5      /clr-namespace:LTOKiosk.ViewsLTOKiosk.Views  5	      $    LTOKiosk.Views.CashPaymentView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:LTOKiosk.Views     5      1vehiclesclr-namespace:LTOKiosk.Class     5      8
viewmodels!clr-namespace:LTOKiosk.ViewModels     5      .viewsclr-namespace:LTOKiosk.Views     5	      .��5      � 
���p�  � RowDefinitions  5   
   �� 5      $	��100 �6   5      �� 5      $	��100 �6   5      �� 5      $	��100 �6   5      �� 5      $	��100 �6   5      �� 5      5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5    
   �� $��1��6   $��3��6"   $��0��63   $��3��6C    �� Orientation$ Vertical=�6W   $��0,0,0,50q�6n   
�������$	��250��6�   $	��700��6�   $��Center=�6�   $��Center=�6�   5"      �� 5$   
   $��0,0,0,0q�6   $��0��6&   $��6��63   $ Vertical=�6G   $��50��6^   $	��400��6j   .+�5%      �� $��0,0,0,0q�6   $��Center=�6)   $��Center=�6F   $��Normal$�6a   $��24(�6t   
�������Cash Payment6�   5&      �� 5(   
   $��	0,100,0,0q�6   $��0��6(   $��2��65   $��6��6F   $ Vertical=�6Z   $��50��6q   $	��400��6}   .+�5)      �� $��0,0,0,0q�6   $��Center=�6)   $��Center=�6F   $��Normal$�6a   $��16(�6t   
���   �Total Inserted Amount6�   5*      �� 5,   
   $��	0,100,0,0q�6   $��0��6(   $��3��65   $��6��6F   $ Vertical=�6Z   $��50��6q   $	��400��6}   .+�5-      �� $��0,0,0,0q�6   $��Center=�6)   $��Center=�6F   $��Normal$�6a   $��36(�6t   
���   �
₱ 0.006�   5.      �� 50   
   $��	100,0,0,0q�6   $��2��6(   $��3��65   $��0��6F   $ 
Horizontal=�6V   $��50��6o   $
��auto��6{   .+�51      �� $��0,0,0,0q�6   $
��Left=�6)   $��Center=�6E   $��Normal$�6`   $��12(�6s   
���   �$
��Bold"�6�   Total Bill:6�   �� 53      $��10,0,0,0q�6   $
��Left=�6*   $��Center=�6F   $��Normal$�6a   $��12(�6t   
���   �$
��Bold"�6�   ₱ 1,550.006�   54      �� 57   
   $��0,20,0,0q�6   $��3��6'   $��4��64   $��1��6E   $��1��6U   $��Center=�6i   $��Center=�6�   $ 
Horizontal=�6�   .+�58      �� 
������ ���#DEE4F0$��45��6D   $	��100��6P   $��0,0,20,0q�6\   .��59      �� 
�������Cancel5;      5<      �� 5=      ���#DEE4F0���#DEE4F0$��45��6@   $	��100��6L   $��0,0,0,0q�6X   .��5>      �� Done5@      5A      5B      5C      5E      