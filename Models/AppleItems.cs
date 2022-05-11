using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment.Models
{
    public class AppleItems : GoodsItems
    {
        private const decimal ApplePrice = 1.00m;
        private const decimal ApplesDiscount = 0.1m;

        public decimal GetApplesDiscount()
        {
            return ApplesDiscount;
        }

        public decimal GetApplesPrice()
        {
            return ApplePrice * this.Quantity;
        }
        public override decimal DiscountPrice()
        {
            decimal ApplesTotalDiscount = 0;
            
            if (this.Quantity > 0)
            {
                ApplesTotalDiscount = ApplesDiscount * (ApplePrice * this.Quantity);
            }

            return ApplesTotalDiscount;
        }
        
        public string OfferMsg()
        {   // Create a OfferMsg for display
            int Pence = Decimal.ToInt32(this.DiscountPrice() * 100);
     
            string StrMsg = (this.Quantity > 0) ? this.ItemName + " " + (this.GetApplesDiscount() * 100) + " % off: -" + Util.pence2Pound(Pence) + " \r\n" : "";
            return StrMsg;
        }

        public override decimal SpecialOffer()
        {
            throw new NotImplementedException();
        }
    }
}
