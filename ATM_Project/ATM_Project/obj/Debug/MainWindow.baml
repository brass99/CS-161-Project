   M S B A M L   `   `   `  ����F  BATM_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ATM_ProjectATM_Project  5   	       ATM_Project.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ATM_Project     5   	     � Title$  
MainWindow��5   	   $	��480��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��74* �6   �� 5      $	��25* �6   .+�5   
   �� -   5         ��Name$ FirstButton��5      $��card_One��5      $��84,10,4,379q�5      $��1��5   +   �� 5   
   -   5        $ SecondButton��5      $��card_Two��5      $��84,75,4,314q�6$   $��1��5   ,   �� 5   
   -   5        $ ThirdButton��5      $��
card_Three��5      $��84,140,4,249q�6&   $��1��5   +   �� 5   
   -   5        $ FourthButton��5      $��	card_Four��5      $��84,205,4,184q�6%   $��1��5   ,   �� 5   
   -   5        $ FifthButton��5      $��	card_Five��5      $��84,270,4,119q�6%   $��1��5   +   �� 5   
   -   5         ��Name$ 
TestingBox��5      $��Testing��5       $��255,211,249,209q�5!       �� TextAlignment$ Center=�5"      �� 5$   
   -   5         ��Name$ PinTitle��5$      $��Please Enter Your PIN��5%      $��243,140,236,284q�61   �� 5'   
   -   5        $ KeyBox��5'      $��255,165,249,258q�6"   $ Center=�5)      �� 5+   
   -	   5        $ StartButton��5+      $��Begin��5,       J� RenderTransformOrigin$ 
0.33,2.067&�5-      $��34,352,470,37q�5.      5/      �� 51   
   -
   5        $ TesterButton��51      $��Info File Test��52      $��34,165,470,224q�53   &   54      55      