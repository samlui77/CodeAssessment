using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment.Models
{
    internal class SoupItems : GoodsItems
    {
        private const decimal SoupPrice = 0.65m;

        public decimal GetSoupPrice()
        {
            return SoupPrice * this.Quantity;
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
