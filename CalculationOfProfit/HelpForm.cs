namespace CalculationOfProfit
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Форма справки.
    /// </summary>
    public partial class HelpForm : Form
    {
        /// <summary>
        /// Отображение справки.
        /// </summary>
        public HelpForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружаем справку при отображении формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader instr = File.OpenText(Application.StartupPath + "\\Resources\\help.txt");

                // Загружаем справку из текстового документа.
                tb_Help.Text = instr.ReadToEnd();
                instr.Close();
            }
            catch
            {
                MessageBox.Show(@"Не удалось загрузить файл справки", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
