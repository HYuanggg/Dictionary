namespace Vocabulary
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChinese = new System.Windows.Forms.TextBox();
            this.tbEnglish = new System.Windows.Forms.TextBox();
            this.btnFewer = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChinese = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewChinese = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.tbNewEnglish = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.lvWords = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnShowWords = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkGray;
            this.btnNext.Location = new System.Drawing.Point(42, 164);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 36);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "下一个";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "英文";
            // 
            // tbChinese
            // 
            this.tbChinese.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbChinese.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChinese.Enabled = false;
            this.tbChinese.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbChinese.Location = new System.Drawing.Point(73, 74);
            this.tbChinese.Name = "tbChinese";
            this.tbChinese.Size = new System.Drawing.Size(461, 47);
            this.tbChinese.TabIndex = 10;
            this.tbChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEnglish
            // 
            this.tbEnglish.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEnglish.Enabled = false;
            this.tbEnglish.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEnglish.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbEnglish.Location = new System.Drawing.Point(74, 18);
            this.tbEnglish.Name = "tbEnglish";
            this.tbEnglish.Size = new System.Drawing.Size(460, 47);
            this.tbEnglish.TabIndex = 9;
            this.tbEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFewer
            // 
            this.btnFewer.BackColor = System.Drawing.Color.DarkGray;
            this.btnFewer.Location = new System.Drawing.Point(148, 206);
            this.btnFewer.Name = "btnFewer";
            this.btnFewer.Size = new System.Drawing.Size(75, 36);
            this.btnFewer.TabIndex = 8;
            this.btnFewer.Text = "减少频率";
            this.btnFewer.UseVisualStyleBackColor = false;
            this.btnFewer.Click += new System.EventHandler(this.btnFewer_Click);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.DarkGray;
            this.btnMore.Location = new System.Drawing.Point(148, 164);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(75, 36);
            this.btnMore.TabIndex = 7;
            this.btnMore.Text = "增加频率";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.Location = new System.Drawing.Point(42, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChinese
            // 
            this.btnChinese.BackColor = System.Drawing.Color.DarkGray;
            this.btnChinese.Location = new System.Drawing.Point(42, 206);
            this.btnChinese.Name = "btnChinese";
            this.btnChinese.Size = new System.Drawing.Size(75, 36);
            this.btnChinese.TabIndex = 5;
            this.btnChinese.Text = "显示中文";
            this.btnChinese.UseVisualStyleBackColor = false;
            this.btnChinese.Click += new System.EventHandler(this.btnChinese_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "中文";
            // 
            // tbNewChinese
            // 
            this.tbNewChinese.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNewChinese.Location = new System.Drawing.Point(55, 72);
            this.tbNewChinese.Name = "tbNewChinese";
            this.tbNewChinese.Size = new System.Drawing.Size(373, 34);
            this.tbNewChinese.TabIndex = 4;
            this.tbNewChinese.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNewChinese_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "中文";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(443, 32);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 36);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "添加";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // tbNewEnglish
            // 
            this.tbNewEnglish.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNewEnglish.Location = new System.Drawing.Point(55, 32);
            this.tbNewEnglish.Name = "tbNewEnglish";
            this.tbNewEnglish.Size = new System.Drawing.Size(373, 34);
            this.tbNewEnglish.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "英文";
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(400, 482);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFile.TabIndex = 9;
            this.btnWriteFile.Text = "写入文件";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Visible = false;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(319, 482);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFile.TabIndex = 10;
            this.btnReadFile.Text = "读取文件";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Visible = false;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // lvWords
            // 
            this.lvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvWords.FullRowSelect = true;
            this.lvWords.GridLines = true;
            this.lvWords.Location = new System.Drawing.Point(6, 148);
            this.lvWords.Name = "lvWords";
            this.lvWords.Size = new System.Drawing.Size(327, 279);
            this.lvWords.TabIndex = 11;
            this.lvWords.UseCompatibleStateImageBehavior = false;
            this.lvWords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "英文";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "中文";
            this.columnHeader2.Width = 203;
            // 
            // btnShowWords
            // 
            this.btnShowWords.Location = new System.Drawing.Point(6, 119);
            this.btnShowWords.Name = "btnShowWords";
            this.btnShowWords.Size = new System.Drawing.Size(75, 23);
            this.btnShowWords.TabIndex = 12;
            this.btnShowWords.Text = "显示单词表";
            this.btnShowWords.UseVisualStyleBackColor = true;
            this.btnShowWords.Click += new System.EventHandler(this.btnShowWords_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(87, 119);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 14;
            this.btnClearList.Text = "清空单词表";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 464);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.tbChinese);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.tbEnglish);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnFewer);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnMore);
            this.tabPage1.Controls.Add(this.btnChinese);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "背单词";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.tbNewChinese);
            this.tabPage2.Controls.Add(this.lvWords);
            this.tabPage2.Controls.Add(this.btnClearList);
            this.tabPage2.Controls.Add(this.btnAddNew);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnShowWords);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbNewEnglish);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "添/删单词";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(443, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 36);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(481, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭并保存";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(570, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Form1";
            this.Text = "Gigig";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChinese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewChinese;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox tbNewEnglish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFewer;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.ListView lvWords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnShowWords;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.TextBox tbChinese;
        private System.Windows.Forms.TextBox tbEnglish;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
    }
}

