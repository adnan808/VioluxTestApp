   M S B A M L   `   `   `  ����H  DVioluxTestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VioluxTestAppVioluxTestApp  5   	       VioluxTestApp.Home   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:VioluxTestApp     5   	     � Title$
  Home��5   	   $
��1920��6   $
��1080��6$    � WindowState$ 	Maximized=�61   .��5	      �  � ColumnDefinitions 5   
   �� 5   
   $��* �6   �� 5   
   $��* �6    � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   ]� .+�5      o� $	��Top=�6   .@�5      m� $��	_Settings��6   .@�5      m� -   5        $��
_Com Ports��5      63   5      5      �� 5       �� AcceptsReturn . 6   5       �� 5!   
   -   5        $��btnHWSim��5!      $��Hardware Simulator��6!   $��26,20,25,20q�6>   $��0��6S   $��0��6`   6�   �� 5"   
   -   5        $��
btnTestFix��5"      $��Test Fixture��6#   $��25,20,25,20q�6:   $��0��6O   $��1��6\   6�   �� 5#   
   -   5        $��btnAgingSim��5#      $��Aging Simulator��6$   $��25,20,25,20q�6>   $��1��6S   $��0��6`   6�   �� 5$   
   -   5        $��
btnCmdLine��5$      $��Command Line��6#   $��25,20,25,20q�6:   $��1��6O   $��1��6\   6�   5(      5)      