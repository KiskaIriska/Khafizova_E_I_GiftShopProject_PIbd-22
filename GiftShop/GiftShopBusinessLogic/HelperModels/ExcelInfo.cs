﻿using GiftShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftShopBusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportOrdersViewModel> Orders { get; set; }
    }
}
