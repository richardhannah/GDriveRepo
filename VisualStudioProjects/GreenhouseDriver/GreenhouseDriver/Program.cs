using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Collections.Specialized;
using System.Net;

namespace GreenhouseDriver
{
    class Program
    {

        private static Timer aTimer;
        private static int temp;
        private static int humid;
        private static bool heater;
        private static bool humidifier;

        static void Main(string[] args)
        {

            temp = 20;
            humid = 30;

            heater = true;
            humidifier = true;




            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(60000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program... ");
            Console.ReadLine();
            Console.WriteLine("Terminating the application...");


        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

            Random rng = new Random();

            if (temp > 25)
            {
                heater = false;
            }
            else if (temp < 20)
            {
                heater = true;
            }

            Console.WriteLine("heater {0}", heater);

            if (humid > 40)
            {
                humidifier = false;
            }
            else if (humid < 30)
            {
                humidifier = true;
            }

            Console.WriteLine("humidifier {0}", humidifier);

            if (heater == true)
            {
                temp++;
            }
            else
            {
                temp--;
            }

            if (humidifier == true)
            {
                humid++;
            }
            else
            {
                humid--;
            }
            Console.WriteLine("Temp {0}  Humidity {1}", temp,humid);
            //int temp = rng.Next(1, 100);
            //int humid = rng.Next(1, 100);


            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["temp"] = temp.ToString();
                values["humidity"] = humid.ToString();

                var response = client.UploadValues("http://mayar.abertay.ac.uk/~1104623/greenhouse/readingshandler.php", values);

                var responseString = Encoding.Default.GetString(response);
            }


        }
    }
}
