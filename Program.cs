Album mana = new Album();
mana.Name = "Revolución de amor";

Music music1 = new Music();
music1.Name = "Mariposa traicionera";
music1.Duration = 213;

Music music2 = new Music();
music2.Name = "Labios compartidos";
music2.Duration = 350;

mana.AddMusic(music1);
mana.AddMusic(music2);

mana.DisplayAlbumMusics();