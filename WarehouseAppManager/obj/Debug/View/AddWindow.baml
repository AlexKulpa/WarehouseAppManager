   M S B A M L   `   `   `  ����N  JWarehouseAppManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WarehouseAppManager.ViewWarehouseAppManager.View  5   	   M+clr-namespace:WarehouseAppManager.ViewModelWarehouseAppManager.ViewModel  5	   	   (    "WarehouseAppManager.View.AddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   2local&clr-namespace:WarehouseAppManager.View  5   	   4vm+clr-namespace:WarehouseAppManager.ViewModel  5	   	   -   5          �Name$  
add_window��5   	    � Title$ 	AddWindow��5   	   $	��556��6   $	��450��6(    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $��1q�5   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5      3  -WarehouseAppManager.ViewModel.AddingViewModel   addingVM��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      .+�5$   
   �� $��0��6   $��0��6   $��2��6-   $��Center=�5%      $��Center=�6+   $��40(�5&      $��	DODAWANIE��5'      �� 5)   
   $��1��6   $��0��6   $��Center=�5*      $��30(�5+      $��5q�5,      $��Nazwa��5-      �� 5.   
   $��1��6   $��1��6   $��Center=�5/      $��Center=�50      $��5q�51      $��30(�52      �� 54   
   $��2��6   $��0��6   $��Center=�55      $��30(�56      $��5q�57      $��Ilość��58      �� 59   
   $��2��6   $��1��6   $��Center=�5:      $��Center=�5;      $��5q�5<      $��30(�5=      �� 5?   
   $��3��6   $��0��6   $��Center=�5@      $��30(�5A      $��5q�5B      $��	Jednostka��5C      �� 5D   
   $��3��6   $��1��6   $��Center=�5E      $��Center=�5F      $��5q�5G      $��30(�5H      �� 5J   
   $��4��6   $��0��6   $��Center=�5K      $��30(�5L      $��5q�5M      $��Regał��5N      �� 5O   
   $��4��6   $��1��6   $��Center=�5P      $��Center=�5Q      $��5q�5R      $��30(�5S      �� 5U   
   $��5��6   $��0��6   $��Center=�5V      $��30(�5W      $��5q�5X      $��Id Pracownika��5Y      �� 5Z   
   $��5��6   $��1��6   $��Center=�5[      $��Center=�5\      $��5q�5]      $��30(�5^      �� 5`   
   $��6��6   $��1��6   $��Center=�5a      $��Center=�5b      $��30(�5c      $��5q�5d      $��Dodaj��5e      ��5f      �� *DodajTowarDoBazy+��5g      �� 	 �� ElementName$	 
add_window��5h      5i      5j      