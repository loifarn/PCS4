namespace Assignment6
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
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.Btn_Count = new System.Windows.Forms.Button();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.Btn_Test = new System.Windows.Forms.Button();
            this.Label_Add = new System.Windows.Forms.Label();
            this.Label_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(174, 9);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Show
            // 
            this.Btn_Show.Location = new System.Drawing.Point(12, 154);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(75, 23);
            this.Btn_Show.TabIndex = 1;
            this.Btn_Show.Text = "Show";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // Btn_Count
            // 
            this.Btn_Count.Location = new System.Drawing.Point(93, 154);
            this.Btn_Count.Name = "Btn_Count";
            this.Btn_Count.Size = new System.Drawing.Size(75, 23);
            this.Btn_Count.TabIndex = 2;
            this.Btn_Count.Text = "Count";
            this.Btn_Count.UseVisualStyleBackColor = true;
            this.Btn_Count.Click += new System.EventHandler(this.Btn_Count_Click);
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(255, 9);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(75, 23);
            this.Btn_Find.TabIndex = 3;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(12, 12);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(156, 20);
            this.TB_Input.TabIndex = 4;
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(12, 53);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(237, 95);
            this.LB_Output.TabIndex = 5;
            // 
            // Btn_Test
            // 
            this.Btn_Test.Location = new System.Drawing.Point(283, 222);
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.Size = new System.Drawing.Size(75, 23);
            this.Btn_Test.TabIndex = 6;
            this.Btn_Test.Text = "Test";
            this.Btn_Test.UseVisualStyleBackColor = true;
            this.Btn_Test.Click += new System.EventHandler(this.Btn_Test_Click);
            // 
            // Label_Add
            // 
            this.Label_Add.AutoSize = true;
            this.Label_Add.Location = new System.Drawing.Point(12, 34);
            this.Label_Add.Name = "Label_Add";
            this.Label_Add.Size = new System.Drawing.Size(41, 13);
            this.Label_Add.TabIndex = 7;
            this.Label_Add.Text = "Added:";
            // 
            // Label_Count
            // 
            this.Label_Count.AutoSize = true;
            this.Label_Count.Location = new System.Drawing.Point(171, 159);
            this.Label_Count.Name = "Label_Count";
            this.Label_Count.Size = new System.Drawing.Size(38, 13);
            this.Label_Count.TabIndex = 8;
            this.Label_Count.Text = "Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 257);
            this.Controls.Add(this.Label_Count);
            this.Controls.Add(this.Label_Add);
            this.Controls.Add(this.Btn_Test);
            this.Controls.Add(this.LB_Output);
            this.Controls.Add(this.TB_Input);
            this.Controls.Add(this.Btn_Find);
            this.Controls.Add(this.Btn_Count);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.Btn_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.Button Btn_Count;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.ListBox LB_Output;
        private System.Windows.Forms.Button Btn_Test;
        private System.Windows.Forms.Label Label_Add;
        private System.Windows.Forms.Label Label_Count;
    }
}

