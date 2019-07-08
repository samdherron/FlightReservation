//Written September 19th, 2017 by Sam Herron
//SamDHerronAssignment1
//Allows the reservation and cancelation of seats on an airplane

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamDHerronAssignment1
{




    public partial class form1 : Form
    {
        //size 15
        string[] seatList = {"null" , "null", "null", "null", "null",
                             "null", "null", "null", "null", "null",
                             "null", "null", "null", "null", "null"};

        //size 10
        string[] waitList = { "null", "null", "null", "null", "null",
            "null", "null", "null", "null", "null" };

        //debugging purposes
        string[] nameList =
        {
            "Tom Cruise", "Jim Carrey", "Adam Sandler", "John Candy", "Chevy Chase", "Patrick Swayze",
            "Mike Myers", "Eddie Van Halen", "Josh Brolin", "Daniel Radcliffe", "Corey Taylor",
            "Jerry Springer", "Kollegah", "Tiesto", "Avicii", "Coone", "Seth Green", "Seth Macfarlane",
            "Betty White", "Chris Rock", "David Spade", "Kevin James", "Adam West", "Rob Schneider", "Chris Farley"};


        //variables
        string passengerName = "";
        bool seatsFilled = false;
        bool waitListfilled = false;
        string selection1 = "";
        string selection2 = "";
        int waitListcount = 0;
        string seatReset = "";
        string combinedSeat = "";

        /*
         * 
         * Image sources

            Background: http://www.slate.com/content/dam/slate/articles/technology/future_tense/2016/05/160503_FT_cybersecurity-airplanes.jpg.CROP.promo-xlarge2.jpg
            Window Icon: https://d30y9cdsu7xlg0.cloudfront.net/png/1753-200.png

        */


        public form1()
        {
            InitializeComponent();
        }

        public string[] cancelSeat(string[] seatList)
        {
            string combinedSeat = (listBox1.SelectedItem.ToString() + "" + listBox2.SelectedItem.ToString());


            //Checks that the chosen seat is not empty, then cancels it and displays a message

            if (combinedSeat == "A0")
            {
                if (seatList[0] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[0] + ".");
                    seatList[0] = "null";
                    seatReset = "A0";
                }
            }

            if (combinedSeat == "A1")
            {
                if (seatList[1] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[1] + ".");
                    seatList[1] = "null";
                    seatReset = "A1";
                }
            }

            if (combinedSeat == "A2")
            {
                if (seatList[2] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[2] + ".");
                    seatList[2] = "null";
                    seatReset = "A2";
                }
            }

            if (combinedSeat == "B0")
            {
                if (seatList[3] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[3] + ".");
                    seatList[3] = "null";
                    seatReset = "B0";
                }
            }

            if (combinedSeat == "B1")
            {
                if (seatList[4] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[4] + ".");
                    seatList[4] = "null";
                    seatReset = "B1";

                }
            }

            if (combinedSeat == "B2")
            {
                if (seatList[5] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[5] + ".");
                    seatList[5] = "null";
                    seatReset = "B2";
                }
            }

            if (combinedSeat == "C0")
            {
                if (seatList[6] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[6] + ".");
                    seatList[6] = "null";
                    seatReset = "C0";
                }
            }

            if (combinedSeat == "C1")
            {
                if (seatList[7] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[7] + ".");
                    seatList[7] = "null";
                    seatReset = "C1";
                }
            }

            if (combinedSeat == "C2")
            {
                if (seatList[8] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[8] + ".");
                    seatList[8] = "null";
                    seatReset = "C2";
                }
            }

            if (combinedSeat == "D0")
            {
                if (seatList[9] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[9] + ".");
                    seatList[9] = "null";
                    seatReset = "D0";
                }
            }

            if (combinedSeat == "D1")
            {
                if (seatList[10] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[10] + ".");
                    seatList[10] = "null";
                    seatReset = "D1";
                }
            }

            if (combinedSeat == "D2")
            {
                if (seatList[11] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[11] + ".");
                    seatList[11] = "null";
                    seatReset = "D2";
                }
            }

            if (combinedSeat == "E0")
            {
                if (seatList[12] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[12] + ".");
                    seatList[12] = "null";
                    seatReset = "E0";
                }
            }

            if (combinedSeat == "E1")
            {
                if (seatList[13] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[13] + ".");
                    seatList[13] = "null";
                    seatReset = "E1";
                }
            }

            if (combinedSeat == "E2")
            {
                if (seatList[14] != "null")
                {
                    MessageBox.Show("You succesfully cancelled the seat for: " + seatList[14] + ".");
                    seatList[14] = "null";
                    seatReset = "E2";
                }
            }


            return seatList;

        }


        public string[] bookSeat(string[] seatList, string selection1, string selection2)
        {

            //Checks that the chosen seat is vacant, then fills the seat with the passenger name


            if (selection1 == "A")
            {

                if (selection2 == "0")
                {
                    if (seatList[0] == "null")
                    {
                        seatList[0] = passengerName;
                    }

                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[1] == "null")
                    {
                        seatList[1] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[2] == "null")
                    {
                        seatList[2] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

            }

            if (selection1 == "B")
            {

                if (selection2 == "0")
                {
                    if (seatList[3] == "null")
                    {
                        seatList[3] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[4] == "null")
                    {
                        seatList[4] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[5] == "null")
                    {
                        seatList[5] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

            }

            if (selection1 == "C")
            {

                if (selection2 == "0")
                {
                    if (seatList[6] == "null")
                    {
                        seatList[6] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[7] == "null")
                    {
                        seatList[7] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[8] == "null")
                    {
                        seatList[8] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

            }

            if (selection1 == "D")
            {

                if (selection2 == "0")
                {
                    if (seatList[9] == "null")
                    {
                        seatList[9] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[10] == "null")
                    {
                        seatList[10] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[11] == "null")
                    {
                        seatList[11] = passengerName;
                    }
                    else
                    {
                        MessageBox.Show("This seat is Unavailable..");
                    }
                }

                if (selection1 == "E")
                {

                    if (selection2 == "0")
                    {
                        if (seatList[12] == "null")
                        {
                            seatList[12] = passengerName;
                        }
                        else
                        {
                            MessageBox.Show("This seat is Unavailable..");
                        }
                    }

                    if (selection2 == "1")
                    {
                        if (seatList[13] == "null")
                        {
                            seatList[13] = passengerName;
                        }
                        else
                        {
                            MessageBox.Show("This seat is Unavailable..");
                        }
                    }

                    if (selection2 == "2")
                    {
                        if (seatList[14] == "null")
                        {
                            seatList[14] = passengerName;
                        }
                    }

                }

            }

            return seatList;
        }

        public string statusOfseat(string seatStatus, string[] seatList, string selection1, string selection2)
        {

            //determines the seat selection, checks if null and returns the seat availability
            if (selection1 == "A")
            {

                if (selection2 == "0")
                {
                    if (seatList[0] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[1] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable";
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[2] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable";
                    }
                }

            }

            if (selection1 == "B")
            {

                if (selection2 == "0")
                {
                    if (seatList[4] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[5] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[5] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

            }

            if (selection1 == "C")
            {

                if (selection2 == "0")
                {
                    if (seatList[6] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[7] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[8] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

            }

            if (selection1 == "D")
            {

                if (selection2 == "0")
                {
                    if (seatList[9] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[10] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[11] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }
            }

            if (selection1 == "E")
            {

                if (selection2 == "0")
                {
                    if (seatList[12] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "1")
                {
                    if (seatList[13] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

                if (selection2 == "2")
                {
                    if (seatList[14] == "null")
                    {
                        seatStatus = "Available.";
                    }

                    else
                    {
                        seatStatus = "Unavailable.";
                    }
                }

            }

            return seatStatus;
        }

        public string[] shiftSeat(string[] seatList, string combinedSeat, string passengerName, string[] waitList)
        {

            int tempCounter = 0;

            foreach (string seat in seatList)
            {
                if (seat == "null")
                {
                    seatList[tempCounter] = waitList[0];
                }

                tempCounter++;
            }

            return seatList;
        }

        public string[] removeWaitlist(string[] waitList)
        {
            string[] updatedList = new string[waitList.Length];
            waitList[0] = "null";

            //copies the old waitList to a new waitList to move elements over
            Array.Copy(waitList, updatedList, 10);
            waitList = updatedList;

            return waitList;
        }


        private void button16_Click(object sender, EventArgs e)
        {

            richTextBox1.ResetText();
            //richTextBox2.Text = "";


            for (int i = 0; i < seatList.Length; i++)
            {
                if (seatList[i] == "null")
                {

                    richTextBox1.Text += "Empty  \n";

                }
                else
                {

                    richTextBox1.Text += seatList[i] + "  \n";
                }
            }

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            passengerName = textBox1.Text;
            int seatCheck = 0;

            for (int i = 0; i < seatList.Length; i++)
            {
                if (!seatList[i].Contains("null"))
                {
                    seatCheck++;
                }
            }


            //checks to see if seatlist is full
            if (seatCheck >= 15)
            {
                seatsFilled = true;
            }



            if (passengerName != "")
            {
                if (seatsFilled == false)
                {

                    if (listBox1.SelectedIndex == -1 && listBox2.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a seat first.");
                    }

                    else if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
                    {

                        selection1 = listBox1.SelectedItem.ToString();
                        selection2 = listBox2.SelectedItem.ToString();


                        //calls method to book the passenger
                        seatList = bookSeat(seatList, selection1, selection2);


                        MessageBox.Show("You successfully booked a seat for: " + passengerName + ".");
                        textBox1.Text = "";
                        listBox1.SelectedIndex = -1;
                        listBox2.SelectedIndex = -1;

                    }
                    else if (!seatsFilled && !waitListfilled)
                    {


                    }
                }

                else if (seatsFilled && !waitListfilled)
                {
                    MessageBox.Show("Seats are full. You've been added to the waiting list.");
                    waitList[waitListcount] = passengerName;
                    waitListcount++;
                }

            }

            else
            {
                MessageBox.Show("A name is required.");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {



            if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {

                //updates array with the the correct set of names, the targeted name deleted
                seatList = cancelSeat(seatList);

                combinedSeat = (listBox1.SelectedItem.ToString() + "" + listBox2.SelectedItem.ToString());

                if (waitListcount > 0)
                {


                    //moves name from waitling list to seatList
                    seatList = shiftSeat(seatList, combinedSeat, passengerName, waitList);
                    waitList = removeWaitlist(waitList);
                    waitListcount--;

                    MessageBox.Show(passengerName + " has been moved to the seating list.");

                }



            }

            else
            {

                MessageBox.Show("Please select a seat first.");
            }

        }



        private void buttonAddWaitingList_Click(object sender, EventArgs e)
        {

            passengerName = textBox1.Text;


            if (passengerName != "")
            {
                if (waitListcount < 9)
                {


                    if ((seatsFilled) && !waitListfilled)
                    {
                        waitList[waitListcount] = passengerName;
                        waitListcount++;

                        MessageBox.Show(passengerName + " has been added to the waiting list.");

                        textBox1.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("There are seats available.");

                    }
                }

                else if (!seatsFilled)
                {
                    MessageBox.Show("Seats are available.");
                }

                else if (seatsFilled && waitListfilled)
                {
                    MessageBox.Show("All seats and waitlists are full.");
                }




                else
                {
                    MessageBox.Show("Please select a seat first.");
                }

            }
            else
            {
                MessageBox.Show("A name is required.");
            }

        }

        private void buttonShowWaitingList_Click(object sender, EventArgs e)
        {

            richTextBox2.ResetText();

            //loop to update array
            if (richTextBox2.Text == "")
            {
                for (int i = 0; i < waitList.Length; i++)
                {
                    if (waitList[i] == "null")
                    {

                        richTextBox2.Text += "Empty  \n";

                    }
                    else
                    {

                        richTextBox2.Text += waitList[i] + "  \n";
                    }
                }
            }
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            string seatStatus = "";



            if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {
                selection1 = listBox1.SelectedItem.ToString();
                selection2 = listBox2.SelectedItem.ToString();

                //calls seatStatus method
                seatStatus = statusOfseat(seatStatus, seatList, selection1, selection2);

                textBox2.Text = seatStatus;

            }

            else if (listBox1.SelectedIndex == -1 && listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a seat first.");

            }


        }



        private void buttonDebug_Click(object sender, EventArgs e)
        {

            //fills all seats 
            for (int i = 0; i < seatList.Length; i++)
            {
                seatList[i] = nameList[i];
            }

            seatsFilled = true;


            /*
             * 
             * to fill the waitlist
             * 
            for (int i = 0; i < waitList.Length; i++)
            {
                waitList[i] = nameList[i + 15];
            }
            


            waitListfilled = true; 
            
             */

        }
    }
}
