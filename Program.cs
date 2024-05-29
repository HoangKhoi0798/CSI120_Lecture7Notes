using System.Numerics;

namespace CSI120_Lecture7
{
    internal class Program
    {
        // 3 levels of variable scopes: Class > Method > Block

        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen
            // CSI 120 - Computer Programming 1
            // Lecture 7 Notes
            

        }//Main

        public static void ArrayExample()
        {
            // Arrays
            // A collection of variables of the same TYPE
            // Method Scope
            // To declare Array, TYPE[]
            // To Initialize = new type[size]
            int[] vickyGrades = new int[10];

            // How to initialize an Array with value
            int[] willsGrades = new int[] { 10, 45, 99, 14, 56 };

            // Change value of an element
            int changeGrade = 10;
            vickyGrades[0] = changeGrade;


            // To access an Element in an Array, use [index]
            // Element is term for individual value in Array
            // All Array starts at INDEX 0
            int firstGrade = vickyGrades[0];

            Console.WriteLine(firstGrade);
            Console.WriteLine("Display Will's Grades");

            // i = 0 starts at the beginning of the Array
            // length indicate the numbers of elements in Array
            // array.Length
            // Last Index is Lenght minus 1

            int totalGrade = 0;

            for (int i = 0; i < willsGrades.Length; i++)
            {
                // Storing current grades
                int willsCurrentGrade = willsGrades[i];
                totalGrade += willsCurrentGrade;
                int currentElement = i + 1;
                int currentIndex = i;
                string currentGrade = GradeCoverter(willsCurrentGrade);

                Console.WriteLine($"Index {currentIndex} Element {currentElement} Value {willsCurrentGrade} Letter Grade {currentGrade} ");

            }

            double averageGrade = Math.Round((double)totalGrade / willsGrades.Length);
            string letterAverage = GradeCoverter((int)averageGrade);

            Console.WriteLine($"Will's average grade is: {averageGrade} Letter Average Grade: {letterAverage}");
        }

        public static void LetterGradeCoverterLoop()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                GradeCoverter(rand.Next(40, 106));
            }
        }
        public static void RandomExample()
        {

            // Introduce Random Object
            // Type Random
            Random rand = new Random();
            Random rand2 = new Random();
            // To use random object, call .Next method
            int randomNumber = rand.Next();
            // Calling Next with a max value (exclusive)
            int randomMaxValue = rand.Next(101);
            // Calling Next with a min and max value
            int randomMinMax = rand.Next(-50, 51);

            Console.WriteLine(randomNumber);
            Console.WriteLine();
            Console.WriteLine(randomMaxValue);
            Console.WriteLine();
            Console.WriteLine(randomMinMax);
            Console.WriteLine();

            // Calling the same seed
            Random randomFor = new Random();
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(randomFor.Next());
            }

        }// RandomEx End

        public static void LetterGradeConverter()
        {

            // What is nested if statement?
            // If - answer one question
            // If ( condition && condition)
            //      if (subsequent condition)



            // Nested conditions
            // Grading Table


            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {

                int numericalGrade = rand.Next(45, 106);


                string letterGrade = "";

                Console.Write($"{numericalGrade} - ");

                if (numericalGrade > 100)
                {
                    letterGrade = "Invalid Input";
                }
                else if (numericalGrade >= 90)
                {
                    letterGrade = "A";
                    numericalGrade -= 90;
                    if (numericalGrade < 5)
                    {
                        letterGrade += "-";
                    }

                }
                else if (numericalGrade >= 80)
                {
                    numericalGrade -= 80;
                    letterGrade = "B";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";

                    }


                }
                else if (numericalGrade >= 70)
                {
                    numericalGrade -= 70;
                    letterGrade = "C";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";

                    }
                }
                else if (numericalGrade >= 60)
                {
                    numericalGrade -= 60;
                    letterGrade = "D";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";

                    }
                }
                else
                {
                    letterGrade = "F";

                }
                letterGrade = "Grade: " + letterGrade;
                Console.WriteLine(letterGrade);
            }

        }// LetterGrade End

        public static string GradeCoverter(int grade)
        {
            int numericalGrade = grade;
            
                string letterGrade = "";

                Console.Write($"{numericalGrade} - ");

                if (numericalGrade > 100)
                {
                    letterGrade = "Invalid Input";
                }
                else if (numericalGrade >= 90)
                {
                    letterGrade = "A";
                    numericalGrade -= 90;
                    if (numericalGrade < 5)
                    {
                        letterGrade += "-";
                    }

                }
                else if (numericalGrade >= 80)
                {
                    numericalGrade -= 80;
                    letterGrade = "B";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";

                    }


                }
                else if (numericalGrade >= 70)
                {
                    numericalGrade -= 70;
                    letterGrade = "C";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";

                    }
                }
                else if (numericalGrade >= 60)
                {
                    numericalGrade -= 60;
                    letterGrade = "D";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";

                    }
                }
                else
                {
                    letterGrade = "F";

                }
                
                Console.WriteLine(letterGrade);
                return letterGrade;
            }
        

    }// Class

}//Name
