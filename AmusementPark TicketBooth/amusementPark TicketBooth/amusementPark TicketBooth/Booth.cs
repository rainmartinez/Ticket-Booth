using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//COE114L/A3
// Machine problem by group #AllBlue
//Members: Martinez, Krisha Rain T. ; Sembrano, Joecel ; Viray, Kristoffer

namespace amusementPark_TicketBooth
{
    class Booth
    {
        //declarations
        string[] Type = new string[3] { "Admission", "Ride-All-You Can", "Express" }; 
        decimal[] costTicket = new decimal [3] {150m, 500m, 800m}; 
        decimal[] discount = new decimal[4] { 0, 0.10m, 0.20m, 0.25m };
        decimal[] addOnCost = new decimal[4] { 250m, 150m, 100m, 200m }; 
        decimal[] addOnCount = new decimal[4];
        decimal totalCost;
        int  quantity, index,indexDiscount;
        string Date;

        public Booth () {} // default constructor

        public Booth (int i,int x,int q,decimal[] c) 
        {
            index = i;
            indexDiscount = x;
            quantity = q;
            addOnCount = c;
        }

        public string[]  TicketType //set and return the ticket type
        {
            get {return Type;}
            set { Type = value; }
        }

 
        public int propQuantity //sets and return the quantity 
        {
            get { return quantity;}
            set { quantity = value; }
        }     

        public void Compute()
        {
            //The process for computing the total cost
            decimal totalAddOnCost = 0;
            for(int x=0; x<4 ;x++)
            {
                totalAddOnCost += addOnCount[x] * addOnCost[x]; 
            }
            totalCost = (totalAddOnCost + (costTicket[index] * quantity)) ;
            totalCost = totalCost - (totalCost * discount[indexDiscount]);
        }

        internal void SaveFile()
        {
            // create and rewrites data done in the program
            string output;
            output = Date + " " + totalCost.ToString();
            using (StreamWriter file = File.AppendText(@"TicketPurchased.txt"))
            {
                file.WriteLine(output);
            }  

        }
        public override string ToString()
        {
            return "The total cost of the ticket is: \u20B1 " + totalCost.ToString(); 
        }

        public string setDate //set the date of purchase of the ticket
        {
            set { Date = value; }
        }
    }
}
