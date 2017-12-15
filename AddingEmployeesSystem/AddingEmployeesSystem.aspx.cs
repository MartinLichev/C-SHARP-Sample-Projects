using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AddingEmployeesSystem
{
    public partial class AddingEmployeesSystem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




        }

        protected void AddButton_Click(object sender, EventArgs e)
        {

            if (AddingEmployeeText.Text != "")
            {
                ListboxEmployees.Items.Add(AddingEmployeeText.Text);

                AddingEmployeeText.Text = "";
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int position = ListboxEmployees.SelectedIndex;

                ListboxEmployees.Items.RemoveAt(position);

                AddingEmployeeText.Text = "";
            }
            catch(SystemException)
            {
                AddingEmployeeText.Text = "Please, select specific item from Listbox!";
            }
        }

        protected void CheckPositionButton_Click(object sender, EventArgs e)
        {
            int position = ListboxEmployees.SelectedIndex;

            CheckCurrentPositionText.Text = position.ToString();
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            ListboxEmployees.Items.Clear();

            AddingEmployeeText.Text = "";
        }
    }
}
