namespace Demo20254
{
    partial class SimulatorTest
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Setlabel = new Label();
            GetButton = new Button();
            SendButton = new Button();
            GetLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Setlabel, 1, 1);
            tableLayoutPanel1.Controls.Add(GetButton, 0, 0);
            tableLayoutPanel1.Controls.Add(SendButton, 0, 1);
            tableLayoutPanel1.Controls.Add(GetLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(804, 442);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Setlabel
            // 
            Setlabel.AutoSize = true;
            Setlabel.Dock = DockStyle.Fill;
            Setlabel.Location = new Point(405, 221);
            Setlabel.Name = "Setlabel";
            Setlabel.Size = new Size(396, 221);
            Setlabel.TabIndex = 3;
            Setlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GetButton
            // 
            GetButton.Dock = DockStyle.Fill;
            GetButton.Location = new Point(25, 25);
            GetButton.Margin = new Padding(25);
            GetButton.Name = "GetButton";
            GetButton.Size = new Size(352, 171);
            GetButton.TabIndex = 0;
            GetButton.Text = "Получить данные";
            GetButton.UseVisualStyleBackColor = true;
            GetButton.Click += GetButton_Click;
            // 
            // SendButton
            // 
            SendButton.Dock = DockStyle.Fill;
            SendButton.Location = new Point(25, 246);
            SendButton.Margin = new Padding(25);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(352, 171);
            SendButton.TabIndex = 1;
            SendButton.Text = "Отправить результат теста";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // GetLabel
            // 
            GetLabel.AutoSize = true;
            GetLabel.Dock = DockStyle.Fill;
            GetLabel.Location = new Point(405, 0);
            GetLabel.Name = "GetLabel";
            GetLabel.Size = new Size(396, 221);
            GetLabel.TabIndex = 2;
            GetLabel.TextAlign = ContentAlignment.MiddleCenter;
            GetLabel.Click += GetLabel_Click;
            // 
            // SimulatorTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 442);
            Controls.Add(tableLayoutPanel1);
            Name = "SimulatorTest";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Setlabel;
        private Button GetButton;
        private Button SendButton;
        private Label GetLabel;
    }
}
