using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuyetFileTuXa
{
    public partial class XuliFile : Form
    {
        string tempR;
        public XuliFile(string url)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            FileStream fs = new FileStream(url, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            tempR = content;
            fs.Close();
            this.Text = fs.Name;
            txtLink.Text = url;

            content = content.Replace("\r\n", "\r");
            content = content.Replace('\r', ' ');
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            txtSoTu.Text = source.Count().ToString();
            txtKiTu.Text = richTextBox1.Text.Count().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtLink.Text, FileMode.Create);
            StreamWriter fw = new StreamWriter(fs, Encoding.UTF8); 
            richTextBox1.Text = richTextBox1.Text.ToString();
            fw.WriteLine(richTextBox1.Text.Trim());
            fw.Flush();
            fw.Close();
            MessageBox.Show("Success");
        }

        private void cbAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            cbAutoSave.Enabled = false;
            Thread thread = new Thread(() =>
            {
                FileStream fs = new FileStream(txtLink.Text, FileMode.Create);
                StreamWriter fw = new StreamWriter(fs, Encoding.UTF8);

                fw.WriteLine(richTextBox1.Text.Trim());
                fw.Flush();
                fw.Close();
                for (int i = 30; i >= 0; i--)
                {
                    cbAutoSave.Text = "Auto save in " + i + " s";
                    Thread.Sleep(500);
                }
            });
            thread.Start();
        }

        private void cbAutoSave_CheckStateChanged(object sender, EventArgs e)
        {

        }
        bool isCheckbox1 = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCheckbox1 = !isCheckbox1;
            if (isCheckbox1)
                richTextBox1.Text = richTextBox1.Text.ToUpper();
            else
                richTextBox1.Text = richTextBox1.Text.ToLower();
        }
        bool isCheckbox2 = false;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isCheckbox2 = !isCheckbox2;
            if (isCheckbox2)
                richTextBox1.Text = richTextBox1.Text.ToLower();
            else
                richTextBox1.Text = richTextBox1.Text.ToUpper();
        }
        bool ischeckBox3 = false;
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {       //dinh dang in hoa in thuong chu cai dau dong cuoi dong
            ischeckBox3 = !ischeckBox3;
            if (ischeckBox3 == true)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, 1).ToUpper() + tempR.Substring(1);
                richTextBox1.Text = richTextBox1.Text = richTextBox1.Text.Trim().Replace("\na", "\nA");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nă", "\nĂ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nâ", "\nÂ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nb", "\nB");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nc", "\nC");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nd", "\nD");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nđ", "\nĐ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\ne", "\nE");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nê", "\nÊ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\ng", "\nG");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nh", "\nH");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\ni", "\nI");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nk", "\nK");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nl", "\nL");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nm", "\nM");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nn", "\nN");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\no", "\nO");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nô", "\nÔ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nơ", "\nƠ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\np", "\nP");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nq", "\nQ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nr", "\nR");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\ns", "\nS");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nt", "\nT");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nu", "\nU");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nư", "\nƯ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nv", "\nV");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\nx", "\nX");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("\ny", "\nY");

                //----------------------------------------------------------------

                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". a", ". A");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". ă", ". Ă");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". â", ". Â");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". b", ". B");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". c", ". C");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". d", ". D");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". đ", ". Đ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". e", ". E");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". ê", ". Ê");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". g", ". G");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". h", ". H");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". i", ". I");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". k", ". K");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". l", ". L");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". m", ". M");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". n", ". N");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". o", ". O");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". ô", ". Ô");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". ơ", ". Ơ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". p", ". P");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". q", ". Q");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". r", ". R");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". s", ". S");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". t", ". T");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". u", ". U");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". ư", ". Ư");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". v", ". V");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". x", ". X");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(". y", ". Y");
            }
            else
                richTextBox1.Text = tempR;
        }

        bool isChecBox4 = false;
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            isChecBox4 = !isChecBox4;
            if (isChecBox4 == true)
            {       // dinh dang khoang cach
                richTextBox1.Text = richTextBox1.Text.Trim().Replace(" ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("  ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("   ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("    ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("     ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("      ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("       ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("        ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("         ", " ");
                richTextBox1.Text = richTextBox1.Text.Trim().Replace("          ", " ");
            }
            else
            {
                richTextBox1.Text = tempR;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BoldText(richTextBox1);
        }
        void BoldText(RichTextBox rtb)
        {
            Font newFont = new Font(rtb.SelectionFont.FontFamily.Name, rtb.SelectionFont.Size, FontStyle.Bold);
            rtb.SelectionFont = newFont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItalicText(richTextBox1);
        }
        void ItalicText(RichTextBox rtb)
        {
            Font newFont = new Font(rtb.SelectionFont.FontFamily.Name, rtb.SelectionFont.Size, FontStyle.Italic);
            rtb.SelectionFont = newFont;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NomalText(richTextBox1);
        }
        void NomalText(RichTextBox rtb)
        {
            Font newFont = new Font(rtb.SelectionFont.FontFamily.Name, rtb.SelectionFont.Size, FontStyle.Regular);
            rtb.SelectionFont = newFont;
        }
        void ChangeSize(RichTextBox rtb, int size)
        {
            Font newFont = new Font(rtb.SelectionFont.FontFamily.Name, size, rtb.SelectionFont.Style);
            rtb.SelectionFont = newFont;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ChangeSize(richTextBox1, (int)(numericUpDown1.Value));
        }
        void ChangeColorBlack(RichTextBox rtb)
        {
            rtb.SelectionColor = Color.Black;
        }
        void ChangeColorRed(RichTextBox rtb)
        {
            rtb.SelectionColor = Color.Red;
        }
        void ChangeColorYellow(RichTextBox rtb)
        {
            rtb.SelectionColor = Color.Yellow;
        }
        void ChangeColorBlue(RichTextBox rtb)
        {
            rtb.SelectionColor = Color.Blue;
        }
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColorBlack(richTextBox1);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColorYellow(richTextBox1);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColorRed(richTextBox1);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColorBlue(richTextBox1);
        }
    }
}