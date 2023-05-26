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

            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // 선택된 행의 값을 각각의 컨트롤에 할당
                selectedDate = DateTime.Parse(selectedRow.Cells[0].Value.ToString());
                memoTextBox.Text = selectedRow.Cells[2].Value.ToString();
                noteTextBox.Text = selectedRow.Cells[4].Value.ToString();

                string importance = selectedRow.Cells[1].Value.ToString();
                if (importance == "상")
                    importanceButton1.Checked = true;
                else if (importance == "중")
                    importanceButton2.Checked = true;
                else if (importance == "하")
                    importanceButton3.Checked = true;

                string comboBoxValue = selectedRow.Cells[3].Value.ToString();
                if (metroComboBox1.Items.Contains(comboBoxValue))
                    metroComboBox1.SelectedItem = comboBoxValue;
            }
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                // 수정된 값 가져오기
                string modifiedSchedule = memoTextBox.Text;
                string modifiedImportance = string.Empty;
                string modifiedNote = noteTextBox.Text;

                if (importanceButton1.Checked)
                    modifiedImportance = "상";
                else if (importanceButton2.Checked)
                    modifiedImportance = "중";
                else if (importanceButton3.Checked)
                    modifiedImportance = "하";

                // 선택된 행의 값을 수정된 값으로 변경
                selectedRow.Cells[0].Value = selectedDate.ToShortDateString();
                selectedRow.Cells[1].Value = modifiedImportance;
                selectedRow.Cells[2].Value = modifiedSchedule;
                selectedRow.Cells[3].Value = metroComboBox1.SelectedItem.ToString();
                selectedRow.Cells[4].Value = modifiedNote;
            }
            else
            {
                // 선택된 행이 없을 경우에 대한 처리
                MessageBox.Show("수정할 행을 선택해주세요.");
            }

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
            string executablePath = Application.ExecutablePath; // 실행 중인 애플리케이션 경로
            string directoryPath = Path.GetDirectoryName(executablePath); // 실행 중인 애플리케이션의 디렉토리 경로
            string filePath = Path.Combine(directoryPath, "Schedule.csv"); // 디렉토리 경로와 파일 이름을 결합하여 파일 경로 생성


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // 데이터 그리드 뷰의 각 행을 확인하며 저장
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // 행이 비어있는지 확인
                    bool isEmptyRow = true;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                        {
                            isEmptyRow = false;
                            break;
                        }
                    }

                    // 행이 비어있지 않다면 저장
                    if (!isEmptyRow)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value);

                            if (i != row.Cells.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string executablePath = Application.ExecutablePath; // 실행 중인 애플리케이션 경로
            string directoryPath = Path.GetDirectoryName(executablePath); // 실행 중인 애플리케이션의 디렉토리 경로
            string filePath = Path.Combine(directoryPath, "Schedule.csv"); // 디렉토리 경로와 파일 이름을 결합하여 파일 경로 생성

            if (File.Exists(filePath))
            {
                dataGridView1.Rows.Clear();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');

                        // 비어있는 행은 건너뜀
                        if (values.All(string.IsNullOrEmpty))
                            continue;

                        // 데이터 그리드 뷰에 행 추가
                        int rowIndex = dataGridView1.Rows.Add();
                        DataGridViewRow row = dataGridView1.Rows[rowIndex];

                        // 각 셀에 값을 설정
                        for (int i = 0; i < values.Length; i++)
                        {
                            row.Cells[i].Value = values[i];
                        }
                    }
                }
            }
        }
    }
}
