   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp2.ViewWpfApp2.View  5   	       WpfApp2.View.MapWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp2.View     5   	     � Title$  	MapWindow��5   	   $	��750��6   $	��430��6(   .��5	      � .+�5
   
   � $��Center=�6   $	��Top=�6,   $��0,31,0,0q�6D   $	��430��6V   $	��640��6b    � RowDefinitions 5      �� 5       � ColumnDefinitions 5      �� 5      $	��320 �6#   �� 5      $	��110 �6#   .+�5      �� -   5         ��Name$ ListBox��5   �   $��1��6   $��0��6'   $��Right=�6�   $	��Top=�6�   $��0,0,0,0q�6�   $	��640��6  $	��110��6I   J� 	AllowDrop . ��64   �� *Events+��5      �� 5      .R�5      � .+�5      �� $��20��6$   $��20��6/   ��6;   �� *	ImagePath+�� 5      ��6(   �� *Name+5      5      5      �� 5      -   5         ��Name$ canvas��5      $��0��6&   $��0��66   
������  . $	��640��5   ;   $	��320��6H   .+�5!      �� -   5         ��Name$ image��5!   �   $
��Fill=�6   $	��640��6'   $	��320��64   $��0��6@   $��0��6P    . $,��&/WpfApp2;component/Image/worldMap.png ��6o   6�   5"      �� 5%      -   5        $ ListViewOnMap��5%   �   $��Right=�6�   $	��Top=�6�   $��0,0,0,0q�6�   $��0��6  $��0��6  ��6   �� *EventsOnMap+��5&      �� 5'      .R�5(      � .+�5)      �� $��0��6$   $��0��6.   ��69   �� *	ImagePath+�� 5*      $��0��6?   $��0��6I   ��6(   �� *Name+6I   5+      5,      5.      5/      �� 51   
   $��Filter:��6   $��13(�6#   $��40��61   $��25��6<   $��5,1,0,0q�6H   $
��Left=�6Y   $	��Top=�6t   �� 52   
   -   5         ��Name$ FilterBinding��52   x   $
��Left=�6   $��56,7,0,0q�6-    �� TextWrapping$
 Wrap=�6?   $	��Top=�6S   $	��120��6k   6�   �� 58   
   -   5        $
��Left=�58      $��	5,680,0,0q�6-   $	��Top=�6@   	 J� RenderTransformOrigin$	 
0.14,4.795&�6u   
������ $��0q�6�   .��59      �� $'��!/WpfApp2;component/Image/tag.png ��6   $��30��6?   $��30��6K   5:      �� 5;   
   -   5        $
��Left=�5;      $��
51,680,0,0q�6-   $	��Top=�6A   
������ $��0q�6�   .��5<      �� $(��"/WpfApp2;component/Image/type.png ��6   $��30��6@   $��30��6L   5=      �� 5>   
   -   5        $
��Left=�5>      $��97.5,680,0,0q�6-   $	��Top=�6C   
������ $��0q�6�   .��5?      �� $,��&/WpfApp2;component/Image/addEvent.png ��6   $��30��6D   $��30��6P   5@      �� 5A   
   -	   5        $
��Left=�5A      $��249,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5B      �� $,��&/WpfApp2;component/Image/dataGrid.png ��6   $��30��6D   $��30��6P   5C      �� 5D   
   -
   5        $
��Left=�5D      $��190,670,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5E      �� $(��"/WpfApp2;component/Image/home.png ��6   $��40��6@   $��40��6L   5F      �� 5G   
   -   5        $
��Left=�5G      $��385,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5H      �� $(��"/WpfApp2;component/Image/help.png ��6   $��30��6@   $��30��6L   5I      �� 5J   
   -   5        $
��Left=�5J      $��346,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5K      �� $*��$/WpfApp2;component/Image/delete.png ��6   $��30��6B   $��30��6N   5L      �� 5M   
   -   5        $
��Left=�5M      $��297.5,680,0,0q�6,   $	��Top=�6C   
������ $��0q�6�   .��5N      �� $(��"/WpfApp2;component/Image/edit.png ��6   $��30��6@   $��30��6L   5O      �� 5P   
   -   5        $
��Left=�5P      $��144,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5Q      �� $'��!/WpfApp2;component/Image/map.png ��6   $��30��6?   $��30��6K   5R      �� 5S   
   
���   �$��1q�6%   $��Center=�69   $��1��6V   $��	0,670,0,0q�6a   $	��Top=�6t   $	��430��6�   5U      5V      