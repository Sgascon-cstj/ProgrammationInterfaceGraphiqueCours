   M S B A M L   `   `   `  ����B  >Exemple, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ExempleExemple  5          Exemple.UCGestionPart   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Exemple     5        � 	Resources  5	       �� 
TargetType �� Property �� Value �� 
TargetType   EllipseButtonTemplate  RadiusButtonTemplate �� CornerRadius  CustomButtonTemplate �� RadiusX �� RadiusY �� Triggers	 P� Property
 P� Value �� 
TargetName��%�  '��       &	  �     &	 [    &	     �� 5
   
   " ��6   .�5      ��  � ��
 ��  �6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 25��6'   5      �� 5   
   " ��6   .R�5      � .+�5      A� $��ButtonEllipse��6   
��� ���6/   �� 5      #��z��5      $��Center=�5      $��Center=�5      5      5      5      �� 5   
   " ��6   .R�5      � .+�5      �� $��BaseRectangle��6   $ 	10,0,10,0��6.   ._�5      �� $��Center=�6'   $��Center=�6D   5      5       5!      �� 5#   
   " ��67   .R�5$      � .+�5%      �� $��ButtonRectangle��6   
�����_�$ 5��6D   $ 5��6P   �� 5&      $��ButtonTextBlock��6   #��z��63   
�������$��Center=�6g   $��Center=�6�   5'       5(      P� 5)      	 �@J�IsMouseOver
 . . �5*      �� $ ButtonRectangle��6    � ��
 ��  �6J   5+      5-      5.      .��5/      ]� $��10q�50   	   .+�51   
   �� $��Right=�52      $��10,0,0,0q�53      .+�54      �� -   5         ��Name$ btnAdd��54      $��Ajouter��55      #��[  56      57      �� 58      -   5        $ 	btnModify��58      $��Modfier��59      $	��0,5q�5:      #��[ 5;      5<      �� 5=      -   5        $ 	btnDelete��5=      $��	Supprimer��5>      #��[ 5?      5@      �� 5A      -   5        $��btnListView��5A      $��
ListViewUi��6(   $	��0 5q�5B   1   6@   5C      &   System.Windows.Controls.DataGrid  5E   
   -   5        $��dgParticpants��5F      $	��Top=�5H      $
��Left=�5I         AutoGenerateColumns .  
�������   AlternatingRowBackground
 �����   Columns 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Matricule��5O         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5P         
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5Q      �� *	Matricule+5R        5S      $ Prénom��5T      $ 2* 5U       5V      �� *Prenom+  5W      $	 Nom��5X      $ * 5Y       5Z      �� *Nom+  5[      $ Genre��5\      $ * 5]       5^      �� *Genre+  5_      $ Niveau��5`      $ * 5a       5b      �� *Niveau+   RowDetailsTemplate 5h      �� 5i      .R�5j      � .+�5k      �� $��Email: ��6$   65   �� 5l      ��6$   �� *Email+6=   5m      5n      5p      5r      5s      