﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Serializable]
    public class Item
    {
        public Item() { }
        [Key]
        public int ItemID { get; set; }

        [ForeignKey("Drug")]
        public int DrugID { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual Order Order { get; set; }
    }
}
