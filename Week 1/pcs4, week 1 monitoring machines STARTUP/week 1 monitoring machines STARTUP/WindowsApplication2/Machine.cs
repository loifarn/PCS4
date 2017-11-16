using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication2
{
    public class Machine
    {
        /************datafields*******************************************/
        private String name;
        private int temperature, pressure; //the current working temperature and the current working pressure

        /************delegates and events***********************************/
 
        //todo

        /************constructor******************************************/
        public Machine(String name, int temperature, int pressure)
        {
            this.name = name;
            this.temperature = temperature;
            this.pressure = pressure;
        }

        /************property's*********************************************/
        public String Name { get { return this.name; } }
        public int Temperature { get { return this.temperature; } }
        public int Pressure { get { return this.pressure; } }

        /************methods*********************************************/
        public void SetTemperature(int newTemperature)
        {
            this.temperature = newTemperature; 
           
        }

        public void SetPressure(int newPressure)
        {
            this.pressure = newPressure;
           
        }


        /// <summary>
        /// returns a string with information about the current temperature and current pressure
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            
            return "name: " + this.name +
                "; currrent temp: " + Convert.ToString(this.temperature) +
                "; current press: " + Convert.ToString(this.pressure) + ".";
        }

    }
}