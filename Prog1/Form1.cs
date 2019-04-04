// Grading ID 9865
// Program 1
// Due Feb 14th
// Section 75
// Description:
// This Program allows you to enter three pieces of information: your wallspace in square feet,
// the number of coats of paint you desire and the price per gallon of your paint that you want to use.
// After you have enter this information you can click the button and it will calculate and output six pieces
// of information including: The total wall space that needs to be covered, the number of gallons of paint required,
// the hours of labor required to paint it, the total cost of paint needed, the total cost of labor needed
// and the total cost of the whole job.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e) // This click event will take the data the user inputted and use it to calculate total square feet, totals gallons of paint, total hours of labor, price of the paint, price of the labor, and the total cost for the job.
        {
            const int wallspace = 330; // This constant holds the value of the square feet that can be painted with a single gallon of paint.
            const int labor = 6; // This constant holds the value of the number of hours of labor required to paint 330 square feet.
            const double hourlyFee = 10.50; // This constant holds the value of the price per hour for labor.

            float userWallSpace; // This local variable holds the value the user inputs into the wallSpaceInput Textbox.
            int userCoats; // This local variable holds the value the user inputs into the coatsOfPaintInput Textbox.
            float userPricePerGallon; // This local varialbe holds the value the user inputs into the pricePerGallonInput Textbox.
            float totalSqFeet; // This local variable holds the value of the total sqft of the users paint job.
            float gallons; // This local variable holds the value of the gallons required for the users paint job.
            double gallonsCeiling; // This local variable holds the value (Rounded up to the nearest integer) of the gallons required.
            float hoursLabor; // This local variable holds the value of the number of hours of labor required to complete the users paint job.
            double paintCost; // This local variable holds the value of the cost of the paint required to complete the users paint job.
            double laborCost; // This local varialbe holds the value of the cost of labor required to complete the users job.
            double totalCost; // This local variable holds the value of the total cost of the users paint job.


            if (float.TryParse(wallSpaceInput.Text, out userWallSpace))
            {
                if (int.TryParse(coatsOfPaintInput.Text, out userCoats))
                {
                    if (float.TryParse(pricePerGallonInput.Text, out userPricePerGallon))
                    {
                        
                        totalSqFeet = userWallSpace * userCoats;
                        squareFeetOutput.Text = totalSqFeet.ToString("N1");

                        gallons = totalSqFeet / wallspace;
                        gallonsCeiling = Math.Ceiling(gallons);
                        gallonsOutput.Text = gallonsCeiling.ToString("#");

                        hoursLabor = (float)labor * gallons;
                        hoursOfLaborOutput.Text = hoursLabor.ToString("N1");

                        paintCost = gallonsCeiling * userPricePerGallon;
                        costOfPaintOutput.Text = paintCost.ToString("C");

                        laborCost = hoursLabor * hourlyFee;
                        costOfLaborOutput.Text = laborCost.ToString("C");

                        totalCost = paintCost + laborCost;
                        totalCostOutput.Text = totalCost.ToString("C");
                    }

                    else
                    {
                        MessageBox.Show("Price Per Gallon Input Invalid");
                    }

                }
                else
                {
                    MessageBox.Show("Coats of Paint Input Invalid");
                }
                

            }
            else
            {
                MessageBox.Show("Wall Space Input Invalid");
            }

        }
    }
}
