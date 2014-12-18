namespace CalculationOfProfit
{
    using System;
    using System.IO;
    using System.Xml.Serialization;
    using System.Windows.Forms;

    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Данные тестов.
        /// </summary>
        private Data dataOfTest = new Data
        {
            T = new int[4],
            V = new int[2],
            Profit = new double[4]
        };

        /// <summary>
        /// Инициализатор формы.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Процедура открывания данных прошлых испытаний.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openTestData_Click(object sender, EventArgs e)
        {
            // Объявляем диалог на открытие файла.
            OpenFileDialog openDialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath + "\\Results",
                Filter = @"xml file (*.xml)|*.xml"
            };

            // Если пользователь выбрал файл, то загружаем его.
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openDialog.FileName;

                //Cоздаем экземпляр xmlser класса XmlSerializer
                XmlSerializer xmlser = new XmlSerializer(typeof(Data));
                FileStream filestream = new FileStream(filename, FileMode.Open);
                // Передаем данные, полученные в процессе десериализации.
                dataOfTest = (Data)xmlser.Deserialize(filestream);
                filestream.Close();
               
                #region Загрузка данных в textbox'ы

                TB_date.Text = dataOfTest.DateOfTest.ToString();

                Tb_t1.Text = dataOfTest.T[0].ToString();
                Tb_t2.Text = dataOfTest.T[1].ToString();
                Tb_t3.Text = dataOfTest.T[2].ToString();
                Tb_t4.Text = dataOfTest.T[3].ToString();

                Tb_v1.Text = dataOfTest.V[0].ToString();
                Tb_v2.Text = dataOfTest.V[1].ToString();

                Tb_price.Text = dataOfTest.Price.ToString();
                Tb_costs.Text = dataOfTest.Costs.ToString();

                tb_prof1.Text = dataOfTest.Profit[0].ToString();
                tb_prof2.Text = dataOfTest.Profit[1].ToString();
                tb_prof3.Text = dataOfTest.Profit[2].ToString();
                tb_prof4.Text = dataOfTest.Profit[3].ToString();

                tb_profTotal.Text = dataOfTest.TotalProfit.ToString();

                #endregion
            }
        }

        /// <summary>
        /// Выход из приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Процедура сохранения данных испытаний.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTestData_Click(object sender, EventArgs e)
        {
            // Объявляем диалог на сохранение файла.
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath + "\\Results",
                Filter = @"xml file (*.xml)|*.xml",
                FileName = TB_date.Text.Replace(':','-')
            };

            // Если пользователь выбрал куда сохранять, то выполняем запись.
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveDialog.FileName;

                // Cоздаем экземпляр xmlser класса XmlSerializer.
                XmlSerializer xmlser = new XmlSerializer(typeof(Data));
                // Создаем поток filestream для создания XML-файла.
                FileStream filestream = new FileStream(filename, FileMode.Create);
                // Создаем сериализацию.
                xmlser.Serialize(filestream, dataOfTest);
                // Закрываем поток.
                filestream.Close();
            }
        }

        /// <summary>
        /// Выполнение расчетов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_result_Click(object sender, EventArgs e)
        {
            // TODO: Расчеты.

            // TODO: Удалить регион ниже.
            #region Тестовые данные
            Tb_t1.Text = "5";
            Tb_t2.Text = "6";
            Tb_t3.Text = "7";
            Tb_t4.Text = "4";

            Tb_v1.Text = "350";
            Tb_v2.Text = "500";

            Tb_price.Text = "50";
            Tb_costs.Text = "20";

            tb_prof1.Text = "1000";
            tb_prof2.Text = "5000";
            tb_prof3.Text = "10000";
            tb_prof4.Text = "3000";

            tb_profTotal.Text = "19000";
            #endregion


            #region Загрузка данных из textbox'ов

            dataOfTest.DateOfTest = Convert.ToDateTime(TB_date.Text);

            dataOfTest.T[0] = Convert.ToInt32(Tb_t1.Text);
            dataOfTest.T[1] = Convert.ToInt32(Tb_t2.Text);
            dataOfTest.T[2] = Convert.ToInt32(Tb_t3.Text);
            dataOfTest.T[3] = Convert.ToInt32(Tb_t4.Text);

            dataOfTest.V[0] = Convert.ToInt32(Tb_v1.Text);
            dataOfTest.V[1] = Convert.ToInt32(Tb_v2.Text);

            dataOfTest.Price = Convert.ToDouble(Tb_price.Text);
            dataOfTest.Costs = Convert.ToDouble(Tb_costs.Text);

            dataOfTest.Profit[0] = Convert.ToDouble(tb_prof1.Text);
            dataOfTest.Profit[1] = Convert.ToDouble(tb_prof2.Text);
            dataOfTest.Profit[2] = Convert.ToDouble(tb_prof3.Text);
            dataOfTest.Profit[3] = Convert.ToDouble(tb_prof4.Text);

            dataOfTest.TotalProfit = Convert.ToDouble(tb_profTotal.Text);

            #endregion
        }

        /// <summary>
        /// Действия при загрузке формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            TB_date.Text = DateTime.Now.ToString();
        }
    }
}
