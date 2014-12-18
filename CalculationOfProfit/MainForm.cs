namespace CalculationOfProfit
{
    using System;
    using System.Drawing;
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
                try
                {

                    string filename = openDialog.FileName;

                    //Cоздаем экземпляр xmlser класса XmlSerializer
                    XmlSerializer xmlser = new XmlSerializer(typeof (Data));
                    FileStream filestream = new FileStream(filename, FileMode.Open);
                    // Передаем данные, полученные в процессе десериализации.
                    dataOfTest = (Data) xmlser.Deserialize(filestream);
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
                catch(Exception exc)
                {
                    MessageBox.Show(@"Ошибка при загрузке файла: " + exc.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            try
            {

                // Объявляем диалог на сохранение файла.
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    InitialDirectory = Application.StartupPath + "\\Results",
                    Filter = @"xml file (*.xml)|*.xml",
                    FileName = TB_date.Text.Replace(':', '-')
                };

                // Если пользователь выбрал куда сохранять, то выполняем запись.
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveDialog.FileName;

                    // Cоздаем экземпляр xmlser класса XmlSerializer.
                    XmlSerializer xmlser = new XmlSerializer(typeof (Data));
                    // Создаем поток filestream для создания XML-файла.
                    FileStream filestream = new FileStream(filename, FileMode.Create);
                    // Создаем сериализацию.
                    xmlser.Serialize(filestream, dataOfTest);
                    // Закрываем поток.
                    filestream.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(@"Ошибка при сохранении файла: " + exc.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Выполнение расчетов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_result_Click(object sender, EventArgs e)
        {
            try
            {
                #region Загрузка начальных данных из textbox'ов

                dataOfTest.DateOfTest = Convert.ToDateTime(TB_date.Text);

                dataOfTest.T[0] = Convert.ToInt32(Tb_t1.Text);
                dataOfTest.T[1] = Convert.ToInt32(Tb_t2.Text);
                dataOfTest.T[2] = Convert.ToInt32(Tb_t3.Text);
                dataOfTest.T[3] = Convert.ToInt32(Tb_t4.Text);

                dataOfTest.V[0] = Convert.ToInt32(Tb_v1.Text);
                dataOfTest.V[1] = Convert.ToInt32(Tb_v2.Text);

                dataOfTest.Price = Convert.ToDouble(Tb_price.Text);
                dataOfTest.Costs = Convert.ToDouble(Tb_costs.Text);

                #endregion

            // Сброс графиков.
            graphWind.Refresh();

            #region Расчет

            // Коэффициенты рассчитываются исходя из того, что:
            // v=kt+b
            // k=(v2-v1)/(t2-t1)
            // b=-(t1*v2-t2*v1)/(t2-t1)

            #region Параметры участков

            float[] k = new float[4];
            float[] b = new float[4];
            int[] t1 = new int[4];
            int[] t2 = new int[4];

            // Расчитываем параметры каждого участка и строим прямую, соответчтвующую этим параметрам.

            t1[0] = 0;
            t2[0] = dataOfTest.T[0];
            k[0] = dataOfTest.V[0]/t2[0];
            b[0] = 0;
            graph(t1[0], 0, t2[0], dataOfTest.V[0]);

            t1[1] = dataOfTest.T[0];
            t2[1] = dataOfTest.T[0] + dataOfTest.T[1];
            k[1] = (dataOfTest.V[1] - dataOfTest.V[0]) / (t2[1] - t1[1]);
            b[1] = -(t1[1]*dataOfTest.V[1] - t2[1]*dataOfTest.V[0])/(t2[1] - t1[1]);
            graph(t1[1], dataOfTest.V[0], t2[1], dataOfTest.V[1]);

            t1[2] = dataOfTest.T[0] + dataOfTest.T[1];
            t2[2] = dataOfTest.T[0] + dataOfTest.T[1] + dataOfTest.T[2];
            k[2] = 0;
            b[2] = dataOfTest.V[1];
            graph(t1[2], dataOfTest.V[1], t2[2], dataOfTest.V[1]);

            t1[3] = dataOfTest.T[0] + dataOfTest.T[1] + dataOfTest.T[2];
            t2[3] = dataOfTest.T[0] + dataOfTest.T[1] + dataOfTest.T[2] + dataOfTest.T[3];
            k[3] = (0 - dataOfTest.V[1]) / (t2[3] - t1[3]);
            b[3] = -(0 - t2[3] * dataOfTest.V[1]) / (t2[3] - t1[3]);
            graph(t1[3], dataOfTest.V[1], t2[3], 0);

            #endregion

            dataOfTest.Profit[0] = (dataOfTest.Price - dataOfTest.Costs) * Local_V(k[0], b[0], t1[0], t2[0]);
            dataOfTest.Profit[1] = (dataOfTest.Price - dataOfTest.Costs) * Local_V(k[1], b[1], t1[1], t2[1]);
            dataOfTest.Profit[2] = (dataOfTest.Price - dataOfTest.Costs) * Local_V(k[2], b[2], t1[2], t2[2]);
            dataOfTest.Profit[3] = (dataOfTest.Price - dataOfTest.Costs) * Local_V(k[3], b[3], t1[3], t2[3]);

            dataOfTest.TotalProfit = dataOfTest.Profit[0] + dataOfTest.Profit[1] + dataOfTest.Profit[2] +
                                     dataOfTest.Profit[3];

            tb_prof1.Text = dataOfTest.Profit[0].ToString();
            tb_prof2.Text = dataOfTest.Profit[1].ToString();
            tb_prof3.Text = dataOfTest.Profit[2].ToString();
            tb_prof4.Text = dataOfTest.Profit[3].ToString();

            tb_profTotal.Text = dataOfTest.TotalProfit.ToString();

            #endregion
            
            }
            catch (Exception exc)
            {
                MessageBox.Show(@"Ошибка загрузки данных: " + exc.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Процедура построения графика.
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        private void graph(float x1, float y1, float x2, float y2)
        {
            try
            {
                Graphics g = graphWind.CreateGraphics();

                // Задаем параметры для построения.
                float xmax = dataOfTest.T[0] + dataOfTest.T[1] + dataOfTest.T[2] + dataOfTest.T[3] + 1;
                float ymax = dataOfTest.V[1] + 1;
                float kx = graphWind.Width/xmax;
                float ky = graphWind.Height/ymax;
                Pen myPen = new Pen(Color.Blue);

                // Строим прямую.
                g.DrawLine(myPen, kx*x1, graphWind.Height - ky*y1, kx*x2, graphWind.Height - ky*y2);
            }
            catch (Exception exc)
            {
                MessageBox.Show(@"Ошибка построения графика: " + exc.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Расчет объема продаж на данном участке ЖЦ.
        /// </summary>
        /// <param name="k">Параметр прямой.</param>
        /// <param name="b">Параметр прямой.</param>
        /// <param name="t1">Начальное время участка.</param>
        /// <param name="t2">Конечное время участка.</param>
        /// <returns>Объем продаж на этом участке.</returns>
        private double Local_V(double k, double b, int t1, int t2)
        {
            double v = 0;

            // Суммируем объем продаж на участке за весь этап.
            for (int t = t1+1; t <= t2; t++)
            {
                v += k*t + b;
            }

            return v;
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

        /// <summary>
        /// Новое испытание.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTest_Click(object sender, EventArgs e)
        {
            TB_date.Text = DateTime.Now.ToString();
            
            // Обнуляем параметры.
            Tb_t1.Text =
                Tb_t2.Text =
                    Tb_t3.Text =
                        Tb_t4.Text =
                            Tb_v1.Text =
                                Tb_v2.Text =
                                    Tb_price.Text =
                                        Tb_costs.Text =
                                            tb_prof1.Text =
                                                tb_prof2.Text =
                                                    tb_prof3.Text = tb_prof4.Text = tb_profTotal.Text = String.Empty;
        }

        /// <summary>
        /// Вызов формы справки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Форма справки. 
            HelpForm helpForm = new HelpForm();
            // Открываем диалогом, чтобы не допустить повторного вызова этой формы.
            helpForm.ShowDialog();
        }
    }
}
