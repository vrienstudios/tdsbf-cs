public class User
{
    public string username { get; set; }
    public string id { get; set; }
    public string discriminator { get; set; }
    public string avatar { get; set; }
    public bool? bot { get; set; }
}