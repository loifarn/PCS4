namespace WindowsApplication2
{
    partial class Form2
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
            this.rb_tocapitals = new System.Windows.Forms.RadioButton();
            this.rb_nextchar = new System.Windows.Forms.RadioButton();
            this.rb_formerchar = new System.Windows.Forms.RadioButton();
            this.rb_towhat = new System.Windows.Forms.RadioButton();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_changestring = new System.Windows.Forms.Button();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rb_tocapitals
            // 
            this.rb_tocapitals.AutoSize = true;
            this.rb_tocapitals.Location = new System.Drawing.Point(12, 12);
            this.rb_tocapitals.Name = "rb_tocapitals";
            this.rb_tocapitals.Size = new System.Drawing.Size(73, 17);
            this.rb_tocapitals.TabIndex = 0;
            this.rb_tocapitals.TabStop = true;
            this.rb_tocapitals.Text = "to capitals";
            this.rb_tocapitals.UseVisualStyleBackColor = true;
            // 
            // rb_nextchar
            // 
            this.rb_nextchar.AutoSize = true;
            this.rb_nextchar.Location = new System.Drawing.Point(12, 35);
            this.rb_nextchar.Name = "rb_nextchar";
            this.rb_nextchar.Size = new System.Drawing.Size(105, 17);
            this.rb_nextchar.TabIndex = 1;
            this.rb_nextchar.TabStop = true;
            this.rb_nextchar.Text = "to next character";
            this.rb_nextchar.UseVisualStyleBackColor = true;
            // 
            // rb_formerchar
            // 
            this.rb_formerchar.AutoSize = true;
            this.rb_formerchar.Location = new System.Drawing.Point(12, 59);
            this.rb_formerchar.Name = "rb_formerchar";
            this.rb_formerchar.Size = new System.Drawing.Size(114, 17);
            this.rb_formerchar.TabIndex = 2;
            this.rb_formerchar.TabStop = true;
            this.rb_formerchar.Text = "to former character";
            this.rb_formerchar.UseVisualStyleBackColor = true;
            // 
            // rb_towhat
            // 
            this.rb_towhat.AutoSize = true;
            this.rb_towhat.Location = new System.Drawing.Point(12, 83);
            this.rb_towhat.Name = "rb_towhat";
            this.rb_towhat.Size = new System.Drawing.Size(60, 17);
            this.rb_towhat.TabIndex = 3;
            this.rb_towhat.TabStop = true;
            this.rb_towhat.Text = "to what";
            this.rb_towhat.UseVisualStyleBackColor = true;
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(49, 172);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(100, 20);
            this.tb_input.TabIndex = 4;
            // 
            // btn_changestring
            // 
            this.btn_changestring.Location = new System.Drawing.Point(156, 172);
            this.btn_changestring.Name = "btn_changestring";
            this.btn_changestring.Size = new System.Drawing.Size(75, 23);
            this.btn_changestring.TabIndex = 5;
            this.btn_changestring.Text = ">>";
            this.btn_changestring.UseVisualStyleBackColor = true;
            this.btn_changestring.Click += new System.EventHandler(this.btn_changestring_Click);
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(237, 172);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(100, 20);
            this.tb_output.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 237);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.btn_changestring);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.rb_towhat);
            this.Controls.Add(this.rb_formerchar);
            this.Controls.Add(this.rb_nextchar);
            this.Controls.Add(this.rb_tocapitals);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_tocapitals;
        private System.Windows.Forms.RadioButton rb_nextchar;
        private System.Windows.Forms.RadioButton rb_formerchar;
        private System.Windows.Forms.RadioButton rb_towhat;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button btn_changestring;
        private System.Windows.Forms.TextBox tb_output;
    }
}