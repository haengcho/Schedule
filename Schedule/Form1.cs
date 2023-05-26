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
            if (!string.IsNullOrEmpty(schedule)) // 스케줄이 유효한 경우에만 행 추가
            {
                dataGridView1.Rows.Add(selectedDate.ToShortDateString(), importance, schedule, metroComboBox1.SelectedItem.ToString(), note);
            }
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            //string executablePath = Application.ExecutablePath; // 실행 중인 애플리케이션 경로
            //string directoryPath = Path.GetDirectoryName(executablePath); // 실행 중인 애플리케이션의 디렉토리 경로
            //string filePath = Path.Combine(directoryPath, "Schedule.csv"); // 디렉토리 경로와 파일 이름을 결합하여 파일 경로 생성


            //// 데이터 그리드 뷰의 데이터 저장
            //StringBuilder sb = new StringBuilder();

            //    // 헤더 쓰기
            //    foreach (DataGridViewColumn column in dataGridView1.Columns)
            //    {
            //        sb.Append(column.HeaderText).Append(",");
            //    }
            //    sb.AppendLine();

            //    // 행 데이터 쓰기
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            sb.Append(cell.Value).Append(",");
            //        }
            //        sb.AppendLine();
            //    }
            //    // 파일에 데이터 쓰기
            //    System.IO.File.WriteAllText(filePath, sb.ToString());



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string executablePath = Application.ExecutablePath; // 실행 중인 애플리케이션 경로
            string directoryPath = Path.GetDirectoryName(executablePath); // 실행 중인 애플리케이션의 디렉토리 경로
            string filePath = Path.Combine(directoryPath, "Schedule.csv"); // 디렉토리 경로와 파일 이름을 결합하여 파일 경로 생성

            // 파일에서 데이터 읽어오기
            string[] lines = File.ReadAllLines(filePath);

            // 데이터 그리드 뷰 초기화
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // 헤더 추가
            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                dataGridView1.Columns.Add(header, header);
            }

            // 행 추가
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                dataGridView1.Rows.Add(values);
            }

            // 초기화 과정에서 첫 번째 행이 추가되는 문제 해결
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(0); // 초기화 과정에서 첫 번째 행을 제거
            }
        }
    }
}
