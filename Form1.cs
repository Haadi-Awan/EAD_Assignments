using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bcsf20a031_assignment1
{
    public partial class Form1 : Form
    {
        private List<string> subjectList = new List<string>();
        private ArrayList nameList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subject = textBox3.Text;

            if (!string.IsNullOrEmpty(subject))
            {
                if (!subjectList.Contains(subject))
                {
                    subjectList.Add(subject);
                    UpdateLabel();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Subject already present in the list.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a subject.");
            }
        }

        private void UpdateLabel()
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            bool preReq = checkBox1.Checked;

            string fullName = "";
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(lastname))
            {
                fullName = $"{name} {lastname}";
                nameList.Add(fullName);
                UpdateLabel1();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please enter both first name and last name.");
            }

            string labelText = $"Name: {name}\nLastname: {lastname}\nPre-requisite: {preReq}\nSubjects:\n{string.Join("\n", subjectList)}";
            label3.Text = labelText;
        }

        private void UpdateLabel1()
        {
            string labelText = "Names:\n";

            foreach (string fullName in nameList)
            {
                labelText += fullName + "\n";
            }

            label3.Text = labelText;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }

}