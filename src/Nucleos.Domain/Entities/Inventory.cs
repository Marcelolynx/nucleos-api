namespace Nucleos.Domain.Entities;

public class InventoryItem
{
    public string Name { get; private set; }
    public int Quantity { get; private set; }
    public string Description { get; private set; }
    public string ImageUrl { get; private set; }
    public decimal Price { get; private set; }
    public int CategoryId { get; private set; }
    public Category Category { get; private set; }
}