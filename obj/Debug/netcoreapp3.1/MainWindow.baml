   M S B A M L   `   `   `  ����G  CSideScroller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SideScrollerSideScroller  5   	   7 clr-namespace:SideScroller.viewsSideScroller.views  5   	       SideScroller.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SideScroller     5   	   2views clr-namespace:SideScroller.views     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�5
       � WindowStartupLocation$ CenterScreen=�6(    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��6   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��13* �6   .+�5   
   !   SideScroller.views.gameView  $��0��6   $��1��6)   $��2��66   6L   !   SideScroller.views.menuView  5   
   $��0��6   $��1��6)   $��2��66   6L   �� 5   
   
�������6#   �� 5      $��1��6/   $��0��6?   
����p��
�������
������ $��0q�6�   $��X��6�   ��6   �� *WindowCommand+6�   5      5      