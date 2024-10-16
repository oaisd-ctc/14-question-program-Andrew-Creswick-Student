using System;

namespace question_program {
    public class Program {
        public static string name;
        public static string age;
        public static string eyeColor;
        public static string hairColor;
        public static string shoeSize;
        public static string favoriteColor;
        public static string favoriteTVorMovie;
        public static string favoriteTeacher;
        public static string favoriteClass;
        public static string favoriteHoliday;
        public static string favoriteSeason;
        public static string dreamJob;
        public static string numberOfSiblings;
        public static int ageIn5Years;
        static void Main(string[] args) {
            //Name
            AskName();
            //Age
            AskAge();
            //Eye Color
            AskEyeColor();
            //Hair Color
            AskHairColor();
            //Shoe Size
            AskShoeSize();
            //Favorite Color
            AskFavoriteColor();
            //Favorite TV show or movie
            AskFavoriteTVShow();
            //Favorite Teacher
            AskFavoriteTeacher();
            //Favorite Class
            AskFavoriteClass();
            //Favorite Holiday
            AskFavoriteHoliday();
            //Favorite Season
            AskFavoriteSeason();
            //Dream Job
            AskDreamJob();
            //Age in 5 years
            CalculateAgeIn5Years(age);
            //How many siblings
            AskNumberOfSiblings();
            //Display the summary
            DisplaySummaryMessage();
        }
        public static void AskName(){
            Console.Write("What is your name? ");
            name = Console.ReadLine();
        }
        public static void AskAge(){
            Console.Write("What is your age? ");
            age = Console.ReadLine();
        }
        public static void AskEyeColor(){
            Console.Write("What is your eye color? ");
            eyeColor = Console.ReadLine();
        }
        public static void AskHairColor(){
            Console.Write("What is your hair color? ");
             hairColor = Console.ReadLine();
        }
        public static void AskShoeSize(){
            Console.Write("What is your shoe size? ");
             shoeSize = Console.ReadLine();
        }
        public static void AskFavoriteColor(){
            Console.Write("What is your favorite color? ");
            favoriteColor = Console.ReadLine();
        }
        public static void AskFavoriteTVShow(){
            Console.Write("What is your favorite TV show or movie? ");
            favoriteTVorMovie = Console.ReadLine();
        }
        public static void AskFavoriteTeacher(){
            Console.Write("What is your favorite teacher? ");
            favoriteTeacher = Console.ReadLine();
        }
        public static void AskFavoriteClass(){
            Console.Write("What is your favorite class? ");
            favoriteClass = Console.ReadLine();
        }
        public static void AskFavoriteHoliday(){
            Console.Write("What is your favorite holiday? ");
            favoriteHoliday = Console.ReadLine();
        }
        public static void AskFavoriteSeason(){
            Console.Write("What is your favorite season? ");
            favoriteSeason = Console.ReadLine();
        }
        public static void AskDreamJob(){
            Console.Write("What is your dream job? ");
            dreamJob = Console.ReadLine();
        }
        public static void CalculateAgeIn5Years(string age){
            ageIn5Years = int.Parse(age);
            ageIn5Years +=5;
        }
        public static void AskNumberOfSiblings(){
            Console.Write("How many siblings do you have? ");
            string numberOfSiblings = Console.ReadLine();
        }
        public static void DisplaySummaryMessage(){
             Console.WriteLine($"My friends name is {name}. {name} is {age} years old. {name}'s eye color is {eyeColor} and their hair color is {hairColor}. Their shoe size is {shoeSize}. Their favorite color is {favoriteColor}. Their Favorite TV Show or Movie is {favoriteTVorMovie}. Their favorite Teacher is {favoriteTeacher} and their favorite class is {favoriteClass}. Their favorite holiday and season is {favoriteHoliday} and {favoriteSeason}. Their dream job would be {dreamJob} and they will be {ageIn5Years} in 5 years. They also have {numberOfSiblings} siblings.");
        }
    }
}