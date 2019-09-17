using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class FormOpinion : Form
    {
        public FormOpinion()
        {
            InitializeComponent();
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TbsFont_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fontDlg.ShowDialog(); // 사용자입력 대기, 코드 멈춤
            switch (result)
            {
                case DialogResult.OK:
                    this.rtbText.SelectionFont = this.fontDlg.Font;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("폰트 변경을 취소하셨습니다", "알림");
                    break;
            }

        }

        private void TbsColor_Click(object sender, EventArgs e)
        {
            DialogResult result = this.colorDlg.ShowDialog();  // 사용자입력 대기, 코드 멈춤
            switch (result)
            {
                case DialogResult.OK:
                    this.rtbText.SelectionColor = this.colorDlg.Color;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("색 변경을 취소하셨습니다", "알림");
                    break;
            }

        }
    }
}
