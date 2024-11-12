namespace backendLab.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int HotelID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int SupplierID { get; set; }

        // Relationships
        public Hotel Hotel { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }

}
