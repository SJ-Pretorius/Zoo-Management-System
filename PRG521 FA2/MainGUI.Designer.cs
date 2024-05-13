namespace PRG521_FA2
{
    partial class MainGUI
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
            groupBox1 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button2 = new Button();
            label4 = new Label();
            button4 = new Button();
            button3 = new Button();
            groupBox4 = new GroupBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Animals";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(19, 28);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(771, 158);
            checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(14, 38);
            button1.Name = "button1";
            button1.Size = new Size(102, 27);
            button1.TabIndex = 1;
            button1.Text = "Add Animal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(7, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 215);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actions";
            // 
            // button7
            // 
            button7.Location = new Point(123, 38);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(96, 27);
            button7.TabIndex = 6;
            button7.Text = "Remove Animal";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(22, 113);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "Feed";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(123, 147);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(96, 27);
            button5.TabIndex = 4;
            button5.Text = "Sleep";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(74, 181);
            button2.Name = "button2";
            button2.Size = new Size(96, 28);
            button2.TabIndex = 0;
            button2.Text = "Eat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 82);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 3;
            label4.Text = "Select Animals on the top:";
            // 
            // button4
            // 
            button4.Location = new Point(22, 146);
            button4.Name = "button4";
            button4.Size = new Size(96, 29);
            button4.TabIndex = 2;
            button4.Text = "Move";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(123, 113);
            button3.Name = "button3";
            button3.Size = new Size(96, 29);
            button3.TabIndex = 1;
            button3.Text = "Make Noise";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBox1);
            groupBox4.Location = new Point(278, 223);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(528, 217);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Output";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 24);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(503, 184);
            listBox1.TabIndex = 1;
            // 
            // MainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainGUI";
            Text = "Zoo Management System";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private GroupBox groupBox4;
        private Button button5;
        private ListBox listBox1;
        private Button button6;
        private Button button7;
    }
}
