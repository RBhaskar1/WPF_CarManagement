   M S B A M L   `   `   `  ����H  DCarManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CarManagementCarManagement  5   	   > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5   	       CarManagement.AddFeature   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CarManagement     5   	   .DALclr-namespace:DAL;assembly=DAL     5   	   -   5          � Title$  
AddFeature��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
         carFeatureViewSource  individualCarViewSource��%:   &	        &	      �� 5   
   6   �� 5   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��252,110,0,0q�66   $
��Left=�6K    � DataContext# [  6f    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Car Feature Description:��6r   �� 5      -   5         ��Name$$ car_Feature_DescriptionTextBox��5   2   Feature Description��$	��120��6Z   $��Center=�6f   $��0��6�   $��3q�6�   $��23��6	  $
��Left=�6  $��1��60  ��6�   �� *Car_Feature_Description+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 60  5      �� 5   
   -   5        
 ��Name$
 
CarFeature��5      $��Add Car Feature��6%   $
��Left=�6?   $��272,194,0,0q�6Z   $	��Top=�6o   $	��214��6�   $��39��6�   6�   �� 5   
   -   5        $

 back��5      $��GO BACK��6   
��� E��$
��Left=�6H   $��314,256,0,0q�6c   $	��Top=�6x   $	��140��6�   $��42��6�   6�   � 5    
   -   5        $ grid2��5       # [ 6   $
��Left=�6U   $��252,148,0,0q�6p   $	��Top=�6�    5!      �� 5"      $
��Auto �6#   $	��144��60   �� 5#      $
��Auto �6#   $��134.4��60    5%      �� 5&      $
��Auto �6    .+�5(      �� $��Car ID:��6   $��0��6&   $
��Left=�66   $��	3,4,0,3.8q�6Q   $��0��6d   $��Center=�6q   $��25��6�   $��45��6�   �� 5)      -   5        $ carIDTextBox��5)   %   
Car ID��$��1��6;   $
��Left=�6K   $��23��6f   $��	2,5,0,4.8q�6r   $��0��6�   $��Center=�6�   $	��120��6  ��6�   �� *CarID+$ TwoWay=� . 	 . 6  5*      5,      5-      