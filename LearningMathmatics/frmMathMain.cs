using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

//D101 Programming Fundamentals Assignment - Part 1, Math Game
//Code and comments by Robert Madden, student number 1721631

namespace LearningMathmatics
{
    public partial class frmMathMain : Form
    {
        //Private Lists for GameObjects, Emoji images and LineList which are accessed by timer and needs to be global
        private List<GameObject> GOList = new List<GameObject>();
        private List<Image> Emoji = new List<Image>();
        private List<LineInfo> LineList = new List<LineInfo>();
        //Private globally declare and initialise the Sound player for Game Sounds to plays from multiple locations.
        private System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //Every time you do new Random() it is initialized.
        //This means that in a tight loop you get the same value lots of times.
        //You should keep a single Random instance and keep using Next on the same instance. 
        //This is why I declared it as a private static readonly variable.
        private static readonly Random random = new Random();

        //Private globally declare and initialise DrawArea, this is for all the animations.
        private Bitmap DrawArea;
        
        //Default method to initialise components
        public frmMathMain()
        {
            //Standard Initialisation of Objects
            InitializeComponent();
        }

        private void frmMathMain_Load(object sender, EventArgs e)
        {
            //I use 71 Emoji images and this loop loads the resources into a List of Images
            for (int i = 1; i <= 71; i++)
            {
                Emoji.Add(GetImageByName("_" + i));//Using method a methos to fetch image from project resources
            }
            
            //Initialising the size of DrawArea, used to draw animation on.
            DrawArea = new Bitmap(pbxAnimation.Size.Width, pbxAnimation.Size.Height);

            //This next block of code will add lines for animated question characters, the  1 + 2 x 3 = ???? part
            int x = 25;     // Start X location of character line
            int y = 60;     // Start Y location of character line
            int gap = 30;   //variable used to easily change the gap between characters
            int chars = 18; //Number of characters to create
            //Loop to create anchor points for characters.  
            for (int c = 0; c <= chars; c++) {
                LineList.Add(new LineInfo(new Point(x + (c*gap) + (c * gap / 3), y), gap));
            }

            //Reused x,y and gap as they are already declared above
            //This will be for the "YES" and "NO" character animation
            x = 420;
            y = 310;
            gap = 50;
            LineList.Add(new LineInfo(new Point(x, y), gap));
            LineList.Add(new LineInfo(new Point(x + gap + (gap / 3), y), gap));
            LineList.Add(new LineInfo(new Point(x + (2 * gap) + (2 * gap / 3), y), gap));
            
            //Now that everything is set up, we can call method RandomNewGame to create a question to start off with.
            RandomNewGame();
        }

        //Private method to read a image file from resources and returns a resized image.
        private Bitmap GetImageByName(string imageName)
        {
            //Please reference link below for origin of the next 3 lines of code
            //https://stackoverflow.com/questions/1192054/load-image-from-resources-area-of-project-in-c-sharp/1192076
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            //Call method ResizeImage, returning a resize image, then ends method by returning the result
            return ResizeImage((Bitmap)rm.GetObject(imageName), 20, 20);
        }

        private void RandomNewGame()
        {
            int ValueA, ValueB, ValueC, Symbol1, Symbol2;

            //Loop through all Line charecters and reset to nothing
            for (int i = 0; i < LineList.Count; i++)
            {
                LineList[i].SetCharacter("");
                LineList[i].LineColor = Color.White;
            }
            
            //Use switch statement on current progress to determine game difficuilty
            switch (prgProgress.Value)
            {
                //if progress bar value between 0 and 50, only use Symbol 2, which is +
                case int n when (n >= 0 && n <= 50):
                    Symbol1 = 2;
                    Symbol2 = 2;
                    break;
                //if progress bar value between 51 and 150, random between 2 numbers which is will be either + or *
                case int n when (n >= 51 && n <= 150):
                    Symbol1 = random.Next(2, 4);
                    //if symbol 1 is + then make symbol 2 *, and vise versa
                    if (Symbol1 == 3)
                    {
                        Symbol2 = 2;
                    }
                    else {
                        Symbol2 = 3;
                    }
                    break;
                //if progress bar value between 0 and 50, only use Symbol 3, which is *
                case int n when (n >= 151 && n <= 350):
                    Symbol1 = 3;
                    Symbol2 = 3;
                    break;
                default:
                    //By default, only use Symbol 2, which is +
                    Symbol1 = 2;
                    Symbol2 = 2;
                    break;
            }
            //Symbols int value, for reference
            //1 = -
            //2 = +
            //3 = *
            //4 = /

            //Generate random int values for value A, B and C
            ValueA = random.Next(1, 11);
            ValueB = random.Next(1, 11);
            ValueC = random.Next(1, 11);

            //Set start index and Linecharacter values for animation
            setCharacter(0, ValueA);
            setCharacter(4, ValueB);
            setCharacter(8, ValueC);

            //Set Line character for the symbols and "=" sign
            //The GetSymbolString method returns a string value from int representation
            LineList[3].SetCharacter(GetSymbolString(Symbol1));
            LineList[7].SetCharacter(GetSymbolString(Symbol2));
            LineList[11].SetCharacter("=");

            //Hidden feature in game, can be discovered by resizing form to the right.
            //Incedently this is now also used to store the result instead of using a global variable.
            //Also used for testing purposes as the game gets realy hard
            lblEasterEgg.Text = Math.Round(GetCorrectResult(ValueA, Symbol1, ValueB, Symbol2, ValueC), 1, MidpointRounding.AwayFromZero).ToString();

            //Create question marks giving a clue as to the length of the answer
            for (int i = 13; i < (lblEasterEgg.Text.Length + 13); i++)
            {
                LineList[i].SetCharacter("?");
            }

            //Methos to clear Emoji GameObject List and recreate according to value A,B and C
            ResetEmoji(ValueA, ValueB, ValueC);
            
            //Reset input textbox to nothing, ready for next answer.
            tbxInput.Text = "";

            //Question as created so enable Submit button for user to answer
            btnSubmit.Visible = true;
            //Show Make Question button if user wants to create another random question
            btnMakeQuestion.Visible = true;
            //Resets input textbox color to orange, turns green with win and red with lose
            tbxInput.ForeColor = Color.Orange;
        }

        //private method to set Line characters values
        //Provided with start index if LineList and a value to represent
        private void setCharacter(int startindex, int value) {
            //With a value less than 10, the first character needs to be blank
            if (value < 10)
            {
                //the SetCharacter method changes the Point of LineList to match the character required, see LineInfo.cs
                LineList[startindex].SetCharacter("");
                LineList[startindex + 1].SetCharacter(value.ToString());
            }
            //else the first character needs to be 1 and the next 0, 10 being only number in game with 2 digits
            else
            {
                //the SetCharacter method changes the Point of LineList to match the character required, see LineInfo.cs
                LineList[startindex].SetCharacter("1");
                LineList[startindex+1].SetCharacter("0");
            }
        }

        //Private Method returning a decimal value and provided with question values
        private decimal GetCorrectResult(int ValueA,int Symbol1, int ValueB, int Symbol2, int ValueC) {
            //We have a int value assigned to the symbols, 2 = + and 3 = *.
            //This will determine the order of calculation in the event of + and * question
            if (Symbol2 > Symbol1 && Symbol2 > 2)
            {
                //Use of CalculateShortAnswer method twice, since we have 2 calculations to do
                return CalculateShortAnswer(ValueA, CalculateShortAnswer(ValueB, ValueC, Symbol2), Symbol1);
            }
            //If Symbol2 is not * then all calcualtions can proceed with (A and B), then C
            else
            {
                //Use of CalculateShortAnswer method twice, since we have 2 calculations to do
                return CalculateShortAnswer(CalculateShortAnswer(ValueA, ValueB, Symbol1), ValueC, Symbol2);
            }
        }

        //Private method returning a decimal value, using 2 values and calculating the answer by using a Symbol
        private decimal CalculateShortAnswer(decimal value1, decimal value2, int Symbol) {
            //Symbols int value, for reference
            //1 = -
            //2 = +
            //3 = *
            //4 = /
            //Do calculation depending on the symbol value
            switch (Symbol)
            {
                case 1:
                    //Although not used in final version of this game, it is optional to use minus
                    return value1 - value2;
                case 2:
                    //2 = +, adding the two values provided
                    return value1 + value2;
                case 3:
                    //3 = *, multiply the two values provided
                    return value1 * value2;
                case 4:
                    //Although not used in final version of this game, it is optional to use division
                    //It is not easy to calculate decimal values and it is not recommended using division
                    return value1 / value2;
                default:
                    //if symbol value is out of range, return 0
                    return 0;
            }
        }

        //Private method to reset all Emoji images, receives question values to create number of face
        private void ResetEmoji(int intA, int intB, int intC) {
            //Start off by clearing the list
            GOList.Clear();
            //Now create GameObjects for each of the question values
            CreateEmojiForValue("A", intA);
            CreateEmojiForValue("B", intB);
            CreateEmojiForValue("C", intC);
        }

        //Private method to create emoji's for each column and value provided
        private void CreateEmojiForValue(string column, int intvalue) {
            //Declare and initialise x,y and spacing variables.
            int y = 120;
            int x = 0;
            int gapx = 30;
            //Use switch on column string to determine x start positions
            switch (column) {
                case "A" :
                    x = 30;
                    break;
                case "B":
                    x = 190;
                    break;
                case "C":
                    x = 350;
                    break;
            }
            //Declare and initialise i.
            int i = 1;
            //While loop rather than "for" loop used, due to 2 columns of images
            //Its not easy to manipulate i in a for loop
            while (i <= intvalue)
            {
                //Add GameObject at desired location
                GOList.Add(new GameObject(Emoji[GenerateRandomInt("moving")], new Point(x, y)));
                i++;
                //Check to see if i is still less than value required, if so add another object next to previous
                if (i <= intvalue)
                {
                    //Add GameObject at desired location
                    GOList.Add(new GameObject(Emoji[GenerateRandomInt("moving")], new Point(x + gapx, y)));
                    i++;
                }
                //Increment y to move to next row
                y += 40;
            }
        }

        //Private method provided with a string and returning a random int
        private int GenerateRandomInt(string status)
        {
            //We have 71 Emoji's, 3 groups depending on the game status
            //Will change depending on the user answers
            switch (status)
            {
                case "smile": return random.Next(0, 26); //Smiling 0 to 25, faces for winning
                case "moving": return random.Next(26, 46);//Moving 26 to 45, faces for wating
                case "sad": return random.Next(46, 71);//Lose 46 to 70, faces for losing
                default: return random.Next(0, 71);//By default return any face
            }
        }

        //Private method to get string value of int representation
        private string GetSymbolString(int intsymbol) {
            //Depending on intsymbol value, return appropriate string, used to render animation
            switch (intsymbol)
            {
                case 1: return "-";
                case 2: return "+";
                case 3: return "*";
                case 4: return "/";
                default: return "+";
            }
        }

        //Private static method provided with Image, width and height parameters to resize and return image
        //Source: https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        //The heart of any animated game, the Update method
        //This timer has and interval of 30, giving a frame rate of approximately 33 frame per second.
        private void tmeUpdate_Tick(object sender, EventArgs e)
        {
            //Declare graphics variable to be used for drawing
            Graphics g;
            //Initialise graphics by using Global DrawArea.
            g = Graphics.FromImage(DrawArea);
            //Use of existing image in memory rather than creating a new one.
            //This will create a clean backdrop to draw animations on
            g.DrawImage(pbxAnimation.BackgroundImage, new Point(0, 0));
            
            //Declare Pen to be used for drawing Character Lines
            Pen Line = new Pen(Color.White, 8);
            //Declare Brush to be used for drawing Character Lines, this is to draw FillEllipse creating round edges
            Brush b = new SolidBrush(Color.White);

            //First we draw all the Line Characters by loop through them
            foreach (LineInfo L in LineList)
            {
                //Each Line Character have 10 points that, drawing a line from 1 to 2, 2 to 3 ex...
                for (int i = 1; i < L.Points.Count; i++) {
                    //This methodd is called to first do all the movements required. 
                    //Moving all lines 1 to 10, 0 == blank character and nothing is drawn
                    L.Points[i].MovePoint();
                    //Whe need to skip 10 because there are no 11 to connect the line with
                    if (i < L.Points.Count - 1){
                        //if the character to draw is "=" we need to not draw line between 8 and 9, provding a gap
                        if (L.Character == "=" && i == 8)
                        {
                            //Do nothing
                        }
                        //Devide charecter to skip some lines to draw
                        else if (L.Character == "/" && (i == 4 || i == 8)) {
                            //Do nothing
                        }
                        //Question mark charecter to skip some lines to draw
                        else if (L.Character == "?" && (i == 9))
                        {
                            //Do nothing
                        }
                        //Blank charecter where nothing is drawn
                        else if (L.Character == "")
                        {
                            //Do nothing
                        }
                        else
                        {
                            //Set Line Colors as required
                            Line.Color = L.LineColor;
                            //Draw a the line, from Point i to i + 1
                            g.DrawLine(Line, L.Points[i].CurrentPos.X, L.Points[i].CurrentPos.Y, L.Points[i + 1].CurrentPos.X, L.Points[i + 1].CurrentPos.Y);
                        }
                        
                    }
                    //We now need to draw a FillEllipse on each point which will create a round edge on characters
                    //if "" do nothing
                    if (L.Character != "") {
                        //Set the color as required
                        b = new SolidBrush(L.LineColor);
                        //Draw FillEllipse at Point location
                        g.FillEllipse(b, L.Points[i].CurrentPos.X -4, L.Points[i].CurrentPos.Y - 4, 8, 8);
                    }
                }
            }

            //Now we need to draw Emoji's
            //Declare and initialise l as a variable
            int l = 0;
            //I am using a while loop rather than for due to the potensial removal of Abjects from list
            while (l < GOList.Count) {
                //method to move Emoji's as required
                GOList[l].MoveObject();
                //If emoji hits bottom we need to remove it
                if (GOList[l].Location.Y == 360) {
                    //if it was a sad emoji, meaning the player lost, we subtract from progress bar
                    if (GOList[l].Status == "sad")
                    {
                        //Do not go less than zero
                        if (prgProgress.Value > 0) {
                            //Subtract 1 from progress bar
                            prgProgress.Value -= 1;
                            //Method to set color of progress bar, green=easy, yellow=medium, red=hard
                            SetProgressBarColor();
                            //Play a sound
                            player.SoundLocation = "subtract.wav";
                            player.Play();
                        }
                    }
                    //else a happy emoji, meaning the player won, we add to progress bar
                    else
                    {
                        //Do not go more than max
                        if (prgProgress.Value < prgProgress.Maximum)
                        {
                            //Add 1 to progress bar
                            prgProgress.Value += 1;
                            //Method to set color of progress bar, green=easy, yellow=medium, red=hard
                            SetProgressBarColor();
                            //Play a sound
                            player.SoundLocation = "add.wav";
                            player.Play();
                        }
                        else {
                            //Proffesional award, only achieved when max is reached.
                            lblProfessional.Visible = true;
                        }
                    }
                    //Update label to how progress made
                    lblProgress.Text = prgProgress.Value.ToString() + " / " + prgProgress.Maximum.ToString();
                    //Remove Object as it hit the progress bar
                    GOList.RemoveAt(l);
                } else
                {
                    //Draw emoji at its current Object Location
                    g.DrawImage(GOList[l].Image, GOList[l].Location);
                    //Loop to next Emoji
                    l++;
                }
            }

            //Check if animation is complete (No more GameObjects and btnSubmit is not visible) to enable user to create a new question
            if (GOList.Count == 0 && btnSubmit.Visible == false)
            {
                //Show button to Make New Question, 
                btnMakeQuestion.Visible = true;
            }
            
            //Now that all images are drawn, set picture box image
            pbxAnimation.Image = DrawArea;
        }

        //Private method to set end location of all Emoji's
        private void EndGameAnimation(string state)
        {
            //Loop though all Objects in GOList
            foreach (GameObject O in GOList)
            {
                //Set end locations required
                O.EndLocation = new Point(O.Location.X, 360);
                //Set image to either win or lose face
                O.Image = Emoji[GenerateRandomInt(state)];
                //each object status, smile or sad
                O.Status = state;
            }
        }

        //Private Method to Make a New question
        private void btnMakeQuestion_Click(object sender, EventArgs e)
        {
            //Set the Default Enter action to the Submit button
            ActiveForm.AcceptButton = btnSubmit;
            //Method to Reset game and create new numbers
            RandomNewGame();
            //Start drain timer
            tmeDrain.Start();
        }

        //Submit click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Read and convert Answer from textbox
            if (!decimal.TryParse(tbxInput.Text, out decimal Answer)) {
                //If Parse failed, value was entered incorrectly
                //Advise user to enter the correct value
                MessageBox.Show("Please enter numbers only, a maximum length of 4 characters are allowed.");
                //Clear the textbox
                tbxInput.Text = "";
                //Exit method
                return;
            }
            //Hide Submit and Make Question button to allow animation to complete
            btnSubmit.Visible = false;
            btnMakeQuestion.Visible = false;
            
            //Declare and initialise ints to get current progress
            int TimesTried = int.Parse(lblTried.Text);
            int CorrectAnswers = int.Parse(lblCorrect.Text);
            //Increment times tried
            TimesTried += 1;
            //If new player was created, New Player button will be hidden, this will make sure it is shown
            btnNewPlayer.Visible = true;
            //Stop drain counter
            tmeDrain.Stop();
            //Get correct answer from lblEasterEgg
            if (Answer == decimal.Parse(lblEasterEgg.Text))
            {
                //If correct, change emoji's to smiles
                EndGameAnimation("smile");
                //Increment Correct answers
                CorrectAnswers += 1;
                //Change Input textbox to green color
                tbxInput.ForeColor = Color.Lime;
                //Load and play win sound
                player.SoundLocation = "win.wav";
                player.Play();
                //Change Line characters to indicate win
                LineList[19].SetCharacter("Y");
                LineList[20].SetCharacter("E");
                LineList[21].SetCharacter("S");
                //Change linecharacter color to geen
                for (int i = 19; i <= 21; i++)
                {
                    LineList[i].LineColor = Color.Lime;
                }
                //Change linecharacters, the question marks, to answer and color to green
                for (int i = 13; i < lblEasterEgg.Text.Length + 13; i++)
                {
                    LineList[i].SetCharacter(lblEasterEgg.Text.Substring(i - 13, 1));
                    LineList[i].LineColor = Color.Lime;
                }
            }
            else {
                //If lose, change emoji's to sad faces
                EndGameAnimation("sad");
                //Change Input textbox to red color
                tbxInput.ForeColor = Color.Red;
                //Load and play lose sound
                player.SoundLocation = "lose.wav";
                player.Play();
                //Change Line characters to indicate loss
                LineList[19].SetCharacter("N");
                LineList[20].SetCharacter("O");
                LineList[21].SetCharacter("");
                //Change linecharacter color to red
                for (int i = 19; i <= 21; i++)
                {
                    LineList[i].LineColor = Color.Red;
                }
                //Change linecharacters, the question marks, to answer and color to red
                for (int i = 13; i < lblEasterEgg.Text.Length + 13; i++)
                {
                    LineList[i].SetCharacter(lblEasterEgg.Text.Substring(i - 13, 1));
                    LineList[i].LineColor = Color.Red;
                }
            }
            //Apply update to labels accordingly
            lblTried.Text = TimesTried.ToString();
            lblCorrect.Text = CorrectAnswers.ToString();
            //Change the default accept button to MakeQuestion, for pressing enter to continue game rather than clicking.
            ActiveForm.AcceptButton = btnMakeQuestion;
        }

        
        //Click event to create new player record, resets score and progress
        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            //Dialog message requesting confirmation from user, Yes or No
            DialogResult dialogResult = MessageBox.Show("Current player record will be lost, do you want to create a new player record?", "Create New Player", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Reset times tried and correct answers labels
                lblCorrect.Text = "0";
                lblTried.Text = "0";
                //Reset progress bar to zero
                prgProgress.Value = 0;
                //Create a new random game, will be on easy as we set the progressbar to 0
                RandomNewGame();
                //Hide the New Player button as we just created a New player.
                btnNewPlayer.Visible = false;
                //Because we have a new question now we can default the accept button to be the Submit button
                ActiveForm.AcceptButton = btnSubmit;
                //In case the previous player achieved the high score, hide lblProfessional label
                lblProfessional.Visible = false;
            }
        }

        //Private method to set the color of te progress bar depending on the progress bar value
        private void SetProgressBarColor() {
            //Use progress bar value in switch case
            switch (prgProgress.Value)
            {
                case int n when (n >= 0 && n <= 50):
                    ModifyProgressBarColor.SetState(prgProgress, 1); //Change state to green color
                    break;
                case int n when (n >= 51 && n <= 150):
                    ModifyProgressBarColor.SetState(prgProgress, 3);//Change state to orange color
                    break;
                case int n when (n >= 151 && n <= 350):
                    ModifyProgressBarColor.SetState(prgProgress, 2);//Change state to red color
                    break;
                default:
                    ModifyProgressBarColor.SetState(prgProgress, 1);//By default set to green color
                    break;
            }
        }

        //Drain timer to drain progress when waiting for answer, creates urgency to answer quickly
        private void tmeDrain_Tick(object sender, EventArgs e)
        {
            //Make sure to only drain while progress os more than 0 and that Submit button is visible which means the game is waiting for an answer
            if (prgProgress.Value > 0 && btnSubmit.Visible == true)
            {
                //Decrease progress progress by 1
                prgProgress.Value -= 1;
                //Change to drain speed according to current progress
                switch (prgProgress.Value)
                {
                    case int n when (n >= 0 && n <= 50)://Slowest interval, easy mode
                        tmeDrain.Interval = 2000;
                        break;
                    case int n when (n >= 51 && n <= 150)://Medium mode interval
                        tmeDrain.Interval = 1500;
                        break;
                    case int n when (n >= 151 && n <= 350)://Hard mode, fastest interval
                        tmeDrain.Interval = 1000;
                        break;
                    default:
                        break;
                }
                //Method to change color of progress bar accordingly
                SetProgressBarColor();
                //Play drainage sound
                player.SoundLocation = "subtract.wav";
                player.Play();
                //Updates label indicating progress
                lblProgress.Text = prgProgress.Value.ToString() + " / " + prgProgress.Maximum.ToString();
            }
        }

        //Click method to hide help picture box, only shows when opening the game the first time
        private void pbxHelp_Click(object sender, EventArgs e)
        {
            pbxHelp.Visible = false;
        }
    }
}
