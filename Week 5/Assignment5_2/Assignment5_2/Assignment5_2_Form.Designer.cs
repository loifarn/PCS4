namespace Assignment5_2
{
    partial class Assignment5_2_Form
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
            this.GB_Registration = new System.Windows.Forms.GroupBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.GB_DoctorPref = new System.Windows.Forms.GroupBox();
            this.Rb_NoPreference = new System.Windows.Forms.RadioButton();
            this.Rb_Carla = new System.Windows.Forms.RadioButton();
            this.Rb_John = new System.Windows.Forms.RadioButton();
            this.TB_Reason = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_WaitingRoom = new System.Windows.Forms.GroupBox();
            this.GB_John = new System.Windows.Forms.GroupBox();
            this.GB_Carla = new System.Windows.Forms.GroupBox();
            this.GB_Registration.SuspendLayout();
            this.GB_DoctorPref.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Registration
            // 
            this.GB_Registration.BackColor = System.Drawing.Color.Yellow;
            this.GB_Registration.Controls.Add(this.Btn_Register);
            this.GB_Registration.Controls.Add(this.GB_DoctorPref);
            this.GB_Registration.Controls.Add(this.TB_Reason);
            this.GB_Registration.Controls.Add(this.TB_Name);
            this.GB_Registration.Controls.Add(this.label2);
            this.GB_Registration.Controls.Add(this.label1);
            this.GB_Registration.Location = new System.Drawing.Point(12, 12);
            this.GB_Registration.Name = "GB_Registration";
            this.GB_Registration.Size = new System.Drawing.Size(352, 211);
            this.GB_Registration.TabIndex = 0;
            this.GB_Registration.TabStop = false;
            this.GB_Registration.Text = "Registration";
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(230, 112);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(96, 56);
            this.Btn_Register.TabIndex = 5;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // GB_DoctorPref
            // 
            this.GB_DoctorPref.Controls.Add(this.Rb_NoPreference);
            this.GB_DoctorPref.Controls.Add(this.Rb_Carla);
            this.GB_DoctorPref.Controls.Add(this.Rb_John);
            this.GB_DoctorPref.Location = new System.Drawing.Point(15, 89);
            this.GB_DoctorPref.Name = "GB_DoctorPref";
            this.GB_DoctorPref.Size = new System.Drawing.Size(183, 99);
            this.GB_DoctorPref.TabIndex = 4;
            this.GB_DoctorPref.TabStop = false;
            this.GB_DoctorPref.Text = "I prefer doctor";
            // 
            // Rb_NoPreference
            // 
            this.Rb_NoPreference.AutoSize = true;
            this.Rb_NoPreference.Location = new System.Drawing.Point(19, 62);
            this.Rb_NoPreference.Name = "Rb_NoPreference";
            this.Rb_NoPreference.Size = new System.Drawing.Size(94, 17);
            this.Rb_NoPreference.TabIndex = 2;
            this.Rb_NoPreference.TabStop = true;
            this.Rb_NoPreference.Text = "No Preference";
            this.Rb_NoPreference.UseVisualStyleBackColor = true;
            // 
            // Rb_Carla
            // 
            this.Rb_Carla.AutoSize = true;
            this.Rb_Carla.Location = new System.Drawing.Point(19, 43);
            this.Rb_Carla.Name = "Rb_Carla";
            this.Rb_Carla.Size = new System.Drawing.Size(66, 17);
            this.Rb_Carla.TabIndex = 1;
            this.Rb_Carla.TabStop = true;
            this.Rb_Carla.Text = "Dr. Carla";
            this.Rb_Carla.UseVisualStyleBackColor = true;
            // 
            // Rb_John
            // 
            this.Rb_John.AutoSize = true;
            this.Rb_John.Location = new System.Drawing.Point(19, 23);
            this.Rb_John.Name = "Rb_John";
            this.Rb_John.Size = new System.Drawing.Size(65, 17);
            this.Rb_John.TabIndex = 0;
            this.Rb_John.TabStop = true;
            this.Rb_John.Text = "Dr. John";
            this.Rb_John.UseVisualStyleBackColor = true;
            // 
            // TB_Reason
            // 
            this.TB_Reason.Location = new System.Drawing.Point(98, 53);
            this.TB_Reason.Name = "TB_Reason";
            this.TB_Reason.Size = new System.Drawing.Size(100, 20);
            this.TB_Reason.TabIndex = 3;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(98, 28);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reason for visit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // GB_WaitingRoom
            // 
            this.GB_WaitingRoom.BackColor = System.Drawing.Color.Lime;
            this.GB_WaitingRoom.Location = new System.Drawing.Point(12, 229);
            this.GB_WaitingRoom.Name = "GB_WaitingRoom";
            this.GB_WaitingRoom.Size = new System.Drawing.Size(352, 224);
            this.GB_WaitingRoom.TabIndex = 1;
            this.GB_WaitingRoom.TabStop = false;
            this.GB_WaitingRoom.Text = "Waiting Room";
            // 
            // GB_John
            // 
            this.GB_John.BackColor = System.Drawing.Color.Fuchsia;
            this.GB_John.Location = new System.Drawing.Point(370, 12);
            this.GB_John.Name = "GB_John";
            this.GB_John.Size = new System.Drawing.Size(395, 211);
            this.GB_John.TabIndex = 1;
            this.GB_John.TabStop = false;
            this.GB_John.Text = "Dr. John";
            // 
            // GB_Carla
            // 
            this.GB_Carla.BackColor = System.Drawing.Color.Fuchsia;
            this.GB_Carla.Location = new System.Drawing.Point(370, 229);
            this.GB_Carla.Name = "GB_Carla";
            this.GB_Carla.Size = new System.Drawing.Size(395, 224);
            this.GB_Carla.TabIndex = 2;
            this.GB_Carla.TabStop = false;
            this.GB_Carla.Text = "Dr. Carla";
            // 
            // Assignment5_2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 465);
            this.Controls.Add(this.GB_Carla);
            this.Controls.Add(this.GB_WaitingRoom);
            this.Controls.Add(this.GB_John);
            this.Controls.Add(this.GB_Registration);
            this.Name = "Assignment5_2_Form";
            this.Text = "Assignment 5_2";
            this.GB_Registration.ResumeLayout(false);
            this.GB_Registration.PerformLayout();
            this.GB_DoctorPref.ResumeLayout(false);
            this.GB_DoctorPref.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Registration;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.GroupBox GB_DoctorPref;
        private System.Windows.Forms.TextBox TB_Reason;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_WaitingRoom;
        private System.Windows.Forms.GroupBox GB_John;
        private System.Windows.Forms.GroupBox GB_Carla;
        private System.Windows.Forms.RadioButton Rb_NoPreference;
        private System.Windows.Forms.RadioButton Rb_Carla;
        private System.Windows.Forms.RadioButton Rb_John;
    }
}

