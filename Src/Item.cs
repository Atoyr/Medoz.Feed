namespace Medoz.Feed;

public class Item
{
    public string Title { get; set; }
    public string Link { get; set; }
    public string Desciption { get; set; }

    public DateTime Updated { get; set; }

    /// <summary>
    /// RSS Feed Item
    /// </summary>
    public Item()
    {
        Title = string.Empty;
        Link = string.Empty;
        Desciption = string.Empty;
    }
}