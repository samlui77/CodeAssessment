using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment.Models
{
    public class MilkItems : GoodsItems
    {
        private const decimal MilkPrice = 1.30m;

        public decimal GetMilkPrice()
        {
            return MilkPrice * this.Quantity;
        }

        public override decimal DiscountPrice()
        {
            throw new NotImplementedException();
        }

        public override decimal SpecialOffer()
        {
            throw new NotImplementedException();
        }
    }
}
