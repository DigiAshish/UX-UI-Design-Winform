using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg2_axm160031
{
    public partial class Form1 : Form
    {
        string StartTime; //Gobal Decaration of StartTime Varibale.
        string dup="No"; // Initialization of dup variable with "No" to keep track of Duplicate Value being entered.
        public Form1()
        {
            InitializeComponent();
            tbFirstName.ForeColor = SystemColors.GrayText; //Placeholder in Gray Text color
            tbFirstName.Text = "First Name*"; //Placeholder for First Name Text Box
            this.tbFirstName.Leave += new System.EventHandler(this.tbFirstName_Leave); // Event Handler to be called when leaving the First Name TextBox
            this.tbFirstName.Enter += new System.EventHandler(this.tbFirstName_Enter); // Event Handler to be called when entering the First Name TextBox
            tbMiddleName.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbMiddleName.Text = "M*";//Placeholder for the Text Box
            this.tbMiddleName.Leave += new System.EventHandler(this.tbMiddleName_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbMiddleName.Enter += new System.EventHandler(this.tbMiddleName_Enter);// Event Handler to be called when entering the TextBox
            tbLastName.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbLastName.Text = "Last Name*";//Placeholder for the Text Box
            this.tbLastName.Leave += new System.EventHandler(this.tbLastName_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbLastName.Enter += new System.EventHandler(this.tbLastName_Enter);// Event Handler to be called when entering the TextBox
            tbAddress1.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbAddress1.Text = "Address 1";//Placeholder for the Text Box
            this.tbAddress1.Leave += new System.EventHandler(this.tbAddress1_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbAddress1.Enter += new System.EventHandler(this.tbAddress1_Enter);// Event Handler to be called when entering the TextBox
            tbAddress2.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbAddress2.Text = "Address 2";//Placeholder for the Text Box
            this.tbAddress2.Leave += new System.EventHandler(this.tbAddress2_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbAddress2.Enter += new System.EventHandler(this.tbAddress2_Enter);// Event Handler to be called when entering the TextBox
            tbCity.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbCity.Text = "City";//Placeholder for the Text Box
            this.tbCity.Leave += new System.EventHandler(this.tbCity_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbCity.Enter += new System.EventHandler(this.tbCity_Enter);// Event Handler to be called when entering the TextBox
            tbState.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbState.Text = "State";//Placeholder for the Text Box
            this.tbState.Leave += new System.EventHandler(this.tbState_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbState.Enter += new System.EventHandler(this.tbState_Enter);// Event Handler to be called when entering the TextBox
            tbZipCode.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbZipCode.Text = "Zip Code";//Placeholder for the Text Box
            this.tbZipCode.Leave += new System.EventHandler(this.tbZipCode_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbZipCode.Enter += new System.EventHandler(this.tbZipCode_Enter);// Event Handler to be called when entering the TextBox
            tbPhone.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbPhone.Text = "Phone Number*";//Placeholder for the Text Box
            this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbPhone.Enter += new System.EventHandler(this.tbPhone_Enter);// Event Handler to be called when entering the TextBox
            tbEmail.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbEmail.Text = "Enter your Email";//Placeholder for the Text Box
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);// Event Handler to be called when entering the TextBox
            cbProofOfPurchase.Text = "Proof of Purchased attached?";//Placeholder for the Text Box
            cbProofOfPurchase.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            this.cbProofOfPurchase.Leave += new System.EventHandler(this.cbProofOfPurchase_Leave);// Event Handler to be called when leaving the TextBox.
            this.cbProofOfPurchase.Enter += new System.EventHandler(this.cbProofOfPurchase_Enter);// Event Handler to be called when entering the TextBox
        }

        // Event Handler when leaving the First Name TextBox
        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Length == 0) //If No Text is entered in the TextBox
            {
                tbFirstName.Text = " "; // Initialize is to a space
                tbFirstName.ForeColor = SystemColors.GrayText;
                tbFirstName.BackColor = Color.Pink; //Show pink color textBox background in the field if empty.
                tbNotification.Visible = true; //Bring front the Notification TextBox to display the message
                tbNotification.Text = "First Name is mandatory"; // Display message as to why the field is being shown as pink color.
            }
            else
            {
                string concat = tbFirstName.Text + "\t" + tbMiddleName.Text + "\t" + tbLastName.Text; //Concat the value of three TextBox
                List<string> lines = File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory()) + @"\CS6326Asg2.txt").ToList(); // Read all the lines from the .txt file.
                foreach (var line in lines) //Run the for loop line by line.
                {
                    if (string.IsNullOrWhiteSpace(line)) //if the line contains blank the ignore that line.
                    {
                        continue;
                    }
                    string[] split = line.Split('\t'); // For each line split the to words and store them to a string array. Split by tab.
                    string lineSplitConcat = split[0] + "\t" + split[1] + "\t" + split[2]; // Concat the first three words of the line captured.
                    if (lineSplitConcat.Equals(concat)) //Check If the first three words of the line is equal to the first three values entered in the Text Box.
                    {
                        tbFirstName.BackColor = Color.Pink; //If they are same then turn the background of tbFirstName to pink to show something is wrong.
                        tbMiddleName.BackColor = Color.Pink;
                        tbLastName.BackColor = Color.Pink;
                        tbNotification.Visible = true; //Bring front the Notification TextBox to display the message
                        tbNotification.Text = "This person already exists. Please try again."; // Display message as to why the field is being shown as pink color.i.e "Duplicate entry to the text file".
                        dup = "yes"; // Change the dup variable to "Yes" to show a duplicate name has been encountered.
                        break; // Break from the for each loop
                    }
                    else // If those words donot match then there is no duplicate value
                    {
                        tbFirstName.BackColor = Color.White; // Change the background color of TextBox to white to show that the value entered is correct.
                        tbMiddleName.BackColor = Color.White;
                        tbLastName.BackColor = Color.White;
                        tbNotification.Visible = false; // Since the Name is correct ,no need to show any error message or notification.
                        dup = "No"; // Change the dup variable to "No" to show no duplicate name has been encountered.
                    }
                }
            }
        }

        private void tbFirstName_Enter(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "First Name*")
            {
                tbFirstName.Text = "";// When the TextBox is in focus, allow writing values to it.
                tbFirstName.ForeColor = SystemColors.WindowText; // Text color is default windows color.
                StartTime = DateTime.Now.ToString("HH:mm:ss");// Once the cursor is in First Name text box. Note the start time and store it in a variable.
            }
        }

        private void tbMiddleName_Leave(object sender, EventArgs e)
        {
            if (tbMiddleName.Text.Length == 0)
            {
                tbMiddleName.Text = " ";
                tbMiddleName.ForeColor = SystemColors.GrayText;
                tbMiddleName.BackColor = Color.Pink;
                tbNotification.Visible = true;
                tbNotification.Text = "Middle Name is mandatory";
            }
            else
            {
                string concat = tbFirstName.Text + "\t" + tbMiddleName.Text + "\t" + tbLastName.Text;
                List<string> lines = File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory()) + @"\CS6326Asg2.txt").ToList();
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) //if the line contains blank the ignore that line.
                    {
                        continue;
                    }
                    string[] split = line.Split('\t');
                    string lineSplitConcat = split[0] + "\t" + split[1] + "\t" + split[2];
                    if (lineSplitConcat.Equals(concat))
                    {
                        tbFirstName.BackColor = Color.Pink;
                        tbMiddleName.BackColor = Color.Pink;
                        tbLastName.BackColor = Color.Pink;
                        tbNotification.Visible = true;
                        tbNotification.Text = "This person already exists. Please try again.";
                        dup = "yes";
                        break;
                    }
                    else
                    {
                        tbFirstName.BackColor = Color.White;
                        tbMiddleName.BackColor = Color.White;
                        tbLastName.BackColor = Color.White;
                        tbNotification.Visible = false;
                        dup = "No";
                    }
                }
            }
        }

        private void tbMiddleName_Enter(object sender, EventArgs e)
        {
            if (tbMiddleName.Text == "M*")
            {
                tbMiddleName.Text = "";
                tbMiddleName.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            if (tbLastName.Text.Length == 0)
            {
                tbLastName.Text = " ";
                tbLastName.ForeColor = SystemColors.GrayText;
                tbLastName.BackColor = Color.Pink;
                tbNotification.Visible = true;
                tbNotification.Text = "Last Name is mandatory";
            }
            else
            {
                string concat = tbFirstName.Text + "\t" + tbMiddleName.Text + "\t" + tbLastName.Text;
                List<string> lines = File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory()) + @"\CS6326Asg2.txt").ToList();
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) //if the line contains blank the ignore that line.
                    {
                        continue;
                    }
                    string[] split = line.Split('\t');
                    string lineSplitConcat = split[0] + "\t" + split[1] + "\t" + split[2];
                    if (lineSplitConcat.Equals(concat))
                    {
                        tbFirstName.BackColor = Color.Pink;
                        tbMiddleName.BackColor = Color.Pink;
                        tbLastName.BackColor = Color.Pink;
                        tbNotification.Visible = true;
                        tbNotification.Text = "This person already exists. Please try again.";
                        dup = "yes";
                        break;
                    }
                    else
                    {
                        tbFirstName.BackColor = Color.White;
                        tbMiddleName.BackColor = Color.White;
                        tbLastName.BackColor = Color.White;
                        tbNotification.Visible = false;
                        dup = "No";
                    }
                }
            }
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {
            if (tbLastName.Text == "Last Name*")
            {
                tbLastName.Text = "";
                tbLastName.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbAddress1_Leave(object sender, EventArgs e)
        {
            if (tbAddress1.Text.Length == 0)
            {
                tbAddress1.Text = " ";
                tbAddress1.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbAddress1_Enter(object sender, EventArgs e)
        {
            if (tbAddress1.Text == "Address 1")
            {
                tbAddress1.Text = "";
                tbAddress1.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbAddress2_Leave(object sender, EventArgs e)
        {
            if (tbAddress2.Text.Length == 0)
            {
                tbAddress2.Text = " ";
                tbAddress2.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbAddress2_Enter(object sender, EventArgs e)
        {
            if (tbAddress2.Text == "Address 2")
            {
                tbAddress2.Text = "";
                tbAddress2.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbCity_Leave(object sender, EventArgs e)
        {
            if (tbCity.Text.Length == 0)
            {
                tbCity.Text = " ";
                tbCity.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbCity_Enter(object sender, EventArgs e)
        {
            if (tbCity.Text == "City")
            {
                tbCity.Text = "";
                tbCity.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbState_Leave(object sender, EventArgs e)
        {
            if (tbState.Text.Length == 0)
            {
                tbState.Text = " ";
                tbState.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbState_Enter(object sender, EventArgs e)
        {
            if (tbState.Text == "State")
            {
                tbState.Text = "";
                tbState.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbZipCode_Leave(object sender, EventArgs e)
        {
            if (tbZipCode.Text.Length == 0)
            {
                tbZipCode.Text = " ";
                tbZipCode.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbZipCode_Enter(object sender, EventArgs e)
        {
            if (tbZipCode.Text == "Zip Code")
            {
                tbZipCode.Text = "";
                tbZipCode.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            if (tbPhone.Text.Length == 0)
            {
                tbPhone.Text = " ";
                tbPhone.ForeColor = SystemColors.GrayText;
                tbPhone.BackColor = Color.Pink;
                tbNotification.Visible = true;
                tbNotification.Text = "Phone Number is mandatory";
            }
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "Phone Number*")
            {
                tbPhone.Text = "";
                tbPhone.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length == 0)
            {
                tbEmail.Text = " ";
                tbEmail.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Enter your Email")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = SystemColors.WindowText;
            }
        }

        private void cbProofOfPurchase_Leave(object sender, EventArgs e)
        {
            if (cbProofOfPurchase.Text.Length == 0)
            {
                cbProofOfPurchase.Text = "No";
                cbProofOfPurchase.ForeColor = SystemColors.GrayText;
            }
        }

        private void cbProofOfPurchase_Enter(object sender, EventArgs e)
        {
            if (cbProofOfPurchase.Text == "Proof of Purchased attached?")
            {
                cbProofOfPurchase.Text = "";
                cbProofOfPurchase.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string EndTime = DateTime.Now.ToString("HH:mm:ss"); //Once the "Add" Button is clicked, Note the end time and store it in a variable.
            string line = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}",
                                   tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, tbAddress1.Text, tbAddress2.Text, tbCity.Text,
                                   tbState.Text, tbZipCode.Text, tbPhone.Text, tbEmail.Text, cbProofOfPurchase.Text, dtDateRecieved.Text,StartTime, EndTime);// Collect all the values entered in the TextBox and concat them to a string separated by Tab.
            string path = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt"); //Path to where the Text file is stored. i.e "\Visual Studio 2015\Projects\Asg2-axm160031\Asg2-axm160031\bin\Release".
            if (!File.Exists(path)) // Check if the file exist at the given path.
            {
                File.Create(path).Dispose(); // If Not. Then create a file and close the file creation task.
            }
            if(tbFirstName.Text ==" " || tbMiddleName.Text ==" " || tbLastName.Text ==" " || tbPhone.Text ==" ") //Check if the values for Name and Phone Number is left empty.
            {
                
                btnSubmit.BackColor = Color.Pink; // Highlight the "Add" Button by changing its color to pink to show that a entry or field is incorrectly field and unless it is corrected no data will be saved.
                tbNotification.Visible = true; // Enable the Notification TextBox
                tbNotification.Text = "Name or Phone Number is not Provided"; // Show the correct message as to why the data cannot be saved.
            }
            else
            {
                string concat = tbFirstName.Text + "\t" + tbMiddleName.Text + "\t" + tbLastName.Text; //Concat the value of three TextBox
                List<string> lines = File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory()) + @"\CS6326Asg2.txt").ToList(); // Read all the lines from the .txt file.
                foreach (var linee in lines) //Run the for loop line by line.
                {
                    if (string.IsNullOrWhiteSpace(linee)) //if the line contains blank the ignore that line.
                    {
                        continue;
                    }
                    string[] split = linee.Split('\t'); // For each line split the to words and store them to a string array. Split by tab.
                    string lineSplitConcat = split[0] + "\t" + split[1] + "\t" + split[2]; // Concat the first three words of the line captured.
                    if (lineSplitConcat.Equals(concat)) //Check If the first three words of the line is equal to the first three values entered in the Text Box.
                    {
                        tbFirstName.BackColor = Color.Pink; //If they are same then turn the background of tbFirstName to pink to show something is wrong.
                        tbMiddleName.BackColor = Color.Pink;
                        tbLastName.BackColor = Color.Pink;
                        btnSubmit.BackColor = Color.Pink;
                        tbNotification.Visible = true; //Bring front the Notification TextBox to display the message
                        tbNotification.Text = "This person already exists. Please try again."; // Display message as to why the field is being shown as pink color.i.e "Duplicate entry to the text file".
                        dup = "Yes";
                        break; // Break from the for each loop
                    }
                }
                if (dup == "No")
                {
                    tbFirstName.BackColor = Color.White; // Change the background color of TextBox to white to show that the value entered is correct.
                    tbMiddleName.BackColor = Color.White;
                    tbLastName.BackColor = Color.White;
                    tbPhone.BackColor = Color.White;
                    btnSubmit.BackColor = Color.Gainsboro; // Change the color of the "Add" button back to its normal grey color.
                    tbNotification.Visible = false; // Since the Name is correct ,no need to show any error message or notification.
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(path, true); //open the file for writing.
                    writer.Write(Environment.NewLine + line); //write the current line to the file. First take your cursor to the new line then append the new line to already present data.
                    writer.Close(); //remember to close the file again.
                    writer.Dispose(); // Close the writing process
                    MessageBox.Show("Added!"); // Show a pop-up that the entry has been entered.
                }
            }
        }
    
        private void Form1_Load(object sender, System.EventArgs e) // Its the first thing that loads when the winform is executed.
        {
            string path = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt");//Path to where the Text file is stored. i.e "\Visual Studio 2015\Projects\Asg2-axm160031\Asg2-axm160031\bin\Release".
            if (!File.Exists(path))// Check if the file exist at the given path.
            {
                File.Create(path).Dispose();// If Not. Then create a file and close the file creation task.
            }
            else
            {
                string[] curItem = System.IO.File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt")); //if the file exist then read all the lines into a string array.
                foreach (var item in curItem)// run through each line in the file.
                {
                    if(string.IsNullOrWhiteSpace(item)) //if the line contains blank the ignore that line.
                    {
                        continue;
                    }
                    string[] split = item.Split('\t');// Split each line by words and store them in a string array.
                    lbDataView.Items.Add(split[0] + "\t" + split[1] + "\t" + split[2] + "\t" + split[8]); // in the list box area , only show the First Name, Middle Name, Last name and Phone number.
                }
            }
        }

        private void lbDataView_SelectedIndexChanged(object sender, EventArgs e)// It populates all the data corresponding to the person selected in the ListBox.
        {
            tbFirstName.BackColor = Color.White; // Change the background color of TextBox to white to show that the value entered is correct.
            tbMiddleName.BackColor = Color.White;
            tbLastName.BackColor = Color.White;
            tbPhone.BackColor = Color.White;
            btnSubmit.BackColor = Color.Gainsboro; // Change the color of the "Add" button back to its normal grey color.
            tbNotification.Visible = false;
            string selectItem = lbDataView.SelectedItem.ToString();// Store the item selected in the list box to a string
            string[] splitSelectItem = selectItem.Split('\t'); // Split those values based on tab.

            string[] curItem = System.IO.File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt"));// Open the text file and read all the lines present in it.
            foreach (var item in curItem)// run through each line in the file.
            {
                if (string.IsNullOrWhiteSpace(item))//if the line contains blank the ignore that line.
                {
                    continue;
                }
                string[] splitCurItem = item.Split('\t');// Split each line by words and store them in a string array.
                if (splitCurItem[0]== splitSelectItem[0] && splitCurItem[1] == splitSelectItem[1] && splitCurItem[2] == splitSelectItem[2]) //Compare the words selected in the listBox with the entry in the file.If there is a match then populate all the values of the entry selected from the file to their corresponding TextBoxes.
                {
                    tbFirstName.Text = splitCurItem[0]; // First value in the string array to the First Name text Box.
                    tbMiddleName.Text = splitCurItem[1];
                    tbLastName.Text = splitCurItem[2];
                    tbAddress1.Text = splitCurItem[3];
                    tbAddress2.Text = splitCurItem[4];
                    tbCity.Text = splitCurItem[5];
                    tbState.Text = splitCurItem[6];
                    tbZipCode.Text = splitCurItem[7];
                    tbPhone.Text = splitCurItem[8];
                    tbEmail.Text = splitCurItem[9];
                    cbProofOfPurchase.Text = splitCurItem[10];
                    dtDateRecieved.Text = splitCurItem[11];
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)//A button to clear all the field of the text Box for fresh entry.
        {
            tbFirstName.BackColor = Color.White; // Change the background color of TextBox to white to show that the value entered is correct.
            tbMiddleName.BackColor = Color.White;
            tbLastName.BackColor = Color.White;
            tbPhone.BackColor = Color.White;
            btnModify.BackColor = Color.Gainsboro;
            btnSubmit.BackColor = Color.Gainsboro; // Change the color of the "Add" button back to its normal grey color.
            tbNotification.Visible = false;
            tbFirstName.Text = string.Empty;// Clear individual text  box.
            tbMiddleName.Text = string.Empty;// Clear individual text  box.
            tbLastName.Text = string.Empty;// Clear individual text  box.
            tbAddress1.Text = string.Empty;// Clear individual text  box.
            tbAddress2.Text = string.Empty;// Clear individual text  box.
            tbCity.Text = string.Empty;// Clear individual text  box.
            tbState.Text = string.Empty;// Clear individual text  box.
            tbZipCode.Text = string.Empty;// Clear individual text  box.
            tbPhone.Text = string.Empty;// Clear individual text  box.
            tbEmail.Text = string.Empty;// Clear individual text  box.
            cbProofOfPurchase.Text = string.Empty;// Clear individual text  box.
            dtDateRecieved.Text = string.Empty;// Clear individual text  box.
            tbFirstName.ForeColor = SystemColors.GrayText; //Placeholder in Gray Text color
            tbFirstName.Text = "First Name*"; //Placeholder for First Name Text Box
            this.tbFirstName.Leave += new System.EventHandler(this.tbFirstName_Leave); // Event Handler to be called when leaving the First Name TextBox
            this.tbFirstName.Enter += new System.EventHandler(this.tbFirstName_Enter); // Event Handler to be called when entering the First Name TextBox
            tbMiddleName.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbMiddleName.Text = "M*";//Placeholder for the Text Box
            this.tbMiddleName.Leave += new System.EventHandler(this.tbMiddleName_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbMiddleName.Enter += new System.EventHandler(this.tbMiddleName_Enter);// Event Handler to be called when entering the TextBox
            tbLastName.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbLastName.Text = "Last Name*";//Placeholder for the Text Box
            this.tbLastName.Leave += new System.EventHandler(this.tbLastName_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbLastName.Enter += new System.EventHandler(this.tbLastName_Enter);// Event Handler to be called when entering the TextBox
            tbAddress1.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbAddress1.Text = "Address 1";//Placeholder for the Text Box
            this.tbAddress1.Leave += new System.EventHandler(this.tbAddress1_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbAddress1.Enter += new System.EventHandler(this.tbAddress1_Enter);// Event Handler to be called when entering the TextBox
            tbAddress2.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbAddress2.Text = "Address 2";//Placeholder for the Text Box
            this.tbAddress2.Leave += new System.EventHandler(this.tbAddress2_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbAddress2.Enter += new System.EventHandler(this.tbAddress2_Enter);// Event Handler to be called when entering the TextBox
            tbCity.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbCity.Text = "City";//Placeholder for the Text Box
            this.tbCity.Leave += new System.EventHandler(this.tbCity_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbCity.Enter += new System.EventHandler(this.tbCity_Enter);// Event Handler to be called when entering the TextBox
            tbState.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbState.Text = "State";//Placeholder for the Text Box
            this.tbState.Leave += new System.EventHandler(this.tbState_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbState.Enter += new System.EventHandler(this.tbState_Enter);// Event Handler to be called when entering the TextBox
            tbZipCode.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbZipCode.Text = "Zip Code";//Placeholder for the Text Box
            this.tbZipCode.Leave += new System.EventHandler(this.tbZipCode_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbZipCode.Enter += new System.EventHandler(this.tbZipCode_Enter);// Event Handler to be called when entering the TextBox
            tbPhone.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbPhone.Text = "Phone Number*";//Placeholder for the Text Box
            this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbPhone.Enter += new System.EventHandler(this.tbPhone_Enter);// Event Handler to be called when entering the TextBox
            tbEmail.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            tbEmail.Text = "Enter your Email";//Placeholder for the Text Box
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);// Event Handler to be called when leaving the TextBox.
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);// Event Handler to be called when entering the TextBox
            cbProofOfPurchase.Text = "Proof of Purchased attached?";//Placeholder for the Text Box
            cbProofOfPurchase.ForeColor = SystemColors.GrayText;//Placeholder in Gray Text color
            this.cbProofOfPurchase.Leave += new System.EventHandler(this.cbProofOfPurchase_Leave);// Event Handler to be called when leaving the TextBox.
            this.cbProofOfPurchase.Enter += new System.EventHandler(this.cbProofOfPurchase_Enter);// Event Handler to be called when entering the TextBox
        }

        private void btnDelete_Click(object sender, EventArgs e) // Button to delete an entry from the file by selecting an item in the listBox.
        {
            tbFirstName.BackColor = Color.White; // Change the background color of TextBox to white to show that the value entered is correct.
            tbMiddleName.BackColor = Color.White;
            tbLastName.BackColor = Color.White;
            tbPhone.BackColor = Color.White;
            btnSubmit.BackColor = Color.Gainsboro; // Change the color of the "Add" button back to its normal grey color.
            string selectItem = lbDataView.SelectedItem.ToString(); // Store the item selected in the list box to a string
            string[] splitSelectItem = selectItem.Split('\t'); // Split those values separated on tab.

           List<string> lines = File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt")).ToList(); // Open the text file and read all the lines present in it.
           foreach (string item in lines)// run through each line in the file.
            {
                string[] splitlines = item.Split('\t'); // Split each line by words and store them in a string array.
                if (splitlines[0] == splitSelectItem[0] && splitlines[1] == splitSelectItem[1] && splitlines[2] == splitSelectItem[2]) //Compare the words selected in the listBox with the entry in the file.If there is a match then delete all the values of the entry from the file.
                {
                    if (lines.Contains(item)) //If there is a match
                    {
                        lines.Remove(item); // Remove the selected item's entry from the file
                        break; // break the for loop
                    }
                }
            }
            File.WriteAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt"), lines);//Write the remaing lines back to the files.
            MessageBox.Show("Deleted!");// Pop up a message saying that the item has been deleted from the file.
        }

        private void btnModify_Click(object sender, EventArgs e) // Button to Modify an entry from the file by selecting an item in the listBox.
        {
            tbFirstName.BackColor = Color.White; // Change the background color of TextBox to white to show that the value entered is correct.
            tbMiddleName.BackColor = Color.White;
            tbLastName.BackColor = Color.White;
            tbPhone.BackColor = Color.White;
            btnSubmit.BackColor = Color.Gainsboro; // Change the color of the "Add" button back to its normal grey color.
            string selectItem = lbDataView.SelectedItem.ToString(); // Store the item selected in the list box to a string
            string[] splitSelectItem = selectItem.Split('\t'); // Split those values based on tab.

            string EndTime = DateTime.Now.ToString("HH:mm:ss"); //Once the "Add" Button is clicked, Note the end time and store it in a variable.
            string line = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}",
                                   tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, tbAddress1.Text, tbAddress2.Text, tbCity.Text,
                                   tbState.Text, tbZipCode.Text, tbPhone.Text, tbEmail.Text, cbProofOfPurchase.Text, dtDateRecieved.Text, StartTime, EndTime);// Collect all the values entered in the TextBox and concat them to a string separated by Tab.
            string path = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt"); //Path to where the Text file is stored. i.e "\Visual Studio 2015\Projects\Asg2-axm160031\Asg2-axm160031\bin\Release".

            if (tbFirstName.Text == " " || tbMiddleName.Text == " " || tbLastName.Text == " " || tbPhone.Text == " ") //Check if the values for Name and Phone Number is left empty.
            {

                btnModify.BackColor = Color.Pink; // Highlight the "Add" Button by changing its color to pink to show that a entry or field is incorrectly field and unless it is corrected no data will be saved.
                tbNotification.Visible = true; // Enable the Notification TextBox
                tbNotification.Text = "Name or Phone Number is not Provided"; // Show the correct message as to why the data cannot be saved.
            }
            else
            {
                List<string> lines = File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt")).ToList(); // Open the text file and read all the lines present in it.
                foreach (string item in lines)// run through each line in the file.
                {
                    string[] splitlines = item.Split('\t'); // Split each line by words and store them in a string array.
                    if (splitlines[0] == splitSelectItem[0] && splitlines[1] == splitSelectItem[1] && splitlines[2] == splitSelectItem[2]) //Compare the words selected in the listBox with the entry in the file.If there is a match then delete all the values of the entry from the file.
                    {
                        if (lines.Contains(item)) //If there is a match
                        {
                            lines.Remove(item); // Remove the selected item's entry from the file
                            break; // break the for loop
                        }
                    }
                }
                File.WriteAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt"), lines);
                System.IO.StreamWriter writer = new System.IO.StreamWriter(path, true); //open the file for writing.
                    writer.Write(line); //write the current line to the file. First take your cursor to the new line then append the new line to already present data.
                    writer.Close(); //remember to close the file again.
                    writer.Dispose(); // Close the writing process
                    btnModify.BackColor = Color.Gainsboro; // Change the color of the "Add" button back to its normal grey color.
                    MessageBox.Show("Updated!"); // Show a pop-up that the entry has been updated.
            }
        }

        private void btRefresh_Click(object sender, EventArgs e) // To refresh the listbox values
        {
            //var lines = File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt")).Where(arg => !string.IsNullOrWhiteSpace(arg));
            //File.WriteAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt"), lines);
            tbFirstName.BackColor = Color.White; // Change the background color of TextBox to white to show that the value entered is correct.
            tbMiddleName.BackColor = Color.White;
            tbLastName.BackColor = Color.White;
            tbPhone.BackColor = Color.White;
            btnModify.BackColor = Color.Gainsboro;
            btnSubmit.BackColor = Color.Gainsboro; // Change the color of the "Add" button back to its normal grey color.
            tbNotification.Visible = false;
            lbDataView.Items.Clear(); // First clear all the old values being displayed in ListBox
            string[] curItem = System.IO.File.ReadAllLines(Path.GetFullPath(Directory.GetCurrentDirectory() + @"\CS6326Asg2.txt")); // read all the lines from the file into a string array.
            foreach (var item in curItem)// run through each line in the file.
            {
                if (string.IsNullOrWhiteSpace(item)) //if the line contains blank the ignore that line.
                {
                    continue;
                }
                string[] split = item.Split('\t');// Split each line by words and store them in a string array.
                lbDataView.Items.Add(split[0] + "\t" + split[1] + "\t" + split[2] + "\t" + split[8]); // in the list box area , only show the First Name, Middle Name, Last name and Phone number.
            }
        }
    }
}
