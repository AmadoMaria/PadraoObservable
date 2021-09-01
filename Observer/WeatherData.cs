using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class WeatherData: Subject
    {
        private List<Observer> Observers;
        private float Temperature;
        private float Humidity;
        private float Pressure;

        public WeatherData()
        {
            Observers = new List<Observer>();
        }

        public void RegisterObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(Observer observer in Observers)
            {
                observer.Update(this.Temperature, this.Humidity,this.Pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure) {
            this.Temperature = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasurementsChanged();
        }

        //other WeatherData methods here
    }
}
