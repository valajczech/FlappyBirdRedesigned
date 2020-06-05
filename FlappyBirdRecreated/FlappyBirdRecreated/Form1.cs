using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace FlappyBirdRecreated
{
    public partial class ActualGame : Form
    {

        #region GameProperies
        int jumpSpeed = 50; //Decelares default jumpspeed, gotta be bigger than fallspeed to ensure playablity, default 75
        int fallSpeed = 10;//Declares default fallspeed, gotta be smaller than jumpspeed, default 10
        int gameSpeed = 15 ; //Declares default gamespeed, which might speedup after certain amount of time
        int points = 0;

        bool gameStarted = false;
        #endregion
        #region PlayerProperties
        int jumpStep = 1; //default step for jump
        int fallStep = 1; //defualt step for fall

        int PlayerX;//left
        int PlayerY;//top
        int PlayerXmax;//right
        int PlayerYmax;//bottom
        int topGap = 5  ;//3
        int leftGap = 7;//5
        int rightGap = 7;//4
        int botGap = 9;//5

        bool isJumping;
        bool isFalling;
        bool isAlive = true;
        #endregion
        #region ColumnProperties
        #region How it works?
        /*
         *      ColumnY is needed only on DownColumns!
         *              |
         *  ColumnX -> ---- <-ColumnMaxX
         *             |**|
         *             |**|
         *             ----
         *              |
         *      ColumnMaxY is needed only on UpColumns!
         * 
         * 
         * */
        #endregion
       

        int dCol1DefaultX;
        int dCol2DefaultX;
        int dCol3DefaultX;

        int uCol1DefaultX;
        int uCol2DefaultX;
        int uCol3DefaultX;

        #region DownColumns
        int dCol1X;
        int dCol1MaxX;
        int dCol1Y;

        int dCol2X;
        int dCol2MaxX;
        int dCol2Y;

        int dCol3X;
        int dCol3MaxX;
        int dCol3Y;
        #endregion
        #region UpColumns
        int uCol1X;
        int uCol1MaxX;
        int uCol1MaxY;

        int uCol2X;
        int uCol2MaxX;
        int uCol2MaxY;

        int uCol3X;
        int uCol3MaxX;
        int uCol3MaxY;
        #endregion
        //well to je hodně přehledné :)
        #endregion

        Stopwatch stopWatch = new Stopwatch();
       


        public ActualGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Game Elements

            gametimer.Start();
            gameStarted = true;
            gameSpeedTimer.Start();
           

            //debug
            stopWatch.Start();
            gameSpeedTimer.Start();
           

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {

                isFalling = false;

                for(int jump =0; jump < jumpSpeed; jump++) //To render all the frames in Jump, so it doesnt teleport (well, it does, what the fuck is wrong?)
                {
                    Jump(jumpStep);
                    
                }
                
                //debug
                lbl_jumping.Text = "jumps";
                lbl_falling.Text = "null";
                

            }
            else
            {
                isJumping = false;
                isFalling = true;
            }
           
            
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void gametimer_Tick(object sender, EventArgs e)
        {


            #region Debug
            //Fall(1);
            //Jump(1);

            lbl_falling.Visible = false;
            lbl_jumping.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            #endregion

            isFalling = true;
            isJumping = false;

            MoveColumns(gameSpeed);
            

            while (gameStarted && isFalling)
            {
                
                for (int fall = 0; fall < fallSpeed; fall++)//to render all the frames in fall so it doesnt just teleport :)
                {
                    Fall(fallStep);   
                }

                //debug
                lbl_falling.Text = "falls";
                lbl_jumping.Text = "null";
                break;
            }

        }

        void Fall(int fallSpeed)
        {
            GameObject_Player.Top += fallStep;
            GetPlayerCoordinates();
            GetColumnsCoordinates();
            CheckForCollision();
            
        }

        void Jump(int jumpSpeed)
        {
            GameObject_Player.Top -= jumpSpeed;
            GetPlayerCoordinates();
            GetColumnsCoordinates();
            CheckForCollision();
            
        }

        void MoveColumns(int gameSpeed)
        {//create column movement
            dCol1DefaultX = DownColumn_1.Left;
            dCol2DefaultX = DownColumn_2.Left;
            dCol3DefaultX = DownColumn_3.Left;
            uCol1DefaultX = UpColumn_1.Left;
            uCol2DefaultX = UpColumn_2.Left;
            uCol3DefaultX = UpColumn_3.Left;
            //for RestartGame()
            Random height = new Random();


            if (DownColumn_1.Left >=0)
            {
                DownColumn_1.Left -= gameSpeed;
            }
            else
            {
                DownColumn_1.Left = 800;
                DownColumn_1.Top = height.Next(200, 350);
            }

            if (DownColumn_2.Left >= 0)
            {
                DownColumn_2.Left -= gameSpeed;
            }
            else
            {
                DownColumn_2.Left = 800;
                DownColumn_2.Top = height.Next(200, 350);
            }

            if (DownColumn_3.Left >= 0)
            {
                DownColumn_3.Left -= gameSpeed;
            }
            else
            {
                DownColumn_3.Left = 800;
                DownColumn_3.Top = height.Next(200, 350);
            }

            if (UpColumn_1.Left >= 0)
            {
                UpColumn_1.Left -= gameSpeed;
            }
            else
            {
                UpColumn_1.Left = 800;
                UpColumn_1.Top = height.Next(-400, -250);
            }

            if (UpColumn_2.Left >= 0)
            {
                UpColumn_2.Left -= gameSpeed;
            }
            else
            {
                UpColumn_2.Left = 800;
                UpColumn_2.Top = height.Next(-400,-250);
            }

            if (UpColumn_3.Left >= 0)
            {
                UpColumn_3.Left -= gameSpeed;
            }
            else
            {
                UpColumn_3.Left = 800;
                UpColumn_3.Top = height.Next(-400, -250);
            }


        }

  

        void RestartGame()
        {
            DownColumn_1.Left = dCol1DefaultX;
            DownColumn_2.Left = dCol2DefaultX;
            DownColumn_3.Left = dCol3DefaultX;
            UpColumn_1.Left = uCol1DefaultX;
            UpColumn_2.Left = uCol2DefaultX;
            UpColumn_3.Left = uCol3DefaultX;

            GameObject_Player.Left = 59;
            GameObject_Player.Top = 181;

            gametimer.Start();
            gameSpeed = 15;
        }

        void CheckForCollision()
        {
            if((((PlayerXmax <= dCol1MaxX)&&(PlayerXmax>=dCol1X))||((PlayerX>=dCol1X)&&(PlayerX <=dCol1MaxX)))&&(PlayerYmax==dCol1Y))
            {//Collides on top of the DownCollumn1
                Collide();
            }
            else if((((PlayerXmax <= dCol2MaxX) && (PlayerXmax >= dCol2X)) || ((PlayerX >= dCol2X) && (PlayerX <= dCol2MaxX))) && (PlayerYmax == dCol2Y))
            {//Collides on top of the DownColumn2
                Collide();
            }
            else if ((((PlayerXmax <= uCol1MaxX) && (PlayerXmax >= uCol1X)) || ((PlayerX >= uCol1X) && (PlayerX <= uCol1MaxX))) && (PlayerY == uCol1MaxY))
            {//Collides on bottom of the UpColumn1
                Collide();
            }
            else if ((((PlayerXmax <= uCol2MaxX) && (PlayerXmax >= uCol2X)) || ((PlayerX >= uCol2X) && (PlayerX <= uCol2MaxX))) && (PlayerY == uCol2MaxY))
            {//Collides on bottom of the UpColumn1
                Collide();
            }
            else if(((PlayerXmax >= dCol1X && (PlayerXmax<=dCol1MaxX)) && (PlayerYmax >= dCol1Y)))
            {//Collides on left side of the DownColumn1
                Collide();
            }
            else if (((PlayerXmax >= dCol2X) && (PlayerXmax <= dCol2MaxX) && (PlayerYmax >= dCol2Y)))
            {//Collides on left side of the DownColumn2
                Collide();
            }
            else if (((PlayerXmax >= uCol1X) && (PlayerXmax <= uCol1MaxX) && (PlayerY <= uCol1MaxY)))
            {//Collides on left side of the UpColumn1
                Collide();
            }
            else if (((PlayerXmax >= uCol2X) && (PlayerXmax <= uCol2MaxX) && (PlayerY <= uCol2MaxY)))
            {//Collides on left side of the UpColumn2
                Collide();
            }
            else if ((((PlayerXmax <= dCol3MaxX) && (PlayerXmax >= dCol3X)) || ((PlayerX >= dCol3X) && (PlayerX <= dCol3MaxX))) && (PlayerYmax == dCol3Y))
            {//Collides on top of the DownColumn3
                Collide();
            }
            else if (((PlayerXmax >= dCol3X) && (PlayerXmax <= dCol3MaxX) && (PlayerYmax >= dCol3Y)))
            {//Collides on left side of the DownColumn3
                Collide();
            }
            else if (((PlayerXmax >= uCol3X) && (PlayerXmax <= uCol3MaxX) && (PlayerY <= uCol3MaxY)))
            {//Collides on left side of the UpColumn3
                Collide();
            }
            else if ((((PlayerXmax <= uCol3MaxX) && (PlayerXmax >= uCol3X)) || ((PlayerX >= uCol3X) && (PlayerX <= uCol3MaxX))) && (PlayerY == uCol3MaxY))
            {//Collides on bottom of the UpColumn3
                Collide();
            }
            //Zjistil jsem, že pictureBox jako takový má vlastnost Bounds, která handluje hranice pictureBoxu.
            //Nicméně v době developu jsem o tom nevěděl, tak jsem to řešil těmito mega složitýma podmínkama, 
            //které zjišťují, zda-li se nějáká hrana pictureBoxu (hráče) dotýká sloupu, a právě tyto Bounds jsem  řešil
            //pomocí object.X(Y) a object.MaxX(Y)
            //kdybych použil Bounds vlatnost, podmínky by byly jednodušší a vypadaly by asi takto:
            //if(GameObject_Player.Bounds.IntersectsWith(DownColumn_1)){
            //  Collide();
            //}

            //well, takže je tu docela dost zbytečného kódu, ale už budu dělat s tím co mám a dokončím to. Nakonec technicky vzato
            // jsem si procvičil logické myšlení což je +1 za mě.

        }

        void Collide()
        {
            gametimer.Stop();
            lbl_death.Visible = true;
            lbl_restart.Visible = true;
            btn_bckMain.Visible = true;
            btn_restart.Visible = true;
            btn_bckMain.Enabled = true;
            btn_restart.Enabled = true;
            trolololo.Visible = true;
        }
        void GetPlayerCoordinates()
        {
            PlayerX = GameObject_Player.Left - leftGap; 
            PlayerY = GameObject_Player.Top + topGap;
            PlayerXmax = GameObject_Player.Right - rightGap;
            PlayerYmax = GameObject_Player.Bottom - botGap;
            //innnerGap bcuz I gotta handle the real size of the character which is not 50;50, but something less bcuz imma dumb and painted it wrong
        }

        void GetColumnsCoordinates()
        {//are 4 columns enough?
            dCol1X = DownColumn_1.Left;
            dCol1MaxX = DownColumn_1.Right;
            dCol1Y = DownColumn_1.Top;

            dCol2X = DownColumn_2.Left;
            dCol2MaxX = DownColumn_2.Right;
            dCol2Y = DownColumn_2.Top;

            dCol3X = DownColumn_3.Left;
            dCol3MaxX = DownColumn_3.Right;
            dCol3Y = DownColumn_3.Top;

            uCol1X = UpColumn_1.Left;
            uCol1MaxX = UpColumn_1.Right;
            uCol1MaxY = UpColumn_1.Bottom;

            uCol2X = UpColumn_2.Left;
            uCol2MaxX = UpColumn_2.Right;
            uCol2MaxY = UpColumn_2.Bottom;

            uCol3X = UpColumn_3.Left;
            uCol3MaxX = UpColumn_3.Right;
            uCol3MaxY = UpColumn_3.Bottom;
        }
        
        

       
        private void testTimer_Tick(object sender, EventArgs e)//is GameSpeedTimer
        {
            //Timer's interval is 5 seconds, so after 5 seconds the game will speed up
            gameSpeed += 2;

        }
       
        private void GameObject_Player_Click(object sender, EventArgs e)
        {

        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            gametimer.Start();
            gameSpeedTimer.Start();
            RestartGame();
            

            lbl_death.Visible = false;
            lbl_restart.Visible = false;
            btn_bckMain.Visible = false;
            btn_restart.Visible = false;
            btn_restart.Enabled = false;
            btn_bckMain.Enabled = false;
            trolololo.Visible = false;


        }

        private void btn_bckMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trolololo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ"); //got rickrolled?
           
        }
        //Je tu dost zbytečného kódu ale funguje to :)

       

    }
}
