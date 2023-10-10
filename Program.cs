Band mana = new Band("Mana");

Album manaAlbum = new Album("Revolución de amor");

Music music1 = new Music(mana, "Mariposa traicionera")
{
    Duration = 213,
    Available = true,
};

Music music2 = new Music(mana, "Lábios compartidos")
{
    Duration = 350,
    Available = false,
};

manaAlbum.AddMusic(music1);
manaAlbum.AddMusic(music2);

mana.AddAlbum(manaAlbum);
mana.DisplayAlbums();