using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingSqlDataFromDataBaseAndWritingItInCollection
{
    public class LooneyTunes
    {

        private string charactername;
        private string type;
        private int firstappearance;
        private string moviename;
        private string setname;
        private string setdescription;

        public string Charactername
        {
            get
            {
                return charactername;
            }

            set
            {
                charactername = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Firstappearance
        {
            get
            {
                return firstappearance;
            }

            set
            {
                firstappearance = value;
            }
        }

        public string Moviename
        {
            get
            {
                return moviename;
            }

            set
            {
                moviename = value;
            }
        }

        public string Setname
        {
            get
            {
                return setname;
            }

            set
            {
                setname = value;
            }
        }

        public string Setdescription
        {
            get
            {
                return setdescription;
            }

            set
            {
                setdescription = value;
            }
        }
    }
}
