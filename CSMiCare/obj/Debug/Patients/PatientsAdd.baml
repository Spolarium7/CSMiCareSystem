   M S B A M L   `   `   `  ����C  ?CSMiCare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CSMiCareCSMiCare  5   	       CSMiCare.PatientsAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CSMiCare     5   	   -   5          �Name$  PatientsAdd��5       � Title$ Add Patient��5   	   $��326.712��6   $��752.74��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ 
lblPatient��5
      $��New Patient��6$   $
��Left=�6:   $��	10,29,0,0q�6U   $	��Top=�6h   $��81��6�   $��26��6�   �� 5   
   -   5         ��Name$ txtPatientFirstName��5      $
��Left=�6/   $��23��6J   $��
112,58,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��287��6�   �� 5   
   -   5        $ lblPatientNameLabel��5      $
��Name��6-   $
��Left=�6<   $��	10,55,0,0q�6W   $	��Top=�6j   $��81��6�   $��26��6�   �� 5   
   -   5        $ txtPatientLastName��5      $
��Left=�6.   $��23��6I   $��
418,58,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��287��6�   �� 5   
   -   5        $ lblPatientNameLabel_Copy��5      $��Date of Birth��62   $
��Left=�6J   $��	10,88,0,0q�6e   $	��Top=�6x   $��81��6�   $��26��6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ calPatientDateOfBirth��5      $
��Left=�62   $��
112,93,0,0q�6M   $	��Top=�6a   $	��178��6y   �� 5   
   -   5        $ lblPatientGenderLabel��5      $��Gender��6/   $
��Left=�6@   $��
418,86,0,0q�6[   $	��Top=�6o   $��81��6�   $��26��6�   �� 5   
   -	   5         ��Name$ cboPatientGender��5      $
��Left=�6-   $��
518,86,0,0q�6H   $	��Top=�6\   $	��187��6t   �� 5   
   -
   5        $ lblPatientTypeLabel��5      $
��Type��6-   $
��Left=�6<   $��418,113,0,0q�6W   $	��Top=�6l   $��81��6�   $��26��6�   �� 5   
   -   5        $ cboPatientType��5      $
��Left=�6+   $��518,113,0,0q�6F   $	��Top=�6[   $	��187��6s   �� 5   
   -   5        $ lblSchoolIdLabel��5      $��	School Id��6*   $
��Left=�6>   $��
418,27,0,0q�6Y   $	��Top=�6m   $��81��6�   $��26��6�   �� 5   
   -   5        $ txtPatientSchoolId��5      $
��Left=�6.   $��23��6I   $��
518,27,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��187��6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��453,250,0,0q�6L   $	��Top=�6a   $	��118��6y   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��587,250,0,0q�6P   $	��Top=�6e   $	��118��6}   5      5      