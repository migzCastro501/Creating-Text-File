using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_Text_File
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName nameForm = new FrmFileName();
            nameForm.ShowDialog();


            string getInput = txtInput.Text;


            if (string.IsNullOrWhiteSpace(FrmFileName.SetFileName))
            {
                MessageBox.Show("No filename entered. File not created.", "Warning");
                return;
            }


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, FrmFileName.SetFileName);

            try
            {

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(getInput);
                }

                MessageBox.Show($"File successfully created!\n\nPath:\n{filePath}", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing file:\n{ex.Message}", "Error");
            }
        }
    }
}

