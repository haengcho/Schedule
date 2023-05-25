using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Schedule
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private DateTime selectedDate;
        public Form1()
        {
            InitializeComponent();

            

    }

        private void plusButton_Click(object sender, EventArgs e)
        {
            string schedule = memoTextBox.Text;
            string importance = string.Empty;
            string note = noteTextBox.Text;

            if (importanceButton1.Checked)
                importance = "상";
            else if (importanceButton2.Checked)
                importance = "중";
            else if (importanceButton3.Checked)
                importance = "하";
            //그리드뷰에 기입한 변수 순서대로 삽입 됨
            dataGridView1.Rows.Add(selectedDate.ToShortDateString(), importance, schedule, metroComboBox1.SelectedItem.ToString(), note);
       

            



        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 선택된 행의 인덱스 가져오기
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // 선택된 행에 해당하는 데이터 삭제
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                // 선택된 행이 없을 경우에 대한 처리
                MessageBox.Show("삭제할 행을 선택해주세요.");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate = monthCalendar1.SelectionStart; //달력 선택날짜가 저장이 됨
        }

        private void importanceButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
