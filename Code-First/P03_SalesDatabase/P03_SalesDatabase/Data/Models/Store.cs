﻿namespace P03_SalesDatabase.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class Store
    {
        public Store()
        {
            Sales = new List<Sale>();
        }
        public int StoreId { get; set; }
        public string Name { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
