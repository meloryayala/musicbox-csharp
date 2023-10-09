Music music1 = new Music();
music1.name = "Crazy in love";
music1.artist = "Beyoncé";
music1.style = "Pop";
music1.duration = 273;
music1.available = true;

Music music2 = new Music();
music2.name = "Traum";
music2.artist = "CRO";
music2.style = "Hip hop";
music2.duration = 300;
music2.available = false;

music1.DisplayMusicDetails();
music2.DisplayMusicDetails();
music1.DisplayNameAndArtist();