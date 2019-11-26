using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace amusementPark_TicketBooth
{
    public partial class Form1 : Form
    {
        int index,indexDiscount;
        decimal[] addOns = new decimal[4];

        public Form1()
        {
            InitializeComponent();
            index = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetForm(); //turns the form back into its default settings
        }

        public void resetForm(){
            
            // sets the default setting of the program
            rbtRide.Checked = false;
            rbtEntrance.Checked = false; 
            rbtExpress.Checked = false; 
            rbdStudent.Checked = false; 
            rbdSenior.Checked = false; 
            rbdMember.Checked = false;
            checkBoxWinter.Checked = false;
            checkBoxLazer.Checked = false; 
            checkBoxScream.Checked = false; 
            checkBoxDragon.Checked = false;
            numWinter.Value = 1;
            numScream.Value = 1;
            numLazer.Value = 1;
            numDragon.Value = 1;
            numTicket.Value = 1;
            rbdNormal.Checked = true;
            rbtEntrance.Checked = true;
            numLazer.Enabled = false;
            numScream.Enabled = false;
            numDragon.Enabled = false;
            numWinter.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Checks if the add-on rides was selected and sets its value appropriately
            if (checkBoxWinter.Checked) { addOns[0] = (decimal)numWinter.Value; }
            if (checkBoxLazer.Checked) { addOns[1] = (decimal)numLazer.Value; }
            if (checkBoxScream.Checked) { addOns[2] = (decimal)numScream.Value; }
            if (checkBoxDragon.Checked) { addOns[3] = (decimal)numDragon.Value; }

            Booth boothObj = new Booth(index, indexDiscount,(int)numTicket.Value,addOns);
            boothObj.Compute();
            // Shows a message of the total cost of the ticket being purchased and asking if the customer is fine with it
            if (MessageBox.Show(boothObj.ToString() + "\nAre you sure?", "Notice!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Records the date and amount of purchase in a text file
                boothObj.setDate = dateTimePicker1.Value.ToShortDateString();
                boothObj.SaveFile();
                // asking if another ticket purchase entry will be made
                if (MessageBox.Show("Another ticket purchase entry? ", "Question!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetForm(); //resets the form in its default settings
                }
                else Close(); //closes the form when "NO" is selected    
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numWinter.Enabled = checkBoxWinter.Checked;
            if (!numWinter.Enabled) //sets the value to zero when the checkbox is not selected
                addOns[0] = 0 ;      
        }

        private void checkBoxLazer_CheckedChanged(object sender, EventArgs e)
        {
            numLazer.Enabled = checkBoxLazer.Checked;
            if (!numLazer.Enabled) //sets the value to zero when the checkbox is not selected
                addOns[1] = 0;
        }

        private void checkBoxScream_CheckedChanged(object sender, EventArgs e)
        {
            numScream.Enabled = checkBoxScream.Checked;
            if (!numScream.Enabled) //sets the value to zero when the checkbox is not selected
                addOns[2] = 0;
        }

        private void checkBoxDragon_CheckedChanged(object sender, EventArgs e)
        {
            numDragon.Enabled = checkBoxDragon.Checked;
            if (!numDragon.Enabled) //sets the value to zero when the checkbox is not selected
                addOns[3] = 0;
        }

        private void rbdSenior_CheckedChanged(object sender, EventArgs e)
        {
            indexDiscount = 2; //sets the senior discount
        }

        private void rbtEntrance_CheckedChanged(object sender, EventArgs e)
        {
            index = 0; //sets the admission ticket
        
        }

        private void rbtExpress_CheckedChanged(object sender, EventArgs e)
        {
            index = 2; //sets the express ticket
        }
        
        private void rbdNormal_CheckedChanged(object sender, EventArgs e)
        {
            indexDiscount = 0; //sets the no discount
        }

        private void rbdMember_CheckedChanged(object sender, EventArgs e)
        {
            indexDiscount = 3; //sets the club members discount
        }

        private void rbdStudent_CheckedChanged(object sender, EventArgs e)
        {
            indexDiscount = 1; //sets the student discount
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close(); //closes the form
        }

        private void rbtRide_CheckedChanged(object sender, EventArgs e)
        {
            index = 1; // set the ride-all-you can ticket 
        }
    }
}
