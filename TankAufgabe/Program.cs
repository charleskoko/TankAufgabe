using System;

namespace TankAufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            Tank diesel = new Tank {volume = 1000, inhalt=0};

            do
            {
                Console.Clear();
                choice = Menu(diesel);
                Console.Clear();
                tankLeiter(choice, diesel);

            } while (choice != 'x');
         
        }







        public static void tankLeiter(char choice, Tank tank)
        {
            switch (choice)
            {
                case 'b':
                    Console.Clear();
                    Console.Write("Wieviel Liter moechten Sie einfuellen: "); 
                    int userEingabe = UserEingabeChecking();
                    tank.Befuellen(userEingabe);
                    break;
                case 'e':
                    Console.Clear();
                    Console.Write("Wieviel Liter moechten Sie entnehmen: ");
                    userEingabe = UserEingabeChecking();
                    tank.Entnehmen(userEingabe);
                    break;
            }
        }

        public static void DispLayMenu(Tank tank)
        {
            Console.WriteLine("Tankvolumen: "+ tank.volume +" Liter");
            Console.WriteLine("Tankinhalt: "+ tank.inhalt+ " Liter");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Was moechten Sie tun:");
            Console.WriteLine("Befuellen(b)");
            Console.WriteLine("Entnehmen(e)");
            Console.WriteLine("Beenden(x)");
            Console.Write(" -->");

        }


        public static char Menu(Tank tank)
        {

            char userEingabe=' ';
            char[] choiceTable = { 'b', 'e', 'x' };
            DispLayMenu(tank);
            bool is_valid = false;
            do
            {
                 userEingabe = Convert.ToChar(Console.Read());
                 is_valid = Array.Exists(choiceTable, element => element == userEingabe);
                if (!is_valid)
                {
                    Console.Clear();
                    Console.WriteLine("Sil vous plait, Choisissez entre les element suivant:'b', 'e', 'x'. Merci! ");
                    DispLayMenu(tank);
                }
            } while (!is_valid);

            return userEingabe;
        }

        public static int UserEingabeChecking()
        {
            int id = 0;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Please Enter a valid numerical value!");
               
            }

            return id;
        }
    }
}
