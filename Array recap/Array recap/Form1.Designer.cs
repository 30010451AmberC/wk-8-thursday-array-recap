namespace Array_recap
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
            this.textBoxTask1 = new System.Windows.Forms.TextBox();
            this.textBoxTask1Instructions = new System.Windows.Forms.Label();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxTask1
            // 
            this.textBoxTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTask1.Location = new System.Drawing.Point(38, 73);
            this.textBoxTask1.Name = "textBoxTask1";
            this.textBoxTask1.Size = new System.Drawing.Size(184, 20);
            this.textBoxTask1.TabIndex = 0;
            this.textBoxTask1.Text = "Enter numbers here...";
            this.textBoxTask1.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // textBoxTask1Instructions
            // 
            this.textBoxTask1Instructions.AutoSize = true;
            this.textBoxTask1Instructions.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask1Instructions.Location = new System.Drawing.Point(32, 38);
            this.textBoxTask1Instructions.Name = "textBoxTask1Instructions";
            this.textBoxTask1Instructions.Size = new System.Drawing.Size(225, 32);
            this.textBoxTask1Instructions.TabIndex = 1;
            this.textBoxTask1Instructions.Text = "Enter 10 numbers:";
            this.textBoxTask1Instructions.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(38, 99);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(67, 22);
            this.btnAddNumber.TabIndex = 2;
            this.btnAddNumber.Text = "ADD";
            this.btnAddNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(38, 127);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(96, 26);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display numbers";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // listBoxArray
            // 
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.Location = new System.Drawing.Point(38, 166);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(205, 264);
            this.listBoxArray.TabIndex = 4;
            this.listBoxArray.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.textBoxTask1Instructions);
            this.Controls.Add(this.textBoxTask1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTask1;
        private System.Windows.Forms.Label textBoxTask1Instructions;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox listBoxArray;
    }
}

