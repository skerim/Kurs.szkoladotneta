using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.
            Console.WriteLine("Zad.1");
            string name;
            string surname;
            int age;
            char sex;
            long pesel;
            int employeeNumber;
            Console.WriteLine("Zadeklarowano zmienne: name, surname, age, sex, pesel, employeeNumber");
            Console.ReadKey();

            //Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.
            Console.WriteLine("Zad. 2");
            char a = 'A', b = 'B', c = 'C';
            Console.WriteLine($"{c}{b}{a}");
            Console.ReadKey();

            //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
            Console.WriteLine("Zad. 3");
            double width = 5;
            double height = 6;
            double diagonal = Math.Sqrt((Math.Pow(width, 2) + Math.Pow(height, 2)));
            Console.WriteLine($"{diagonal}");
            Console.ReadKey();

            //Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości 10; Szkoła Dotneta; 12,5
            Console.WriteLine("Zad. 4");
            int a4;
            string b4;
            double c4;
            a4 = 10;
            b4 = "Szkoła Dotneta";
            c4 = 12.5;

            Console.WriteLine($"{a4}, {b4}, {c4}");
            Console.ReadKey();

            //Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85,7), itp
            Console.WriteLine("Zad.5");

            string name5;
            string surname5;
            int age5;
            char sex5;
            string pesel5;
            double weight5;
            double height5;
            string phone5;
            string email5;


            Console.WriteLine("Ankieta personalna");

            Console.WriteLine("Proszę podaj imię");
            name5 = Console.ReadLine();

            Console.WriteLine("Proszę podaj nazwisko");
            surname5 = Console.ReadLine();


            Console.WriteLine("Proszę podaj wiek");
            string choice = Console.ReadLine();
            Int32.TryParse(choice, out age5);

            Console.WriteLine("Proszę podaj płeć");
            choice = Console.ReadLine();
            char.TryParse(choice, out sex5);


            Console.WriteLine("Proszę podaj PESEL");
            pesel5 = Console.ReadLine();
            
            Console.WriteLine("Proszę podaj wagę");
            choice = Console.ReadLine();
            double.TryParse(choice, out weight5);

            Console.WriteLine("Proszę podaj wrost");
            choice = Console.ReadLine();
            double.TryParse(choice, out height5);

            Console.WriteLine("Proszę podaj nr telefonu");
            phone5 = Console.ReadLine();

            Console.WriteLine("Proszę podaj adres email");
            email5 = Console.ReadLine();

            Console.WriteLine("Wprowadzono:");
            Console.WriteLine($" Imię: {name5} \r\n Nazwisko: {surname5} \r\n Wiek: {age5} \r\n Płeć: {sex5} \r\n PESEL: {pesel5} \r\n Waga: {weight5} \r\n Wrost: {height5} \r\n Nr tel.: {phone5} \r\n Email: {email5}");
            Console.ReadKey();





        }
    }
}
