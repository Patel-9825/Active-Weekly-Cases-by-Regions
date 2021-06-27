
using System;

namespace Lab3
{
    partial class formAverageCase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCaseEntry = new System.Windows.Forms.TextBox();
            this.labelRegion1Prompt = new System.Windows.Forms.Label();
            this.labelRegion2Prompt = new System.Windows.Forms.Label();
            this.labelRegion3Prompt = new System.Windows.Forms.Label();
            this.textBoxRegion1List = new System.Windows.Forms.TextBox();
            this.textBoxRegion2List = new System.Windows.Forms.TextBox();
            this.textBoxRegion3List = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelRegion1Average = new System.Windows.Forms.Label();
            this.labelRegion2Average = new System.Windows.Forms.Label();
            this.labelRegion3Average = new System.Windows.Forms.Label();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily &Cases:";
            // 
            // textBoxCaseEntry
            // 
            this.textBoxCaseEntry.Location = new System.Drawing.Point(142, 29);
            this.textBoxCaseEntry.Name = "textBoxCaseEntry";
            this.textBoxCaseEntry.Size = new System.Drawing.Size(213, 27);
            this.textBoxCaseEntry.TabIndex = 1;
            // 
            // labelRegion1Prompt
            // 
            this.labelRegion1Prompt.AutoSize = true;
            this.labelRegion1Prompt.Location = new System.Drawing.Point(73, 96);
            this.labelRegion1Prompt.Name = "labelRegion1Prompt";
            this.labelRegion1Prompt.Size = new System.Drawing.Size(68, 20);
            this.labelRegion1Prompt.TabIndex = 2;
            this.labelRegion1Prompt.Text = "Region &1";
            // 
            // labelRegion2Prompt
            // 
            this.labelRegion2Prompt.AutoSize = true;
            this.labelRegion2Prompt.Location = new System.Drawing.Point(245, 96);
            this.labelRegion2Prompt.Name = "labelRegion2Prompt";
            this.labelRegion2Prompt.Size = new System.Drawing.Size(68, 20);
            this.labelRegion2Prompt.TabIndex = 3;
            this.labelRegion2Prompt.Text = "Region &2";
            // 
            // labelRegion3Prompt
            // 
            this.labelRegion3Prompt.AutoSize = true;
            this.labelRegion3Prompt.Location = new System.Drawing.Point(426, 96);
            this.labelRegion3Prompt.Name = "labelRegion3Prompt";
            this.labelRegion3Prompt.Size = new System.Drawing.Size(68, 20);
            this.labelRegion3Prompt.TabIndex = 4;
            this.labelRegion3Prompt.Text = "Region &3";
            // 
            // textBoxRegion1List
            // 
            this.textBoxRegion1List.Location = new System.Drawing.Point(28, 133);
            this.textBoxRegion1List.Multiline = true;
            this.textBoxRegion1List.Name = "textBoxRegion1List";
            this.textBoxRegion1List.Size = new System.Drawing.Size(151, 241);
            this.textBoxRegion1List.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxRegion1List, "List of Average Cases in Region  1");
            // 
            // textBoxRegion2List
            // 
            this.textBoxRegion2List.Location = new System.Drawing.Point(204, 133);
            this.textBoxRegion2List.Multiline = true;
            this.textBoxRegion2List.Name = "textBoxRegion2List";
            this.textBoxRegion2List.Size = new System.Drawing.Size(151, 241);
            this.textBoxRegion2List.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxRegion2List, "List of Average Cases in Region  2");
            // 
            // textBoxRegion3List
            // 
            this.textBoxRegion3List.Location = new System.Drawing.Point(384, 133);
            this.textBoxRegion3List.Multiline = true;
            this.textBoxRegion3List.Name = "textBoxRegion3List";
            this.textBoxRegion3List.Size = new System.Drawing.Size(151, 241);
            this.textBoxRegion3List.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxRegion3List, "List of Average Cases in Region  3");
            this.textBoxRegion3List.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(28, 501);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(151, 29);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Click to get the current number of cases");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.EnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(204, 501);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(151, 29);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Click to reset this form to normal one");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(384, 501);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(151, 29);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Click to Exit the form.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // labelRegion1Average
            // 
            this.labelRegion1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion1Average.Location = new System.Drawing.Point(28, 398);
            this.labelRegion1Average.Name = "labelRegion1Average";
            this.labelRegion1Average.Size = new System.Drawing.Size(151, 25);
            this.labelRegion1Average.TabIndex = 15;
            this.labelRegion1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion1Average, "Average Cases of Region 1");
            this.labelRegion1Average.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRegion2Average
            // 
            this.labelRegion2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion2Average.Location = new System.Drawing.Point(204, 398);
            this.labelRegion2Average.Name = "labelRegion2Average";
            this.labelRegion2Average.Size = new System.Drawing.Size(151, 25);
            this.labelRegion2Average.TabIndex = 16;
            this.labelRegion2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion2Average, "Average Cases of Region 2");
            // 
            // labelRegion3Average
            // 
            this.labelRegion3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion3Average.Location = new System.Drawing.Point(384, 398);
            this.labelRegion3Average.Name = "labelRegion3Average";
            this.labelRegion3Average.Size = new System.Drawing.Size(151, 25);
            this.labelRegion3Average.TabIndex = 17;
            this.labelRegion3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion3Average, "Average Cases of Region 3");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(28, 441);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(507, 37);
            this.labelAverageOutput.TabIndex = 18;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(462, 30);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(47, 20);
            this.labelDay.TabIndex = 19;
            this.labelDay.Text = "Day 1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formAverageCase
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 545);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.labelRegion3Average);
            this.Controls.Add(this.labelRegion2Average);
            this.Controls.Add(this.labelRegion1Average);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxRegion3List);
            this.Controls.Add(this.textBoxRegion2List);
            this.Controls.Add(this.textBoxRegion1List);
            this.Controls.Add(this.labelRegion3Prompt);
            this.Controls.Add(this.labelRegion2Prompt);
            this.Controls.Add(this.labelRegion1Prompt);
            this.Controls.Add(this.textBoxCaseEntry);
            this.Controls.Add(this.label1);
            this.Name = "formAverageCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units by Region";
            this.Load += new System.EventHandler(this.formAverageCase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCaseEntry;
        private System.Windows.Forms.Label labelRegion1Prompt;
        private System.Windows.Forms.Label labelRegion2Prompt;
        private System.Windows.Forms.Label labelRegion3Prompt;
        private System.Windows.Forms.TextBox textBoxRegion1List;
        private System.Windows.Forms.TextBox textBoxRegion2List;
        private System.Windows.Forms.TextBox textBoxRegion3List;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelRegion1Average;
        private System.Windows.Forms.Label labelRegion2Average;
        private System.Windows.Forms.Label labelRegion3Average;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Label labelDay;
    }
}

