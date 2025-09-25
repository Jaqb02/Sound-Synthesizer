namespace Sound_Synthesizer
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
            btnLoad = new Button();
            cmbDevices = new ComboBox();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.GrayText;
            btnLoad.Location = new Point(12, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(109, 126);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Wgraj Plik";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // cmbDevices
            // 
            cmbDevices.BackColor = SystemColors.ActiveCaption;
            cmbDevices.FormattingEnabled = true;
            cmbDevices.Location = new Point(127, 12);
            cmbDevices.Name = "cmbDevices";
            cmbDevices.Size = new Size(365, 23);
            cmbDevices.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(498, 426);
            Controls.Add(cmbDevices);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoad;
        private ComboBox cmbDevices;
    }
}
