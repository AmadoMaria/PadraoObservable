using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class CurrentConditiosDisplay: Observer
    {
        private float Temperature;
        private float Humidity;
        private Subject Subject;

        public CurrentConditiosDisplay(Subject subject)
        {
            this.Subject = subject;
            subject.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure) {
            this.Temperature = temp;
            this.Humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
        }
    }
}
