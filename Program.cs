using System;

namespace question_program {
    public class Program {
        static void Main(string[] args) {
            //Name
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            //Age
            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());
            //Eye Color
            Console.Write("What is your eye color? ");
            string eyeColor = Console.ReadLine();
            //Hair Color
            Console.Write("What is your hair color? ");
            string hairColor = Console.ReadLine();
            //Shoe Size
            Console.Write("What is your shoe size? ");
            string shoeSize = Console.ReadLine();
            //Favorite Color
            Console.Write("What is your favorite color? ");
            string favoriteColor = Console.ReadLine();
            //Favorite TV show or movie
            Console.Write("What is your favorite TV show or movie? ");
            string favoriteTVShowMovie = Console.ReadLine();
            //Favorite Teacher
            Console.Write("What is your favorite teacher? ");
            string favoriteTeacher = Console.ReadLine();
            //Favorite Class
            Console.Write("What is your favorite class? ");
            string favoriteClass = Console.ReadLine();
            //Favorite Holiday
            Console.Write("What is your favorite holiday? ");
            string favoriteHoliday = Console.ReadLine();
            //Favorite Season
            Console.Write("What is your favorite season? ");
            string favoriteSeason = Console.ReadLine();
            //Dream Job
            Console.Write("What is your dream job? ");
            string dreamJob = Console.ReadLine();
            //Age in 5 years
            int ageInFiveYears = age+5;
            //How many siblings
            Console.Write("How many siblings do you have? ");
            string numberOfSiblings = Console.ReadLine();
            Console.WriteLine("My friends name is "+name+". "+name+" is "+ age+" years old. "+name+"'s eye color is "+eyeColor+" and their hair color is "+hairColor+". Their shoe size is "+shoeSize+". Their favorite color is "+favoriteColor+". Their Favorite TV Show or Movie is "+favoriteTVShowMovie+". Their favorite Teacher is "+favoriteTeacher+" and their favorite class is "+favoriteClass+". Their favorite holiday and season is "+favoriteHoliday+" and "+favoriteSeason+". Their dream job would be "+dreamJob+" and they will be "+ageInFiveYears+" in 5 years."+" They also have "+numberOfSiblings+" siblings.");
        }
    }
}