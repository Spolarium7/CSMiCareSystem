   M S B A M L   `   `   `  ����C  ?CSMiCare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CSMiCareCSMiCare  5   	       CSMiCare.PatientsIndex   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CSMiCare     5   	   -   5          �Name$  PatientsIndex��5   	    � Title$ Patients��5   	   $	��499��6   $	��841��6'   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
grPatients��5
      $
��Left=�6'   $	��293��6B   $��	10,63,0,0q�6O   $	��Top=�6b   $	��772��6z      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        grPatientsFullName��,  &System.Windows.Controls.DataGridColumn   CanUserSort .     CanUserReorder .     Header$
 Name��5   �      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� *
FullName+
   ClipboardContentBinding
 6�   Z� 6�     5      -   5        grPatientsAge�� .   .  $	 Age��5   �    . 	 6<   �� *Age+
 6�   Z� 6�     5      -   5        grPatientsGender�� .   .  $ Gender��5   �    . 	 6?   �� *Gender+
 6�   Z� 6�     5      -   5        grPatientsType�� .   .  $
 Type��5   �    . 	 6=   �� *Type+
 6�   Z� 6�   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  ��Name$ btnEdit��6%   -   5        $
��Edit��5   h   y�6L   �� *Edit+6h   5      5        5       5      �� 5      .R�5      �� $ btnConfirmDelete��6%   -   5        $��Delete��5   �   y�6^   �� *ConfirmDeleteButton+6�   5      5      5      �� 5    
   -	   5        $ btnNewPatient��5    z   $��New Patient��6   $
��Left=�6'   $��
654,27,0,0q�6B   $	��Top=�6V   $	��128��6n   6z   �� 5!   
   -
   5        $ btnFirst��5!      $��|<��6#   $
��Left=�63   $��
10,375,0,0q�6N   $	��Top=�6b   $��36��6z   $��38��6�   �� 5"   
   -   5        $ btnPrev��5"      $��<��6"   $
��Left=�61   $��
51,375,0,0q�6L   $	��Top=�6`   $��36��6x   $��38��6�   �� 5#   
   -   5         ��Name$ lblPageDescription��5#      $��Label��6,   $
��Left=�6<   $��
92,381,0,0q�6W   $	��Top=�6k   $��74��6�   �� 5$   
   -   5        $ btnNext��5$      $��>��6"   $
��Left=�61   $��171,375,0,0q�6L   $	��Top=�6a   $��36��6y   $��38��6�   �� 5%   
   -   5        $ btnLast��5%      $��>|��6"   $
��Left=�62   $��212,375,0,0q�6M   $	��Top=�6b   $��36��6z   $��38��6�   �� 5&   
   $��Search��6   $
��Left=�6!   $��	10,24,0,0q�6<   $	��Top=�6O   �� 5'   
   -   5         ��Name$ 	txtSearch��5'   �   $
��Left=�6   $��23��6-   $��	60,27,0,0q�69    �� TextWrapping$
 Wrap=�6L   $�� ��6`   $	��Top=�6h   $	��361��6�   6�   5)      5*      