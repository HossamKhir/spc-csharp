using System;
namespace Properties
{
    public class Box
    {
        // private attributes
        private double length;
        private double height;
        private double width;
        // private double volume;

        // properties
        // INFO: defining setters & getters will allow for having properties
        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Length cannot be less than 0");
                }
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Width cannot be less than 0");
                }
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Height cannot be less than 0");
                }
                height = value;
            }
        }

        // NOTE: properties allow to have read-only properties/fields
        public double Volume
        { get { return length * width * height; } }

        // NOTE: there is also the automatic properties, where the property only
        //  need to be get & set
        public string Unit { get; set; }

        public Box() { Unit = "cm"; }
        public Box(double length, double width, double height)
        : this()
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"Length:\t{Length}\nHeight:\t{Height}\nWidth:\t{Width}";
        }
    }
}