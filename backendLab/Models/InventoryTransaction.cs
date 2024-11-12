namespace backendLab.Models
{
    public class InventoryTransaction
    {
        public int TransactionID { get; set; }
        public int InventoryID { get; set; }
        public string TransactionType { get; set; } // e.g., "Purchase" or "Usage"
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }

        // Relationships
        public Inventory Inventory { get; set; }
    }

}
