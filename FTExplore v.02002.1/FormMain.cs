using Myrmec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTypeExplorer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_process_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if ((!string.IsNullOrEmpty(textBox_Path.Text.Trim())) && (File.Exists(textBox_Path.Text.Trim())))
            {
                // create a sniffer instance.
                Sniffer sniffer = new Sniffer();

                // populate with mata data.
                sniffer.Populate(FileTypes.CommonFileTypes);

                //// get file head byte, may be 20 bytes enough.
                //byte[] fileHead = ReadFileHead();

                const int HEADER_SIZE = 20;

                byte[] bytesFile = new byte[HEADER_SIZE];

                using (FileStream fs = File.OpenRead(textBox_Path.Text.Trim()))
                {
                    fs.Read(bytesFile, 0, HEADER_SIZE);
                    fs.Close();
                }

                // start match.
                List<string> results = sniffer.Match(bytesFile);

                foreach (var res in results)
                    listBox1.Items.Add(res);
            }
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                RestoreDirectory = true,

                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_Path.Text = openFileDialog.FileName;
                button_process_Click(this, e);
            }  
        }
    }
}
