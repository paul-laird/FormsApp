namespace FormsApp
{
    partial class Form1
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
            this.initialiseButton = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialiseButton
            // 
            this.initialiseButton.Location = new System.Drawing.Point(415, 12);
            this.initialiseButton.Name = "initialiseButton";
            this.initialiseButton.Size = new System.Drawing.Size(97, 23);
            this.initialiseButton.TabIndex = 0;
            this.initialiseButton.Text = "Initialise";
            this.initialiseButton.UseVisualStyleBackColor = true;
            this.initialiseButton.Click += new System.EventHandler(this.InitialiseButton_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(162, 15);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 1;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(162, 72);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 20);
            this.Address.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(415, 72);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(97, 23);
            this.AddCustomer.TabIndex = 6;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 460);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.initialiseButton);
//            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initialiseButton;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCustomer;
    }
}

