namespace DataBaseMySQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IDLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            SexeLabel = new Label();
            AgeLabel = new Label();
            NameLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            textEmail = new TextBox();
            textSexe = new TextBox();
            textName = new TextBox();
            textID = new TextBox();
            textAge = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textAge).BeginInit();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Dock = DockStyle.Fill;
            IDLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDLabel.Location = new Point(3, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(132, 85);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID :";
            IDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(SexeLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(AgeLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(IDLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(138, 426);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 340);
            label3.Name = "label3";
            label3.Size = new Size(132, 86);
            label3.TabIndex = 4;
            label3.Text = "Email :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SexeLabel
            // 
            SexeLabel.AutoSize = true;
            SexeLabel.Dock = DockStyle.Fill;
            SexeLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SexeLabel.Location = new Point(3, 255);
            SexeLabel.Name = "SexeLabel";
            SexeLabel.Size = new Size(132, 85);
            SexeLabel.TabIndex = 3;
            SexeLabel.Text = "Sexe :";
            SexeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Dock = DockStyle.Fill;
            AgeLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgeLabel.Location = new Point(3, 170);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(132, 85);
            AgeLabel.TabIndex = 2;
            AgeLabel.Text = "Age :";
            AgeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(3, 85);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(132, 85);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name :";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 5);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 100);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 5;
            label1.Text = "Email :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 18);
            label2.TabIndex = 4;
            label2.Text = "Birthday :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(textEmail, 0, 4);
            tableLayoutPanel3.Controls.Add(textSexe, 0, 3);
            tableLayoutPanel3.Controls.Add(textName, 0, 1);
            tableLayoutPanel3.Controls.Add(textID, 0, 0);
            tableLayoutPanel3.Controls.Add(textAge, 0, 2);
            tableLayoutPanel3.Location = new Point(201, 15);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(235, 426);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.None;
            textEmail.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(3, 369);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(229, 27);
            textEmail.TabIndex = 4;
            textEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textSexe
            // 
            textSexe.Anchor = AnchorStyles.None;
            textSexe.CharacterCasing = CharacterCasing.Upper;
            textSexe.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textSexe.Location = new Point(3, 284);
            textSexe.MaxLength = 1;
            textSexe.Name = "textSexe";
            textSexe.Size = new Size(229, 27);
            textSexe.TabIndex = 3;
            textSexe.TextAlign = HorizontalAlignment.Center;
            textSexe.TextChanged += textSexe_TextChanged;
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.None;
            textName.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textName.Location = new Point(3, 114);
            textName.MaxLength = 250;
            textName.Name = "textName";
            textName.Size = new Size(229, 27);
            textName.TabIndex = 1;
            textName.TextAlign = HorizontalAlignment.Center;
            // 
            // textID
            // 
            textID.Anchor = AnchorStyles.None;
            textID.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textID.Location = new Point(3, 29);
            textID.Name = "textID";
            textID.Size = new Size(229, 27);
            textID.TabIndex = 0;
            textID.TextAlign = HorizontalAlignment.Center;
            // 
            // textAge
            // 
            textAge.Anchor = AnchorStyles.None;
            textAge.BorderStyle = BorderStyle.FixedSingle;
            textAge.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textAge.Location = new Point(3, 199);
            textAge.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            textAge.Name = "textAge";
            textAge.Size = new Size(229, 27);
            textAge.TabIndex = 3;
            textAge.TabStop = false;
            textAge.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(559, 36);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(559, 107);
            button2.Name = "button2";
            button2.Size = new Size(124, 35);
            button2.TabIndex = 7;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(559, 178);
            button3.Name = "button3";
            button3.Size = new Size(124, 35);
            button3.TabIndex = 8;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(559, 249);
            button4.Name = "button4";
            button4.Size = new Size(124, 35);
            button4.TabIndex = 9;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(559, 320);
            button5.Name = "button5";
            button5.Size = new Size(124, 35);
            button5.TabIndex = 10;
            button5.Text = "Send Email";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(559, 384);
            button6.Name = "button6";
            button6.Size = new Size(124, 35);
            button6.TabIndex = 11;
            button6.Text = "Export";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label IDLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label SexeLabel;
        private Label AgeLabel;
        private Label NameLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textSexe;
        private TextBox textName;
        private TextBox textID;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private TextBox textEmail;
        private Button button5;
        private Button button6;
        private NumericUpDown textAge;
    }
}
