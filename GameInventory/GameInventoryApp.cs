﻿///////////////////////////////////////////////////////////////////////////////
//
// Author: Brycen Dunn, DUNNBE@ETSU.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1
// Description: Java -> C# Application Conversion
//
///////////////////////////////////////////////////////////////////////////////

namespace GameInventory
{
    internal class GameInventoryApp
    {
        static void Main(string[] args)
        {
            Backpack myBackpack = new Backpack();

            myBackpack.Add(new Clue("Letter", "A threatening letter from Fred", .1, 0));
            myBackpack.Add(new Weapon("Sword", "A bright shiny sword", 10.0, 25.0));
            myBackpack.Add(new Consumable("Aspirin", "A little something for your aching head", .5, 1.0));
            myBackpack.Add(new Consumable("Chocolate cake", "Delicious cake", 2.0, 7.5));
            myBackpack.Add(new Weapon("Battle Axe", "A wicked looking battle axe", 15.0, 35.0));
            myBackpack.Add(new Clue("Shirt", "A bloody shirt", 2.0, 0));
            myBackpack.Add(new Weapon("Pole Arm", "A heavy stick for hitting things", 8.0, 10.0));
            myBackpack.Add(new Consumable("Bandages", "A box of assorted bandages", .6, 1.0));

            Console.WriteLine(myBackpack.ListWeapons());
            Console.WriteLine(myBackpack.ListClues());
            Console.WriteLine(myBackpack.ListConsumables());
        }
    }
}