namespace amusementPark_TicketBooth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numTicket = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtExpress = new System.Windows.Forms.RadioButton();
            this.rbtEntrance = new System.Windows.Forms.RadioButton();
            this.rbtRide = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numDragon = new System.Windows.Forms.NumericUpDown();
            this.numLazer = new System.Windows.Forms.NumericUpDown();
            this.numScream = new System.Windows.Forms.NumericUpDown();
            this.numWinter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDragon = new System.Windows.Forms.CheckBox();
            this.checkBoxScream = new System.Windows.Forms.CheckBox();
            this.checkBoxLazer = new System.Windows.Forms.CheckBox();
            this.checkBoxWinter = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbdNormal = new System.Windows.Forms.RadioButton();
            this.rbdMember = new System.Windows.Forms.RadioButton();
            this.rbdSenior = new System.Windows.Forms.RadioButton();
            this.rbdStudent = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTicket)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinter)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amusement park ticket booth System";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numTicket);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtExpress);
            this.groupBox1.Controls.Add(this.rbtEntrance);
            this.groupBox1.Controls.Add(this.rbtRide);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TICKET TYPE";
            // 
            // numTicket
            // 
            this.numTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTicket.Location = new System.Drawing.Point(114, 198);
            this.numTicket.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numTicket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTicket.Name = "numTicket";
            this.numTicket.Size = new System.Drawing.Size(120, 27);
            this.numTicket.TabIndex = 6;
            this.numTicket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // rbtExpress
            // 
            this.rbtExpress.AutoSize = true;
            this.rbtExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtExpress.Location = new System.Drawing.Point(22, 136);
            this.rbtExpress.Name = "rbtExpress";
            this.rbtExpress.Size = new System.Drawing.Size(141, 24);
            this.rbtExpress.TabIndex = 3;
            this.rbtExpress.Text = "Express Ticket";
            this.rbtExpress.UseVisualStyleBackColor = true;
            this.rbtExpress.CheckedChanged += new System.EventHandler(this.rbtExpress_CheckedChanged);
            // 
            // rbtEntrance
            // 
            this.rbtEntrance.AutoSize = true;
            this.rbtEntrance.Checked = true;
            this.rbtEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEntrance.Location = new System.Drawing.Point(22, 51);
            this.rbtEntrance.Name = "rbtEntrance";
            this.rbtEntrance.Size = new System.Drawing.Size(158, 24);
            this.rbtEntrance.TabIndex = 2;
            this.rbtEntrance.TabStop = true;
            this.rbtEntrance.Text = "Admission Ticket";
            this.rbtEntrance.UseVisualStyleBackColor = true;
            this.rbtEntrance.CheckedChanged += new System.EventHandler(this.rbtEntrance_CheckedChanged);
            // 
            // rbtRide
            // 
            this.rbtRide.AutoSize = true;
            this.rbtRide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRide.Location = new System.Drawing.Point(22, 95);
            this.rbtRide.Name = "rbtRide";
            this.rbtRide.Size = new System.Drawing.Size(208, 24);
            this.rbtRide.TabIndex = 0;
            this.rbtRide.Text = "Ride-All-You Can Ticket";
            this.rbtRide.UseVisualStyleBackColor = true;
            this.rbtRide.CheckedChanged += new System.EventHandler(this.rbtRide_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.numDragon);
            this.groupBox2.Controls.Add(this.numLazer);
            this.groupBox2.Controls.Add(this.numScream);
            this.groupBox2.Controls.Add(this.numWinter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxDragon);
            this.groupBox2.Controls.Add(this.checkBoxScream);
            this.groupBox2.Controls.Add(this.checkBoxLazer);
            this.groupBox2.Controls.Add(this.checkBoxWinter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(362, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 243);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADD-ONS";
            // 
            // numDragon
            // 
            this.numDragon.Enabled = false;
            this.numDragon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDragon.Location = new System.Drawing.Point(271, 189);
            this.numDragon.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numDragon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDragon.Name = "numDragon";
            this.numDragon.Size = new System.Drawing.Size(120, 27);
            this.numDragon.TabIndex = 13;
            this.numDragon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLazer
            // 
            this.numLazer.Enabled = false;
            this.numLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLazer.Location = new System.Drawing.Point(271, 112);
            this.numLazer.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numLazer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLazer.Name = "numLazer";
            this.numLazer.Size = new System.Drawing.Size(120, 27);
            this.numLazer.TabIndex = 12;
            this.numLazer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numScream
            // 
            this.numScream.Enabled = false;
            this.numScream.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numScream.Location = new System.Drawing.Point(271, 153);
            this.numScream.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numScream.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScream.Name = "numScream";
            this.numScream.Size = new System.Drawing.Size(120, 27);
            this.numScream.TabIndex = 12;
            this.numScream.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWinter
            // 
            this.numWinter.Enabled = false;
            this.numWinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWinter.Location = new System.Drawing.Point(271, 71);
            this.numWinter.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numWinter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWinter.Name = "numWinter";
            this.numWinter.Size = new System.Drawing.Size(120, 27);
            this.numWinter.TabIndex = 7;
            this.numWinter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ride";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(285, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity";
            // 
            // checkBoxDragon
            // 
            this.checkBoxDragon.AutoSize = true;
            this.checkBoxDragon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDragon.Location = new System.Drawing.Point(45, 190);
            this.checkBoxDragon.Name = "checkBoxDragon";
            this.checkBoxDragon.Size = new System.Drawing.Size(180, 24);
            this.checkBoxDragon.TabIndex = 3;
            this.checkBoxDragon.Text = "Heart of the Dragon";
            this.checkBoxDragon.UseVisualStyleBackColor = true;
            this.checkBoxDragon.CheckedChanged += new System.EventHandler(this.checkBoxDragon_CheckedChanged);
            // 
            // checkBoxScream
            // 
            this.checkBoxScream.AutoSize = true;
            this.checkBoxScream.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxScream.Location = new System.Drawing.Point(44, 154);
            this.checkBoxScream.Name = "checkBoxScream";
            this.checkBoxScream.Size = new System.Drawing.Size(128, 24);
            this.checkBoxScream.TabIndex = 2;
            this.checkBoxScream.Text = "Scream Park";
            this.checkBoxScream.UseVisualStyleBackColor = true;
            this.checkBoxScream.CheckedChanged += new System.EventHandler(this.checkBoxScream_CheckedChanged);
            // 
            // checkBoxLazer
            // 
            this.checkBoxLazer.AutoSize = true;
            this.checkBoxLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLazer.Location = new System.Drawing.Point(45, 113);
            this.checkBoxLazer.Name = "checkBoxLazer";
            this.checkBoxLazer.Size = new System.Drawing.Size(133, 24);
            this.checkBoxLazer.TabIndex = 1;
            this.checkBoxLazer.Text = "Lazer Blazter";
            this.checkBoxLazer.UseVisualStyleBackColor = true;
            this.checkBoxLazer.CheckedChanged += new System.EventHandler(this.checkBoxLazer_CheckedChanged);
            // 
            // checkBoxWinter
            // 
            this.checkBoxWinter.AutoSize = true;
            this.checkBoxWinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWinter.Location = new System.Drawing.Point(44, 72);
            this.checkBoxWinter.Name = "checkBoxWinter";
            this.checkBoxWinter.Size = new System.Drawing.Size(180, 24);
            this.checkBoxWinter.TabIndex = 0;
            this.checkBoxWinter.Text = "Winter WonderLand";
            this.checkBoxWinter.UseVisualStyleBackColor = true;
            this.checkBoxWinter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbdNormal);
            this.groupBox4.Controls.Add(this.rbdMember);
            this.groupBox4.Controls.Add(this.rbdSenior);
            this.groupBox4.Controls.Add(this.rbdStudent);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(880, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 243);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DISCOUNT";
            // 
            // rbdNormal
            // 
            this.rbdNormal.AutoSize = true;
            this.rbdNormal.Checked = true;
            this.rbdNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdNormal.Location = new System.Drawing.Point(22, 177);
            this.rbdNormal.Name = "rbdNormal";
            this.rbdNormal.Size = new System.Drawing.Size(123, 24);
            this.rbdNormal.TabIndex = 3;
            this.rbdNormal.TabStop = true;
            this.rbdNormal.Text = "No Discount";
            this.rbdNormal.UseVisualStyleBackColor = true;
            this.rbdNormal.CheckedChanged += new System.EventHandler(this.rbdNormal_CheckedChanged);
            // 
            // rbdMember
            // 
            this.rbdMember.AutoSize = true;
            this.rbdMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdMember.Location = new System.Drawing.Point(22, 136);
            this.rbdMember.Name = "rbdMember";
            this.rbdMember.Size = new System.Drawing.Size(161, 24);
            this.rbdMember.TabIndex = 2;
            this.rbdMember.Text = "Club Membership";
            this.rbdMember.UseVisualStyleBackColor = true;
            this.rbdMember.CheckedChanged += new System.EventHandler(this.rbdMember_CheckedChanged);
            // 
            // rbdSenior
            // 
            this.rbdSenior.AutoSize = true;
            this.rbdSenior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdSenior.Location = new System.Drawing.Point(22, 95);
            this.rbdSenior.Name = "rbdSenior";
            this.rbdSenior.Size = new System.Drawing.Size(135, 24);
            this.rbdSenior.TabIndex = 1;
            this.rbdSenior.Text = "Senior Citizen";
            this.rbdSenior.UseVisualStyleBackColor = true;
            this.rbdSenior.CheckedChanged += new System.EventHandler(this.rbdSenior_CheckedChanged);
            // 
            // rbdStudent
            // 
            this.rbdStudent.AutoSize = true;
            this.rbdStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdStudent.Location = new System.Drawing.Point(22, 51);
            this.rbdStudent.Name = "rbdStudent";
            this.rbdStudent.Size = new System.Drawing.Size(87, 24);
            this.rbdStudent.TabIndex = 0;
            this.rbdStudent.Text = "Student";
            this.rbdStudent.UseVisualStyleBackColor = true;
            this.rbdStudent.CheckedChanged += new System.EventHandler(this.rbdStudent_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1188, 778);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Ticket Booth";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTicket)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinter)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtRide;
        private System.Windows.Forms.RadioButton rbtEntrance;
        private System.Windows.Forms.RadioButton rbtExpress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxWinter;
        private System.Windows.Forms.CheckBox checkBoxDragon;
        private System.Windows.Forms.CheckBox checkBoxScream;
        private System.Windows.Forms.CheckBox checkBoxLazer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbdMember;
        private System.Windows.Forms.RadioButton rbdSenior;
        private System.Windows.Forms.RadioButton rbdStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numTicket;
        private System.Windows.Forms.NumericUpDown numDragon;
        private System.Windows.Forms.NumericUpDown numLazer;
        private System.Windows.Forms.NumericUpDown numScream;
        private System.Windows.Forms.NumericUpDown numWinter;
        private System.Windows.Forms.RadioButton rbdNormal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}

