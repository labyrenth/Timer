using System;

namespace TIMER
{
    partial class TimerCalenderForm
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
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.ShowTimeLine = new System.Windows.Forms.TextBox();
            this.Form2_End = new System.Windows.Forms.Button();
            this.Search_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(12, 12);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 25);
            this.StartDate.Value = DateTime.Today;
            this.StartDate.TabIndex = 0;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(12, 43);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 25);
            this.EndDate.Value = DateTime.Today;
            this.EndDate.TabIndex = 1;
            // 
            // ShowTimeLine
            // 
            this.ShowTimeLine.Location = new System.Drawing.Point(12, 74);
            this.ShowTimeLine.Multiline = true;
            this.ShowTimeLine.Name = "ShowTimeLine";
            this.ShowTimeLine.Size = new System.Drawing.Size(200, 50);
            this.ShowTimeLine.TabIndex = 2;
            // 
            // Form2_End
            // 
            this.Form2_End.Location = new System.Drawing.Point(122, 130);
            this.Form2_End.Name = "Form2_End";
            this.Form2_End.Size = new System.Drawing.Size(90, 23);
            this.Form2_End.TabIndex = 3;
            this.Form2_End.Text = "종료";
            this.Form2_End.UseVisualStyleBackColor = true;
            this.Form2_End.Click += new System.EventHandler(this.Form2_End_Click);
            // 
            // Search_Start
            // 
            this.Search_Start.Location = new System.Drawing.Point(12, 130);
            this.Search_Start.Name = "Search_Start";
            this.Search_Start.Size = new System.Drawing.Size(89, 23);
            this.Search_Start.TabIndex = 4;
            this.Search_Start.Text = "검색 시작";
            this.Search_Start.UseVisualStyleBackColor = true;
            this.Search_Start.Click += new System.EventHandler(this.Search_Start_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 163);
            this.Controls.Add(this.Search_Start);
            this.Controls.Add(this.Form2_End);
            this.Controls.Add(this.ShowTimeLine);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Name = "Form2";
            this.Text = "공부 시간 검색기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.TextBox ShowTimeLine;
        private System.Windows.Forms.Button Form2_End;
        private System.Windows.Forms.Button Search_Start;
    }
}