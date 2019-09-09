
using System.Collections.Generic;
using System.Drawing;

namespace LearningMathmatics
{
    class LineInfo
    {
        // The default constructor has no parameters. The default constructor 
        // is invoked in the processing of object initializers. 
        public LineInfo() {
            Points = new List<PointInfo>();
            Character = "";
            LineColor = Color.White;
        }

        // Constructor to create LineInfo with parameters.
        public LineInfo(Point Location, int size)
        {
            Points = new List<PointInfo>(); //List of Points to be used
            Character = ""; //By default all characters
            for (int i = 0; i < 10; i++)
            {
                PointInfo start = new PointInfo();
                start.CurrentPos = Location;
                start.EndPos = Location;
                Points.Add(start);

            }
            PointInfo end = new PointInfo();
            end.CurrentPos = new Point(Location.X, Location.Y + size);
            end.EndPos = new Point(Location.X, Location.Y + size);
            Points.Add(end);
            CharSize = size;
            LineColor = Color.White;
        }

        // The following constructor has parameters for two of the three 
        // properties. 
        // Properties.
        public List<PointInfo> Points { get; set; }
        public string Character { get; set; }
        public int CharSize  { get; set; }
        public Color LineColor { get; set; }


        public void SetCharacter(string Char) {
            Point Anchor = Points[0].CurrentPos;
            Point topleft = new Point(Anchor.X, Anchor.Y);
            Point topright = new Point(Anchor.X + CharSize, Anchor.Y);
            Point topmiddle = new Point(Anchor.X + (CharSize / 2), Anchor.Y);

            Point bottomright = new Point(Anchor.X + CharSize, Anchor.Y + CharSize);
            Point bottomleft = new Point(Anchor.X, Anchor.Y + CharSize);
            Point bottommiddle = new Point(Anchor.X + (CharSize / 2), Anchor.Y + CharSize);

            Point middle = new Point(Anchor.X + (CharSize / 2), Anchor.Y + (CharSize / 2));
            Point leftmiddle = new Point(Anchor.X, Anchor.Y + (CharSize / 2));
            Point rightmiddle = new Point(Anchor.X + CharSize, Anchor.Y + (CharSize / 2));

            Point top1qleft = new Point(Anchor.X + (CharSize / 4), Anchor.Y);
            Point top1qright = new Point(Anchor.X + ((CharSize / 4) * 3), Anchor.Y);

            Point bottom1qleft = new Point(Anchor.X + (CharSize / 4), Anchor.Y + CharSize);
            Point bottom1qright = new Point(Anchor.X + ((CharSize / 4) * 3), Anchor.Y + CharSize);

            Point left1qtop = new Point(Anchor.X, Anchor.Y + (CharSize / 4));
            Point left1qbottom = new Point(Anchor.X, Anchor.Y + ((CharSize / 4) *3));

            Point right1qtop = new Point(Anchor.X + CharSize, Anchor.Y + (CharSize / 4));
            Point right1qbottom = new Point(Anchor.X + CharSize, Anchor.Y + ((CharSize / 4) * 3));

            Point devidetop = new Point(Anchor.X + (CharSize / 2), Anchor.Y + (CharSize / 4));
            Point devidebottom = new Point(Anchor.X + (CharSize / 2), Anchor.Y + ((CharSize / 4) * 3));

            Character = Char;
            switch (Char)
            {
                case "1":
                    {
                        Points[1].EndPos = top1qleft;
                        Points[2].EndPos = top1qleft;
                        Points[3].EndPos = top1qleft;
                        Points[4].EndPos = top1qleft;
                        Points[5].EndPos = top1qleft;
                        Points[6].EndPos = top1qleft;
                        Points[7].EndPos = topmiddle;
                        Points[8].EndPos = bottommiddle;
                        Points[9].EndPos = bottomleft;
                        Points[10].EndPos = bottomright;
                        
                    }
                break;
                case "2":
                    {
                        Points[1].EndPos = left1qtop;
                        Points[2].EndPos = left1qtop;
                        Points[3].EndPos = left1qtop;
                        Points[4].EndPos = left1qtop;
                        Points[5].EndPos = top1qleft;
                        Points[6].EndPos = top1qright;
                        Points[7].EndPos = right1qtop;
                        Points[8].EndPos = rightmiddle;
                        Points[9].EndPos = bottomleft;
                        Points[10].EndPos = bottomright;

                    }
                    break;
                case "3":
                    {
                        Points[1].EndPos = topleft;
                        Points[2].EndPos = topleft;
                        Points[3].EndPos = topleft;
                        Points[4].EndPos = topleft;
                        Points[5].EndPos = topright;
                        Points[6].EndPos = rightmiddle;
                        Points[7].EndPos = leftmiddle;
                        Points[8].EndPos = rightmiddle;
                        Points[9].EndPos = bottomright;
                        Points[10].EndPos = bottomleft;
                    }
                    break;
                case "4":
                    {
                        Points[1].EndPos = right1qbottom;
                        Points[2].EndPos = right1qbottom;
                        Points[3].EndPos = right1qbottom;
                        Points[4].EndPos = right1qbottom;
                        Points[5].EndPos = right1qbottom;
                        Points[6].EndPos = right1qbottom;
                        Points[7].EndPos = right1qbottom;
                        Points[8].EndPos = left1qbottom;
                        Points[9].EndPos = top1qright;
                        Points[10].EndPos = bottom1qright;
                    }
                    break;
                case "5":
                    {
                        Points[1].EndPos = topright;
                        Points[2].EndPos = topright;
                        Points[3].EndPos = topright;
                        Points[4].EndPos = topleft;
                        Points[5].EndPos = leftmiddle;
                        Points[6].EndPos = rightmiddle;
                        Points[7].EndPos = right1qbottom;
                        Points[8].EndPos = bottom1qright;
                        Points[9].EndPos = bottom1qleft;
                        Points[10].EndPos = bottomleft;
                    }
                    break;
                case "6":
                    {
                        Points[1].EndPos = topright;
                        Points[2].EndPos = topright;
                        Points[3].EndPos = topright;
                        Points[4].EndPos = topright;
                        Points[5].EndPos = topright;
                        Points[6].EndPos = topleft;
                        Points[7].EndPos = bottomleft;
                        Points[8].EndPos = bottomright;
                        Points[9].EndPos = rightmiddle;
                        Points[10].EndPos = leftmiddle;
                    }
                    break;
                case "7":
                    {
                        Points[1].EndPos = topleft;
                        Points[2].EndPos = topleft;
                        Points[3].EndPos = topleft;
                        Points[4].EndPos = topleft;
                        Points[5].EndPos = topleft;
                        Points[6].EndPos = topleft;
                        Points[7].EndPos = topleft;
                        Points[8].EndPos = topleft;
                        Points[9].EndPos = topright;
                        Points[10].EndPos = bottomleft;
                    }
                    break;
                case "8":
                    {
                        Points[1].EndPos = topleft;
                        Points[2].EndPos = topleft;
                        Points[3].EndPos = topright;
                        Points[4].EndPos = rightmiddle;
                        Points[5].EndPos = leftmiddle;
                        Points[6].EndPos = bottomleft;
                        Points[7].EndPos = bottomright;
                        Points[8].EndPos = rightmiddle;
                        Points[9].EndPos = leftmiddle;
                        Points[10].EndPos = topleft;
                    }
                    break;
                case "9":
                    {
                        Points[1].EndPos = rightmiddle;
                        Points[2].EndPos = rightmiddle;
                        Points[3].EndPos = rightmiddle;
                        Points[4].EndPos = rightmiddle;
                        Points[5].EndPos = rightmiddle;
                        Points[6].EndPos = rightmiddle;
                        Points[7].EndPos = leftmiddle;
                        Points[8].EndPos = topleft;
                        Points[9].EndPos = topright;
                        Points[10].EndPos = bottomright;
                    }
                    break;
                case "0":
                    {
                        Points[1].EndPos = bottomright;
                        Points[2].EndPos = bottomright;
                        Points[3].EndPos = bottomleft;
                        Points[4].EndPos = topleft;
                        Points[5].EndPos = topright;
                        Points[6].EndPos = bottomright;
                        Points[7].EndPos = bottomleft;
                        Points[8].EndPos = topleft;
                        Points[9].EndPos = topright;
                        Points[10].EndPos = bottomright;
                    }
                    break;
                case "+":
                    {
                        Points[1].EndPos = middle;
                        Points[2].EndPos = middle;
                        Points[3].EndPos = middle;
                        Points[4].EndPos = middle;
                        Points[5].EndPos = middle;
                        Points[6].EndPos = leftmiddle;
                        Points[7].EndPos = rightmiddle;
                        Points[8].EndPos = middle;
                        Points[9].EndPos = topmiddle;
                        Points[10].EndPos = bottommiddle;
                    }
                    break;
                case "*":
                    {
                        Points[1].EndPos = middle;
                        Points[2].EndPos = middle;
                        Points[3].EndPos = middle;
                        Points[4].EndPos = bottomleft;
                        Points[5].EndPos = middle;
                        Points[6].EndPos = topleft;
                        Points[7].EndPos = middle;
                        Points[8].EndPos = topright;
                        Points[9].EndPos = middle;
                        Points[10].EndPos = bottomright;
                    }
                    break;
                case "-":
                    {
                        Points[1].EndPos = leftmiddle;
                        Points[2].EndPos = rightmiddle;
                        Points[3].EndPos = leftmiddle;
                        Points[4].EndPos = rightmiddle;
                        Points[5].EndPos = leftmiddle;
                        Points[6].EndPos = rightmiddle;
                        Points[7].EndPos = leftmiddle;
                        Points[8].EndPos = rightmiddle;
                        Points[9].EndPos = leftmiddle;
                        Points[10].EndPos = rightmiddle;
                    }
                    break;
                case "/":
                    {
                        Points[1].EndPos = devidetop;
                        Points[2].EndPos = devidetop;
                        Points[3].EndPos = devidetop;
                        Points[4].EndPos = devidetop;
                        Points[5].EndPos = devidebottom;
                        Points[6].EndPos = devidebottom;
                        Points[7].EndPos = devidebottom;
                        Points[8].EndPos = devidebottom;
                        Points[9].EndPos = leftmiddle;
                        Points[10].EndPos = rightmiddle;
                    }
                    break;
                case "=":
                    {
                        Points[1].EndPos = left1qtop;
                        Points[2].EndPos = right1qtop;
                        Points[3].EndPos = left1qtop;
                        Points[4].EndPos = right1qtop;
                        Points[5].EndPos = left1qtop;
                        Points[6].EndPos = right1qtop;
                        Points[7].EndPos = left1qtop;
                        Points[8].EndPos = right1qtop;
                        Points[9].EndPos = left1qbottom;
                        Points[10].EndPos = right1qbottom;
                    }
                    break;
                case ".":
                    {
                        Points[1].EndPos = bottommiddle;
                        Points[2].EndPos = bottommiddle;
                        Points[3].EndPos = bottommiddle;
                        Points[4].EndPos = bottommiddle;
                        Points[5].EndPos = bottommiddle;
                        Points[6].EndPos = bottommiddle;
                        Points[7].EndPos = bottommiddle;
                        Points[8].EndPos = bottommiddle;
                        Points[9].EndPos = bottommiddle;
                        Points[10].EndPos = bottommiddle;
                    }
                    break;
                case "?":
                    {
                        Points[1].EndPos = left1qtop;
                        Points[2].EndPos = left1qtop;
                        Points[3].EndPos = left1qtop;
                        Points[4].EndPos = left1qtop;
                        Points[5].EndPos = top1qleft;
                        Points[6].EndPos = top1qright;
                        Points[7].EndPos = right1qtop;
                        Points[8].EndPos = middle;
                        Points[9].EndPos = devidebottom;
                        Points[10].EndPos = bottommiddle;
                    }
                    break;
                case "Y":
                    {
                        Points[1].EndPos = middle;
                        Points[2].EndPos = topleft;
                        Points[3].EndPos = middle;
                        Points[4].EndPos = bottommiddle;
                        Points[5].EndPos = middle;
                        Points[6].EndPos = topright;
                        Points[7].EndPos = middle;
                        Points[8].EndPos = topleft;
                        Points[9].EndPos = middle;
                        Points[10].EndPos = bottommiddle;
                    }
                    break;
                case "E":
                    {
                        Points[1].EndPos = topright;
                        Points[2].EndPos = topright;
                        Points[3].EndPos = topright;
                        Points[4].EndPos = topright;
                        Points[5].EndPos = topleft;
                        Points[6].EndPos = leftmiddle;
                        Points[7].EndPos = rightmiddle;
                        Points[8].EndPos = leftmiddle;
                        Points[9].EndPos = bottomleft;
                        Points[10].EndPos = bottomright;
                    }
                    break;
                case "S":
                    {
                        Points[1].EndPos = topright;
                        Points[2].EndPos = topright;
                        Points[3].EndPos = topright;
                        Points[4].EndPos = topright;
                        Points[5].EndPos = topright;
                        Points[6].EndPos = topleft;
                        Points[7].EndPos = leftmiddle;
                        Points[8].EndPos = rightmiddle;
                        Points[9].EndPos = bottomright;
                        Points[10].EndPos = bottomleft;
                    }
                    break;
                case "N":
                    {
                        Points[1].EndPos = topright;
                        Points[2].EndPos = bottomright;
                        Points[3].EndPos = topleft;
                        Points[4].EndPos = bottomleft;
                        Points[5].EndPos = topleft;
                        Points[6].EndPos = bottomright;
                        Points[7].EndPos = topright;
                        Points[8].EndPos = bottomright;
                        Points[9].EndPos = topleft;
                        Points[10].EndPos = bottomleft;
                    }
                    break;
                case "O":
                    {
                        Points[1].EndPos = bottomright;
                        Points[2].EndPos = bottomright;
                        Points[3].EndPos = bottomleft;
                        Points[4].EndPos = topleft;
                        Points[5].EndPos = topright;
                        Points[6].EndPos = bottomright;
                        Points[7].EndPos = bottomleft;
                        Points[8].EndPos = topleft;
                        Points[9].EndPos = topright;
                        Points[10].EndPos = bottomright;
                    }
                    break;
                case "":
                    {
                        Points[1].EndPos = middle;
                        Points[2].EndPos = middle;
                        Points[3].EndPos = middle;
                        Points[4].EndPos = middle;
                        Points[5].EndPos = middle;
                        Points[6].EndPos = middle;
                        Points[7].EndPos = middle;
                        Points[8].EndPos = middle;
                        Points[9].EndPos = middle;
                        Points[10].EndPos = middle;
                    }
                    break;
            }
        }
    }
}
