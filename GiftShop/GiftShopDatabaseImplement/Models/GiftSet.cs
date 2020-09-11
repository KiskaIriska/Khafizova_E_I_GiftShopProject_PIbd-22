﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GiftShopDatabaseImplement.Models
{
    public class GiftSet
    {
        public int Id { get; set; }

        [Required]
        public string GiftSetName { get; set; }
        [Required]
        public decimal Price { get; set; }
        
        public virtual List<Order> Orders { get; set; }
        public virtual List<GiftSetComponent> GiftSetComponents { get; set; }
    }
}
