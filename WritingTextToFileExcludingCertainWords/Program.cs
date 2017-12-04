using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

    public class SplittingTextToWordsAndWritingThemToFile
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"          PROGRAM FOR WRITING TEXT TO FILE AND EXCLUDING CERTAIN WORDS ");
            Console.WriteLine("\n======================================================================");


            //Directory.CreateDirectory(@"D:\PROGRAMEXERCISES\");

            //File.Create(@"D:\PROGRAMEXERCISES\textfile.txt");

            string text = "Alfredo James Pacino (/pəˈtʃiːnoʊ/; born April 25, 1940) is an American actor of stage and screen, filmmaker, and screenwriter. Pacino has had a career spanning over five decades, during which time he has received numerous accolades and honors both competitive and honorary, among them an Academy Award, two Tony Awards, two Primetime Emmy Awards, a British Academy Film Award, four Golden Globe Awards, the Lifetime Achievement Award from the American Film Institute, the Golden Globe Cecil B. DeMille Award, and the National Medal of Arts. He is also one of few performers to have won a competitive Oscar, an Emmy and a Tony Award for acting, dubbed the \"Triple Crown of Acting\".";

            string[] splitter = text.Split();

            for (int a = 0; a < splitter.Length; a++)
            {
                Console.WriteLine($"\nWORD {a}:{splitter[a]}");


            }

            using (StreamWriter writer = new StreamWriter(@"D:\PROGRAMEXERCISES\textfile.txt"))
            {
                for (int a = 0; a < splitter.Length; a++)
                {
                    writer.WriteLine($"\nWORD {a}:{splitter[a]}");

                }
            }
        }
    }

    



