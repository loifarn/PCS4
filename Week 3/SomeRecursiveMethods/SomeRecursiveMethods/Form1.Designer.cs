namespace SomeRecursiveMethods
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
            this.Btn_SumSquares = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_SumArray = new System.Windows.Forms.Button();
            this.Btn_MaxInArray = new System.Windows.Forms.Button();
            this.Btn_SumOfDigits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_SumSquares
            // 
            this.Btn_SumSquares.Location = new System.Drawing.Point(13, 52);
            this.Btn_SumSquares.Name = "Btn_SumSquares";
            this.Btn_SumSquares.Size = new System.Drawing.Size(75, 23);
            this.Btn_SumSquares.TabIndex = 0;
            this.Btn_SumSquares.Text = "SumSquares";
            this.Btn_SumSquares.UseVisualStyleBackColor = true;
            this.Btn_SumSquares.Click += new System.EventHandler(this.Btn_SumSquares_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(173, 112);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(229, 96);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(173, 73);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // Btn_SumArray
            // 
            this.Btn_SumArray.Location = new System.Drawing.Point(13, 85);
            this.Btn_SumArray.Name = "Btn_SumArray";
            this.Btn_SumArray.Size = new System.Drawing.Size(75, 23);
            this.Btn_SumArray.TabIndex = 5;
            this.Btn_SumArray.Text = "SumArray";
            this.Btn_SumArray.UseVisualStyleBackColor = true;
            this.Btn_SumArray.Click += new System.EventHandler(this.Btn_SumArray_Click);
            // 
            // Btn_MaxInArray
            // 
            this.Btn_MaxInArray.Location = new System.Drawing.Point(13, 114);
            this.Btn_MaxInArray.Name = "Btn_MaxInArray";
            this.Btn_MaxInArray.Size = new System.Drawing.Size(75, 23);
            this.Btn_MaxInArray.TabIndex = 6;
            this.Btn_MaxInArray.Text = "MaxInArray";
            this.Btn_MaxInArray.UseVisualStyleBackColor = true;
            this.Btn_MaxInArray.Click += new System.EventHandler(this.Btn_MaxInArray_Click);
            // 
            // Btn_SumOfDigits
            // 
            this.Btn_SumOfDigits.Location = new System.Drawing.Point(13, 143);
            this.Btn_SumOfDigits.Name = "Btn_SumOfDigits";
            this.Btn_SumOfDigits.Size = new System.Drawing.Size(75, 23);
            this.Btn_SumOfDigits.TabIndex = 7;
            this.Btn_SumOfDigits.Text = "SumOfDigits";
            this.Btn_SumOfDigits.UseVisualStyleBackColor = true;
            this.Btn_SumOfDigits.Click += new System.EventHandler(this.Btn_SumOfDigits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 268);
            this.Controls.Add(this.Btn_SumOfDigits);
            this.Controls.Add(this.Btn_MaxInArray);
            this.Controls.Add(this.Btn_SumArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Btn_SumSquares);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SumSquares;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_SumArray;
        private System.Windows.Forms.Button Btn_MaxInArray;
        private System.Windows.Forms.Button Btn_SumOfDigits;
    }
}

