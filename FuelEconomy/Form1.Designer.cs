namespace FuelEconomy
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
            this.components = new System.ComponentModel.Container();
            this.MileageTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GallonsUsedTextBox = new System.Windows.Forms.TextBox();
            this.MPGBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateMPG = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MileageTextBox
            // 
            this.MileageTextBox.Location = new System.Drawing.Point(269, 60);
            this.MileageTextBox.Name = "MileageTextBox";
            this.MileageTextBox.Size = new System.Drawing.Size(109, 20);
            this.MileageTextBox.TabIndex = 0;
            this.MileageTextBox.TextChanged += new System.EventHandler(this.MileageTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GallonsUsedTextBox
            // 
            this.GallonsUsedTextBox.Location = new System.Drawing.Point(269, 108);
            this.GallonsUsedTextBox.Name = "GallonsUsedTextBox";
            this.GallonsUsedTextBox.Size = new System.Drawing.Size(109, 20);
            this.GallonsUsedTextBox.TabIndex = 2;
            this.GallonsUsedTextBox.TextChanged += new System.EventHandler(this.GallonsUsedTextBox_TextChanged);
            // 
            // MPGBox
            // 
            this.MPGBox.Location = new System.Drawing.Point(269, 189);
            this.MPGBox.Name = "MPGBox";
            this.MPGBox.Size = new System.Drawing.Size(109, 20);
            this.MPGBox.TabIndex = 3;
            this.MPGBox.TextChanged += new System.EventHandler(this.MPGBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter the number of miles driven:";
            this.label1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please enter the number of Gallons used:";
            this.label2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your car\'s MPG:";
            this.label3.Click += new System.EventHandler(this.Form1_Load);
            // 
            // CalculateMPG
            // 
            this.CalculateMPG.Location = new System.Drawing.Point(94, 257);
            this.CalculateMPG.Name = "CalculateMPG";
            this.CalculateMPG.Size = new System.Drawing.Size(102, 26);
            this.CalculateMPG.TabIndex = 8;
            this.CalculateMPG.Text = "Calculate MPG";
            this.CalculateMPG.UseVisualStyleBackColor = true;
            this.CalculateMPG.Click += new System.EventHandler(this.CalculateMPG_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(269, 257);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(102, 26);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 323);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateMPG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MPGBox);
            this.Controls.Add(this.GallonsUsedTextBox);
            this.Controls.Add(this.MileageTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MileageTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox GallonsUsedTextBox;
        private System.Windows.Forms.TextBox MPGBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateMPG;
        private System.Windows.Forms.Button ExitButton;
    }
}

