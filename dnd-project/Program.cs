﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new MainMenu().Show();
            //new DieRoller().Show();
            Application.Run();

            //Character character = new Character();
            //character.Name = "Byrd";
            //character.SetCharacterClass("Ranger");
            //character.SetCharacterRace("Wood Elf");
            //Console.WriteLine("\n*********FIRST WRITE********\n\n");
            //Console.Write(character);

            //int[] randomRoll = new DiceRoller().RollAttributes(6, 6, 5, 3);
            //Console.Write("New attribute values: ");
            //foreach (int val in randomRoll)
            //{
            //    Console.Write(val + ",");
            //}
            //Console.Write("\n");

            //character.SetBaseAttributes(new string[] { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" }, randomRoll);

            //Console.WriteLine("\n*********2ND WRITE********\n\n");
            //Console.Write(character);


            //character.SetCharacterClass("Monk");
            //Console.WriteLine("\n*********SECOND WRITE********\n\n");
            //Console.Write(character);

            //character.SetCharacterRace("Dragonborn");
            //Console.WriteLine("\n*********THIRD WRITE********\n\n");
            //Console.Write(character);
        }
    }
}
