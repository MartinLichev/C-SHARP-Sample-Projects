using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFrameworkDataBaseManipulation
{
    public class EnityFrameworkDataBaseManipulation
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"         PROGRAM FOR SQL DATA BASE MANIPULATIONS, USING ENTITY FRAMEWORK");
            Console.WriteLine("\n=======================================================================");

            using (var entity = new TrainingDataBase2Entities())
            {

                SelectAllFromLooneyTunes(entity);
                Console.WriteLine("\n=====================================================");
                SelectAllFromCartoonMovieSets(entity);
                Console.WriteLine("\n=====================================================");
                SelectAllFromMovies(entity);
                Console.WriteLine("\n=====================================================");
                JoinTwoTables(entity);
                Console.WriteLine("\n=====================================================");
                //AddNewRecord(entity);
                RenameElement(entity);
                //RemoveElement(entity);
                Console.WriteLine("\n=====================================================");
                SelectWithSQL(entity);





            }

        }


        public static void SelectAllFromLooneyTunes(TrainingDataBase2Entities entity)
        {


            var select = from character
                         in entity.LooneyTunes
                         select character;


            foreach (var element in select)
            {
                Console.WriteLine($"{element.CharacterName} {element.Type} {element.FirstAppearance}");
            }

        }

        public static void SelectAllFromMovies(TrainingDataBase2Entities entity)
        {
            var select = from movie
                         in entity.CartoonMovies
                         select movie;

            foreach (var element in select)
            {
                Console.WriteLine($"{element.CharacterName} {element.MovieName}");
            }
        }

        public static void SelectAllFromCartoonMovieSets(TrainingDataBase2Entities entity)
        {
            var select = from set
                         in entity.CartoonMovieSets
                         select set;

            foreach (var element in select)
            {
                Console.WriteLine($"{element.SetName} {element.SetDescription}");
            }
        }

        public static void JoinTwoTables(TrainingDataBase2Entities entity)
        {
            var join = from character
                       in entity.LooneyTunes
                       join movie in
                       entity.CartoonMovies
                       on character.CharacterName
                       equals movie.CharacterName
                       select new { LooneyTunes = character, CartoonMovies = movie };

            foreach (var element in join)
            {
                Console.WriteLine($"{element.LooneyTunes.CharacterName} {element.LooneyTunes.Type} {element.LooneyTunes.FirstAppearance} {element.CartoonMovies.CharacterName} {element.CartoonMovies.MovieName}");
            }
        }

        public static void AddNewRecord(TrainingDataBase2Entities entity)
        {
            LooneyTune character = new LooneyTune();
            character.CharacterName = "DUCK DOGGERS";
            character.Type = "SPACE DUCK";
            character.FirstAppearance = 1989;

            entity.LooneyTunes.Add(character);

            entity.SaveChanges();
        }

        public static void RenameElement(TrainingDataBase2Entities entity)
        {
            var rename = entity.LooneyTunes.Single(character => character.FirstAppearance == 1950);

            rename.Type = "CARTOON ALIEN";

            entity.SaveChanges();
        }

        public static void RemoveElement(TrainingDataBase2Entities entity)
        {
            var remove = entity.LooneyTunes.Single(character => character.CharacterName == "TAZ");

            entity.LooneyTunes.Remove(remove);

            entity.SaveChanges();
                         
        }

        public static void SelectWithSQL(TrainingDataBase2Entities entity)
        {

            var select = entity.LooneyTunes.SqlQuery("SELECT * FROM LooneyTunes");


            foreach(var element in select)
            {
                Console.WriteLine($"{element.CharacterName} {element.Type} {element.FirstAppearance}");
            }
        }
    }
}

            
            


