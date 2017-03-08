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

namespace Asg3_axm160031
{
    public partial class Form1 : Form
    {
        int NoOfRecords = 0; string LastLeavingTime;
        //Int Variables to store Min/Max/Avg/total time taken to Enter 1 entry in the Data Form
        int MinEnterTime = 10000; int MaxEnterTime = 0; int AvgEnterTime = 0; int TotalEnterTime = 0;
        //Int Variables to store Min/Max/Avg/total Inter-Record time taken for 1 entry in the Data Form
        int MinGapTime = 10000; int MaxGapTime = 0; int AvgGapTime = 0; int TotalGapTime = 0;
        //Int Variable to store total number of backspace used to enter 10 entries.
        int BackSpacecount = 0;
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
                tbFileInfo.Visible = true; //Bring front the TextBox to display the message
                tbNotification.Visible = true; //Bring front the Notification TextBox to display the message
                tbNotification.Text = file; // Show the path of the text file show in the list Box.
                string[] curItem = System.IO.File.ReadAllLines(file);
                foreach (var item in curItem)
                {
                    if(string.IsNullOrWhiteSpace(item)) //if any line contains blank line then ignore it.
                    {
                        continue;
                    }
                    NoOfRecords = NoOfRecords + 1; //for every item encountered,increase the NoOfRecords by 1.
                    string[] split = item.Split('\t');// Split each line by words and store them in a string array.
                    BackSpacecount = BackSpacecount + Int32.Parse(split[14]); //Parse the string value of split[14],i.e : no of backspace key pressed for each entry and add them to BackspaceCount to get Total Number of BackSpace pressed for 10 entires.
                    TimeSpan diffCur = DateTime.Parse(split[13]) - DateTime.Parse(split[12]); //Parse split[12] (Entry Start Time) and split [13] (Entry Leave Time) to DateTime and find the difference in time taken to enter 1 entry.
                    var CurMins = diffCur.Minutes; //Get Minutes
                    var CurSecs = diffCur.Seconds; // Get Seconds
                    var EnterTime =( CurMins * 60) + CurSecs; //Get Total time for 1 Entry of data in seconds
                    if(EnterTime < MinEnterTime) // If  Total time for 1 Entry is less than last Min Entry Time
                    {
                        MinEnterTime = EnterTime; // then Replace MinEntryTime with the current Total time
                    }
                    if (EnterTime > MaxEnterTime) // If  Total time for 1 Entry is more than last Max Entry Time
                    {
                        MaxEnterTime = EnterTime; // then Replace MaxEntryTime with the current Total time
                    }
                    TotalEnterTime = TotalEnterTime + EnterTime; // Add all the Entry Times of each Entry to get Total Time taken to enter 10 records.
                    if (NoOfRecords != 1) // Except for the First Entry do the following
                    {
                        TimeSpan diffPrev = DateTime.Parse(split[12]) - DateTime.Parse(LastLeavingTime); // Find the time taken between last Entry End time and the next Entry Start time
                        var PrevMins = diffPrev.Minutes; //Get Minutes
                        var PrevSecs = diffPrev.Seconds; // Get Seconds
                        var GapTime = (PrevMins * 60) + PrevSecs; //Get Inter-Record time for 1 Entry of data in seconds
                        if (GapTime < MinGapTime) // If  Inter-Record time for 1 Entry is less than last Min Inter-Record Time
                        {
                            MinGapTime = GapTime; // then Replace MinInter-RecordTime with the current Inter-Record time
                        }
                        if (GapTime > MaxGapTime) // If  Inter-Record time for 1 Entry is more than last Max Inter-Record Time
                        {
                            MaxGapTime = GapTime; // then Replace MaxInter-RecordTime with the current Inter-Record time
                        }
                        TotalGapTime = TotalGapTime + GapTime; // Add all the Inter-Record Times of each Entry to get Total Inter-Record taken to enter 10 records.
                    }
                    LastLeavingTime = split[13]; //Save the End time of the entry in a global variable to use in the next iteration
                }
                lbDisplay.Items.Add("Number of records:" + "\t"  + "\t" + NoOfRecords);
                //All the Variables are integers and stores Time:seconds, we need to parse the int to TimeSpan format to show them in MM:SS Format
                lbDisplay.Items.Add("Minimum Entry Time:" + "\t" + string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(MinEnterTime).Minutes, TimeSpan.FromSeconds(MinEnterTime).Seconds));
                lbDisplay.Items.Add("Maximum Entry Time:" + "\t" + string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(MaxEnterTime).Minutes, TimeSpan.FromSeconds(MaxEnterTime).Seconds));
                lbDisplay.Items.Add("Average Entry Time:" + "\t" + string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(TotalEnterTime / NoOfRecords).Minutes, TimeSpan.FromSeconds(TotalEnterTime / NoOfRecords).Seconds));
                lbDisplay.Items.Add("Minimum Inter-Record Time:" + "\t" + string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(MinGapTime).Minutes, TimeSpan.FromSeconds(MinGapTime).Seconds));
                lbDisplay.Items.Add("Maximum Inter-Record Time:" + "\t" + string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(MaxGapTime).Minutes, TimeSpan.FromSeconds(MaxGapTime).Seconds));
                lbDisplay.Items.Add("Average Inter-Record Time:" + "\t" + string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(TotalGapTime / NoOfRecords).Minutes, TimeSpan.FromSeconds(TotalGapTime / NoOfRecords).Seconds));
                lbDisplay.Items.Add("Total Time:" + "\t"  + "\t" + string.Format("{0:D2}:{1:D2}", TimeSpan.FromSeconds(TotalEnterTime + TotalGapTime).Minutes, TimeSpan.FromSeconds(TotalEnterTime + TotalGapTime).Seconds));
                lbDisplay.Items.Add("Backspace count:" + "\t" + "\t" + BackSpacecount);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(System.IO.Directory.GetCurrentDirectory() + @"\CS6326Asg3.txt"); // Save the file in bin/Release/CS6326Asg3.txt
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(path);
            foreach (var item in lbDisplay.Items) // for each line in List box do the following
            {
                SaveFile.WriteLine(item); // Save each item in the file.
            }
            SaveFile.Close();// Close the file
            MessageBox.Show("Programs saved!"); // Show a pop-up that the entry has been updated.
        }
    }
}