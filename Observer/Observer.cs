using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface Observer
    {
        public void Update(float temp, float humidity, float pressure) { }
    }
}
