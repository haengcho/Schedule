namespace Schedule
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plusButton = new MetroFramework.Controls.MetroButton();
            this.memoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.modifyButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.importanceButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.importanceButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.importanceButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.noteTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(273, 130);
            this.plusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(69, 22);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "추가";
            this.plusButton.UseSelectable = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // memoTextBox
            // 
            // 
            // 
            // 
            this.memoTextBox.CustomButton.Image = null;
            this.memoTextBox.CustomButton.Location = new System.Drawing.Point(223, 2);
            this.memoTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoTextBox.CustomButton.Name = "";
            this.memoTextBox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.memoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.memoTextBox.CustomButton.TabIndex = 1;
            this.memoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.memoTextBox.CustomButton.UseSelectable = true;
            this.memoTextBox.CustomButton.Visible = false;
            this.memoTextBox.Lines = new string[0];
            this.memoTextBox.Location = new System.Drawing.Point(273, 78);
            this.memoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoTextBox.MaxLength = 32767;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.PasswordChar = '\0';
            this.memoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoTextBox.SelectedText = "";
            this.memoTextBox.SelectionLength = 0;
            this.memoTextBox.SelectionStart = 0;
            this.memoTextBox.ShortcutsEnabled = true;
            this.memoTextBox.Size = new System.Drawing.Size(261, 40);
            this.memoTextBox.TabIndex = 3;
            this.memoTextBox.UseSelectable = true;
            this.memoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.memoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(25, 55);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar1.RightToLeftLayout = true;
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(369, 130);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(69, 22);
            this.modifyButton.TabIndex = 5;
            this.modifyButton.Text = "수정";
            this.modifyButton.UseSelectable = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(465, 130);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(69, 22);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.importance,
            this.schedule,
            this.category,
            this.note});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(25, 302);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(706, 120);
            this.dataGridView1.TabIndex = 7;
            // 
            // date
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.date.DefaultCellStyle = dataGridViewCellStyle2;
            this.date.FillWeight = 240.6417F;
            this.date.HeaderText = "날짜";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 130;
            // 
            // importance
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.importance.DefaultCellStyle = dataGridViewCellStyle3;
            this.importance.FillWeight = 29.67915F;
            this.importance.HeaderText = "중요도";
            this.importance.MinimumWidth = 6;
            this.importance.Name = "importance";
            this.importance.Width = 70;
            // 
            // schedule
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.schedule.DefaultCellStyle = dataGridViewCellStyle4;
            this.schedule.FillWeight = 29.67915F;
            this.schedule.HeaderText = "일정";
            this.schedule.MinimumWidth = 6;
            this.schedule.Name = "schedule";
            this.schedule.Width = 300;
            // 
            // category
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.category.DefaultCellStyle = dataGridViewCellStyle5;
            this.category.HeaderText = "카테고리";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            // 
            // note
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.note.DefaultCellStyle = dataGridViewCellStyle6;
            this.note.HeaderText = "비고";
            this.note.MinimumWidth = 6;
            this.note.Name = "note";
            this.note.Width = 103;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.importanceButton3);
            this.GroupBox1.Controls.Add(this.importanceButton1);
            this.GroupBox1.Controls.Add(this.importanceButton2);
            this.GroupBox1.Location = new System.Drawing.Point(273, 167);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(56, 73);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "중요도";
            // 
            // importanceButton3
            // 
            this.importanceButton3.AutoSize = true;
            this.importanceButton3.Location = new System.Drawing.Point(10, 55);
            this.importanceButton3.Name = "importanceButton3";
            this.importanceButton3.Size = new System.Drawing.Size(35, 15);
            this.importanceButton3.TabIndex = 15;
            this.importanceButton3.Text = "하";
            this.importanceButton3.UseSelectable = true;
            // 
            // importanceButton1
            // 
            this.importanceButton1.AutoSize = true;
            this.importanceButton1.Location = new System.Drawing.Point(10, 13);
            this.importanceButton1.Name = "importanceButton1";
            this.importanceButton1.Size = new System.Drawing.Size(35, 15);
            this.importanceButton1.TabIndex = 13;
            this.importanceButton1.Text = "상";
            this.importanceButton1.UseSelectable = true;
            // 
            // importanceButton2
            // 
            this.importanceButton2.AutoSize = true;
            this.importanceButton2.Location = new System.Drawing.Point(10, 34);
            this.importanceButton2.Name = "importanceButton2";
            this.importanceButton2.Size = new System.Drawing.Size(35, 15);
            this.importanceButton2.TabIndex = 14;
            this.importanceButton2.Text = "중";
            this.importanceButton2.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "학업",
            "시험",
            "과제",
            "회의",
            "약속",
            "운동",
            "일상",
            "취미/여가",
            "여행",
            "기타"});
            this.metroComboBox1.Location = new System.Drawing.Point(567, 152);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(107, 29);
            this.metroComboBox1.TabIndex = 13;
            this.metroComboBox1.UseSelectable = true;
            // 
            // noteTextBox
            // 
            // 
            // 
            // 
            this.noteTextBox.CustomButton.Image = null;
            this.noteTextBox.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.noteTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noteTextBox.CustomButton.Name = "";
            this.noteTextBox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.noteTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noteTextBox.CustomButton.TabIndex = 1;
            this.noteTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noteTextBox.CustomButton.UseSelectable = true;
            this.noteTextBox.CustomButton.Visible = false;
            this.noteTextBox.Lines = new string[0];
            this.noteTextBox.Location = new System.Drawing.Point(567, 78);
            this.noteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noteTextBox.MaxLength = 32767;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.PasswordChar = '\0';
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noteTextBox.SelectedText = "";
            this.noteTextBox.SelectionLength = 0;
            this.noteTextBox.SelectionStart = 0;
            this.noteTextBox.ShortcutsEnabled = true;
            this.noteTextBox.Size = new System.Drawing.Size(127, 40);
            this.noteTextBox.TabIndex = 14;
            this.noteTextBox.UseSelectable = true;
            this.noteTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.noteTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(268, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "일정";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(562, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "비고";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(563, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "카테고리";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.plusButton);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton plusButton;
        private MetroFramework.Controls.MetroTextBox memoTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Controls.MetroButton modifyButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn importance;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private MetroFramework.Controls.MetroRadioButton importanceButton1;
        private MetroFramework.Controls.MetroRadioButton importanceButton2;
        private MetroFramework.Controls.MetroRadioButton importanceButton3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox noteTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

