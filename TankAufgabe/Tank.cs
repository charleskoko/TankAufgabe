﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TankAufgabe
{
    class Tank
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int inhalt { get; set; }

        public void Befuellen(int userEingabe)
        {
            int copyInhalt = this.inhalt;
            int copyVolume = this.volume;
            int neueInhalt = copyInhalt + userEingabe;

            while (neueInhalt > this.volume)
            {
                userEingabe = 0;
                int volumeDisponible = copyVolume - copyInhalt;
                Console.Write("Es passen nur noch "+ volumeDisponible + " Liter hinein");
                while(!int.TryParse(Console.ReadLine(), out userEingabe))
                {
                    Console.WriteLine("Geben Sie eine Zahl ein.");
                }
                neueInhalt = copyInhalt + userEingabe;
            }

            inhalt += userEingabe;
            Console.WriteLine("Fuellmenge des Tanks: "+this.inhalt);
        }

        public void Entnehmen(int userEingabe)
        {
            int copyInhalt = this.inhalt;
            int neueInhalt = copyInhalt - userEingabe;

            while (neueInhalt<0)
            {
                Console.Write("Es sind nur noch "+this.inhalt+" Liter drin!");
                int.TryParse(Console.ReadLine(), out userEingabe);
                neueInhalt = copyInhalt - userEingabe;
            }
            inhalt -= userEingabe;
            Console.WriteLine("Fuellmenge des Tanks: " + this.inhalt);
        }

    }
}
