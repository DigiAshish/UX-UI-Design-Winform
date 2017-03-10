/*********************************************************************************************
 Author - Ashish Mohapatra
 This program Browse a file from the Local and accepts a keyword to be search in the file. Whenever there is a hit of the keyword
 with the line in the file,This program shows the line number and the corresponding line.
**********************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg4_axm160031
{
    public partial class Form1 : Form
    {
        private bool stopIt = false;//To check whether "Cancel" instruction has been provided
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog(); //On click of Button, Open the file explorer
            if (ofg.ShowDialog() == DialogResult.OK) // Show the file explorer dialog box.
            {
                string file = ofg.FileName; //Store the path of the file name selected to a string variable
                tbFilename.Text = file;      // Show the file name in the text box for reference          
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(DisplayResult);//Initiate Threading
            if (btnSearch.Text == "Search") //If the button is "Search" enabled
            {
                stopIt = false; //Continue showing the result
                t.IsBackground = true;
                t.Start();// Start Threading
                lbDisplay.HorizontalScrollbar = true;// Enable horizontal Scrolling bar
                lblNotification.Visible = false; //Disable the notification TextBox
            }
            else
            {
                stopIt = true; //If the button is "Cancel" Enabled then enabled the variable to stop the search
            }
        }
        void DisplayResult()
        {
            string file = tbFilename.Text; //Get the file name
            string keyword = tbKeyword.Text; //Get the keyword to be searched
            Boolean NotFound = false; //Initialize NotFound string to be false
            int i = 1;
            if (lbDisplay.Items != null && lbDisplay.Items.Count > 0)
            {
                this.Invoke((MethodInvoker)(() => lbDisplay.Items.Clear())); //Clear the list box for multiple search result
            }
            string[] curItem = System.IO.File.ReadAllLines(file);//Read all lines from the Text file
            this.Invoke((MethodInvoker)(() => lbDisplay.Items.Add("Line Number:" + "\t" + "\t" + "Line")));//Show the header
            try
            {
                foreach (var item in curItem)
                {
                    this.Invoke((MethodInvoker)(() => btnSearch.Text = "Cancel"));//Change the button from "Search" to "Cancel"
                    if (string.IsNullOrWhiteSpace(item)) //if any line contains blank line then ignore it.
                    {
                        continue;
                    }
                    if (!stopIt) //If not instructed to stop the search do teh following
                    {
                        if (item.ToLower().Contains(keyword.ToLower()))//if the line contains the keyword
                        {
                            System.Threading.Thread.Sleep(100);//Delay the search by 100ms
                            this.Invoke((MethodInvoker)(() => lbDisplay.Items.Add(i + "\t" + "\t" + item))); //Display the line number and the whole line
                            this.Invoke((MethodInvoker)(() => NotFound = true)); //Change the notFound variable to be true
                        }
                    }
                    i++;
                }
                if(NotFound==false)//if the notFound variable is still false that means there is no search result
                {
                    this.Invoke((MethodInvoker)(() => lblNotification.Visible = true)); //Enable the notification text box
                    this.Invoke((MethodInvoker)(() => lblNotification.Text = "No Results were found")); //Show the notification that No result found
                }
            }catch (System.IO.IOException e){
            }
            finally
            {
                this.Invoke((MethodInvoker)(() => btnSearch.Text = "Search"));//Finally change the button back to "Search"
            }
        }
    }
}
