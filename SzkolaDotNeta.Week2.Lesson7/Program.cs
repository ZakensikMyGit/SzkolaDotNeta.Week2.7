namespace SzkolaDotNeta.Week2.Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj zmienną a: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.Write("Podaj zmienną b: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            // Exercise 1
            Console.WriteLine("\nZadanie 1: Czy liczby 'a' i 'b' są równe?");
            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} są równe");
            }

            // Exercise 2
            Console.WriteLine($"\nZadanie 2: Czy liczba 'a' jest parzysta?");
            if (a % 2 == 0)
            {
                Console.WriteLine($"Liczba: {a} jest parzysta");
            }
            else
            {
                Console.WriteLine($"Liczba: {a} jest NIEparzysta");
            }

            // Exercise 3
            Console.WriteLine($"\nZadanie 3: Czy liczba 'a' jest dodatnia?");
            if (a >= 0)
            {
                Console.WriteLine($"Liczba: {a} jest liczbą parzystą");
            }

            // Exercise 4
            Console.WriteLine("\nZadanie 4: Czy dany rok jest przestępny");
            Console.WriteLine("Podaj rok do sprawdzenia: ");
            Int32.TryParse(Console.ReadLine(), out int year);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"Rok {year} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"Rok {year} nie jest rokiem przestępnym");
            }

            // Exercise 5
            Console.WriteLine("\nZadanie 5: Do czego uprawnia wiek?");
            Console.WriteLine("Podaj swój wiek: ");
            Int32.TryParse(Console.ReadLine(), out int yourAge);

            // int primeMinisterAge = 18;
            int envoyAge = 21;
            int senatorAge = 30;
            int presidentAge = 35;

            if (yourAge >= presidentAge)
            {
                Console.WriteLine("W Polsce możesz starać się o 'fotel': premiera, posła, senatora oraz Prezydenta RP");
            }
            else if (yourAge >= senatorAge)
            {
                Console.WriteLine("W Polsce możesz starać się o 'fotel': premiera, posła oraz Senatora");
            }
            else if (yourAge >= envoyAge)
            {
                Console.WriteLine("W Polsce możesz starać się o 'fotel': premiera, posła oraz Posła");
            }
            else
            {
                Console.WriteLine("W Polsce możesz starać się o 'fotel': Premiera");
            }

            // Exercise 6
            Console.WriteLine("\nZadanie 6: Co to za wzrost?");
            Console.WriteLine("Podaj swój wzrost: ");
            Int32.TryParse(Console.ReadLine(), out int yourHeight);

            int ogreHeight = 350;
            int dwarfHeight = 100;
            int elvesHeight = 250;
            int humanoidiumHeight = 140;

            if (yourHeight >= ogreHeight)
            {
                Console.WriteLine("Jesteś Ogrem");
            }
            else if (yourHeight >= elvesHeight)
            {
                Console.WriteLine("Jesteś Elfem");
            }
            else if (yourHeight >= humanoidiumHeight)
            {
                Console.WriteLine("Jesteś jakimś Humanoidem");
            }
            else if (yourHeight >= dwarfHeight)
            {
                Console.WriteLine("Jesteś Krasnoludem");
            }
            else
            {
                Console.WriteLine("Jesteś Niziołkiem");
            }

            // Exercise 7
            Console.WriteLine("\nZadanie 7: Która liczba jest największa?");
            Console.WriteLine("\nPodaj trzy liczby: ");
            Int32.TryParse(Console.ReadLine(), out int numberOne);
            Int32.TryParse(Console.ReadLine(), out int numberTwo);
            Int32.TryParse(Console.ReadLine(), out int numberThree);
            Console.WriteLine($"Podano następujące liczby: {numberOne}, {numberTwo}, {numberThree}");

            if (numberOne > numberTwo)
            {
                if (numberOne > numberTwo)
                    Console.WriteLine($"Liczba {numberOne} jest najwieksza z podanych");
            }
            else if (numberTwo > numberThree)
            {
                Console.WriteLine($"Liczba {numberTwo} jest największa z podanych");
            }
            else
                Console.WriteLine($"Liczba {numberThree} jets największa z podanych");

            // Exercise 8
            Console.WriteLine("Zadanie 8: Czy dostałeś się na studia ?");
            Console.Write("Podaj wynik z matematyki: ");
            Int32.TryParse(Console.ReadLine(), out int mathResult);
            Console.Write("Podaj wynik z fizyki: ");
            Int32.TryParse(Console.ReadLine(), out int physicsResult);
            Console.Write("Podaj wynik z chemii: ");
            Int32.TryParse(Console.ReadLine(), out int chemistryResult);

            Console.WriteLine($"Twoje wyniki maturalne:\nmatematyka: {mathResult}\nfizyka: {physicsResult}\nchemia: {chemistryResult}");

            int math = 70;
            int physics = 55;
            int chemistry = 45;
            int result = 180;
            int mathWithOtherResult = 150;

            if (mathResult > math && (physicsResult > physics || chemistryResult > chemistry))
            {
                if ((mathWithOtherResult > mathResult + physicsResult || mathWithOtherResult > mathResult + chemistryResult) || (result > mathResult + physicsResult + chemistryResult))
                {
                    Console.WriteLine("Kandydat dopuszczony do rekruatcji");
                }
            }
            else
            {
                Console.WriteLine("Nie dopuszczono do rekrutacji");
            }

            // Exercise 9
            Console.WriteLine("Zadanie 9: Jaka jest temperatura?");
            Console.WriteLine("Podaj aktualną temperaturę: ");
            Int32.TryParse(Console.ReadLine(), out int temp);
            Console.WriteLine($"Dane testowe: {temp}");

            if (temp < 0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("Zimno");
            }
            else if (temp > 0 && temp <= 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę");
            }


            // Exercise 10
            Console.WriteLine("Zadanie 10: Czy można utworzyć trójkąt?");
            Console.WriteLine("Podaj trzy długości: ");
            Int32.TryParse(Console.ReadLine(), out int lengthOne);
            Int32.TryParse(Console.ReadLine(), out int lengthTwo);
            Int32.TryParse(Console.ReadLine(), out int lengthThree);

            if (lengthOne > lengthTwo && lengthOne > lengthThree)
            {
                if (lengthTwo + lengthThree > lengthOne)
                    Console.WriteLine("Można zbudować trójkąt");
            }
            else if (lengthTwo > lengthOne && lengthTwo > lengthThree)
            {
                if (lengthThree + lengthOne > lengthTwo)
                    Console.WriteLine("Można zbudować trójkąt");
            }
            else if (lengthThree > lengthTwo && lengthOne < lengthThree)
            {
                if (lengthTwo + lengthOne > lengthThree)
                    Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

            //Exercise 11
            Console.WriteLine("\nZadanie 11: Jaką dostałeś ocenę?");
            Console.WriteLine("Podaj ocenę jaką dostałeś: ");
            Int32.TryParse(Console.ReadLine(), out int grade);
            Console.WriteLine($"Dante testowe: {grade}");

            if (grade == 1)
            {
                Console.WriteLine("Niedostateczny");
            }
            else if (grade == 2)
            {
                Console.WriteLine("Dopuszczający");
            }
            else if (grade == 3)
            {
                Console.WriteLine("Dostateczny");
            }
            else if (grade == 4)
            {
                Console.WriteLine("Dobry");
            }
            else if (grade == 5)
            {
                Console.WriteLine("Bardzo dobry");
            }
            else if (grade == 6)
            {
                Console.WriteLine("Celujący");
            }
            else
            {
                Console.WriteLine("Niepoprawna wartość !");
            }

            // Exercise 12
            Console.WriteLine("\nZadanie 12: Jaką dzień tygodnia?");
            Console.WriteLine("Podaj numer dnia tygodnia: ");
            Int32.TryParse(Console.ReadLine(), out int day);
            Console.WriteLine($"Dante testowe: {day}");

            if (day == 1)
            {
                Console.WriteLine("Poniedziałek");
            }
            else if (day == 2)
            {
                Console.WriteLine("Wtorek");
            }
            else if (day == 3)
            {
                Console.WriteLine("Środa");
            }
            else if (day == 4)
            {
                Console.WriteLine("Czwartek");
            }
            else if (day == 5)
            {
                Console.WriteLine("Piątek");
            }
            else if (day == 6)
            {
                Console.WriteLine("Sobota");
            }
            else if (day == 7)
            {
                Console.WriteLine("Niedziela");
            }
            else
            {
                Console.WriteLine("Niepoprawna wartość !");
            }

            //Exercise 13
            Console.WriteLine("Zadanie 13: Kalkulator");
            Console.WriteLine("Podaj pierwszą liczbę: ");
            decimal.TryParse(Console.ReadLine(), out decimal firtstNumber);
            Console.WriteLine("Podaj drugą liczbę: ");
            decimal.TryParse(Console.ReadLine(), out decimal secondNumber);

            Console.WriteLine("Podaj numer operacji do wykonania:\n\t1.\tDodawanie\n\t2.\tOdejmowanie\n\t3.\tMnożenie\n\t4.\tDzielenie");
            Int32.TryParse(Console.ReadLine(), out int action);
            decimal sum = 0;

            if(action == 1)
            {
                result = numberOne + numberTwo;
                Console.WriteLine($"Twój wynik to: {result}");
            }
            if (action == 2)
            {
                result = numberOne - numberTwo;
                Console.WriteLine($"Twój wynik to: {result}");
            }
            if (action == 3)
            {
                result = numberOne * numberTwo;
                Console.WriteLine($"Twój wynik to: {result}");
            }
            if (action == 4)
            {
                result = numberOne / numberTwo;
                Console.WriteLine($"Twój wynik to: {result}");
            }

        }
    }
}