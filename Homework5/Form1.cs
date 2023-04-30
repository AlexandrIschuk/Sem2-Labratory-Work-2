using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Homework5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SingleLinkedList list = new SingleLinkedList();


        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "�� ������������� ������ �����?";
            const string caption = "����� �� ���������";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && list.first == null)
            {
                string input = textBox2.Text;
                string[] strNumbers = input.Split();
                int[] numbers = new int[strNumbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                    if (!int.TryParse(strNumbers[i], out numbers[i]))
                    {
                        MessageBox.Show("������ �����!");
                    }
                        
                        
                else
                    numbers[i] = int.Parse(strNumbers[i]);
                list.AddRangeToEnd(numbers);
                list.ListBoxUPD(list, listBox1);

            }
            else
            {
                MessageBox.Show("������� �������� ��� ���������� ����� ��������� ��� ������ ��� ������!");
            }


        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.Destroy();
            list.ListBoxUPD(list, listBox1);

        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.first != null)
            {
                int N;
                if (!int.TryParse(textBox2.Text, out N))
                {
                    MessageBox.Show("������ �����!");
                }
                else
                {

                    list.AddToBeginning(N);
                    list.ListBoxUPD(list, listBox1);
                }

            }
            else
            {
                MessageBox.Show("������ �� ����������!");
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.first != null)
            {
                int N;
                if (!int.TryParse(textBox2.Text, out N))
                {
                    MessageBox.Show("������ �����!");
                }
                else
                {

                    list.AddToEnd1(N);
                    list.ListBoxUPD(list, listBox1);
                }

            }
            else
            {
                MessageBox.Show("������ �� ����������!");
            }


        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.RemoveFromBeginning();
            list.ListBoxUPD(list, listBox1);
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.RemoveFromEnd();
            list.ListBoxUPD(list, listBox1);
        }

        private void �������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int N;
            if (!int.TryParse(textBox2.Text, out N))
            {
                MessageBox.Show("������ �����!");
            }
            else
            {

                list.RemoveNodeByIndex(N);
                list.ListBoxUPD(list, listBox1);
            }

        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.ShowDialog();
            if(form1.DialogResult == DialogResult.OK)
            {
                list.AddNode(form1._s1, form1._s);
                list.ListBoxUPD(list, listBox1);

            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            if(form4.DialogResult == DialogResult.OK)
            {
                list.RemoveRange(form4._s, form4._s1);
                list.ListBoxUPD(list, listBox1);
            }
        }
    }
}
