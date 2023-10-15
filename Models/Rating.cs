namespace MusicBox.Models;

internal class Rating
{
    public Rating(int rate)
    {
        if (rate <= 0) rate = 0;
        if (rate >= 10) rate = 10;
        Rate = rate;
    }
    
    public int Rate { get;}

    public static Rating Parse(string text)
    {
        int rate = int.Parse(text);
        return new Rating(rate);
    }
}