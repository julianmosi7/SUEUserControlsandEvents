   M S B A M L   `   `   `  ����S  OSUEUserControlsandEvents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MyUserControlsLibMyUserControlsLib  5   	   L HMyUserControlsLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:MyUserControlsLib;assembly=MyUserControlsLibMyUserControlsLib 5   	   "    MyUserControlsLib.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MyUserControlsLib     5   	   XMyUserControlsLib:clr-namespace:MyUserControlsLib;assembly=MyUserControlsLib     5   	   -   5          � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��100* �6   6,   �� 5      $
��100* �6   6,   �� 5      $	��80* �6   6+   �� 5      $	��80* �6   6+   �� 5      $	��30* �6   6+   .+�5   
   $  MyUserControlsLib.UserControl1  -   5        $��SlideProzent��5   )   $��0��6=   $��0��6M   $��2��6Z   $	��Top=�6n   $
��Left=�6�   $��	10,10,0,0q�6�   6�     5   
   -   5        $��SlideUeberschrift��5   )   $��0��6B   $��1��6R   $��2��6_   $	��Top=�6s   $
��Left=�6�   $��	10,10,0,0q�6�   6�      MyUserControlsLib.Equlizer  5   
   -   5        $��
Equalizer1��5   %   $��2��67   $��0��6G   $��2��6T   $��Center=�6e   $��Center=�6�   $��	10,10,0,0q�6�   6�     5    
   -   5        $��
Equalizer2��5    %   $��3��67   $��0��6G   $��2��6T   $��Center=�6e   $��Center=�6�   $��	10,10,0,0q�6�   6�     5!   
   -   5        $��SlideThousand��5!   )   $��0��6>   $��2��6N   $��4��6[   $��Center=�6o   $
��Left=�6�   $��10,3.5,0,45.5q�6�   $��85��6�   $��2��6�   $	��775��6�   6  � 5"   
   -   5        $��Progressbar��5"      $��0��6)   $��4��69   $��3��6F   $��8q�6Z    � Minimum$ 0Q�6e   6s   �� 5#   
   -   5        $��Arrow��5#      $��4��6   $��4��6-   $��2��6:   $��
40,6,100,6q�6N   6d   �� 5$   
   -	   5        $��txtArrow��5$      $��4��6"   $��4��62   $��
130,6,20,6q�6?   $��Center=�6S   $��Center=�6w   6�   5&      5'      