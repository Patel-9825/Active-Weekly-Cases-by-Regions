// Dhruv Patel #100800111
// June 26, 2021
// Description: Form about the cases which will be collected for 3 different region and each region will
//              will collect 7 values and average of each region will be printed with another average of 
//              of three regions.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class formAverageCase : Form
    {
        // Declare class-level variables
        int currentDay = 0;
        int currentRegion = 0;
        const int NumberOfRegions = 3;
        const int NumberOfDays = 7;

        // This is the 2D array of all cases.
        int[,] cases = new int[NumberOfRegions, NumberOfDays];

        // These are arrays of controls on the form.
        TextBox[] textBoxCaseLists;
        Label[] labelAverages;


        /// <summary>
        /// Initialize the form and arrays of controls.
        /// </summary>
        public formAverageCase()
        {
            InitializeComponent();

            textBoxCaseLists = new TextBox[] { textBoxRegion1List, textBoxRegion2List, textBoxRegion3List };

            labelAverages = new Label[] { labelRegion1Average, labelRegion2Average, labelRegion3Average };
        }

        /// <summary>
        /// This exits the application.
        /// </summary>

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }
        /// Clear all fields and resets the form to its default state.
        /// </summary>

        private void ResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Validates and accepts a value for a number of cases entered by the user. When it's valid, 
        /// records the value and adds to a running total. Once all cases are entered, calculates and 
        /// displays an average.
        /// </summary>
        private void EnterClick(object sender, EventArgs e)
        {
            // Declare a variable to store the user's last (numeric) input.
            int enteredCases;

            // If the contents of the textbox are a number...
            if (int.TryParse(textBoxCaseEntry.Text, out enteredCases))
            {
                // If the contents of the textbox are in the valid range (positive)...
                if (enteredCases >= 0 && enteredCases <= int.MaxValue)
                {
                    // Add the entered cases to the array.
                    cases[currentRegion, currentDay] = enteredCases;

                    // Add the entered cases to the appropriate textbox.
                    textBoxCaseLists[currentRegion].Text += enteredCases + Environment.NewLine;

                    // Increment the day.
                    currentDay++;

                    //If we are at day 7, go to the next region.
                    if (currentDay >= NumberOfDays)
                    {
                        // Calculate the average for the current region.
                        double totalCases = 0;
                        for (int dayCount = 0; dayCount < NumberOfDays; dayCount++)
                        {
                            totalCases += cases[currentRegion, dayCount];
                        }

                        // Use the total to calculate and output the average.
                        labelAverages[currentRegion].Text = "Average: " + Math.Round(totalCases / NumberOfDays, 2);

                        // Go to the next region.
                        currentDay = 0;
                        currentRegion++;

                        // If we are at region 3, run the final calculations
                        if (currentRegion >= NumberOfRegions)
                        {
                            // Calculate the total among all regions
                            // Consider using a foreach loop for this.
                            double totalRegion = 0;
                            for (int regionCount = 0; regionCount < NumberOfRegions; regionCount++)
                            {
                                totalRegion += regionCount;
                            }

                            // Use the total to calculate and output the overall average.
                            labelAverageOutput.Text = "Average This Week: " + Math.Round(totalRegion / NumberOfRegions, 2);


                            // Disable the input textbox and calculate button.
                        }
                    }
                    labelDay.Text = "Day " + currentDay + 1;

                }
                // The contents are in range. Report an error.
                else
                {
                    MessageBox.Show("Your entry must be between 0 and " + int.MaxValue, "Entry Error!");
                    textBoxCaseEntry.SelectAll();
                    textBoxCaseEntry.Focus();
                }
            }
            // The contents are not a whole number. Report an error.
            else
            {
                MessageBox.Show("Your entry must be a whole number. ", "Entry Error!");
                textBoxCaseEntry.SelectAll();
                textBoxCaseEntry.Focus();
            }
        }

        public void SetDefaults()
        {
            // Clear input and output controls.
            textBoxCaseEntry.Clear();
            textBoxRegion1List.Clear();
            textBoxRegion2List.Clear();
            textBoxRegion3List.Clear();
            labelAverageOutput.Text = String.Empty;
            labelRegion1Average.Text = String.Empty;
            labelRegion2Average.Text = String.Empty;
            labelRegion3Average.Text = String.Empty;

            // Re-enable any controls that could be disabled.
            textBoxCaseEntry.Enabled = true;
            buttonEnter.Enabled = true;

            // Reset the value of the class-level variables.
            currentDay = 0;
            currentRegion = 0;

            // Set the displayed day back to default.
            labelDay.Text = "Day" + currentDay;

            // Set Focus.
            textBoxCaseEntry.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formAverageCase_Load(object sender, EventArgs e)
        {

        }
    }
}