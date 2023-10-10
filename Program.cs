Band mana = new Band("Mana");

Album manaAlbum = new Album("Revolución de amor");

Music music1 = new Music(mana, "Mariposa traicionera")
{
    Duration = 213,
    Available = true,
    Genre = new Genre("Latin"),
};

Music music2 = new Music(mana, "Lábios compartidos")
{
    Duration = 350,
    Available = false,
    Genre = new Genre("Latin"),
};

Podcast podcast1 = new Podcast("Manuel Hübli", "DevTalks");
Episode episode1 = new Episode("The power of code reviews", 2)
{
    Duration = 45,
};
Episode episode2 = new Episode("Code splitting is good practice?", 3)
{
    Duration = 20,
};
Episode episode3 = new Episode("Database, the basic to know", 1)
{
    Duration = 60,
};

Console.WriteLine("\n********PODCAST**********\n");
podcast1.AddEpisode(episode1);
podcast1.AddEpisode(episode2);
podcast1.AddEpisode(episode3);

episode1.AddGuest("Tina Van");
episode2.AddGuest("Gean Palermo");
episode2.AddGuest("Mariol Gruel");

podcast1.DisplayPodcastDetails();

Console.WriteLine("\n\n********MUSICS***********\n");
manaAlbum.AddMusic(music1);
manaAlbum.AddMusic(music2);
mana.AddAlbum(manaAlbum);

music1.DisplayMusicDetails();
music2.DisplayMusicDetails();
manaAlbum.DisplayAlbumMusics();
mana.DisplayAlbums();