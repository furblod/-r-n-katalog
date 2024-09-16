using Abc.MvvWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Models
{
    public class UserOrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public EnumOrderStatee OrderState { get; set; }
        public DateTime OrderDate { get; set; }
    }
}