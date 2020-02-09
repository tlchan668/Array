using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var grades = new int[] { 71, 78, 89, 73, 68, 73, 96, 71, 72, 65, 87, 63 };

            //assignment 1 add up all numbers 1-10 and multiply 3
            //assignment 2 add up number 1-15 but skip even #s and multiply by 3
            //assignment 3 upgrade want to exclude the numbers that are evenly divisble by 3 or 5
            //assignment 4 find average of grade array
            var avg = 0;
            foreach(var grade in grades) {
                //find average of grade
                avg += grade / grades.Length;
            }
            Console.WriteLine($"avg is {avg}");
            var sum = 0;
            var total = 0;
            //var number = 0;
            //Console.WriteLine(numbers[number]);
           foreach(var number in numbers) {
                //if (number % 2 == 0) {  //modulus functin returns remainder if 
                if ((number % 3 == 0)||(number % 5 == 0)) { 
                    Console.WriteLine(number);
                    continue;//skip it can't use break because need to finish the foreach look of sum
                }
               sum = sum + number *3;
              //or sum +=number *3;
            }
           for (int i = 0; i<numbers.Length; i++) {
                total = total + numbers[i] * 3;
            }
            Console.WriteLine($"Sum= {sum}");
           // Console.WriteLine(total);
            //arrays
            //var randomNumbers = new int[5];
            //randomNumbers[0] = 123;
            //randomNumbers[1] = 456;
            //randomNumbers[2] = 789;
            //randomNumbers[3] = 1;
            //randomNumbers[4] = 0;

            //add up first three numbers
            // var sum = randomNumbers[0] + randomNumbers[1] + randomNumbers[2];
            //Console.WriteLine(sum);
        }
    }
}
