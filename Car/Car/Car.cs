using System;

namespace Car
{
    public class Car
    {

        public double TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Farbe { get; set; }
        public int Geschwindigkeit { get; set; }
        public bool MotorAn { get; set; }
        public bool Speed { get; set; }
        public bool Bremsen { get; set; }
        public bool ChangeColor { get; set; }


        public Car(double typeid, string make, string model, string typename, string farbe, int geschwindigkeit, bool motorAn, bool speed, bool bremsen, bool changeColor)
        {
            TypeId = typeid;
            Make = make;
            Model = model;
            TypeName = typename;
            Farbe = farbe;
            Geschwindigkeit = geschwindigkeit;
            MotorAn = motorAn;
            Speed = speed;
            Bremsen = bremsen;
            ChangeColor = changeColor;



        }

        public void PrintCar()
        {
            Console.WriteLine($"Car {TypeId} starts. The car has the color {Farbe} and drives at a speed of {Geschwindigkeit}");
        }

        public void Start()
        {
            if (MotorAn == true)
            {
                Console.WriteLine("Das auto ist bereits an!");
            }
            else
            {
                Console.WriteLine("Auto startet \nBRUMMMM");
                MotorAn = true;
            }

        }
        public void SpeedSTart()
        {
            if (Speed == true)
            {
                Console.WriteLine("Noch schneller geht nicht!");
            }
            else
            {
                Console.WriteLine("beschleunige! \nWRUUUM!");
            }
        }

        public void BemsenStart()
        {
            if(Bremsen == true)
            {
                Console.WriteLine("Wird schon gebremst!");
            }
            else
            {
                Console.WriteLine("BREMSEN!!!!! \nQuiiiiiiiiiiiitsch");
            }
        }

        public void LackierenStart()
        {
            if(ChangeColor == true)
            {
                Console.WriteLine("What do you want to change the color of your vehicle to?");
                string newColor = Console.ReadLine();
                if (newColor == Farbe)
                {
                    Console.WriteLine($"Die Farbe ist bereits {Farbe}.");
                }
                else
                {
                    Farbe = newColor;
                    Console.WriteLine($"Die neue Farbe deines Autos ist jetzt {Farbe}"); 
                }
            }
        }








    }
}
