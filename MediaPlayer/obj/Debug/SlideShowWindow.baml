   M S B A M L   `   `   `  ����F  BMediaPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MediaPlayerMediaPlayer  5   	   !    MediaPlayer.SlideShowWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MediaPlayer     5   	     � Title$  Player��5   	   $	��300��6   $	��300��6%    � Icon$ Images/device.png��61    � SizeToContent$ WidthAndHeight=�6J    � 	Resources 5
       
  FadeIn g� Duration �� TargetProperty W� From	 W� To  FadeOut��%�   &	        &	 h     �� 5   
   .��5      W� $ 0:0:.25D�6   $ Opacity�61   $ 0X�6U   $ 1X�6^   5      �� 5   
   .��5      W� $ 0:0:.5D�6   $ Opacity�60   $ 0X�6T   5      5      .��5      �� $
��1024��6   $	��768��6   .+�5   
   �� -   5         ��Name$ myImage��5      $��UniformToFill=�6!   	 J� RenderTransformOrigin$	 0.5,0.5&�69   $
��1024��6Y   $	��768��6f   z�5      V� 5      .~�5      T� 
 T� X$
 0Q�6)    T� Y$ 0Q�6/   5      5      �� 5   
   -   5        $ myImage2��5      $��UniformToFill=�6"   $	 0.5,0.5&�6:   $
��1024��6Z   $	��768��6g   z�5      V� 5      .~�5       T� $
 0Q�6)   $ 0Q�6/   5!      5#      r� 5$   
   -   5        $��myVideo��5$       r� Stretch$ Uniform=�69    r� LoadedBehavior$ Manual=�6K    r� Source 6&   �� 6K   5%      5&      