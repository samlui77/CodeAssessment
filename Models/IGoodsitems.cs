using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment.Models
{
    public interface IGoodsitems
    {
        string ItemName { get; set; }
       // decimal Price { get; set; }
        int Quantity { get; set; }
        decimal DiscountPrice();
        decimal SpecialOffer();

    }
}
