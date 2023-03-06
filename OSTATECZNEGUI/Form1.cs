using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static OSTATECZNEGUI.Projektowanie;

namespace OSTATECZNEGUI
{
    public partial class Form1 : Form
    {

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Koszulka");
            comboBox1.Items.Add("Bluza");
            comboBox1.Items.Add("Sukienka");
            comboBox1.Items.Add("Spodnie");
            comboBox1.Items.Add("Buty");
            
            
        }

        private void przymierzBtn_Click(object sender, EventArgs e)
        {
            Ubranie ubranie = null;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Koszulka":
                    ubranie = new Koszulka("koszuleczka", "M", "biala", "bawelna", true, textBox1);
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Kasia\\Downloads\\apka_inspiracje/koszulka.png");
                    break;
                case "Bluza":
                    Koszulka podkoszulek = new Koszulka("podkoszuleczka", "S", "czarna", "bawelna", false, textBox1);
                    ubranie = new Bluza("bluzeczka", "L", "czarna", "bawelna", podkoszulek, true, textBox1);
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Kasia\\Downloads\\apka_inspiracje/bluza.png");
                    
                    break;
                case "Sukienka":
                    ubranie = new Sukienka("sukieneczka", "S", "rozowa", "jedwab", "kropki", "za kolano", false, textBox1);
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Kasia\\Downloads\\apka_inspiracje/sukienka.png");
                    break;
                case "Spodnie":
                    ubranie = new Spodnie("spodeneczki", "L", "niebieskie", "denim", "straight", true, textBox1);
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Kasia\\Downloads\\apka_inspiracje/spodnie.png");
                    break;
                case "Buty":
                    ubranie = new Buty("buciorki", "37", "czarne", "skora", textBox1);
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Kasia\\Downloads\\apka_inspiracje/buty.png");
                    break;
                default:
                    break;
            }

            if (ubranie != null)
            {
                ubranie.Przymierz();
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int xDiff = lastCursor.X - Cursor.Position.X;
                int yDiff = lastCursor.Y - Cursor.Position.Y;
                this.Location = new Point(lastForm.X - xDiff, lastForm.Y - yDiff);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int xDiff = lastCursor.X - Cursor.Position.X;
                int yDiff = lastCursor.Y - Cursor.Position.Y;
                this.Location = new Point(lastForm.X - xDiff, lastForm.Y - yDiff);
            }
        }

        private void przymierzBtn_MouseClick(object sender, MouseEventArgs e)
        {
            przymierzBtn.BackColor = Color.LightGray;
        }
    }
}
