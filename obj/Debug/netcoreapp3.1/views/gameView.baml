   M S B A M L   `   `   `  ����G  CSideScroller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SideScroller.viewsSideScroller.views  5      !    SideScroller.views.gameView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc4wpfanimated"http://wpfanimatedgif.codeplex.com  5      ,local clr-namespace:SideScroller.views  5      -   5           
SharedGame  � DataContext#  [  5
      .��5      �� .+�5   
   �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ ../images/Desert.gif��6      RepeatBehavior$ 1��5         AnimateInDesignMode$
 true��5         	AutoStart$
 True��5      $��-157,-74,-226,-79q�6?    �� Left$
 -153��6Z   
 �� Top$ 91��6m   $	��433��6}   �� 5   
   -   5         ��Name$ playerHitbox��5      $	��100��6*   $��50��66   $	 152��6B    6T   �� * PlayerCoordinates.PlayerHitbox+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5   
   $E ?C:\Users\chri45n5\Source\Repos\SideScrollerGame\images\bird.gif��6   $ 1��5      $
 true��5      $
 True��5      $��-28,92,533,79q�6?   $	 120��6V    6h   �� * PlayerCoordinates.CoordinatesY+$ TwoWay=�$	 PropertyChanged=��� 5   
   ��6   �� 
 �� Path$
 ActiveBlockades�$	 PropertyChanged=�$ OneWay=���5      �� 5      .R�5      �� $	��432��6   $
��1093��6*   .+�5      �� $ blockade��6$    �� Bottom$ 0��6   $��30��6�    66   �� *
Position.X+$	 PropertyChanged=���6�   �� *Height+6�   �� 5      $
��Fill=�6    $ 0��6�   $��80��6�   ��6/   �� *	Texture+ 6J   �� *
Position.X+$	 PropertyChanged=���6�   �� *Height+6�   5      5      5      �� 5    
    �� TextAlignment$ Center=�6   $��30(�6+   $��76��6�   $	��799��6�   $ 16��6�   ��69   �� *Player.CurrentScore+$	 PropertyChanged=�$ OneWay=�6�   5!      5"      