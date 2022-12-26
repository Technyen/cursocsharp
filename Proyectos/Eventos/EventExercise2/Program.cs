using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace TimeEvent

{
    internal class Program
    {
         static async Task Main(string[] args)
        {

            Timer miTimer = new Timer();
            miTimer.Tick += TickHandler;
           await miTimer.Start(2000);
            
                      
        }
        public static void TickHandler()
        {
            Console.WriteLine("tik tak");
        }
    }

    public class Timer
    {
        public delegate void TimerTickHandler();

        public event TimerTickHandler Tick;

     
        public async Task Start(int segundos)
        {
            await Task.Delay(segundos);
            Stop();
            
        }

        public void Stop()
        {
            if (Tick != null) 
            {
                Tick.Invoke();
            }
           
        }
        
    }

}