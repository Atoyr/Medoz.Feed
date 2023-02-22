namespace Medoz.Feed;

public class Entry : Item
{
    public string Id { get; set; }
    public string LinkRel { get; set; }
    public string LinkType { get; set; }
    public string Summary 
    {
        get => Desciption;
        set => Desciption = value;
    }

    /// <summary>
    /// ATOM Entry
    /// </summary>
    public Entry() : base()
    {
    }
}
