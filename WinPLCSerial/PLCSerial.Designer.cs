namespace WinPLCSerial {
    partial class PLCSerial {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            portNameComboBox = new ComboBox();
            label1 = new Label();
            portNameLabel = new Label();
            baudRateLabel = new Label();
            baudRateComboBox = new ComboBox();
            dataBitsLabel = new Label();
            dataBitsComboBox = new ComboBox();
            stopBitsLabel = new Label();
            stopBitsComboBox = new ComboBox();
            parityLabel = new Label();
            parityComboBox = new ComboBox();
            timeoutLabel = new Label();
            timeoutEntry = new TextBox();
            commandLabel = new Label();
            commandEntry = new TextBox();
            outputBox = new TextBox();
            clearButton = new Button();
            openPortButton = new Button();
            closePortButton = new Button();
            SuspendLayout();
            // 
            // portNameComboBox
            // 
            portNameComboBox.FormattingEnabled = true;
            portNameComboBox.Items.AddRange(new object[] { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6" });
            portNameComboBox.Location = new Point(115, 20);
            portNameComboBox.Name = "portNameComboBox";
            portNameComboBox.Size = new Size(151, 28);
            portNameComboBox.TabIndex = 0;
            portNameComboBox.SelectedIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // portNameLabel
            // 
            portNameLabel.AutoSize = true;
            portNameLabel.Location = new Point(18, 23);
            portNameLabel.Name = "portNameLabel";
            portNameLabel.Size = new Size(82, 20);
            portNameLabel.TabIndex = 1;
            portNameLabel.Text = "Port Name:";
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new Point(318, 23);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new Size(80, 20);
            baudRateLabel.TabIndex = 2;
            baudRateLabel.Text = "Baud Rate:";
            // 
            // baudRateComboBox
            // 
            baudRateComboBox.FormattingEnabled = true;
            baudRateComboBox.Items.AddRange(new object[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            baudRateComboBox.Location = new Point(423, 15);
            baudRateComboBox.Name = "baudRateComboBox";
            baudRateComboBox.Size = new Size(151, 28);
            baudRateComboBox.TabIndex = 3;
            baudRateComboBox.SelectedIndex = 5;
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.AutoSize = true;
            dataBitsLabel.Location = new Point(18, 78);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new Size(72, 20);
            dataBitsLabel.TabIndex = 4;
            dataBitsLabel.Text = "Data Bits:";
            // 
            // dataBitsComboBox
            // 
            dataBitsComboBox.FormattingEnabled = true;
            dataBitsComboBox.Items.AddRange(new object[] { "7", "8" });
            dataBitsComboBox.Location = new Point(115, 75);
            dataBitsComboBox.Name = "dataBitsComboBox";
            dataBitsComboBox.Size = new Size(151, 28);
            dataBitsComboBox.TabIndex = 5;
            dataBitsComboBox.SelectedIndex = 1;
            // 
            // stopBitsLabel
            // 
            stopBitsLabel.AutoSize = true;
            stopBitsLabel.Location = new Point(318, 78);
            stopBitsLabel.Name = "stopBitsLabel";
            stopBitsLabel.Size = new Size(71, 20);
            stopBitsLabel.TabIndex = 6;
            stopBitsLabel.Text = "Stop Bits:";
            // 
            // stopBitsComboBox
            // 
            stopBitsComboBox.FormattingEnabled = true;
            stopBitsComboBox.Items.AddRange(new object[] { "1", "2" });
            stopBitsComboBox.Location = new Point(423, 70);
            stopBitsComboBox.Name = "stopBitsComboBox";
            stopBitsComboBox.Size = new Size(151, 28);
            stopBitsComboBox.TabIndex = 7;
            stopBitsComboBox.SelectedIndex = 0;
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Location = new Point(18, 133);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new Size(48, 20);
            parityLabel.TabIndex = 8;
            parityLabel.Text = "Parity:";
            // 
            // parityComboBox
            // 
            parityComboBox.FormattingEnabled = true;
            parityComboBox.Items.AddRange(new object[] { "None", "Even", "Odd" });
            parityComboBox.Location = new Point(115, 130);
            parityComboBox.Name = "parityComboBox";
            parityComboBox.Size = new Size(151, 28);
            parityComboBox.TabIndex = 9;
            parityComboBox.SelectedIndex = 0;
            // 
            // timeoutLabel
            // 
            timeoutLabel.AutoSize = true;
            timeoutLabel.Location = new Point(318, 130);
            timeoutLabel.Name = "timeoutLabel";
            timeoutLabel.Size = new Size(100, 20);
            timeoutLabel.TabIndex = 10;
            timeoutLabel.Text = "Timeout (ms):";
            // 
            // timeoutEntry
            // 
            timeoutEntry.Location = new Point(423, 126);
            timeoutEntry.Name = "timeoutEntry";
            timeoutEntry.Size = new Size(125, 27);
            timeoutEntry.TabIndex = 11;
            timeoutEntry.Text = "500";
            // 
            // commandLabel
            // 
            commandLabel.AutoSize = true;
            commandLabel.Location = new Point(18, 218);
            commandLabel.Name = "commandLabel";
            commandLabel.Size = new Size(261, 20);
            commandLabel.TabIndex = 12;
            commandLabel.Text = "Command String (Press Enter to Send)";
            // 
            // commandEntry
            // 
            commandEntry.Location = new Point(18, 252);
            commandEntry.Name = "commandEntry";
            commandEntry.Size = new Size(556, 27);
            commandEntry.TabIndex = 13;
            commandEntry.KeyDown += new KeyEventHandler(commandEntry_KeyDown);
            // 
            // outputBox
            // 
            outputBox.Location = new Point(18, 296);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(556, 325);
            outputBox.TabIndex = 14;
            outputBox.ReadOnly = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(480, 640);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 15;
            clearButton.Text = "Clear Output";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += new EventHandler(clearButton_click);
            // 
            // openPortButton
            // 
            openPortButton.Location = new Point(172, 175);
            openPortButton.Name = "openPortButton";
            openPortButton.Size = new Size(94, 29);
            openPortButton.TabIndex = 16;
            openPortButton.Text = "Open Port";
            openPortButton.UseVisualStyleBackColor = true;
            openPortButton.Click += new EventHandler(openPortButton_click);
            // 
            // closePortButton
            // 
            closePortButton.Location = new Point(318, 175);
            closePortButton.Name = "closePortButton";
            closePortButton.Size = new Size(94, 29);
            closePortButton.TabIndex = 17;
            closePortButton.Text = "Close Port";
            closePortButton.UseVisualStyleBackColor = true;
            closePortButton.Click += new EventHandler(closePortButton_click);
            closePortButton.Enabled = false;
            // 
            // PLCSerial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 681);
            Controls.Add(closePortButton);
            Controls.Add(openPortButton);
            Controls.Add(clearButton);
            Controls.Add(outputBox);
            Controls.Add(commandEntry);
            Controls.Add(commandLabel);
            Controls.Add(timeoutEntry);
            Controls.Add(timeoutLabel);
            Controls.Add(parityComboBox);
            Controls.Add(parityLabel);
            Controls.Add(stopBitsComboBox);
            Controls.Add(stopBitsLabel);
            Controls.Add(dataBitsComboBox);
            Controls.Add(dataBitsLabel);
            Controls.Add(baudRateComboBox);
            Controls.Add(baudRateLabel);
            Controls.Add(portNameLabel);
            Controls.Add(label1);
            Controls.Add(portNameComboBox);
            Name = "PLCSerial";
            Text = "PLCSerial";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox portNameComboBox;
        private Label label1;
        private Label portNameLabel;
        private Label baudRateLabel;
        private ComboBox baudRateComboBox;
        private Label dataBitsLabel;
        private ComboBox dataBitsComboBox;
        private Label stopBitsLabel;
        private ComboBox stopBitsComboBox;
        private Label parityLabel;
        private ComboBox parityComboBox;
        private Label timeoutLabel;
        private TextBox timeoutEntry;
        private Label commandLabel;
        private TextBox commandEntry;
        private TextBox outputBox;
        private Button clearButton;
        private Button openPortButton;
        private Button closePortButton;
    }
}
