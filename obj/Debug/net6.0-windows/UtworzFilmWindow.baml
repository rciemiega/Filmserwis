   M S B A M L   `   `   `  ����H  DFilmSerwisWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FilmSerwisWPFFilmSerwisWPF  5   	   $    FilmSerwisWPF.UtworzFilmWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:FilmSerwisWPF     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ UtworzFilmWindow��5	   	   $	��450��6"   $	��800��6/   .��5
      � ���	#FF2D9292$��0,1,0,-1q�6"   .+�5   
   �� -   5         ��Name$ tytulFilmuTextbox��5      $
��Left=�6-   $��	84,61,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $��Tytul filmu��6o   $	��Top=�6�   $	��120��6�   �� 5   
   $��	Typ filmu��6   $
��Left=�6$   $��	84,84,0,0q�6?   $	��Top=�6R   $	��120��6j   �� 5   
   -   5         ��Name$ typFilmuCombobox��5      $
��Left=�6-   $��
84,115,0,0q�6H   $	��Top=�6\   $	��120��6t    �� Text$ 	Typ filmu��6�   �� 5   
   -   5        $ opisFilmuTextbox��5      $
��Left=�6,   $��
84,160,0,0q�6G   $
 Wrap=�6[   $��
Opis filmu��6o   $	��Top=�6�   $	��643��6�   $��71��6�   �� 5   
   $��Rezyser��6   $
��Left=�6"   $��
84,244,0,0q�6=   $	��Top=�6Q   $��32��6i   $��98��6u   �� 5   
   -   5        $ imieRezyseraTextbox��5      $
��Left=�6/   $��
84,274,0,0q�6J   $
 Wrap=�6^   $
��Imie��6r   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ nazwiskoRezyseraTextbox��5      $
��Left=�64   $��243,274,0,0q�6O   $
 Wrap=�6d   $��Nazwisko��6x   $	��Top=�6�   $	��120��6�   �� 5   
   $��Data urodzenia��6   $
��Left=�6)   $��406,245,0,0q�6D   $	��Top=�6Y   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$% dataUrodzeniaRezyseraDatepicker��5      $
��Left=�6>   $��400,271,0,0q�6Y   $	��Top=�6n   �� 5   
   $��Glowny Aktor��6   $
��Left=�6'   $��
84,302,0,0q�6B   $	��Top=�6V   $	��120��6n   �� 5   
   -   5        $ imieAktoraTextbox��5      $
��Left=�6-   $��
84,333,0,0q�6H   $
 Wrap=�6\   $
��Imie��6p   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ nazwiskoAktoraTextbox��5      $
��Left=�61   $��243,333,0,0q�6L   $
 Wrap=�6a   $��Nazwisko��6u   $	��Top=�6�   $	��120��6�   �� 5   
   $��Data urodzenia��6   $
��Left=�6)   $��407,302,0,0q�6D   $	��Top=�6Y     5   
   -	   5        $# dataUrodzeniaAktoraDatepicker��5      $
��Left=�6<   $��400,330,0,0q�6W   $	��Top=�6l   �� 5   
   -
   5        $��Utworz Film��5      $
��Left=�6'   $��673,382,0,0q�6B   $	��Top=�6W   6o   �� 5   
   -   5        $ ocenaCombobox��5      $
��Left=�6*   $��
258,59,0,0q�6E   $	��Top=�6Y   $	��120��6q   �� 5   
   $��Ocena��6   $
��Left=�6    $��
262,34,0,0q�6;   $	��Top=�6O   5      5      