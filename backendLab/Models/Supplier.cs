﻿namespace backendLab.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Relationships
        public ICollection<Inventory> Inventories { get; set; }
    }

}
