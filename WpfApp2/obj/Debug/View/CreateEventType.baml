   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp2.ViewWpfApp2.View  5   	   9!clr-namespace:WpfApp2.ValidationsWpfApp2.Validations  5   	   "    WpfApp2.View.CreateEventType   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp2.View     5   	   1val!clr-namespace:WpfApp2.Validations     5   	   -   5          � Title$  CreateEventType��5	   	   $	��750��6!   $	��430��6.   .��5
      � .+�5   
   �� $	��Id:��6   $��	65,10,0,0q�6   $	��Top=�62   $
��Left=�6J   $��15(�6e   �� 5   
   -   5         ��Name$ 	IdBinding��5   y   $
��Left=�6   $��	65,35,0,0q�6-    �� TextWrapping$
 Wrap=�6@   $	��Top=�6T   $	��300��6l   .��6�   ��5      �� 5       �� Path$ TypeIdValidation�6    �� UpdateSourceTrigger$ 	LostFocus=�62    �� ValidationRules 5      *   $WpfApp2.Validations.TypeIdValidation  5      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6/   5      .��5       =� ErrorTemplate 5      �� 5      .R�5      �  � RowDefinitions 5      �� 5      	 � ColumnDefinitions	 5      �� 5      �� 5      $
��Auto �6/   .+�5!      �� 
 ��Name$
 textBox��6Q   $��0��64   $��0��6D   6Q   �� 5"      $��1��6(   $��0��68   
���  ����6E   �� *[0].ErrorContent+6g   5#      5$      .��5%   (   5&      �� 5)   
   $��Name:��6   $��	65,60,0,0q�6!   $	��Top=�64   $
��Left=�6L   $��15(�6g   �� 5*   
   -   5        $ NameBinding��5*   y   $
��Left=�6   $��	65,85,0,0q�6-   $
 Wrap=�6@   $	��Top=�6T   $	��300��6l   .��6�   ��5+      �� 5,      $ TypeNameValidation�6   $ 	LostFocus=�64    5-      ,   &WpfApp2.Validations.TypeNameValidation  5.      $ RawProposedValue=�61   50      .��51       52      �� 53      .R�54      �  55      �� 56      	 58      �� 59      �� 5:      $
��Auto �6/   .+�5=      �� $
 textBox��6Q   $��0��64   $��0��6D   6Q   �� 5>      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   5?      5@      .��5A   (   5B      �� 5C   
   -   5         ��Name$ ImageBinding��5C      $��30��6&   $��30��62   $��
65,110,0,0q�6=   $
��Left=�6Q   $	��Top=�6l   �� 5D   
   $��150,160,0,0q�6   $��20��6)   $	��200��65   $
��Left=�6B   $	��Top=�6]   �� 5E   
   -   5        .�5E   -   Upload your picture5G      5H      �� 5K   
   -   5        $��Submit��5K   �   $��Submit��6   $
��Left=�6"   $��
65,185,0,0q�6=   $	��Top=�6Q   $	��300��6i   $
��Save��6�    J� CommandBindings 5L      )  #System.Windows.Input.CommandBinding  5M      -   5           Command$
 Save��5M   !   60   ��5O      �� 5P       �� 
TargetType" ��6   .�5Q      ��  �� Property � {� �� Value .  62    �� Triggers 5R      ^� 5S       ^� 
Conditions 5T      �� 5U   "    �� Binding 6,   �� $ (Validation.HasError)� �� ElementName$ 	IdBinding�� �� Value	 False6r   �� 5V   "    6,   �� $ (Validation.HasError)�$ NameBinding��	 False6t   .0�5X      ��  � {� . 6:   5Y      5[      5]      �� 5_   
   -   5        $
��Left=�5_      $��	5,680,0,0q�6-   $	��Top=�6@    J� RenderTransformOrigin$ 
0.14,4.795&�6u   
������ $��0q�6�   .��5`      �� $'��!/WpfApp2;component/Image/tag.png ��6   $��30��6?   $��30��6K   5a      �� 5b   
   -	   5        $
��Left=�5b      $��
51,680,0,0q�6-   $	��Top=�6A   
������ $��0q�6�   .��5c      �� $(��"/WpfApp2;component/Image/type.png ��6   $��30��6@   $��30��6L   5d      �� 5e   
   -
   5        $
��Left=�5e      $��97.5,680,0,0q�6-   $	��Top=�6C   
������ $��0q�6�   .��5f      �� $,��&/WpfApp2;component/Image/addEvent.png ��6   $��30��6D   $��30��6P   5g      �� 5h   
   -   5        $
��Left=�5h      $��249,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5i      �� $,��&/WpfApp2;component/Image/dataGrid.png ��6   $��30��6D   $��30��6P   5j      �� 5k   
   -   5        $
��Left=�5k      $��190,670,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5l      �� $(��"/WpfApp2;component/Image/home.png ��6   $��40��6@   $��40��6L   5m      �� 5n   
   -   5        $
��Left=�5n      $��385,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5o      �� $(��"/WpfApp2;component/Image/help.png ��6   $��30��6@   $��30��6L   5p      �� 5q   
   -   5        $
��Left=�5q      $��346,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5r      �� $*��$/WpfApp2;component/Image/delete.png ��6   $��30��6B   $��30��6N   5s      �� 5t   
   -   5        $
��Left=�5t      $��297.5,680,0,0q�6,   $	��Top=�6C   
������ $��0q�6�   .��5u      �� $(��"/WpfApp2;component/Image/edit.png ��6   $��30��6@   $��30��6L   5v      �� 5w   
   -   5        $
��Left=�5w      $��144,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5x      �� $'��!/WpfApp2;component/Image/map.png ��6   $��30��6?   $��30��6K   5y      �� 5z   
   
���   �$��1q�6%   $��Center=�69   $��1��6V   $��	0,670,0,0q�6a   $	��Top=�6t   $	��430��6�   5|      5}      