﻿using GiftShopBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftShopBusinessLogic.BingingModels
{
    public class OrderBindingModel
    {
        public int? Id { get; set; }
        public int GiftSetId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
    }
}
