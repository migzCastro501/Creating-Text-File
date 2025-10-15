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

namespace Creating_Text_File
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Fill combobox with sample college courses
            cboProgram.Items.AddRange(new string[]
            {
                "BS Computer Science",
                "BS Information Technology",
                "BS Information Systems",
                "BS Software Engineering",
                "BS Data Science",
                "BS Civil Engineering",
                "BS Electrical Engineering",
                "BS Mechanical Engineering",
                "BS Architecture",
                "BS Accountancy",
                "BS Business Administration",
                "BS Marketing Management",
                "BS Psychology",
                "BS Nursing",
                "BS Medical Technology",
                "BS Pharmacy",
                "BS Biology",
                "BS Mathematics",
                "BA Communication",
                "BA Political Science",
                "BA Economics",
                "BA English Language Studies",
                "Bachelor of Elementary Education",
                "Bachelor of Secondary Education"
            });

            // Optional: Select first item by default
            if (cboProgram.Items.Count > 0)
                cboProgram.SelectedIndex = 0;

            cbGender.Items.AddRange(new string[]
            {
                "Male",
                "Female"
            });

            if (cbGender.Items.Count > 0)
                cbGender.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleInitial = txtMiddleName.Text;
            string program = cboProgram.Text;
            string gender = cbGender.Text;
            string age = txtAge.Text;
            string birthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            string contactNo = txtContactNo.Text;


            string fullName = $"{lastName}, {firstName}, {middleInitial}.";

            string[] lines = {
            $"Student No.: {studentNo}",
            $"Full Name: {fullName}",
            $"Program: {program}",
            $"Gender: {gender}",
            $"Age: {age}",
            $"Birthday: {birthday}",
            $"Contact No.: {contactNo}"
};
            try
            { 

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = Path.Combine(docPath, FrmFileName.SetFileName);

                using (StreamWriter write = new StreamWriter(filePath, true))
                {
                    write.WriteLine(" Registration Info ");
                }
                        MessageBox.Show("Registration info saved successfully!\n" + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message,
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
