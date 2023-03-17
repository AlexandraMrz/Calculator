namespace Calculator
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
            btnCE = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            btnC = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            btnBackspace = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            btnEquals = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            textDisplay = new TextBox();
            DisplayHistory = new RichTextBox();
            btnClearHistory = new Button();
            label2 = new Label();
            lbHistoryDisplay = new Label();
            label4 = new Label();
            results = new Label();
            SuspendLayout();
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.ActiveBorder;
            btnCE.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCE.Location = new Point(57, 123);
            btnCE.Margin = new Padding(3, 4, 3, 4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(70, 81);
            btnCE.TabIndex = 0;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(57, 199);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(70, 81);
            button2.TabIndex = 1;
            button2.Text = "7";
            button2.UseVisualStyleBackColor = false;
            button2.Click += numbers_Only;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(57, 274);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(70, 81);
            button3.TabIndex = 2;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = false;
            button3.Click += numbers_Only;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(57, 350);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(70, 81);
            button4.TabIndex = 3;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = false;
            button4.Click += numbers_Only;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveBorder;
            button5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(123, 350);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(70, 81);
            button5.TabIndex = 7;
            button5.Text = "2";
            button5.UseVisualStyleBackColor = false;
            button5.Click += numbers_Only;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveBorder;
            button6.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(123, 274);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(70, 81);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += numbers_Only;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveBorder;
            button7.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(123, 199);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(70, 81);
            button7.TabIndex = 5;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = false;
            button7.Click += numbers_Only;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.ActiveBorder;
            btnC.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.Location = new Point(123, 123);
            btnC.Margin = new Padding(3, 4, 3, 4);
            btnC.Name = "btnC";
            btnC.Size = new Size(70, 81);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveBorder;
            button9.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(187, 350);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(70, 81);
            button9.TabIndex = 11;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = false;
            button9.Click += numbers_Only;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveBorder;
            button10.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(187, 274);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(70, 81);
            button10.TabIndex = 10;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            button10.Click += numbers_Only;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ActiveBorder;
            button11.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(187, 199);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(70, 81);
            button11.TabIndex = 9;
            button11.Text = "9";
            button11.UseVisualStyleBackColor = false;
            button11.Click += numbers_Only;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = SystemColors.ActiveBorder;
            btnBackspace.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackspace.Image = Properties.Resources.clear_symbol;
            btnBackspace.Location = new Point(187, 123);
            btnBackspace.Margin = new Padding(3, 4, 3, 4);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(70, 81);
            btnBackspace.TabIndex = 8;
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ActiveBorder;
            button13.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.Black;
            button13.Image = Properties.Resources.plus_math;
            button13.Location = new Point(249, 350);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(70, 81);
            button13.TabIndex = 15;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += basic_op_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ActiveBorder;
            button14.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Image = Properties.Resources.minus_math1;
            button14.Location = new Point(249, 274);
            button14.Margin = new Padding(3, 4, 3, 4);
            button14.Name = "button14";
            button14.Size = new Size(70, 81);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            button14.Click += basic_op_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ActiveBorder;
            button15.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = Color.Silver;
            button15.Image = Properties.Resources.multiply;
            button15.Location = new Point(249, 199);
            button15.Margin = new Padding(3, 4, 3, 4);
            button15.Name = "button15";
            button15.Size = new Size(70, 81);
            button15.TabIndex = 13;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = false;
            button15.Click += basic_op_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ActiveBorder;
            button16.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button16.ForeColor = Color.Silver;
            button16.Image = Properties.Resources.divide;
            button16.Location = new Point(249, 123);
            button16.Margin = new Padding(3, 4, 3, 4);
            button16.Name = "button16";
            button16.Size = new Size(70, 81);
            button16.TabIndex = 12;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = false;
            button16.Click += basic_op_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.ActiveBorder;
            btnEquals.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.ForeColor = Color.Silver;
            btnEquals.Image = Properties.Resources.equal_sign__1_;
            btnEquals.Location = new Point(249, 422);
            btnEquals.Margin = new Padding(3, 4, 3, 4);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(70, 81);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.ActiveBorder;
            button18.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(187, 422);
            button18.Margin = new Padding(3, 4, 3, 4);
            button18.Name = "button18";
            button18.Size = new Size(70, 81);
            button18.TabIndex = 18;
            button18.Text = ",";
            button18.UseVisualStyleBackColor = false;
            button18.Click += numbers_Only;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.ActiveBorder;
            button19.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(123, 422);
            button19.Margin = new Padding(3, 4, 3, 4);
            button19.Name = "button19";
            button19.Size = new Size(70, 81);
            button19.TabIndex = 17;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = false;
            button19.Click += numbers_Only;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.ActiveBorder;
            button20.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Image = Properties.Resources.plus_minus__1_;
            button20.Location = new Point(57, 422);
            button20.Margin = new Padding(3, 4, 3, 4);
            button20.Name = "button20";
            button20.Size = new Size(70, 81);
            button20.TabIndex = 16;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // textDisplay
            // 
            textDisplay.BackColor = SystemColors.ButtonFace;
            textDisplay.BorderStyle = BorderStyle.None;
            textDisplay.Font = new Font("Microsoft New Tai Lue", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textDisplay.Location = new Point(57, 49);
            textDisplay.Margin = new Padding(3, 4, 3, 4);
            textDisplay.Multiline = true;
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(261, 55);
            textDisplay.TabIndex = 20;
            textDisplay.Text = "0";
            textDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // DisplayHistory
            // 
            DisplayHistory.BackColor = SystemColors.ButtonFace;
            DisplayHistory.BorderStyle = BorderStyle.None;
            DisplayHistory.Location = new Point(419, 107);
            DisplayHistory.Margin = new Padding(3, 4, 3, 4);
            DisplayHistory.Name = "DisplayHistory";
            DisplayHistory.Size = new Size(238, 393);
            DisplayHistory.TabIndex = 21;
            DisplayHistory.Text = "";
            // 
            // btnClearHistory
            // 
            btnClearHistory.BackColor = SystemColors.ButtonFace;
            btnClearHistory.Image = Properties.Resources.trash;
            btnClearHistory.Location = new Point(572, 553);
            btnClearHistory.Margin = new Padding(0);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(74, 61);
            btnClearHistory.TabIndex = 22;
            btnClearHistory.UseVisualStyleBackColor = false;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(400, 9);
            label2.Name = "label2";
            label2.Size = new Size(97, 31);
            label2.TabIndex = 24;
            label2.Text = "History";
            // 
            // lbHistoryDisplay
            // 
            lbHistoryDisplay.AutoSize = true;
            lbHistoryDisplay.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbHistoryDisplay.Location = new Point(400, 504);
            lbHistoryDisplay.Name = "lbHistoryDisplay";
            lbHistoryDisplay.Size = new Size(261, 31);
            lbHistoryDisplay.TabIndex = 25;
            lbHistoryDisplay.Text = "There's no history yet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(547, 9);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 26;
            label4.Text = "Memory";
            // 
            // results
            // 
            results.AutoSize = true;
            results.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            results.Location = new Point(209, 25);
            results.Name = "results";
            results.Size = new Size(0, 35);
            results.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 625);
            Controls.Add(results);
            Controls.Add(label4);
            Controls.Add(lbHistoryDisplay);
            Controls.Add(label2);
            Controls.Add(btnClearHistory);
            Controls.Add(DisplayHistory);
            Controls.Add(textDisplay);
            Controls.Add(btnEquals);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(btnBackspace);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(btnC);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCE);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCE;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button btnC;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btnBackspace;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button btnEquals;
        private Button button18;
        private Button button19;
        private Button button20;
        private TextBox textDisplay;
        private RichTextBox DisplayHistory;
        private Button btnClearHistory;
        private Label label2;
        private Label lbHistoryDisplay;
        private Label label4;
        private Label results;
    }
}