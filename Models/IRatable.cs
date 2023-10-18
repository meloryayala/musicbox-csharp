namespace MusicBox.Models;

internal interface IRatable
{
    void AddRate(Rating rate);
    double Average { get; }
}