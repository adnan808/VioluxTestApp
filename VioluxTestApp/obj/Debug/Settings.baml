   M S B A M L   `   `   `  ����H  DVioluxTestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VioluxTestAppVioluxTestApp  5   	       VioluxTestApp.Settings   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:VioluxTestApp     5   	     � Title$  Settings��5   	   $	��300��6   $	��290��6'    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6X   .��5	      � .+�5
   
   �� $	��300��6   $
��Left=�6!   $��0��6<   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��ESP32 Test Fixture��6   $��10,5,0,0q�62   $	��120��6D   $
��Left=�6P   6m   �� 5      -   5        $��cmbESP32TestFixture��5      $	��124��63   $��20��6?    �� SelectedIndex$ 0��6K   5      5      �� 5      $ 
Horizontal=�6   .+�5      �� $��ESP32 Program��6   $��10,5,0,0q�61   $	��120��6C   $
��Left=�6O   6l   �� 5      -   5        $��cmbESP32Prg��5      $	��124��6/   $��20��6;   $ 0��6G   5      5      �� 5      $ 
Horizontal=�6   .+�5      �� $��MSP430 Program 1��6   $��10,5,0,0q�64   $	��120��6F   $
��Left=�6R   6o   �� 5      -   5        $��cmbMSP430Prg1��5      $	��124��61   $��20��6=   $ 0��6I   5      5      �� 5!      $ 
Horizontal=�6   .+�5"      �� $��MSP430 Program 2��6   $��10,5,0,0q�64   $	��120��6F   $
��Left=�6R   6o   �� 5#      -   5        $��cmbMSP43oPrg2��5#      $	��124��61   $��20��6=   $ 0��6I   5%      5&      �� 5(      $ 
Horizontal=�6   .+�5)      �� -   5        $��btnSave��5)      $
��Save��6(   $	��100��67   $��	50,10,5,0q�6C   6n   �� 5*      -   5        $��	btnCancel��5*      $��Cancel��6*   $	��100��6;   $��0,10,0,0q�6G   6s   5+      5-      5.      5/      