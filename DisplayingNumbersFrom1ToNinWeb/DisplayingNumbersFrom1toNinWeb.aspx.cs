using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisplayingNumbersFrom1ToNinWeb
{
    public partial class DisplayingNumbersFrom1toNinWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.inputtextbox.Text == "")
            {
                this.inputtextbox.Text = "0";
            }


        }

        protected void checkbutton_Click(object sender, EventArgs e)
        {

            if(this.inputtextbox.Text == "0")
            {
                this.ListBoxtext.Items.Add("Please, input number, different than ");

            }

            try
            {


                int result = int.Parse(this.inputtextbox.Text);

                for (int a = 0; a <= result; a++)
                {
                    this.ListBoxtext.Items.Add(a.ToString());
                }
            }
            catch(SystemException)
            {
                this.ListBoxtext.Items.Add("Please, input correct \"numbers\" format!");
            }
        }
    }

}