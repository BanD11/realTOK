namespace Keyboard_Training
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mistakesText = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timeSelectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.oneMinuteButton = new System.Windows.Forms.Button();
            this.twoMinuteButton = new System.Windows.Forms.Button();
            this.unlimitedTimeButton = new System.Windows.Forms.Button();
            this.customTimeButton = new System.Windows.Forms.Button();
            this.customTimeTextBox = new System.Windows.Forms.TextBox();
            this.numberInputErrorText = new System.Windows.Forms.Label();
            this.selectTextText = new System.Windows.Forms.Label();
            this.timeSelectText = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.resultsText = new System.Windows.Forms.Label();
            this.textSelectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.text1Name = new System.Windows.Forms.Button();
            this.text2Name = new System.Windows.Forms.Button();
            this.text3Name = new System.Windows.Forms.Button();
            this.timeSelectPanel.SuspendLayout();
            this.textSelectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(59, 59);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(666, 443);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // mistakesText
            // 
            this.mistakesText.AutoSize = true;
            this.mistakesText.BackColor = System.Drawing.SystemColors.Window;
            this.mistakesText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mistakesText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mistakesText.Location = new System.Drawing.Point(19, 14);
            this.mistakesText.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.mistakesText.Name = "mistakesText";
            this.mistakesText.Size = new System.Drawing.Size(181, 30);
            this.mistakesText.TabIndex = 1;
            this.mistakesText.Text = "Mistakes made: 0";
            this.mistakesText.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.SystemColors.Window;
            this.timerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(616, 14);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(154, 30);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "Time: 00:00:00";
            this.timerLabel.Visible = false;
            // 
            // timeSelectPanel
            // 
            this.timeSelectPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeSelectPanel.ColumnCount = 4;
            this.timeSelectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeSelectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeSelectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeSelectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeSelectPanel.Controls.Add(this.oneMinuteButton, 0, 0);
            this.timeSelectPanel.Controls.Add(this.twoMinuteButton, 1, 0);
            this.timeSelectPanel.Controls.Add(this.unlimitedTimeButton, 2, 0);
            this.timeSelectPanel.Controls.Add(this.customTimeButton, 3, 0);
            this.timeSelectPanel.Controls.Add(this.customTimeTextBox, 3, 1);
            this.timeSelectPanel.Controls.Add(this.numberInputErrorText, 3, 2);
            this.timeSelectPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeSelectPanel.Location = new System.Drawing.Point(59, 339);
            this.timeSelectPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeSelectPanel.Name = "timeSelectPanel";
            this.timeSelectPanel.RowCount = 3;
            this.timeSelectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.timeSelectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.timeSelectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.7037F));
            this.timeSelectPanel.Size = new System.Drawing.Size(666, 108);
            this.timeSelectPanel.TabIndex = 3;
            // 
            // oneMinuteButton
            // 
            this.oneMinuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneMinuteButton.BackColor = System.Drawing.SystemColors.Window;
            this.oneMinuteButton.FlatAppearance.BorderSize = 0;
            this.oneMinuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneMinuteButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneMinuteButton.Location = new System.Drawing.Point(4, 5);
            this.oneMinuteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oneMinuteButton.Name = "oneMinuteButton";
            this.oneMinuteButton.Size = new System.Drawing.Size(158, 37);
            this.oneMinuteButton.TabIndex = 0;
            this.oneMinuteButton.Text = "One Minute";
            this.oneMinuteButton.UseVisualStyleBackColor = false;
            this.oneMinuteButton.Click += new System.EventHandler(this.oneMinuteButton_Click);
            // 
            // twoMinuteButton
            // 
            this.twoMinuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twoMinuteButton.BackColor = System.Drawing.SystemColors.Window;
            this.twoMinuteButton.FlatAppearance.BorderSize = 0;
            this.twoMinuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoMinuteButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoMinuteButton.Location = new System.Drawing.Point(170, 5);
            this.twoMinuteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.twoMinuteButton.Name = "twoMinuteButton";
            this.twoMinuteButton.Size = new System.Drawing.Size(158, 37);
            this.twoMinuteButton.TabIndex = 1;
            this.twoMinuteButton.Text = "Two Minutes";
            this.twoMinuteButton.UseVisualStyleBackColor = false;
            this.twoMinuteButton.Click += new System.EventHandler(this.twoMinuteButton_Click);
            // 
            // unlimitedTimeButton
            // 
            this.unlimitedTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unlimitedTimeButton.BackColor = System.Drawing.SystemColors.Window;
            this.unlimitedTimeButton.FlatAppearance.BorderSize = 0;
            this.unlimitedTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlimitedTimeButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unlimitedTimeButton.Location = new System.Drawing.Point(336, 5);
            this.unlimitedTimeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unlimitedTimeButton.Name = "unlimitedTimeButton";
            this.unlimitedTimeButton.Size = new System.Drawing.Size(158, 37);
            this.unlimitedTimeButton.TabIndex = 2;
            this.unlimitedTimeButton.Text = "Infinite Time";
            this.unlimitedTimeButton.UseVisualStyleBackColor = false;
            this.unlimitedTimeButton.Click += new System.EventHandler(this.unlimitedTimeButton_Click);
            // 
            // customTimeButton
            // 
            this.customTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTimeButton.BackColor = System.Drawing.SystemColors.Window;
            this.customTimeButton.FlatAppearance.BorderSize = 0;
            this.customTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customTimeButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customTimeButton.Location = new System.Drawing.Point(502, 5);
            this.customTimeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTimeButton.Name = "customTimeButton";
            this.customTimeButton.Size = new System.Drawing.Size(160, 37);
            this.customTimeButton.TabIndex = 3;
            this.customTimeButton.Text = "Custom Time";
            this.customTimeButton.UseVisualStyleBackColor = false;
            this.customTimeButton.Click += new System.EventHandler(this.customTimeButton_Click);
            // 
            // customTimeTextBox
            // 
            this.customTimeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.customTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customTimeTextBox.Location = new System.Drawing.Point(502, 52);
            this.customTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTimeTextBox.Name = "customTimeTextBox";
            this.customTimeTextBox.Size = new System.Drawing.Size(148, 22);
            this.customTimeTextBox.TabIndex = 4;
            this.customTimeTextBox.Visible = false;
            this.customTimeTextBox.TextChanged += new System.EventHandler(this.customTimeTextBox_TextChanged);
            // 
            // numberInputErrorText
            // 
            this.numberInputErrorText.AutoSize = true;
            this.numberInputErrorText.BackColor = System.Drawing.SystemColors.Window;
            this.numberInputErrorText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberInputErrorText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberInputErrorText.Location = new System.Drawing.Point(502, 76);
            this.numberInputErrorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberInputErrorText.Name = "numberInputErrorText";
            this.numberInputErrorText.Size = new System.Drawing.Size(157, 21);
            this.numberInputErrorText.TabIndex = 5;
            this.numberInputErrorText.Text = "Enter correct number";
            this.numberInputErrorText.Visible = false;
            // 
            // selectTextText
            // 
            this.selectTextText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectTextText.AutoSize = true;
            this.selectTextText.BackColor = System.Drawing.SystemColors.Window;
            this.selectTextText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTextText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectTextText.Location = new System.Drawing.Point(201, 33);
            this.selectTextText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectTextText.Name = "selectTextText";
            this.selectTextText.Size = new System.Drawing.Size(382, 30);
            this.selectTextText.TabIndex = 4;
            this.selectTextText.Text = "Select one of text below and press OK";
            // 
            // timeSelectText
            // 
            this.timeSelectText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeSelectText.AutoSize = true;
            this.timeSelectText.BackColor = System.Drawing.SystemColors.Window;
            this.timeSelectText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeSelectText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeSelectText.Location = new System.Drawing.Point(253, 285);
            this.timeSelectText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeSelectText.Name = "timeSelectText";
            this.timeSelectText.Size = new System.Drawing.Size(279, 30);
            this.timeSelectText.TabIndex = 5;
            this.timeSelectText.Text = "Set time to be tested within";
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.BackColor = System.Drawing.SystemColors.Window;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.okButton.Location = new System.Drawing.Point(341, 457);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(103, 36);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.BackColor = System.Drawing.SystemColors.Window;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.stopButton.Location = new System.Drawing.Point(662, 511);
            this.stopButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(103, 36);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackButton.BackColor = System.Drawing.SystemColors.Window;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.goBackButton.Location = new System.Drawing.Point(19, 511);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(103, 36);
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Visible = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // resultsText
            // 
            this.resultsText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resultsText.AutoSize = true;
            this.resultsText.BackColor = System.Drawing.SystemColors.Window;
            this.resultsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultsText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsText.Location = new System.Drawing.Point(145, 519);
            this.resultsText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsText.Name = "resultsText";
            this.resultsText.Size = new System.Drawing.Size(495, 21);
            this.resultsText.TabIndex = 9;
            this.resultsText.Text = "Your typing speed is xxx character per minute, error percentage is xx%.";
            this.resultsText.Visible = false;
            // 
            // textSelectPanel
            // 
            this.textSelectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSelectPanel.ColumnCount = 3;
            this.textSelectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.textSelectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.textSelectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.textSelectPanel.Controls.Add(this.text1Name, 0, 0);
            this.textSelectPanel.Controls.Add(this.text2Name, 1, 0);
            this.textSelectPanel.Controls.Add(this.text3Name, 2, 0);
            this.textSelectPanel.Location = new System.Drawing.Point(79, 101);
            this.textSelectPanel.Margin = new System.Windows.Forms.Padding(70, 3, 70, 3);
            this.textSelectPanel.Name = "textSelectPanel";
            this.textSelectPanel.RowCount = 1;
            this.textSelectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textSelectPanel.Size = new System.Drawing.Size(626, 159);
            this.textSelectPanel.TabIndex = 10;
            // 
            // text1Name
            // 
            this.text1Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text1Name.FlatAppearance.BorderSize = 0;
            this.text1Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text1Name.Location = new System.Drawing.Point(3, 3);
            this.text1Name.Name = "text1Name";
            this.text1Name.Size = new System.Drawing.Size(202, 153);
            this.text1Name.TabIndex = 0;
            this.text1Name.Text = resources.GetString("text1Name.Text");
            this.text1Name.UseVisualStyleBackColor = true;
            this.text1Name.Click += new System.EventHandler(this.text1Name_Click);
            // 
            // text2Name
            // 
            this.text2Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text2Name.FlatAppearance.BorderSize = 0;
            this.text2Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text2Name.Location = new System.Drawing.Point(211, 3);
            this.text2Name.Name = "text2Name";
            this.text2Name.Size = new System.Drawing.Size(202, 153);
            this.text2Name.TabIndex = 1;
            this.text2Name.Text = resources.GetString("text2Name.Text");
            this.text2Name.UseVisualStyleBackColor = true;
            this.text2Name.Click += new System.EventHandler(this.text2Name_Click);
            // 
            // text3Name
            // 
            this.text3Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text3Name.FlatAppearance.BorderSize = 0;
            this.text3Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text3Name.Location = new System.Drawing.Point(419, 3);
            this.text3Name.Name = "text3Name";
            this.text3Name.Size = new System.Drawing.Size(204, 153);
            this.text3Name.TabIndex = 2;
            this.text3Name.Text = resources.GetString("text3Name.Text");
            this.text3Name.UseVisualStyleBackColor = true;
            this.text3Name.Click += new System.EventHandler(this.text3Name_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textSelectPanel);
            this.Controls.Add(this.resultsText);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.timeSelectText);
            this.Controls.Add(this.selectTextText);
            this.Controls.Add(this.timeSelectPanel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.mistakesText);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Keyboard Training";
            this.timeSelectPanel.ResumeLayout(false);
            this.timeSelectPanel.PerformLayout();
            this.textSelectPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label mistakesText;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.TableLayoutPanel timeSelectPanel;
        private System.Windows.Forms.Button oneMinuteButton;
        private System.Windows.Forms.Button twoMinuteButton;
        private System.Windows.Forms.Button unlimitedTimeButton;
        private System.Windows.Forms.Button customTimeButton;
        private System.Windows.Forms.TextBox customTimeTextBox;
        private System.Windows.Forms.Label numberInputErrorText;
        private System.Windows.Forms.Label selectTextText;
        private System.Windows.Forms.Label timeSelectText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label resultsText;
        private System.Windows.Forms.TableLayoutPanel textSelectPanel;
        private System.Windows.Forms.Button text1Name;
        private System.Windows.Forms.Button text2Name;
        private System.Windows.Forms.Button text3Name;
    }
}

