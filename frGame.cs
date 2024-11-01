
using DevExpress.Utils.Extensions;
using PictureboxForm.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureboxForm
{
    public partial class frGame : Form 
    {
        

        public frGame()
        {
            InitializeComponent();
        }
        public frControl frControl;
        private sbyte _Counter = 0 ; 
        
        enum enPlayers { Player_1 , Player_2}
        enPlayers PlayerTurn; 

        public void EndGame()
        {
            this.Close();
        }
        public void ShowMessage()
        {
            MessageBox.Show("Finnal Result", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void StartGame(frControl Control)
        {
            frControl = Control;
            frControl.lbl_Winner.Text = "In Process";
        }
        bool CheckValues(Button btn1  , Button btn2 , Button btn3)
        {
            if (btn1.Tag.ToString() == "?" || btn2.Tag.ToString() == "?" || btn3.Tag.ToString() == "?")
                return false;
            if (btn1.Tag == btn2.Tag && btn1.Tag == btn3.Tag)
            {
                btn1.BackColor = Color.YellowGreen;
                btn2.BackColor = Color.YellowGreen;
                btn3.BackColor = Color.YellowGreen;
                if (btn1.Tag.ToString() == "X")
                {
                    frControl.lbl_Winner.Text = "Player_1";
                    frControl.lbl_Winner.ForeColor = Color.Yellow;
                    ShowMessage();
                    EndGame();
                    return true;
                }
                else 
                {
                    frControl.lbl_Winner.Text = "Player_2";
                    frControl.lbl_Winner.ForeColor = Color.DarkRed;
                    ShowMessage();
                    EndGame();


                    return true;
                }
            }

            else
            {
              
               
                return false;
            }
           
            return false;
        }

        void CheckWinner()
        {

            if (CheckValues(button1, button2, button3)) 
                return;
            if (CheckValues(button4, button5, button6))
                return;
            if (CheckValues(button7, button8, button9))
                return;
            if (CheckValues(button1, button4, button7))
                return;
            if (CheckValues(button2, button5, button8))
                return;
            if (CheckValues(button3, button5, button9))
                return;
            if (CheckValues(button1, button5, button9))
                return;
            if (CheckValues(button1, button2, button3))
                return;
            if (CheckValues(button3, button6, button9))
                return;
        }

        private void ChangePictue(Button btn)
        {
            if(btn.Tag.ToString() == "?")
            {
              
              
               
                switch (PlayerTurn)
                {
                    case enPlayers.Player_1:

                        
                        frControl.lbl_Palyers.Text = "Player_1";
                        frControl.lbl_Palyers.ForeColor = Color.White; 
                        btn.Image = Resources.X;
                        
                        btn.Tag = "X";
                        PlayerTurn = enPlayers.Player_2;
                        CheckWinner();
                        return;

                    break;

                    case enPlayers.Player_2:

                        frControl.lbl_Palyers.Text = "Player_2";
                        frControl.lbl_Palyers.ForeColor = Color.Red;
                        btn.Image = Resources.O;
                        
                        btn.Tag = "O";
                        PlayerTurn = enPlayers.Player_1;
                        CheckWinner();

                        return;

                    break;
                        
                }

            

            }
            else
            {
                MessageBox.Show("Wrong", "Wrong Choise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color PenColor = Color.Black;
            Pen Pen = new Pen(PenColor);
            Pen.Width = 7;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;


            
            for (int i = 1; i <= 2; i ++ )
            {
              e.Graphics.DrawLine(Pen, i * 130,  8 , i * 130, 318);

            }
            for (int i = 1; i <= 2; i++)
            {
                e.Graphics.DrawLine(Pen, 8, i * 112, 378, i * 112);

            }


        }

        private void frGame_Load(object sender, System.EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePictue(button1);
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePictue(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePictue(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePictue(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePictue(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePictue(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangePictue(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangePictue(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangePictue(button9);
        }
    }
}
