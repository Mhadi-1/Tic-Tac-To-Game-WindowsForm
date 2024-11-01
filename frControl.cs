using DevExpress.Utils.Behaviors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureboxForm
{
    public partial class frControl : Form
    {
        public frControl()
        {
            InitializeComponent();
        }

        public void frControl_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                frGame frGame = new frGame();
                frGame.Show();
                frGame.StartGame(this);
                btn_StratGame.Enabled = false;
               
            
            

        }
    }
}
