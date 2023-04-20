namespace DomainModels;

public class Product
{
    public int Id { get; set; }

    public string Model { get; set; } = string.Empty;

    public double Price { get; set; }

    public int Quantity { get; set; }

    public string Description { get; set; } = string.Empty;

    public int IdCategory { get; set; }

    public int IdManufacturer { get; set; }

    public virtual Category IdCategoryNavigation { get; set; }

    public virtual Manufacturer IdManufacturerNavigation { get; set; }

    public virtual ICollection<OrderedProduct> OrderedProducts { get; } = new List<OrderedProduct>();

    public virtual ICollection<PictureProduct> PictureProducts { get; } = new List<PictureProduct>();
}
