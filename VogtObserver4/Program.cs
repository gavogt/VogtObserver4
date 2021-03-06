﻿using System;
using System.Threading;
namespace VogtObserver4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Install a sensor at Reactor A
            RadiationSensor sensor = new RadiationSensor("Reactor A", 10);

            // Create sensor observers
            RadiationMonitor control = new ControlRoom("Reactor A Control Room", 8.0);
            RadiationMonitor science = new ResearchCenter("Center for Nuclear Research");

            sensor.AddObserver(control);
            sensor.AddObserver(science);

            try
            {
                while (true)
                {
                    sensor.ReadRadiation();
                    Thread.Sleep(4000);
                }
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine(e.StackTrace);
            }
                
        }
    }
}
