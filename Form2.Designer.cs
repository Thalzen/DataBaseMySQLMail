namespace DataBaseMySQL
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
            textMailcontent = new TextBox();
            textMailobject = new TextBox();
            label1 = new Label();
            propertyGrid1 = new PropertyGrid();
            label2 = new Label();
            textRecipient = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            labeloffon = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textMailcontent
            // 
            textMailcontent.Location = new Point(131, 243);
            textMailcontent.Multiline = true;
            textMailcontent.Name = "textMailcontent";
            textMailcontent.Size = new Size(961, 358);
            textMailcontent.TabIndex = 0;
            // 
            // textMailobject
            // 
            textMailobject.Location = new Point(131, 214);
            textMailobject.Name = "textMailobject";
            textMailobject.Size = new Size(961, 23);
            textMailobject.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 216);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 2;
            label1.Text = "Object :";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(1109, 243);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.SelectedObject = textMailobject;
            propertyGrid1.Size = new Size(130, 358);
            propertyGrid1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Vineta BT", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 37);
            label2.Name = "label2";
            label2.Size = new Size(723, 87);
            label2.TabIndex = 4;
            label2.Text = "Email Sender";
            // 
            // textRecipient
            // 
            textRecipient.Location = new Point(131, 185);
            textRecipient.Name = "textRecipient";
            textRecipient.Size = new Size(961, 23);
            textRecipient.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 185);
            label3.Name = "label3";
            label3.Size = new Size(100, 18);
            label3.TabIndex = 6;
            label3.Text = "Recipient :";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(445, 618);
            button1.Name = "button1";
            button1.Size = new Size(324, 48);
            button1.TabIndex = 7;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 633);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 8;
            label4.Text = "Currently :";
            // 
            // labeloffon
            // 
            labeloffon.AutoSize = true;
            labeloffon.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeloffon.ForeColor = Color.Red;
            labeloffon.Location = new Point(121, 634);
            labeloffon.Name = "labeloffon";
            labeloffon.Size = new Size(66, 18);
            labeloffon.TabIndex = 9;
            labeloffon.Text = "Offline";
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(194, 618);
            button2.Name = "button2";
            button2.Size = new Size(118, 48);
            button2.TabIndex = 10;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button2);
            Controls.Add(labeloffon);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textRecipient);
            Controls.Add(label2);
            Controls.Add(propertyGrid1);
            Controls.Add(label1);
            Controls.Add(textMailobject);
            Controls.Add(textMailcontent);
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textMailcontent;
        private TextBox textMailobject;
        private Label label1;
        private PropertyGrid propertyGrid1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
        public Label labeloffon;
        public TextBox textRecipient;
    }
}