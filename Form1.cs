using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonOfDoom
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            
        InitializeComponent();
        xyLabel.Text = Convert.ToString(Program.locX) + "," + Convert.ToString(Program.locY);
        checkWalls();
        updateRoom();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textField_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void actionItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goNorth_Click(object sender, EventArgs e)
        {
             
            Program.locY--;
            checkWalls();
            updateRoom();
        }

        private void goEast_Click(object sender, EventArgs e)
        {
            Program.locX++;
            checkWalls();
            updateRoom();
        }
           

        private void goSouth_Click(object sender, EventArgs e)
        {
            Program.locY++;
            checkWalls();
            updateRoom();

        }

        private void goWest_Click(object sender, EventArgs e)
        {
            Program.locX--;
            checkWalls();
            updateRoom();
        }

        public void updateRoom()
        {
            //tulostetaan tekstikenttään huoneen kuvaus
            textField.Text = Program.caveInfo[Program.locY, Program.locX, 0];
            //Tulostetaan kuva

            //merkataan harmaalla jos napille ei ole toimintoa (null array)
        }
        public void checkWalls()
        {
           
            if (Program.locArray[Program.locY-1, Program.locX] > 0)
            {
                goNorth.Enabled = false;
            }
            else
            {
                goNorth.Enabled = true;
            }

            if (Program.locArray[Program.locY + 1, Program.locX] > 0)
            {
                goSouth.Enabled = false;
            }
            else
            {
                goSouth.Enabled = true;
            }

            if (Program.locArray[Program.locY, Program.locX - 1] > 0)
            {
                goWest.Enabled = false;
            }
            else
            {
                goWest.Enabled = true;
            }

            if (Program.locArray[Program.locY, Program.locX + 1] > 0)
            {
                goEast.Enabled = false;
            }
            else
            {
                goEast.Enabled = true;
            }
            xyLabel.Text = Convert.ToString(Program.locX) + "," + Convert.ToString(Program.locY);

        }




        private void xyLabel_Click(object sender, EventArgs e)
        {
           // xyLabel.Text = Convert.ToString(Program.locX) + "," + Convert.ToString(Program.locY);

        }
    }
}
