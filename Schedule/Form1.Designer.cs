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
            this.plusButton = new MetroFramework.Controls.MetroButton();
            this.memoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.modifyButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(312, 134);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(79, 28);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "추가";
            this.plusButton.UseSelectable = true;
            // 
            // memoTextBox
            // 
            // 
            // 
            // 
            this.memoTextBox.CustomButton.Image = null;
            this.memoTextBox.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.memoTextBox.CustomButton.Name = "";
            this.memoTextBox.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.memoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.memoTextBox.CustomButton.TabIndex = 1;
            this.memoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.memoTextBox.CustomButton.UseSelectable = true;
            this.memoTextBox.CustomButton.Visible = false;
            this.memoTextBox.Lines = new string[0];
            this.memoTextBox.Location = new System.Drawing.Point(312, 69);
            this.memoTextBox.MaxLength = 32767;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.PasswordChar = '\0';
            this.memoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoTextBox.SelectedText = "";
            this.memoTextBox.SelectionLength = 0;
            this.memoTextBox.SelectionStart = 0;
            this.memoTextBox.ShortcutsEnabled = true;
            this.memoTextBox.Size = new System.Drawing.Size(298, 50);
            this.memoTextBox.TabIndex = 3;
            this.memoTextBox.UseSelectable = true;
            this.memoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.memoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 69);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar1.RightToLeftLayout = true;
            this.monthCalendar1.TabIndex = 4;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(422, 134);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(79, 28);
            this.modifyButton.TabIndex = 5;
            this.modifyButton.Text = "수정";
            this.modifyButton.UseSelectable = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(531, 134);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 28);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.schedule,
            this.importance});
            this.dataGridView1.Location = new System.Drawing.Point(35, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 146);
            this.dataGridView1.TabIndex = 7;
            // 
            // date
            // 
            this.date.HeaderText = "날짜";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // schedule
            // 
            this.schedule.HeaderText = "일정";
            this.schedule.MinimumWidth = 6;
            this.schedule.Name = "schedule";
            this.schedule.Width = 125;
            // 
            // importance
            // 
            this.importance.HeaderText = "중요도";
            this.importance.MinimumWidth = 6;
            this.importance.Name = "importance";
            this.importance.Width = 125;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(332, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.plusButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn importance;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

