//N5284
//Lab 4
//February 17, 2019
//CIS 199-75
//Program that accepts/rejects students based on gpa and admissions test score. It keeps a running total of number of students accepted/rejected

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4Form : Form
    {
        //Class Variable Dictionary
        int runningAccept = 0;                      //Class integer that holds the running total of accepted students
        int runningReject = 0;                      //Class integer that holds the running total of rejected students

        public Lab4Form()
        {
            InitializeComponent();
        }

        //When Check button is pressed, do the following:
        private void checkBtn_Click(object sender, EventArgs e)
        {
            //Local Variable Dictionary
            const double GPA_CUTOFF = 3.0;          //Constant Variable that hold the GPA Target
            const int ADMISSIONS_SCORE_LOW = 60;    //Constant Variable that hold the Lowest Admissions score cuttoff
            const int ADMISSIONS_SCORE_HIGH = 80;   //Constant Variable that hold the Highest Admissions score cuttoff

            double gpaValue;                        //Holds users GPA value
            int admissionsScore;                    //Holds users admissions test score
            
            //Check GPA input for validity
            if (double.TryParse(gpaText.Text, out gpaValue) && gpaValue > 0.0)
            {
                //Check admissions score input for validity
                if (Int32.TryParse(admissionsTxt.Text, out admissionsScore) && admissionsScore > 0)
                {
                    if (gpaValue >= GPA_CUTOFF && admissionsScore >= ADMISSIONS_SCORE_LOW)
                    {
                        outStatusLbl.Text = "Accepted";
                        runningAccept++;
                    }

                    else if (gpaValue < GPA_CUTOFF && admissionsScore >= ADMISSIONS_SCORE_HIGH)
                    {
                        outStatusLbl.Text = "Accepted";
                        runningAccept++;
                    }

                    else
                    {
                        outStatusLbl.Text = "Rejected";
                        runningReject++;
                    }
                }

                else
                    MessageBox.Show("Please enter a valid admissions score value");
            }

            else
                MessageBox.Show("Please enter a valid GPA value");

            //Display counter
            outAcceptedLbl.Text = $"{runningAccept}";
            outRejectedLbl.Text = $"{runningReject}";
        }

        //When Clear button is pressed, do the following:
        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            gpaText.Clear();
            admissionsTxt.Clear();
        }
    }
}
