using System;
using System.IO;
using System.Windows.Forms;

namespace ImageFlasherApp
{
    public partial class ImageFlasherForm : Form
    {
        public ImageFlasherForm()
        {
            InitializeComponent();
        }

        private void SelectIsoButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "ISO Files|*.iso",
                Title = "Select ISO file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                isoPathLabel.Text = openFileDialog.FileName;
            }
        }

        private void SelectUsbButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select USB drive"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                usbPathLabel.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void FlashButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(isoPathLabel.Text))
            {
                MessageBox.Show("Please select a valid ISO file.");
                return;
            }

            if (!Directory.Exists(usbPathLabel.Text))
            {
                MessageBox.Show("Please select a valid USB drive.");
                return;
            }

            // Code to flash ISO image to USB drive goes here

            MessageBox.Show("ISO image successfully flashed to USB drive.");
        }

        private TextBox isoPathLabel;

        private void InitializeComponent()
        {
            this.isoPathLabel = new System.Windows.Forms.TextBox();
            this.usbPathLabel = new System.Windows.Forms.TextBox();
            this.SelectIsoButton = new System.Windows.Forms.Button();
            this.SelectUsbButton = new System.Windows.Forms.Button();
            this.FlashButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isoPathLabel
            // 
            this.isoPathLabel.Location = new System.Drawing.Point(13, 202);
            this.isoPathLabel.Name = "isoPathLabel";
            this.isoPathLabel.Size = new System.Drawing.Size(259, 20);
            this.isoPathLabel.TabIndex = 0;
            // 
            // usbPathLabel
            // 
            this.usbPathLabel.Location = new System.Drawing.Point(13, 229);
            this.usbPathLabel.Name = "usbPathLabel";
            this.usbPathLabel.Size = new System.Drawing.Size(259, 20);
            this.usbPathLabel.TabIndex = 1;
            // 
            // SelectIsoButton
            // 
            this.SelectIsoButton.Location = new System.Drawing.Point(13, 173);
            this.SelectIsoButton.Name = "SelectIsoButton";
            this.SelectIsoButton.Size = new System.Drawing.Size(75, 23);
            this.SelectIsoButton.TabIndex = 2;
            this.SelectIsoButton.Text = "Select ISO";
            this.SelectIsoButton.UseVisualStyleBackColor = true;
            // 
            // SelectUsbButton
            // 
            this.SelectUsbButton.Location = new System.Drawing.Point(196, 173);
            this.SelectUsbButton.Name = "SelectUsbButton";
            this.SelectUsbButton.Size = new System.Drawing.Size(75, 23);
            this.SelectUsbButton.TabIndex = 3;
            this.SelectUsbButton.Text = "Select USB";
            this.SelectUsbButton.UseVisualStyleBackColor = true;
            // 
            // FlashButton
            // 
            this.FlashButton.Location = new System.Drawing.Point(105, 173);
            this.FlashButton.Name = "FlashButton";
            this.FlashButton.Size = new System.Drawing.Size(75, 23);
            this.FlashButton.TabIndex = 4;
            this.FlashButton.Text = "Flash!";
            this.FlashButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "PoCISOFlasher!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proof of Concept by p0stbox4life";
            // 
            // ImageFlasherForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlashButton);
            this.Controls.Add(this.SelectUsbButton);
            this.Controls.Add(this.SelectIsoButton);
            this.Controls.Add(this.usbPathLabel);
            this.Controls.Add(this.isoPathLabel);
            this.Name = "ImageFlasherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox usbPathLabel;
        private Button SelectIsoButton;
        private Button SelectUsbButton;
        private Button FlashButton;
        private Label label1;
        private Label label2;
    }
}
