using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeAssessment.Models;

namespace CodeAssessment
{
    public partial class FrmMain : Form
    {
        ArrayList arryItemsDefined = new ArrayList();        // Define the items
        AppleItems applesItems = new AppleItems();           // Apple GoodsItems
        BreadItems breadItems = new BreadItems();            // Bread GoodsItems
        MilkItems milkItems = new MilkItems();              // Milk GoodsItems
        SoupItems soupItems = new SoupItems();              // Soup GoodsItems
       
        public FrmMain()
        {
            InitializeComponent();
            
                arryItemsDefined.Add("Soup");
                arryItemsDefined.Add("Bread");
                arryItemsDefined.Add("Milk");
                arryItemsDefined.Add("Apples");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtCommand.Text += "PriceBasket";
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            txtResult.Clear();  // Clear the result before run
            decimal SubTotal = 0;
            decimal Total = 0;

            

            if (Util.chkCommandLine(txtCommand.Text) == false)
            {   // check Command line input before run
                MessageBox.Show("Please enter the items follow by PriceBasket in the command line.\r\nExample: PriceBasket Soup ");
            }
            else if (Util.chkCommandLineItem(arryItemsDefined, txtCommand.Text) == false)
            {   // check Command line items before run
                MessageBox.Show("Some items does not exist in our item list. Please remove it before check out.");
            }
            else {

                foreach (var item in arryItemsDefined)
                {
                   
                    string searchItem = (string)item;

                    string[] source = txtCommand.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Create the query to check item Count
                    var matchQuery = from word in source
                                     where word.Equals(searchItem, StringComparison.InvariantCultureIgnoreCase)
                                     select word;

                    // Count the matches, which executes the query.  
                    int itemCount = matchQuery.Count();
                    
                    if (searchItem.ToLower().Equals("apples"))
                    {
                        applesItems.ItemName = searchItem;
                        applesItems.Quantity = itemCount;
                        SubTotal += applesItems.GetApplesPrice();
                    }

                    if (searchItem.ToLower().Equals("bread"))
                    {
                        breadItems.Quantity = itemCount;
                        SubTotal += breadItems.GetBreadPrice();
                    }

                    if (searchItem.ToLower().Equals("milk"))
                    {
                        milkItems.Quantity = itemCount;
                        SubTotal += milkItems.GetMilkPrice();
                    }

                    if (searchItem.ToLower().Equals("soup"))
                    {
                        soupItems.Quantity = itemCount;

                        SubTotal += soupItems.GetSoupPrice();
                    }

                    

                } // end foreach


                breadItems.GetHalfPriceCount(soupItems.Quantity);
               
                // For Display the details of result
                txtResult.Text += (applesItems.Quantity > 0) ? "Apple x " + applesItems.Quantity + "\r\n" : "";
                txtResult.Text += (breadItems.Quantity > 0) ? "Bread x " + breadItems.Quantity + "\r\n" : "";
                txtResult.Text += (milkItems.Quantity > 0) ? "Milk x " + milkItems.Quantity + "\r\n" : "";
                txtResult.Text += (soupItems.Quantity>0) ? "Soup x " + soupItems.Quantity + "\r\n" : "";

                txtResult.Text += "-----------------------------------------------------------------\r\n";

                txtResult.Text += "Subtotal: £" + SubTotal + "\r\n";
                txtResult.Text += ((applesItems.OfferMsg().Equals("")) && (breadItems.OfferMsg().Equals(""))) ? "(no offers available)\r\n" : "";
                txtResult.Text += (applesItems.OfferMsg().Equals(""))? "" : applesItems.OfferMsg();
                txtResult.Text += (breadItems.OfferMsg().Equals("")) ? "" : breadItems.OfferMsg();
                txtResult.Text += "-----------------------------------------------------------------\r\n";
                Total = SubTotal - applesItems.DiscountPrice() - breadItems.SpecialOffer();
                txtResult.Text += "Total: £" + Total.ToString("0.00") + "\r\n";

            }// end if 

      
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
           txtCommand.Text += " Apples";
        }

        private void btnSoup_Click(object sender, EventArgs e)
        {
             txtCommand.Text += " Soup";
        }

        private void btnBread_Click(object sender, EventArgs e)
        {
            txtCommand.Text += " Bread";
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            txtCommand.Text += " Milk";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtCommand.Text = "PriceBasket";
        }
    }
}
