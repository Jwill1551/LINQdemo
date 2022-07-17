using System;

namespace LINQdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make some test scores 
            int[] scores = new[] { 50, 40, 55, 63, 100, 21, 10, 11, 15, 70, 75, 84, 91, 82, 87, 99, 98, 110 };

            // Print out each score 
            foreach(var indivdiaulScore in scores)
            {
                Console.WriteLine("One of the scores was {0}", indivdiaulScore);
            }

            // Pause to see the output before going on
            Console.ReadLine();

            // Use a LINQ statement to filter the list 
            var theBestStudents = 
                from individualScore in scores
                where individualScore > 90
                select individualScore;

            // Print only the scores 
            foreach (var individualScore in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", individualScore);
            }

            // Pause to see the output before closing 
            Console.ReadLine();

            // Use LINQ to sort the results 
            var sortedScores = 
                from individualScore in scores 
                orderby individualScore
                select individualScore;

            // Print the sorted list
            foreach(var individualScore in sortedScores)
            {
                Console.WriteLine("One of the scores were {0}", individualScore);
            }

            // Pause to see the output before closing
            Console.ReadLine();

            /**** Challenge ****/
            // Use LINQ to filter the scores that relate to a 'B' grade
            var bScores =
                from individualScore in scores
                where individualScore >= 80 && individualScore <= 89
                select individualScore;

            // Print out the b grade scores 
            foreach( var individualScore in bScores)
            {
                Console.WriteLine("One of the b grade scores were {0}", individualScore);
            }

        }
    }
}