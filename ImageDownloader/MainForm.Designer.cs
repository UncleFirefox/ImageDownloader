namespace ImageDownloader
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberStartlabel = new System.Windows.Forms.Label();
            this.numberEndlabel = new System.Windows.Forms.Label();
            this.folderDestinationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneralProgressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.BrowseFilesButton = new System.Windows.Forms.Button();
            this.imageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.Downloadbutton = new System.Windows.Forms.Button();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // numberStartlabel
            // 
            this.numberStartlabel.AutoSize = true;
            this.numberStartlabel.Location = new System.Drawing.Point(48, 10);
            this.numberStartlabel.Name = "numberStartlabel";
            this.numberStartlabel.Size = new System.Drawing.Size(69, 13);
            this.numberStartlabel.TabIndex = 0;
            this.numberStartlabel.Text = "Number Start";
            // 
            // numberEndlabel
            // 
            this.numberEndlabel.AutoSize = true;
            this.numberEndlabel.Location = new System.Drawing.Point(176, 9);
            this.numberEndlabel.Name = "numberEndlabel";
            this.numberEndlabel.Size = new System.Drawing.Size(66, 13);
            this.numberEndlabel.TabIndex = 3;
            this.numberEndlabel.Text = "Number End";
            // 
            // folderDestinationTextBox
            // 
            this.folderDestinationTextBox.Enabled = false;
            this.folderDestinationTextBox.Location = new System.Drawing.Point(15, 78);
            this.folderDestinationTextBox.Name = "folderDestinationTextBox";
            this.folderDestinationTextBox.Size = new System.Drawing.Size(215, 20);
            this.folderDestinationTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destination Folder";
            // 
            // GeneralProgressBar
            // 
            this.GeneralProgressBar.Location = new System.Drawing.Point(15, 131);
            this.GeneralProgressBar.Name = "GeneralProgressBar";
            this.GeneralProgressBar.Size = new System.Drawing.Size(256, 23);
            this.GeneralProgressBar.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(15, 112);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status:";
            // 
            // BrowseFilesButton
            // 
            this.BrowseFilesButton.Location = new System.Drawing.Point(236, 78);
            this.BrowseFilesButton.Name = "BrowseFilesButton";
            this.BrowseFilesButton.Size = new System.Drawing.Size(36, 23);
            this.BrowseFilesButton.TabIndex = 9;
            this.BrowseFilesButton.Text = "...";
            this.BrowseFilesButton.UseVisualStyleBackColor = true;
            this.BrowseFilesButton.Click += new System.EventHandler(this.BrowseFilesButton_Click);
            // 
            // imageFolderBrowser
            // 
            this.imageFolderBrowser.Description = "Select destination path for images";
            // 
            // Downloadbutton
            // 
            this.Downloadbutton.Location = new System.Drawing.Point(105, 178);
            this.Downloadbutton.Name = "Downloadbutton";
            this.Downloadbutton.Size = new System.Drawing.Size(75, 23);
            this.Downloadbutton.TabIndex = 10;
            this.Downloadbutton.Text = "Download";
            this.Downloadbutton.UseVisualStyleBackColor = true;
            this.Downloadbutton.Click += new System.EventHandler(this.Downloadbutton_Click);
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(31, 26);
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownStart.TabIndex = 11;
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(155, 26);
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownEnd.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.Downloadbutton);
            this.Controls.Add(this.BrowseFilesButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.GeneralProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.folderDestinationTextBox);
            this.Controls.Add(this.numberEndlabel);
            this.Controls.Add(this.numberStartlabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeil\'s Image Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberStartlabel;
        private System.Windows.Forms.Label numberEndlabel;
        private System.Windows.Forms.TextBox folderDestinationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar GeneralProgressBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button BrowseFilesButton;
        private System.Windows.Forms.FolderBrowserDialog imageFolderBrowser;
        private System.Windows.Forms.Button Downloadbutton;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
    }
}

