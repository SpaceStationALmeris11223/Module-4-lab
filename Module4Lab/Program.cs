// See https://aka.ms/new-console-template for more information

using System;
using System.Threading;
using System.Xml;
//Description simulates a rocket launch using loops

namespace RocketLaunchApp {
    class Program {
        static void Main(string[] args){
            //greet user
            Console.WriteLine("Welcome to The Rocket Countdown!");
            Console.WriteLine("Get ready for lift off!");

            //Create countdown using a for loop
            for (int i = 10; i >= 1; i--)
            //Create int i, then as long as i is greater than 1 loop
             {
                //Show the current place in the countdown to the user
                Console.WriteLine($"T-{i} seconds....");

                //wait for 1 second
                Thread.Sleep(1000);//Pauses for 1000 milisecond
             }

                //start ignition sequence
                Console.WriteLine("Ignition sequence start!");
                Console.WriteLine("Engines are firing...");

                //countdown using a while loop
                int countdown = 5;
                while (countdown > 0){
                    //Output the number of seconds for liftoff
                    Console.WriteLine($"T-{countdown} seconds...");
                    Thread.Sleep(1000);//Wait for 1 second (1 sec == 1000 milliseconds)
                    countdown--;
                } //end while loop

                //Liftoff
                Console.WriteLine("Liftoff! The rocket is on it's way to space!");
                Console.WriteLine("Mission accomplished have a stellar day");
            
            //Simulate the rocket ascent 
            for (int altitude = 0; altitude <= 100; altitude += 10){
                //Output the altitude
                Console.WriteLine($"Altitude: {altitude}");
            }
            
            
 
        }//end of main method
    }//End program class
}//end namespace