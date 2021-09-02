using System;
using System.Collections.Generic;
using System.Text;

namespace PaintCalculator
{
    class Room
    {
        private decimal width;
        private decimal height;
        private decimal length;
        private string measurement;
        private int coats;

        //setters and getters for each of the variables that will be used

        public decimal Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public decimal Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public int Coats
        {
            get
            {
                return coats;
            }
            set
            {
                coats = value;
            }
        }

        public string Measurement
        {
            get
            {
                return measurement;
            }
            set
            {
                measurement = value;
            }
        }

        //calculate the floor are of the room
        public decimal FloorArea
        {
            get
            {
                decimal area = width * length;
                return area;
            }

        }

        //calculate the total volume of the room
        public decimal RoomVolume
        {
            get
            {
                decimal volume = width * length * height;
                return volume;
            }

        }

        //calculate the amount of paint that will be required for the room.
        public decimal PaintRequired
        {
            get
            {
                //calculate the total walled are of the room
                decimal wallArea = (width * height * 2) + (length * height * 2);

                //different calculations for the different measurements
                if (measurement == "ft")
                {
                    //divide by 10m squared in the inches squared equivalent
                    decimal paintrequired = wallArea / 15500;
                    return paintrequired * coats;
                }
                else if (measurement == "cm")
                {
                    //divide by 10m squared in the cm squared equivalent
                    decimal paintrequired = wallArea / 100000;
                    return paintrequired * coats;
                    
                }
                else
                {
                    //divide by 10m squared
                    decimal paintrequired = wallArea / 10;
                    return paintrequired * coats;

                }
                
            }

        }

    }
}
