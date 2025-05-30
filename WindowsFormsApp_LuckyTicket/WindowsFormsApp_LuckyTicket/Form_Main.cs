using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using evaluate = WindowsFormsApp_LuckyTicket.lt_Evaluation.Class_Evaluating;
using parse = WindowsFormsApp_LuckyTicket.lt_Evaluation.Class_Parsing;

namespace WindowsFormsApp_LuckyTicket
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_CheckVariant_Click(object sender, EventArgs e)
        {
            short[] arr = { 1, -1, -1, -1, -1, -1 };
            short def = -1;

            string str_arr = this.textBox_Input.Text;
            long lg_count = str_arr.Count();
            for (long lg_i = 0; lg_i < lg_count; lg_i++)
            {
                if (lg_i == 6)
                {
                    break;
                }
                char ch = str_arr[(int)lg_i];
                arr[lg_i] = (short)parse.StrToShortDef(ch.ToString() ,def);
            }
            short sh_checked = evaluate.DEF_VARIANT_DEFAULT;
            if (this.radioButton_VariantDefault.Checked)
            {
                sh_checked = evaluate.DEF_VARIANT_TASK;
            }
            short sh_answer = evaluate.IsHappyLucky(arr, sh_checked);
            string str_answer = evaluate.GetMessageByLuckyValue(sh_answer);
            MessageBox.Show(str_answer);
        }

        private void button_FindAllLucky_Click(object sender, EventArgs e)
        {
            short sh_checked = evaluate.DEF_VARIANT_DEFAULT;
            if (this.radioButton_VariantTask.Checked)
            {
                sh_checked = evaluate.DEF_VARIANT_TASK;
            }
            List<string> lst_lucky = new List<string>();
            lst_lucky.Clear();

            short[] sh_arr = { -1, -1, -1, -1, -1, -1 };

            long lg_count_i = 0;
            for (lg_count_i = 0; lg_count_i <= 999999; lg_count_i += 111111)
            {
                parse.ConvertLongToArray(lg_count_i, ref sh_arr);
                short sh_answer = evaluate.IsHappyLucky(sh_arr, sh_checked);
                if(sh_answer == evaluate.DEF_LUCKY_TICKET)
                {
                    string str = "[" + lg_count_i.ToString() + "]" + parse.ConvertLongToString(lg_count_i, 6);
                    lst_lucky.Add(str);
                    lg_count_i++;
                }
            }
            listBox_Enumerate.Items.Clear();
            listBox_Enumerate.Items.AddRange(lst_lucky.ToArray());
        }
    }
}
