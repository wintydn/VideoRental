namespace VideoRental
{
    partial class Confirm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbReturnDate = new System.Windows.Forms.TextBox();
            this.tbVideoCode = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.lbDateRented = new System.Windows.Forms.Label();
            this.lbVideoCode = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // tbReturnDate
            // 
            this.tbReturnDate.Location = new System.Drawing.Point(379, 310);
            this.tbReturnDate.Name = "tbReturnDate";
            this.tbReturnDate.ReadOnly = true;
            this.tbReturnDate.Size = new System.Drawing.Size(100, 35);
            this.tbReturnDate.TabIndex = 18;
            // 
            // tbVideoCode
            // 
            this.tbVideoCode.Location = new System.Drawing.Point(379, 150);
            this.tbVideoCode.Name = "tbVideoCode";
            this.tbVideoCode.Size = new System.Drawing.Size(100, 35);
            this.tbVideoCode.TabIndex = 17;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(379, 72);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 35);
            this.tbID.TabIndex = 16;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Location = new System.Drawing.Point(141, 310);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(134, 29);
            this.lbReturnDate.TabIndex = 15;
            this.lbReturnDate.Text = "ReturnDate";
            // 
            // lbDateRented
            // 
            this.lbDateRented.AutoSize = true;
            this.lbDateRented.Location = new System.Drawing.Point(141, 236);
            this.lbDateRented.Name = "lbDateRented";
            this.lbDateRented.Size = new System.Drawing.Size(141, 29);
            this.lbDateRented.TabIndex = 14;
            this.lbDateRented.Text = "DateRented";
            // 
            // lbVideoCode
            // 
            this.lbVideoCode.AutoSize = true;
            this.lbVideoCode.Location = new System.Drawing.Point(141, 157);
            this.lbVideoCode.Name = "lbVideoCode";
            this.lbVideoCode.Size = new System.Drawing.Size(126, 29);
            this.lbVideoCode.TabIndex = 13;
            this.lbVideoCode.Text = "MovieTitle";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(141, 75);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(140, 29);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "CustomerID";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(280, 403);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 100);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 672);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbReturnDate);
            this.Controls.Add(this.tbVideoCode);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbReturnDate);
            this.Controls.Add(this.lbDateRented);
            this.Controls.Add(this.lbVideoCode);
            this.Controls.Add(this.lbID);
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbReturnDate;
        private System.Windows.Forms.TextBox tbVideoCode;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.Label lbDateRented;
        private System.Windows.Forms.Label lbVideoCode;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnOK;
    }
}