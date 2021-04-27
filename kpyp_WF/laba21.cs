using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpyp_WF
{
    public partial class laba21 : Form
    {
        public laba21()
        {
            InitializeComponent();
        }
        string[] weeks = {"Понеденльник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

        private void check_Click(object sender, EventArgs e)
        {
            try
            {
                answer.Text = weeks[int.Parse(input_date.Text) - 1];
            }
            catch (IndexOutOfRangeException)
            {
                answer.Text = "Такого дня недели не существует";
            }
            
        }
    }
}
