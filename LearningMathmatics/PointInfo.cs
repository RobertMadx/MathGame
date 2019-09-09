using System.Drawing;

namespace LearningMathmatics
{
    class PointInfo
    {
        // The default constructor has no parameters. The default constructor 
        // is invoked in the processing of object initializers. 
        public PointInfo() {
            CurrentPos = new Point(0, 0);
            EndPos = new Point(0, 0);
        }

        // The following constructor has two properties
        //Point variable for current x and y location of PointInfo
        public Point CurrentPos { get; set; }
        //Point variable for x and y animation end location, timer will keep moving point from Current to end location
        public Point EndPos { get; set; }

        //This method is to move point closer to the desired end location
        //Animation looks acceptable with increment of 1, change here if you should want to increase the speed
        public void MovePoint() {
            //Declare and initialise amount that the x and y value needs to change
            //This change can be either positive or negative depending on the difference between CurrentPos and EndPos
            int moveX = 0; 
            int moveY = 0;
            //Check if x axis needs to move, if not, do nothing
            if (CurrentPos.X != EndPos.X)
            {
                //Check if x axis needs to move down, decrese x (left on screen), else increment x (right on screen)
                moveX = (CurrentPos.X > EndPos.X) ? -1 : 1;
            }
            //Check if y axis needs to move, if not, do nothing
            if (CurrentPos.Y != EndPos.Y)
            {
                //Check if y axis needs to move down, decrese y (up on screen), else increment x (down on screen)
                moveY = (CurrentPos.Y > EndPos.Y) ? -1 : 1;
            }
            //return Point value of changes to CurrentPos
            CurrentPos = new Point(CurrentPos.X + moveX, CurrentPos.Y + moveY);
        }
                
    }
}
