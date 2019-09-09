using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMathmatics
{
    public class GameObject
    {
        // The default constructor has no parameters. The default constructor 
        // is invoked in the processing of object initializers. 
        // You can test this by changing the access modifier from public to 
        // private. The declarations in Main that use object initializers will 
        // fail.
        public GameObject() { }

        // The following constructor has parameters for two of the three 
        // properties. 

        public GameObject(Image ObjectImage, Point ObjectLocation)
        {
            Image = ObjectImage;
            Location = ObjectLocation;
            EndLocation = ObjectLocation;
            //Speed = 1;
            Column = 0;
            Status = "moving";
        }

        // Properties.
        public Image Image { get; set; }
        public Point Location { get; set; }
        public Point EndLocation { get; set; }
        //public int Speed { get; set; }
        public int Column { get; set; }
        public string Status { get; set; }


        //public override string ToString()
        //{
        //    return FirstName + "  " + ID;
        //}


    
        public void MoveObject() {
            int moveX = 0;
            int moveY = 0;
            int Speed;
            if (Location.X != EndLocation.X)
            {
                if (Location.X > EndLocation.X)
                {
                    Speed = AdjustSpeed(GetDifference(Location.X, EndLocation.X));
                    moveX = -(Speed);
                }
                else if (Location.X < EndLocation.X)
                {
                    Speed = AdjustSpeed(GetDifference(Location.X, EndLocation.X));
                    moveX = Speed;
                }
            }
            if (Location.Y != EndLocation.Y)
            {
                if (Location.Y > EndLocation.Y)
                {
                    Speed = AdjustSpeed(GetDifference(Location.Y, EndLocation.Y));
                    moveY = -(Speed);
                }
                else if (Location.Y < EndLocation.Y)
                {
                    Speed = AdjustSpeed(GetDifference(Location.Y, EndLocation.Y));
                    moveY = Speed;
                }
            }
            Location = new Point(Location.X + moveX, Location.Y + moveY);
        }

        private int AdjustSpeed(int gap)
        {
            switch (gap)
            {
                case int n when (n >= 0 && n <= 20):
                    return 1;
                case int n when (n >= 21 && n <= 40):
                    return 2;
                case int n when (n >= 41 && n <= 60):
                    return 3;
                case int n when (n >= 61 && n <= 100):
                    return 6;
                case int n when (n >= 101 && n <= 200):
                    return 8;
                case int n when (n >= 201):
                    return 10;
                default:
                    return -1;
            }
        }

        private int GetDifference(int A, int B)
        {
            if (A > B)
            {
                return A - B;
            }
            else if (B > A)
            {
                return B - A;
            }
            else
            {
                return 0;
            }
        }



    }
}
