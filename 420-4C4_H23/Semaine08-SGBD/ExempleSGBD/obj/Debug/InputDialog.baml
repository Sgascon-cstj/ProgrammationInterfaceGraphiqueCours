   M S B A M L   `   `   `  ����B  >Exemple, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ExempleExemple  5   	       Exemple.InputDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Exemple     5   	   -   5          � Title$  InputDialog��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStartupLocation$ CenterScreen=�6<   .��5
      � $��15q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� -   5        $��lblQuestion��5       $��1��6   .��63   	Question:6>   �� 5   
   -   5         ��Name$ 
txtReponse��5      $��1��6&   $��1��66   $	��250��6C   .��6R   	Reponse6[   � 5   
   $��2��6   $��2��6!   $��Right=�65   $��	0 15 0 0 q�6Q   .+�5      �� -   5         ��Name$ btnDialogOk��5       �� 	IsDefault . $��60��6U   $��0 0 10 0q�6c   .��6u   _OK6z   �� 5       �� IsCancel . $��60��6%   .��63   	_Cancel6<   5      5      5      