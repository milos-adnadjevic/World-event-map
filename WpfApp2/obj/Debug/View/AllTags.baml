   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp2.ViewWpfApp2.View  5   	       WpfApp2.View.AllTags   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp2.View     5   	     � Title$  AllTags��5   	   $	��750��6   $	��430��6&   .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AllTagsBinding��5         
IsReadOnly .    CanUserResizeColumns .    CanUserResizeRows .     AutoGenerateColumns .     VerticalGridLinesBrush
 �����$��0,0,0,40q�6�      	RowHeight$ 30Q�6�    �� SelectedItem 6�   �� *selectedTag+	 �� Mode$	 TwoWay=�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 Name��6%   $
 Auto 6L    63   �� *Name+6L     5      $ Color��6%   $
 Auto 6N    64   �� *Color+6N     5      $ Description��6%   $
 Auto 6]    6:   �� *TagDescription+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ * 6)      CellTemplate 5      �� 5      .R�5      �� -   5        
������ $��0q�5   Q   .��5   "   �� $(��"/WpfApp2;component/Image/edit.png ��6(   $��18��6T   $��18��6`   5      5      5        5      $ * 6)    5      �� 5      .R�5      �� -   5        
������ $��0q�5   M   .��5   "   �� $*��$/WpfApp2;component/Image/delete.png ��6(   $��18��6V   $��18��6b   5      5       5"      5%      �� 5'   
   -   5        $
��Left=�5'      $��	5,680,0,0q�6-   $	��Top=�6@    J� RenderTransformOrigin$ 
0.14,4.795&�6u   
������ $��0q�6�   .��5(      �� $'��!/WpfApp2;component/Image/tag.png ��6   $��30��6?   $��30��6K   5)      �� 5*   
   -   5        $
��Left=�5*      $��
51,680,0,0q�6-   $	��Top=�6A   
������ $��0q�6�   .��5+      �� $(��"/WpfApp2;component/Image/type.png ��6   $��30��6@   $��30��6L   5,      �� 5-   
   -   5        $
��Left=�5-      $��97.5,680,0,0q�6-   $	��Top=�6C   
������ $��0q�6�   .��5.      �� $,��&/WpfApp2;component/Image/addEvent.png ��6   $��30��6D   $��30��6P   5/      �� 50   
   -   5        $
��Left=�50      $��249,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��51      �� $,��&/WpfApp2;component/Image/dataGrid.png ��6   $��30��6D   $��30��6P   52      �� 53   
   -   5        $
��Left=�53      $��190,670,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��54      �� $(��"/WpfApp2;component/Image/home.png ��6   $��40��6@   $��40��6L   55      �� 56   
   -	   5        $
��Left=�56      $��385,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��57      �� $(��"/WpfApp2;component/Image/help.png ��6   $��30��6@   $��30��6L   58      �� 59   
   -
   5        $
��Left=�59      $��346,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5:      �� $*��$/WpfApp2;component/Image/delete.png ��6   $��30��6B   $��30��6N   5;      �� 5<   
   -   5        $
��Left=�5<      $��297.5,680,0,0q�6,   $	��Top=�6C   
������ $��0q�6�   .��5=      �� $(��"/WpfApp2;component/Image/edit.png ��6   $��30��6@   $��30��6L   5>      �� 5?   
   -   5        $
��Left=�5?      $��144,680,0,0q�6,   $	��Top=�6A   
������ $��0q�6�   .��5@      �� $'��!/WpfApp2;component/Image/map.png ��6   $��30��6?   $��30��6K   5A      �� 5C   
   
���   �$��1q�6%   $��Center=�69   $��1��6V   $��	0,670,0,0q�6a   $	��Top=�6t   $	��430��6�   5G      5H      