   M S B A M L   `   `   `  ����H  DCarManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CarManagementCarManagement  5   	   > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5   	       CarManagement.AddModel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CarManagement     5   	   .DALclr-namespace:DAL;assembly=DAL     5   	   -   5          � Title$  AddModel��5	   	   $	��450��6   $	��800��6'    � 	Resources 5
         carModelViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��
85,112,0,0q�66   $
��Left=�6J    � DataContext# [  6e    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Engine Size:��6r   �� 5      -   5         ��Name$ engineSizeTextBox��5   *   Engine Size��$	��120��6E   $��Center=�6Q   $��0��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6l   �� *
EngineSize+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6  �� 5      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Manufacturer:��6r   �� 5      -   5        $ manufacturerTextBox��5   +   Manufacturer��$	��120��6H   $��Center=�6T   $��1��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6o   �� *Manufacturer+$ TwoWay=� . 	 . 6  �� 5      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Model:��6r   �� 5       -   5        $ modelTextBox��5    $   	Model��$	��120��6:   $��Center=�6F   $��2��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6a   �� *Model+$ TwoWay=� . 	 . 6�   �� 5!      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��	Model ID:��6r   �� 5"      -   5        $ modelIDTextBox��5"   '   Model ID��$	��120��6?   $��Center=�6K   $��3��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6f   �� *	ModelID+$ TwoWay=� . 	 . 6  �� 5#      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Number Of Seats:��6r   �� 5$      -   5        $ numberOfSeatsTextBox��5$   .   Number of Seats��$	��120��6L   $��Center=�6X   $��4��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6s   �� *NumberOfSeats+$ TwoWay=� . 	 . 6  5%      �� 5&   
   -   5        
 ��Name$
 addCarModel��5&      $��Add Car Model��6&   $��20(�6>   $
��Left=�6L   $��446,156,0,0q�6g   $	��Top=�6|   $	��180��6�   $��71��6�   6�   �� 5'   
   -	   5        $

 back��5'      $��GO BACK��6   $��20(�61   
��� E��$
��Left=�6V   $��446,267,0,0q�6q   $	��Top=�6�   $	��180��6�   $��51��6�   6�   5)      5*      