   M S B A M L   `   `   `  ����F  BMinesweeper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MinesweeperMinesweeper  5   	       Minesweeper.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Minesweeper     5   	   -   5          �Name$  window��5	   	    � Title$ 
MainWindow��5   	   $	��310��6   $	��260��6)   .��5
      � .+�5   
   �� -   5         ��Name$
 diff��5   �   $
��Easy��6   $
��Left=�6    $��	20,10,0,0q�6;   $	��Top=�6N   $��60��6   6�   �� 5   
   -   5        $
 size��5   �   $��Small��6   $��Center=�6!   $��0,10,0,0q�6>   $	��Top=�6P   $��60��6{   6�   �� 5   
   -   5        $
 play��5   �   $��Start��6   $��Right=�6!   $��	0,10,20,0q�6=   $	��Top=�6P   $��60��6|   6�   � 5   
   -   5         �Name$ gamegrid��5   p   $��	0,40,0,20q�6   $	��240��6"   $	��240��6/   $	��Top=�6;   $��Center=�6S   .+�5      �� -   5         ��Name$ state��5   �   $��Center=�6   $��Center=�61    J� RenderTransformOrigin$ 0.763,0.386&�6L   $y�Visible=�6p   $��82��6�   $	��144��6�   $��Start��6�   $��36(�6�   $��Center=�6�   $��Center=�6�    K� ZIndex$ 1��6  $
��Bold"�6   
���   �5      5      5      5      