using System;
using System.Collections.Generic;

// TODO: a collection of items that can exist in the world and can be used to solve puzzles, like a key to a safe.
// TODO: a player inventory and picking up things/dropping things.
// TODO: NPC entities, like vicious trolls attacking the player.
// TODO: a combat system.

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic playerposition = "road";

            dynamic world = new Dictionary<dynamic, dynamic>() {
                {"house",  new Dictionary<dynamic, dynamic>() {
                    { "description", "You're in an comfy old farmhouse." },
                    { "exits", new Dictionary<dynamic, dynamic>() {
                        {"n", "road" },
                        {"e", "cabbage patch" },
                        {"s", "garden" },
                        } },
                    } },
                {"cabbage patch",  new Dictionary<dynamic, dynamic>() {
                    { "description", "Surrounded by cabbages you are, in this farmer's field. They're almost ready to harvest." },
                    { "exits", new Dictionary<dynamic, dynamic>() {
                        {"w", "house" },
                        {"n", "road" },
                        } },
                    } },
                {"road",  new Dictionary<dynamic, dynamic>() {
                    { "description", "Standing in the gravel country road, you see a small house to the south." },
                    { "exits", new Dictionary<dynamic, dynamic>() {
                        {"n", "jetty" },
                        {"s", "house" },
                        } },
                    } },
                };

            Console.WriteLine("Let's go on an adventure! By Paula Bean, paula.j.bean@partijvoordeinsecten.nl, https://github.com/Paula-Bean");
            while (true) {
                Console.WriteLine("");
                Console.WriteLine(world[playerposition]["description"]);
                Console.WriteLine("You can go to: " + String.Join(", ", world[playerposition]["exits"].Keys) + ".");
                Console.Write("What you want to do? ");
                dynamic cmd = Console.ReadLine();
                if (cmd == "")
                    Console.WriteLine("Type 'q' to quit, or one of 'n' 's' 'e' 'w' to move.");
                else if (cmd == "q")
                    break;
                else if (world[playerposition]["exits"].ContainsKey(cmd)) {
                    dynamic newposition = world[playerposition]["exits"][cmd];
                    if (world.ContainsKey(newposition))
                        playerposition = newposition;
                    else
                        Console.WriteLine($"Hmmm, '{newposition}' doesn't exist in the world!");
                    }
                else
                    Console.WriteLine("Sorry, you can't do that.");
                }
            }
        }
    }
