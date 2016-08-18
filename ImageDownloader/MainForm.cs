using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ImageDownloader
{
    public partial class MainForm : Form
    {
        int numbphotos;

        public MainForm()
        {
            InitializeComponent();
            numericUpDownStart.Maximum = decimal.MaxValue;
            numericUpDownEnd.Maximum = decimal.MaxValue;
        }

        #region Delegate

        public delegate void DelegateDownloadImage(int index);
        
        #endregion

        private void BrowseFilesButton_Click(object sender, EventArgs e)
        {
            if (imageFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderDestinationTextBox.Text = imageFolderBrowser.SelectedPath;
            }
        }

        private void Downloadbutton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderDestinationTextBox.Text))
            {
                MessageBox.Show("The path specified does not exist", "Path problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericUpDownStart.Value > numericUpDownEnd.Value)
            {
                MessageBox.Show("Start number sequence is greater than end sequence", "Sequence problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            numbphotos = (int)(numericUpDownEnd.Value - numericUpDownStart.Value);
            
            GeneralProgressBar.Value = 0;
            GeneralProgressBar.Minimum = 0;
            GeneralProgressBar.Maximum = numbphotos+1;
            Downloadbutton.Enabled = false;

            DelegateDownloadImage delImage = new DelegateDownloadImage(DownloadImageDelegated);

            for (int i = (int)numericUpDownStart.Value; i <= (int)numericUpDownEnd.Value; i++)
            {
                delImage.BeginInvoke(i, DownloadImageCallback, null);
            }
        }

        #region Download Image Region

        public void DownloadImageDelegated(int index)
        {
            Image img = DownloadImage(Properties.Settings.Default.ImageBaseURL + index);
            
            if (img != null && !img.Size.IsEmpty)
                //Try to save the image
                img.Save(Path.Combine(folderDestinationTextBox.Text, 
                         Properties.Settings.Default.ImageNameBase+index+Properties.Settings.Default.ImageExtension)
                );
        }

        public delegate void UpdateProgressDelegate();

        public void DownloadImageCallback(IAsyncResult ar)
        {
            //Increment the progressbar
            UpdateProgressDelegate UpdateProgress = new UpdateProgressDelegate(UpdateProgressBar);
            GeneralProgressBar.Invoke(UpdateProgress);
        }

        private void UpdateProgressBar()
        {
            GeneralProgressBar.Value += 1;

            if (GeneralProgressBar.Value == GeneralProgressBar.Maximum)
            {
                Downloadbutton.Enabled = true;
                MessageBox.Show("Process finished succesfully!");
            }
        }

        /// <summary>
        /// Function to download Image from website
        /// </summary>
        /// <param name="_URL">URL address to download image</param>
        /// <returns>Image</returns>
        public Image DownloadImage(string _URL)
        {
            Image _tmpImage = null;

            try
            {
                // Open a connection
                System.Net.HttpWebRequest _HttpWebRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(_URL);

                _HttpWebRequest.AllowWriteStreamBuffering = true;

                // You can also specify additional header values like the user agent or the referer: (Optional)
                _HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                _HttpWebRequest.Referer = "http://www.google.com/";

                // set timeout for 20 seconds (Optional)
                _HttpWebRequest.Timeout = 20000;

                // Request response:
                System.Net.WebResponse _WebResponse = _HttpWebRequest.GetResponse();

                // Open data stream:
                System.IO.Stream _WebStream = _WebResponse.GetResponseStream();

                // convert webstream to image
                _tmpImage = Image.FromStream(_WebStream);

                // Cleanup
                _WebResponse.Close();
                _WebResponse.Close();
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
                return null;
            }

            return _tmpImage;
        }

        #endregion   
    }
}
