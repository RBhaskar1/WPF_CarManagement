   M S B A M L   `   `   `  ����H  DCarManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CarManagementCarManagement  5   	   > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5   	       CarManagement.AddCar   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CarManagement     5   	   .DALclr-namespace:DAL;assembly=DAL     5   	   -   5          � Title$  AddCar��5	   	   $	��450��6   $	��800��6%    � 	Resources 5
         individualCarViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��	89,62,0,0q�66   $
��Left=�6I    � DataContext# [  6d    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��
Body Type:��6r   �� 5       -   5         ��Name$ body_TypeTextBox��5    (   	Body Type��$	��120��6B   $��Center=�6N   $��0��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6
  ��6i   �� *	Body_Type+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6
  �� 5#      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Colour:��6r   �� 5$      -   5        $ colourTextBox��5$   %   
Colour��$	��120��6<   $��Center=�6H   $��2��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6c   �� *Colour+$ TwoWay=� . 	 . 6  �� 5%      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Current Mileage:��6r   �� 5&      -   5        $ current_MileageTextBox��5&   &   Mileage��$	��120��6F   $��Center=�6R   $��3��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6m   �� *Current_Mileage+$ TwoWay=� . 	 . 6  �� 5'      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Date Imported:��6r   �� 5(      -   5        $ date_ImportedTextBox��5(   ,   Date Imported��$	��120��6J   $��Center=�6V   $��4��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6q   �� *Date_Imported+$ TwoWay=� . 	 . 6  �� 5)      $��Center=�6   $��5��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Manufacture Year:��6r   �� 5*      -   5        $ manufacture_YearTextBox��5*   #   Year��$	��120��6D   $��Center=�6P   $��5��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6k   �� *Manufacture_Year+$ TwoWay=� . 	 . 6  �� 5+      $��Center=�6   $��6��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��	Model ID:��6r   �� 5,      -   5        $ model_IDTextBox��5,   '   Model ID��$	��120��6@   $��Center=�6L   $��6��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6g   �� *
Model_ID+$ TwoWay=� . 	 . 6  �� 5-      $��Center=�6   $��7��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Status:��6r   �� 5.      -	   5        $ statusTextBox��5.   %   
Status��$	��120��6<   $��Center=�6H   $��7��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6c   �� *Status+$ TwoWay=� . 	 . 6  �� 5/      $��Center=�6   $��8��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Transmission:��6r   �� 50      -
   5        $ transmissionTextBox��50   +   Transmission��$	��120��6H   $��Center=�6T   $��8��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6o   �� *Transmission+$ TwoWay=� . 	 . 6  51      �� 52   
   -   5        $��	submitCar��52      $��ADD INDIVIDUAL CAR��6"   $��20(�6?   $
��Left=�6M   $��421,157,0,0q�6h   $	��Top=�6}   $	��252��6�   $��78��6�   6�   �� 53   
   -   5        
 ��Name$

 back��53      $��GO BACK��6   
��� E��$
��Left=�6H   $��480,256,0,0q�6c   $	��Top=�6x   $	��140��6�   $��42��6�   6�   55      56      