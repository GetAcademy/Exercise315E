/*
   Oppgave 315 E  
    Lag en metode som returnerer en array med tall. 
    Som parametre tar du startverdi, sluttverdi og differanse. 
    For eksempel skal start=1000, slutt=1028 og differense=7 
    gi tallene 1000, 1007, 1014, 1021, 1028
*/
namespace Exercise315E
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = GenerateNumbers(1000, 1028, 7);
        }

        static int[] GenerateNumbers(int startValue, int endValue, int change)
        {
            //var size = 0;
            //for (var i = startValue; i <= endValue; i += change)
            //{
            //    size++;
            //}
            var size = 1 + (endValue - startValue) / change;
            var numbers = new int[size];
            var index = 0;
            for (var number = startValue; number <= endValue; number += change)
            {
                numbers[index] = number;
                index++;
            }
            return numbers;
        }

        static int[] GenerateNumbers2(int startValue, int endValue, int change)
        {
            var size = 1 + (endValue - startValue) / change;
            var numbers = new int[size];
            for (var index = 0; index < size; index++)
            {
                numbers[index] = startValue + change * index;
            }
            return numbers;
        }
    }
}
