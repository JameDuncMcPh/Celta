using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class gameForm : Form
    {
        #region Global Varialbes

        //Doors
        Door northDoor, southDoor, westDoor, eastDoor;

        //Ints
        int doorSize = 500;
        int playerSize = 25;
        int playerX = 275;
        int playerY = 500;

        //Brushs
        SolidBrush playerBrush = new SolidBrush(Color.BlueViolet);
        #endregion

        public gameForm()
        {
            InitializeComponent();
        }

        private void gameSetup()
        {
            //set the size of the doors
            northDoor.Size = doorSize;
            southDoor.Size = doorSize;
            westDoor.Size = doorSize;
            eastDoor.Size = doorSize;

            //Set up the parameters of each door
            northDoor.X = this.Width - (northDoor.Size / 2);
            northDoor.Y = 0;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void gameForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
