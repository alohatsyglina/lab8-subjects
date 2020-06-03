namespace lab8
{
    partial class searchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.teacherNameRadio = new System.Windows.Forms.RadioButton();
            this.teacherNameSearch = new System.Windows.Forms.TextBox();
            this.subCodeRadio = new System.Windows.Forms.RadioButton();
            this.subCodeSearch = new System.Windows.Forms.TextBox();
            this.finalPaperRadio = new System.Windows.Forms.RadioButton();
            this.finalPaperSearch = new System.Windows.Forms.ListBox();
            this.controlRadio = new System.Windows.Forms.RadioButton();
            this.controlSearch = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.teacherNameRadio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.teacherNameSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.subCodeRadio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.subCodeSearch, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.finalPaperRadio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.finalPaperSearch, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.controlRadio, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.controlSearch, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.searchBtn, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // teacherNameRadio
            // 
            this.teacherNameRadio.AutoSize = true;
            this.teacherNameRadio.Location = new System.Drawing.Point(3, 3);
            this.teacherNameRadio.Name = "teacherNameRadio";
            this.teacherNameRadio.Size = new System.Drawing.Size(154, 17);
            this.teacherNameRadio.TabIndex = 0;
            this.teacherNameRadio.TabStop = true;
            this.teacherNameRadio.Text = "Фамилия преподавателя";
            this.teacherNameRadio.UseVisualStyleBackColor = true;
            // 
            // teacherNameSearch
            // 
            this.teacherNameSearch.Location = new System.Drawing.Point(184, 3);
            this.teacherNameSearch.Name = "teacherNameSearch";
            this.teacherNameSearch.Size = new System.Drawing.Size(176, 20);
            this.teacherNameSearch.TabIndex = 1;
            // 
            // subCodeRadio
            // 
            this.subCodeRadio.AutoSize = true;
            this.subCodeRadio.Location = new System.Drawing.Point(3, 29);
            this.subCodeRadio.Name = "subCodeRadio";
            this.subCodeRadio.Size = new System.Drawing.Size(109, 17);
            this.subCodeRadio.TabIndex = 2;
            this.subCodeRadio.TabStop = true;
            this.subCodeRadio.Text = "Код дисциплины";
            this.subCodeRadio.UseVisualStyleBackColor = true;
            // 
            // subCodeSearch
            // 
            this.subCodeSearch.Location = new System.Drawing.Point(184, 29);
            this.subCodeSearch.Name = "subCodeSearch";
            this.subCodeSearch.Size = new System.Drawing.Size(176, 20);
            this.subCodeSearch.TabIndex = 3;
            // 
            // finalPaperRadio
            // 
            this.finalPaperRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.finalPaperRadio.AutoSize = true;
            this.finalPaperRadio.Location = new System.Drawing.Point(3, 57);
            this.finalPaperRadio.Name = "finalPaperRadio";
            this.finalPaperRadio.Size = new System.Drawing.Size(158, 31);
            this.finalPaperRadio.TabIndex = 4;
            this.finalPaperRadio.TabStop = true;
            this.finalPaperRadio.Text = "Наличие курсовой работы";
            this.finalPaperRadio.UseVisualStyleBackColor = true;
            // 
            // finalPaperSearch
            // 
            this.finalPaperSearch.FormattingEnabled = true;
            this.finalPaperSearch.Items.AddRange(new object[] {
            "Есть",
            "Нет"});
            this.finalPaperSearch.Location = new System.Drawing.Point(184, 57);
            this.finalPaperSearch.Name = "finalPaperSearch";
            this.finalPaperSearch.Size = new System.Drawing.Size(176, 30);
            this.finalPaperSearch.TabIndex = 5;
            // 
            // controlRadio
            // 
            this.controlRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controlRadio.AutoSize = true;
            this.controlRadio.Location = new System.Drawing.Point(3, 94);
            this.controlRadio.Name = "controlRadio";
            this.controlRadio.Size = new System.Drawing.Size(150, 32);
            this.controlRadio.TabIndex = 6;
            this.controlRadio.TabStop = true;
            this.controlRadio.Text = "Вид итогового контролы";
            this.controlRadio.UseVisualStyleBackColor = true;
            // 
            // controlSearch
            // 
            this.controlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.controlSearch.FormattingEnabled = true;
            this.controlSearch.Items.AddRange(new object[] {
            "Зачет",
            "Экзамен"});
            this.controlSearch.Location = new System.Drawing.Point(184, 94);
            this.controlSearch.Name = "controlSearch";
            this.controlSearch.Size = new System.Drawing.Size(176, 30);
            this.controlSearch.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(285, 132);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 27);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "searchForm";
            this.Text = "Поиск";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton teacherNameRadio;
        private System.Windows.Forms.TextBox teacherNameSearch;
        private System.Windows.Forms.RadioButton subCodeRadio;
        private System.Windows.Forms.TextBox subCodeSearch;
        private System.Windows.Forms.RadioButton finalPaperRadio;
        private System.Windows.Forms.ListBox finalPaperSearch;
        private System.Windows.Forms.RadioButton controlRadio;
        private System.Windows.Forms.ListBox controlSearch;
        private System.Windows.Forms.Button searchBtn;
    }
}