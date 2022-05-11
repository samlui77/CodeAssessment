using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment.Models
{
    public class BreadItems : GoodsItems
    {
        private const decimal BreadPrice = 0.80m;
        private int HalfPriceCount = 0;
        private int BreadCount = 0;

        public override decimal DiscountPrice()
        {
            throw new NotImplementedException();
        }

        public decimal GetBreadPrice()
        {
            return BreadPrice * this.Quantity;
        }

        public void GetHalfPriceCount(int NoOfSoup) {
            // Check Half price count
            HalfPriceCount = NoOfSoup/2;
        }

        public override decimal SpecialOffer()
        {   // Calculate the Special Offer of Bread
           BreadCount = this.Quantity;
           Decimal OfferTotal = 0;

           for (int i = HalfPriceCount - 1; i >= 0; i--)
           {
                if (BreadCount > 0) { 
                    OfferTotal += (BreadPrice / 2);
                    BreadCount--;
                }
            }
            
            return OfferTotal;
        }
        public string OfferMsg()
        {   // Create a OfferMsg for display
            
            int Pence = Decimal.ToInt32(this.SpecialOffer() * 100);

            string StrMsg = (HalfPriceCount > 0) ? "A loaf of bread half price : -"+ Util.pence2Pound(Pence) + ".\r\n" : "";
            return StrMsg;
        }

    }
}
