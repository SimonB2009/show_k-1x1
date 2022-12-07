using System;

namespace simon {

    class Show_k_1x1 {

        static void Main(string[] args) {

            for (int a =1; a<11; a++) {

                Console.WriteLine("    ");

                for (int b = 1; b<11; b++) {

                    Console.WriteLine(a + " * " + b + " = " + (a*b));
                }
            }
        }
    }
}