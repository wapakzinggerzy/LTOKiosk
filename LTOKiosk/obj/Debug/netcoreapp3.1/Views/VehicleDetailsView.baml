   M S B A M L   `   `   `  ����C  ?LTOKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LTOKiosk.ViewsLTOKiosk.Views  5      /clr-namespace:LTOKiosk.ClassLTOKiosk.Class  5      9!clr-namespace:LTOKiosk.ViewModelsLTOKiosk.ViewModels  5      /clr-namespace:LTOKiosk.ViewsLTOKiosk.Views  5	      '    !LTOKiosk.Views.VehicleDetailsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:LTOKiosk.Views     5      1vehiclesclr-namespace:LTOKiosk.Class     5      8
viewmodels!clr-namespace:LTOKiosk.ViewModels     5      .viewsclr-namespace:LTOKiosk.Views     5	      .��5      � -   5        
���p�  � RowDefinitions  5   
   �� 5      $	��100 �6   5      �� 5      $	��200 �6   5      �� 5      $��50 �6   5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0,0,0,0q�6   $��0��6&   $��2��63    �� Orientation$ Vertical=�6G   $��50��6^   $	��400��6j   .+�5      �� $��0,0,0,0q�6   $��Center=�6)   $��Center=�6F   $��Normal$�6a   $��24(�6t   
�������Confirm Details6�   5      �� 5   
   $��1��6   
�������$ Vertical=�66   $��0,0,0,0q�6M   $	��200��6^   $	��200��6k   $��Right=�6w   .+�5      �� $��Plate Number:��6   $��Right=�6,   6J   �� 5      $��MV File Number:��6   $��Right=�6.   6L   �� 5       $��Vehicle Type:��6   $��Right=�6,   6J   �� 5!      $��LTO MV Type:��6   $��Right=�6+   6I   �� 5"      $��Owner:��6   $��0,20,0,0q�6%   $��Right=�67   6U   �� 5#      $��Address:��6   $��Right=�6'   6E   5$      �� 5%   
   $��1��6   
�������$��2��66   $��Center=�6F   $ Vertical=�6a   $��0,0,0,0q�6x   $	��200��6�   $	��200��6�   $
��Left=�6�   .+�5&      �� -   5        $��plate_number��5&      $��Plate Number:��6(   $
��Left=�6@   6]   �� 5'      -   5        $��mv_file_number��5'      $��MV File Number:��6*   $
��Left=�6D   6a   �� 5(      -   5        $��chassis_number��5(      $��Vehicle Type:��6*   $
��Left=�6B   6_   �� 5)      -   5        $��mv_type��5)      $��LTO MV Type:��6#   $
��Left=�6:   6W   �� 5*      -   5        $
��name��5*      $
��name��6    $��0,20,0,0q�6/   $
��Left=�6A   6^   �� 5,      -   5        $��address��5,      $��LTO MV Type:��6#   $
��Left=�6:   6W   5-      �� 5.   
   $��2��6   $��0��6"   $��2��63   $��0,10,0,0q�6G   $ 
Horizontal=�6Y   $��Center=�6r   .+�5/      �� $��0,0,25,0q�6   $
��Auto��6'   $	��100��65   
������ ���#DEE4F0.��50      �� 
�������Cancel52      53      �� 54      -   5        $��0,0,0,0q�54      $
��Auto��6&   $	��100��64   ���#DEE4F0���#DEE4F0.��55      �� 
Continue57      58      59      5;      5<      