using System;
using System.Collections.Generic;

namespace ORFU21_Ovning_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Circle C1 = new Circle();
            C1.diameter = 4;
            Square S1 = new Square();
            S1.side = 5;
            Triangle T1 = new Triangle();
            T1.height = 5;
            T1.width = 10;

            List<IShape> myList = new List<IShape>{ C1, S1, T1 } ;

            foreach (var item in myList)
            {
                Console.WriteLine($"{item.GetArea()}");
            }
        }
    }
}

//Övning shapes
//•	Skapa ett interface som heter IShape som innehåller en metod som heter GetArea.
//•	Skapa en klass som heter Square som implementerar interface:et IShape.
//•	Skapa en property på klassen Square som är av typen int och som heter Side.
//•	I klassen Square skriver du en implementation för GetArea-metoden så att den returnerar Side* Side (arean av en fyrkant).
//•	Skapa en klass som heter Triangle som implementerar IShape.
//•	Skapa två properties av typen int (Height, Width) i Triangle-klassen.
//•	Implementera GetArea-metoden i Triangle så att den nu i stället returnerar Height* Width / 2.0.
//•	Skapa en ny klass som heter Circle som också implementerar IShape.Skapa även
//  samtliga nödvändiga properties för att returnera arean av en cirkel (ni kan
//  använda Math.PI för att komma åt värdet på π). Implementera GetArea.

//•	I Program.cs, skapa en lista av typen IShape.Lägg till en blandning av Square-,
//  Triangle- och Circle-instanser i listan. Skriv en loop som loopar över listan och
//  skriver ut alla elements area.
