namespace Calculator.DpMark.App
{
    partial class Form1
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
            this.lblGroupAssignment = new System.Windows.Forms.Label();
            this.lblIndividualAssignment = new System.Windows.Forms.Label();
            this.lblTestMark = new System.Windows.Forms.Label();
            this.txtIndividualAssignment = new System.Windows.Forms.TextBox();
            this.txtGroupAssignment = new System.Windows.Forms.TextBox();
            this.txtTestMark = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGroupAssignment
            // 
            this.lblGroupAssignment.AutoSize = true;
            this.lblGroupAssignment.Location = new System.Drawing.Point(204, 39);
            this.lblGroupAssignment.Name = "lblGroupAssignment";
            this.lblGroupAssignment.Size = new System.Drawing.Size(162, 15);
            this.lblGroupAssignment.TabIndex = 0;
            this.lblGroupAssignment.Text = "Enter Group Assigment Mark:";
            // 
            // lblIndividualAssignment
            // 
            this.lblIndividualAssignment.AutoSize = true;
            this.lblIndividualAssignment.Location = new System.Drawing.Point(204, 90);
            this.lblIndividualAssignment.Name = "lblIndividualAssignment";
            this.lblIndividualAssignment.Size = new System.Drawing.Size(181, 15);
            this.lblIndividualAssignment.TabIndex = 2;
            this.lblIndividualAssignment.Text = "Enter Individual Assigment Mark:";
            // 
            // lblTestMark
            // 
            this.lblTestMark.AutoSize = true;
            this.lblTestMark.Location = new System.Drawing.Point(204, 135);
            this.lblTestMark.Name = "lblTestMark";
            this.lblTestMark.Size = new System.Drawing.Size(90, 15);
            this.lblTestMark.TabIndex = 4;
            this.lblTestMark.Text = "Enter Test Mark:";
            // 
            // txtIndividualAssignment
            // 
            this.txtIndividualAssignment.Location = new System.Drawing.Point(429, 90);
            this.txtIndividualAssignment.Name = "txtIndividualAssignment";
            this.txtIndividualAssignment.Size = new System.Drawing.Size(165, 23);
            this.txtIndividualAssignment.TabIndex = 3;
            // 
            // txtGroupAssignment
            // 
            this.txtGroupAssignment.Location = new System.Drawing.Point(429, 39);
            this.txtGroupAssignment.Name = "txtGroupAssignment";
            this.txtGroupAssignment.Size = new System.Drawing.Size(165, 23);
            this.txtGroupAssignment.TabIndex = 1;
            // 
            // txtTestMark
            // 
            this.txtTestMark.Location = new System.Drawing.Point(429, 135);
            this.txtTestMark.Name = "txtTestMark";
            this.txtTestMark.Size = new System.Drawing.Size(165, 23);
            this.txtTestMark.TabIndex = 5;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(204, 190);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 6;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(365, 190);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 7;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(519, 190);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.txtTestMark);
            this.Controls.Add(this.txtGroupAssignment);
            this.Controls.Add(this.txtIndividualAssignment);
            this.Controls.Add(this.lblTestMark);
            this.Controls.Add(this.lblIndividualAssignment);
            this.Controls.Add(this.lblGroupAssignment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGroupAssignment;
        private Label lblIndividualAssignment;
        private Label lblTestMark;
        private TextBox txtIndividualAssignment;
        private TextBox txtGroupAssignment;
        private TextBox txtTestMark;
        private Button cmdCalculate;
        private Button cmdClear;
        private Button cmdExit;
    }
}