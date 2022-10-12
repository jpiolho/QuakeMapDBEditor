using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QuakeMapDBEditor
{
    public partial class FormAutoGenerateExceptions : Form
    {
        public FormAutoGenerateExceptions(List<(string, Exception)> exceptions)
        {
            InitializeComponent();
            this.SetDefaultIcon();

            var sb = new StringBuilder();

            foreach (var ex in exceptions)
            {
                sb.AppendLine(ex.Item1);
                sb.AppendLine(ex.Item2.ToString());
                sb.AppendLine();
                sb.AppendLine();
            }

            textBoxExceptions.Text = sb.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
