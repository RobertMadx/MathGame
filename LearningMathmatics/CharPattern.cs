using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMathmatics
{
    class CharPattern
    {

        List<CharPattern> P = new List<CharPattern>();
        // The default constructor has no parameters. The default constructor 
        // is invoked in the processing of object initializers. 
        // You can test this by changing the access modifier from public to 
        // private. The declarations in Main that use object initializers will 
        // fail.
        private CharPattern() { }

        // The following constructor has parameters for two of the three 
        // properties. 
        private CharPattern(Point ObjectLocation, Point ObjectStopLocation, int ObjectCol)
        {
            StartLocation = ObjectLocation;
            Location = ObjectLocation;
            EndLocation = ObjectStopLocation;
            Speed = 1;
            Column = ObjectCol;
            Status = "smile";
        }

        private CharPattern(Image ObjectImage, Point ObjectLocation, int ObjectCol)
        {
            StartLocation = ObjectLocation;
            Location = ObjectLocation;
            EndLocation = ObjectLocation;
            Speed = 1;
            Column = ObjectCol;
            Status = "smile";
        }

        private CharPattern(Image ObjectImage, Point ObjectLocation)
        {
            StartLocation = ObjectLocation;
            Location = ObjectLocation;
            EndLocation = ObjectLocation;
            Speed = 1;
            Column = 0;
            Status = "smile";
        }

        // Properties.

        private Point StartLocation { get; set; }
        private Point Location { get; set; }
        private Point EndLocation { get; set; }
        private int Speed { get; set; }
        private int Column { get; set; }
        private string Status { get; set; }
    }
}
