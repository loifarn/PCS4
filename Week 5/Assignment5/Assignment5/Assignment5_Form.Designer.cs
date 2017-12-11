namespace Assignment5
{
    partial class Assignment5_Form
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
            this.Btn_Add = new System.Windows.Forms.Button();
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Btn_Count = new System.Windows.Forms.Button();
            this.LB_Display = new System.Windows.Forms.ListBox();
            this.Label_Nametag = new System.Windows.Forms.Label();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.Label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(12, 226);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(12, 200);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(125, 20);
            this.TB_Input.TabIndex = 1;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(93, 226);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remove.TabIndex = 2;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Count
            // 
            this.Btn_Count.Location = new System.Drawing.Point(174, 226);
            this.Btn_Count.Name = "Btn_Count";
            this.Btn_Count.Size = new System.Drawing.Size(75, 23);
            this.Btn_Count.TabIndex = 3;
            this.Btn_Count.Text = "Count";
            this.Btn_Count.UseVisualStyleBackColor = true;
            this.Btn_Count.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // LB_Display
            // 
            this.LB_Display.FormattingEnabled = true;
            this.LB_Display.Location = new System.Drawing.Point(12, 12);
            this.LB_Display.Name = "LB_Display";
            this.LB_Display.Size = new System.Drawing.Size(260, 160);
            this.LB_Display.TabIndex = 4;
            // 
            // Label_Nametag
            // 
            this.Label_Nametag.AutoSize = true;
            this.Label_Nametag.Location = new System.Drawing.Point(12, 184);
            this.Label_Nametag.Name = "Label_Nametag";
            this.Label_Nametag.Size = new System.Drawing.Size(61, 13);
            this.Label_Nametag.TabIndex = 5;
            this.Label_Nametag.Text = "Enter name";
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(255, 226);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(75, 23);
            this.Btn_Find.TabIndex = 6;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(174, 200);
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.Size = new System.Drawing.Size(123, 20);
            this.TB_Output.TabIndex = 7;
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(171, 184);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(37, 13);
            this.Label_Result.TabIndex = 8;
            this.Label_Result.Text = "Result";
            // 
            // Assignment5_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 263);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.TB_Output);
            this.Controls.Add(this.Btn_Find);
            this.Controls.Add(this.Label_Nametag);
            this.Controls.Add(this.LB_Display);
            this.Controls.Add(this.Btn_Count);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.TB_Input);
            this.Controls.Add(this.Btn_Add);
            this.Name = "Assignment5_Form";
            this.Text = "Assignment5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Count;
        private System.Windows.Forms.ListBox LB_Display;
        private System.Windows.Forms.Label Label_Nametag;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Label Label_Result;
    }
}

