﻿namespace StopWatchV1
{
    partial class StopWatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatch));
            this.watchLabel = new System.Windows.Forms.Label();
            this.STARTbutton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.lapsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // watchLabel
            // 
            this.watchLabel.Font = new System.Drawing.Font("Impact", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.watchLabel.ForeColor = System.Drawing.Color.White;
            this.watchLabel.Location = new System.Drawing.Point(1, 158);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(1155, 317);
            this.watchLabel.TabIndex = 0;
            this.watchLabel.Text = "00:00:00";
            this.watchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.watchLabel.Click += new System.EventHandler(this.watchLabel_Click);
            // 
            // STARTbutton
            // 
            this.STARTbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.STARTbutton.Location = new System.Drawing.Point(11, 583);
            this.STARTbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.STARTbutton.Name = "STARTbutton";
            this.STARTbutton.Size = new System.Drawing.Size(230, 98);
            this.STARTbutton.TabIndex = 1;
            this.STARTbutton.Text = "START";
            this.STARTbutton.UseVisualStyleBackColor = true;
            this.STARTbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopButton.Location = new System.Drawing.Point(246, 583);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(230, 98);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetButton.Location = new System.Drawing.Point(482, 583);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(230, 98);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // formTimer
            // 
            this.formTimer.Interval = 10;
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(717, 583);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(230, 98);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lapsListBox
            // 
            this.lapsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lapsListBox.FormattingEnabled = true;
            this.lapsListBox.ItemHeight = 42;
            this.lapsListBox.Location = new System.Drawing.Point(953, 54);
            this.lapsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lapsListBox.Name = "lapsListBox";
            this.lapsListBox.Size = new System.Drawing.Size(203, 592);
            this.lapsListBox.TabIndex = 5;
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1156, 683);
            this.Controls.Add(this.lapsListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.STARTbutton);
            this.Controls.Add(this.watchLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StopWatch";
            this.Text = "StopWatch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.Button STARTbutton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer formTimer;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox lapsListBox;
    }
}

