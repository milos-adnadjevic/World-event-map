   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp2.ViewWpfApp2.View  5   	       WpfApp2.View.HelpWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp2.View     5   	     � Title$  
HelpWindow��5   	   $	��750��6   $	��430��6)    � 	Resources 5
         	TitleText �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6"   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Comic Sans MS)�6+   �� 5       � ��$ 14(�6)   5      5      .��5      � .+�5   
   �� #��[  6   $
��Left=�67   $��	10,40,0,0q�6R   
���  ��$��30��6v   $	��Top=�6�   Adding event to map:6�   �� 5   
   $��	10,60,0,0q�6   $��30��6(   $
��Left=�64   $	��Top=�6O   FDIf you want to add event to map, drag that event to map and drop it.6�   �� 5   
   #��[  6   $
��Left=�67   $��	10,80,0,0q�6R   
���  ��$��30��6v   $	��Top=�6�   Delete existing event:6�   �� 5   
   $��
10,100,0,0q�6   $��40��6)   $
��Left=�65   $	��Top=�6P   (&if you want to delete event from table�� 6�   /-select them and press again button to delete.6�   �� 5   
   #��[  6   $
��Left=�67   $��
10,130,0,0q�6R   
���  ��$��30��6w   $	��Top=�6�   Update existing event:6�   �� 5   
   $��
10,150,0,0q�6   $��50��6)   $
��Left=�65   $	��Top=�6P   ECIf you want to update information about some event press that event�� 6�   (&and then press button to update event.6�   �� 5   
   #��[  6   $
��Left=�67   $��
10,180,0,0q�6R   
���  ��$��30��6w   $	��Top=�6�   Search and filter event:6�   �� 5   
   $��
10,200,0,0q�6   $��66��6)   $
��Left=�65   $	��Top=�6P   JHIf you want to find specific event on map or in table go to search field�� 6�   0.and type something about that particular event�� 6�   &$like his name, description, capacity�� 6  OMor you can use filter and fine all event with that name,capacity,description.6z  �� 5   
   #��[  6   $
��Left=�67   $��
10,260,0,0q�6R   
���  ��$��30��6w   $	��Top=�6�   Remove event from map:6�   �� 5   
   $��
10,280,0,0q�6   $��96��6)   $
��Left=�65   $	��Top=�6P   .,If you want to add event on map or remove it�� 6�   <:press that event and drag it to location where you want it�� 6�   then release it,�� 6�   FDif you want additional information press that event with right click�� 5   R   if you on map,�� 6m   ,*or with double left click if you on table.5    9   �� 5"   
   #��[  6   $
��Left=�67   $��
10,376,0,0q�6R   
���  ��$��30��6w   $	��Top=�6�   Delete existing tag:6�   �� 5#   
   $��
10,400,0,0q�6   $��30��6)   $
��Left=�65   $	��Top=�6P   &$If you want to delete tag from table�� 6�   /-select them and press again button to delete.6�   �� 5$   
   #��[  6   $
��Left=�67   $��
10,430,0,0q�6R   
���  ��$��30��6w   $	��Top=�6�   Update existing tag:6�   �� 5%   
   $��
10,450,0,0q�6   $��30��6)   $
��Left=�65   $	��Top=�6P   A?If you want to update information about some tag press that tag�� 6�   &$and then press button to update tag.6�   �� 5'   
   #��[  6   $
��Left=�67   $��
10,480,0,0q�6R   
���  ��$��30��6w   $	��Top=�6�   Delete existing type:6�   �� 5(   
   $��
10,500,0,0q�6   $��30��6)   $
��Left=�65   $	��Top=�6P   '%If you want to delete type from table�� 6�   /-select them and press again button to delete.6�   �� 5)   
   #��[  6   $
��Left=�67   $��
10,530,0,0q�6R   
���  ��$��30��6w   $	��Top=�6�   Update existing type:6�   �� 5*   
   $��
10,550,0,0q�6   $��30��6)   $
��Left=�65   $	��Top=�6P   CAIf you want to update information about some type press that type�� 6�   '%and then press button to update type.6�   �� 5-   
   -   5        $
��Left=�5-      $��	5,680,0,0q�6-   $	��Top=�6@    J� RenderTransformOrigin$ 
0.14,4.795&�6u   
������ $��0q�6�   .��5.      �� $'��!/WpfApp2;component/Image/tag.png ��6   $��30��6?   $��30��6K   5/      �� 50   
   -   5        $
��Left=�50      $��
51,680,0,0q�6-   $	��Top=�6A   
������ $��0q�6�   .��51      �� $(��"/WpfApp2;component/Image/type.png ��6   $��30��6@   $��30��6L   52      �� 53   
   -   5        $
��Left=�53      $��97.5,680,0,0q�6-   $	��Top=�6C   
������ $��0q�6�   .��54      �� $,��&/WpfApp2;component/Image/addEvent.png ��6   $��30��6D   $��30��6P   55      �� 56   
   -   5        $
��Left=�56      $��249,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��57      �� $,��&/WpfApp2;component/Image/dataGrid.png ��6   $��30��6D   $��30��6P   58      �� 59   
   -   5        $
��Left=�59      $��190,670,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5:      �� $(��"/WpfApp2;component/Image/home.png ��6   $��40��6@   $��40��6L   5;      �� 5<   
   -   5        $
��Left=�5<      $��385,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5=      �� $(��"/WpfApp2;component/Image/help.png ��6   $��30��6@   $��30��6L   5>      �� 5?   
   -   5        $
��Left=�5?      $��346,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5@      �� $*��$/WpfApp2;component/Image/delete.png ��6   $��30��6B   $��30��6N   5A      �� 5B   
   -   5        $
��Left=�5B      $��297.5,680,0,0q�6,   $	��Top=�6C   
������ $��0q�6�   .��5C      �� $(��"/WpfApp2;component/Image/edit.png ��6   $��30��6@   $��30��6L   5D      �� 5E   
   -	   5        $
��Left=�5E      $��144,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5F      �� $'��!/WpfApp2;component/Image/map.png ��6   $��30��6?   $��30��6K   5G      �� 5H   
   
���   �$��1q�6%   $��Center=�69   $��1��6V   $��	0,670,0,0q�6a   $	��Top=�6t   $	��430��6�   5J      5M      