namespace DomainModels;

public class PictureProduct
{
    public int Id { get; set; }

    public int IdProduct { get; set; }

    public int PicturePosition { get; set; }

    public string PicturePath { get; set; } = string.Empty;

    public virtual Product IdProductNavigation { get; set; }
}
