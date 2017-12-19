using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsWebControlsTraining
{
    public partial class WebFormsWebControlsTraining : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> names = new List<string>
            {
                {"Martin" },
                {"Dimitar" },
                {"Elenko" },
                {"Stanimir" },
                {"Arsen" },
                {"Dinko" },
                {"Hristomir" },
            };

            if (!Page.IsPostBack)
            {

                this.ListBox.DataSource = names;

            }

            List<string> townlist = new List<string>
            { "Sofia", 
              "Sliven",
              "Plovdiv",
              "Varna",
              "Burgas",
              "Lom",
              "Ruse",
              "Kurdjali",        
            };

            if(!Page.IsPostBack)
            {
                this.CheckBoxList.DataSource = townlist;

            }

            List<Child> childlist = new List<Child>
            {
                new Child {Firstname="Petar", Lastname="Petrov", Age=10 },
                new Child {Firstname ="Georgi", Lastname ="Grigorov", Age =5 },
                new Child {Firstname ="Atanas", Lastname ="Paunov", Age =7 },
                new Child {Firstname = "Boris", Lastname ="Sultov", Age = 9 },

            };

            
            foreach(Child element in childlist)
            {
                this.ListBox2.Items.Add($"{element.Firstname} {element.Lastname} {element.Age}");
            }



            
            


            List<string> peoplenames = new List<string>
            {
                "Martin",
                "Ivan",
                "Dragan",
                "Stefan",
                "Monika",
            };

            this.DropDownList.DataSource = peoplenames;

            this.Page.DataBind();



        }
    }

    public class Child
    {
        private string firstname;

        private string lastname;

        private int age;

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
    }
}