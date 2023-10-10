Band mana = new Band();
mana.Name = "Mana";

Album manaAlbum = new Album();
manaAlbum.Name = "Revolución de amor";

Music music1 = new Music(mana);
music1.Name = "Mariposa traicionera";
music1.Duration = 213;

Music music2 = new Music(mana);
music2.Name = "Labios compartidos";
music2.Duration = 350;

manaAlbum.AddMusic(music1);
manaAlbum.AddMusic(music2);


mana.AddAlbum(manaAlbum);
mana.DisplayAlbums();