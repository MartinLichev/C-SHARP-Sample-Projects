using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicCalculator
{
    public partial class BasicCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.FirstNumberText.Text == "")
            {
                this.FirstNumberText.Text = "0";
            }
            if (this.SecondNumberText.Text == "")
            {
                this.SecondNumberText.Text = "0";
            }
        }

        protected void SumButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstnumber = Convert.ToDouble(this.FirstNumberText.Text);

                double secondnumber = Convert.ToDouble(this.SecondNumberText.Text);

                double result = (firstnumber + secondnumber);

                this.Resulttext.Text = result.ToString();
            }
            catch (SystemException)
            {
                this.Resulttext.Text = "error!";
            }


        }

        protected void DevideButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstnumber = Convert.ToDouble(this.FirstNumberText.Text);

                double secondnumber = Convert.ToDouble(this.SecondNumberText.Text);

                double result = (firstnumber / secondnumber);

                this.Resulttext.Text = result.ToString();
            }
            catch (SystemException)
            {
                this.Resulttext.Text = "error!";
            }

        }

        protected void MultipleButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstnumber = Convert.ToDouble(this.FirstNumberText.Text);

                double secondnumber = Convert.ToDouble(this.SecondNumberText.Text);

                double result = (firstnumber * secondnumber);

                this.Resulttext.Text = result.ToString();
            }
            catch (SystemException)
            {
                this.Resulttext.Text = "error!";
            }

        }

        protected void SubtractionButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstnumber = Convert.ToDouble(this.FirstNumberText.Text);

                double secondnumber = Convert.ToDouble(this.SecondNumberText.Text);

                double result = (firstnumber - secondnumber);

                this.Resulttext.Text = result.ToString();
            }
            catch (SystemException)
            {
                this.Resulttext.Text = "error!";
            }

        }
    }
}