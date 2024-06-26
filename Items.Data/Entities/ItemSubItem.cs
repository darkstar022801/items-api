﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Items.Data.Entities
{
    [Table("ItemSubItem", Schema = "Item")]
    public class ItemSubItem
    {
        public Item Item { get; set; }

        public Guid ItemId { get; set; }

        public SubItem SubItem { get; set; }

        public Guid SubItemId { get; set; }

    }
}
