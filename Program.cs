Music music1 = new Music();
music1.Name = "Crazy in love";
music1.Artist = "Beyoncé";
music1.Style = "Pop";
music1.Duration = 273;
music1.Available = true;
Console.WriteLine(music1.Summary);


Music music2 = new Music();
music2.Name = "Traum";
music2.Artist = "CRO";
music2.Style = "Hip hop";
music2.Duration = 300;
music2.Available = false;
Console.WriteLine(music2.Summary);

music1.DisplayMusicDetails();
music2.DisplayMusicDetails();
