using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment.Models
{
    public abstract class GoodsItems : IGoodsitems
    {
        public string? ItemName { get; set ; }
        //public decimal Price { get; set; }
        public int Quantity { get; set; }
        public abstract decimal DiscountPrice();
        public abstract decimal SpecialOffer();
    }
}
