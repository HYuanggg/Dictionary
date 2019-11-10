using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Vocabulary
{
    public partial class Form1 : Form
    {
        ArrayList al = new ArrayList();
        Word word=new Word("请先选择单词","请先选择单词");
        public Form1()
        {            
            InitializeComponent();            
        }        
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lvWords.BeginUpdate();
            string En = tbNewEnglish.Text;
            string CN = tbNewChinese.Text;
            if (En == "" || CN == "")
            {
                MessageBox.Show("请将中英文填写完整!");
                return;
            }
            Word word = new Word(En, CN);            
            for(int i=0;i<5;i++)
                al.Add(word);            
            ListViewItem lvi = new ListViewItem();            
            lvi.SubItems[0].Text =tbNewEnglish.Text;
            lvi.SubItems.Add( tbNewChinese.Text );
            lvWords.Items.Add(lvi);
            tbNewEnglish.Clear();
            tbNewChinese.Clear();
            lvWords.EndUpdate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {            
            Random rand = new Random();
            int cnt = al.Count;
            if (cnt == 0)
            {
                MessageBox.Show("单词库中没有单词!");
                return;
            }
            int index = rand.Next(0, cnt);
            word =al[index] as Word;
            tbChinese.Clear();
            tbEnglish.Text = word.En;
        }

        private void btnChinese_Click(object sender, EventArgs e)
        {
            tbChinese.Text = word.CN;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (al.Contains(word))
                al.Remove(word);
            tbEnglish.Clear();
            tbChinese.Clear(); 
        }

        private void btnFewer_Click(object sender, EventArgs e)
        {
            if(tbEnglish.Text!="")
                al.Remove(word);
            else
                MessageBox.Show("请先选择单词!");
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (tbEnglish.Text != "")
                al.Add(word);
            else
                MessageBox.Show("请先选择单词!");
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            char[] del =new char[]{'\t'};
            StreamReader sr = new StreamReader("words.txt");
            try
            {
                string line = sr.ReadLine();
                while (sr.Peek() > 0)
                {
                    line = sr.ReadLine();
                    string[] data = line.Split(del);
                    Word word = new Word(data[0], data[1]);                    
                    al.Add(word);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw=File.CreateText("words.txt"))
            {
                sw.Write("英文" + '\t' + "中文");
                sw.WriteLine();
                for(int i=0;i<al.Count;i++)
                {
                    Word word=al[i] as Word;
                    sw.Write(word.En+"\t"+word.CN);
                    sw.WriteLine();
                }
                sw.Close();
            }
        }

        private void tbNewChinese_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNew.PerformClick();
                tbNewEnglish.Focus();
            }
        }

        private void btnShowWords_Click(object sender, EventArgs e)
        {
            ArrayList al2=new ArrayList();            
            lvWords.BeginUpdate();
            lvWords.Items.Clear();
            for (int i = 0; i < al.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                Word word = al[i] as Word;
                if (!al2.Contains(word))
                {
                    al2.Add(word);
                    lvi.SubItems[0].Text = word.En;
                    lvi.SubItems.Add(word.CN);
                    lvWords.Items.Add(lvi);
                }
            }
            lvWords.EndUpdate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnWriteFile.PerformClick();
            this.Close();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lvWords.BeginUpdate();
            lvWords.Items.Clear();
            lvWords.EndUpdate();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btnReadFile_Click(null, null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbNewEnglish.Text == "")
            {
                MessageBox.Show("请输入要删除的英文单词");
                return;
            }
            Word word = new Word(tbNewEnglish.Text, tbNewChinese.Text);
            while(al.Contains(word))
                al.Remove(word);
        }
       
    }
}
