   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp2.ViewWpfApp2.View  5   	       WpfApp2.View.AllEvents   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp2.View     5   	   -   5          � Title$  	AllEvents��5   	   $	��750��6   $	��430��6(   .��5	      � $��0,24,0,0q�6   .+�5   
   �� -   5        $��Search��5      $
��Left=�6    $��
10,-23,0,0q�6;   $	��Top=�6O   $
��Auto��6g   $��18��6�   $��0q�6�   
������ .��5   
   �� $*��$/WpfApp2;component/Image/search.png ��6   $��18��6>   $��18��6J   5      �� 5   
   $��Filter:��6   $��253,-28,0,0q�6"   $��13(�67   �� 5   
   -   5         ��Name$ FilterBinding��5   {   $
��Left=�6   $��290,-23,0,0q�6-    �� TextWrapping$
 Wrap=�6B   $	��Top=�6V   $	��120��6n   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ AllEventsBinding��5         
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .     AutoGenerateColumns .     VerticalGridLinesBrush
 �����$��	0,0,0,100q�6  	   	RowHeight$	 30Q�62  
 �� SelectedItem
 6�   �� *selectedEvent+ �� Mode$ TwoWay=�   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Icon��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 35 68      CellTemplate 5      �� 5      .R�5      �� $��30��6$   $��30��6/   ��6;   �� *	ImagePath+5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $
 Name��6%   $
 Auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     5      $ Description��6%   $	 100 6Z    6:   �� *Description+6Z     5      $
 Type��6%   $
 Auto 6Q    63   �� *	Type.Name+6Q     5      $ Capacity��6%   $
 Auto 6T    67   �� *
Capacity+6T     5!      $ * 6)    5"      �� 5#      .R�5$      �� -   5        
������ $��0q�5$   Q   .��5%   "   �� $(��"/WpfApp2;component/Image/edit.png ��6(   $��18��6T   $��18��6`   5&      5'      5)        5*      $ * 6)    5+      �� 5,      .R�5-      �� -   5        
������ $��0q�5-   M   .��5.   "   �� $*��$/WpfApp2;component/Image/delete.png ��6(   $��18��6V   $��18��6b   5/      50      52      55      �� 58   
   $��All event tags:��6   $��
10,615,0,0q�6*   $��15(�6>   $	��Top=�6L   $
��Left=�6d   �� 59   
   -   5         ��Name$ AllTags��59   �   $
��Left=�6   $��120,615,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5:      �� $,��&/WpfApp2;component/Image/dataGrid.png ��6   $��30��6D   $��30��6P   5;      �� 5=   
   $��All event type:��6   $��
0,615,50,0q�6*   $��15(�6>   $	��Top=�6L   $��Right=�6d   �� 5>   
   -   5        $ AllTypes��5>   �   $��Right=�6   $��
0,615,10,0q�6-   $	��Top=�6A   
������ $��0q�6�   .��5?      �� $,��&/WpfApp2;component/Image/dataGrid.png ��6   $��30��6D   $��30��6P   5@      �� 5C   
   -	   5        $
��Left=�5C      $��	5,656,0,0q�6-   $	��Top=�6@    J� RenderTransformOrigin$ 
0.14,4.795&�6u   
������ $��0q�6�   .��5D      �� $'��!/WpfApp2;component/Image/tag.png ��6   $��30��6?   $��30��6K   5E      �� 5F   
   -
   5        $
��Left=�5F      $��
51,656,0,0q�6-   $	��Top=�6A   
������ $��0q�6�   .��5G      �� $(��"/WpfApp2;component/Image/type.png ��6   $��30��6@   $��30��6L   5H      �� 5I   
   -   5        $
��Left=�5I      $��97.5,656,0,0q�6-   $	��Top=�6C   
������ $��0q�6�   .��5J      �� $,��&/WpfApp2;component/Image/addEvent.png ��6   $��30��6D   $��30��6P   5K      �� 5L   
   -   5        $
��Left=�5L      $��249,656,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5M      �� $,��&/WpfApp2;component/Image/dataGrid.png ��6   $��30��6D   $��30��6P   5N      �� 5O   
   -   5        $
��Left=�5O      $��190,646,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5P      �� $(��"/WpfApp2;component/Image/home.png ��6   $��40��6@   $��40��6L   5Q      �� 5R   
   -   5        $
��Left=�5R      $��385,656,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5S      �� $(��"/WpfApp2;component/Image/help.png ��6   $��30��6@   $��30��6L   5T      �� 5U   
   -   5        $
��Left=�5U      $��346,656,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5V      �� $*��$/WpfApp2;component/Image/delete.png ��6   $��30��6B   $��30��6N   5W      �� 5X   
   -   5        $
��Left=�5X      $��297.5,656,0,0q�6,   $	��Top=�6C   
������ $��0q�6�   .��5Y      �� $(��"/WpfApp2;component/Image/edit.png ��6   $��30��6@   $��30��6L   5Z      �� 5[   
   -   5        $
��Left=�5[      $��144,656,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5\      �� $'��!/WpfApp2;component/Image/map.png ��6   $��30��6?   $��30��6K   5]      �� 5^   
   
���   �$��1q�6%   $��Center=�69   $��1��6V   $��	0,646,0,0q�6a   $	��Top=�6t   $	��430��6�   5b      5c      