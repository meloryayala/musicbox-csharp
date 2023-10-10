class Episode
{
    private List<string> guestsList = new List<string>();
    
    public Episode(string title, int order)
    {
        Title = title;
        Order = order;
    }
    public string Title { get; }
    public int Order { get; }
    public int Duration { get; set; }
    public string Summary => $"Summary => {Order}º Episode - {Duration}min - {string.Join(", ", guestsList)}";

    public void AddGuest(string guest)
    {
        guestsList.Add(guest);
    }

    
}