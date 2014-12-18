namespace CalculationOfProfit
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTest = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestData = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestData = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gb_initVal = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_v2 = new System.Windows.Forms.TextBox();
            this.Tb_v1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_t1 = new System.Windows.Forms.Label();
            this.Tb_t4 = new System.Windows.Forms.TextBox();
            this.Tb_t3 = new System.Windows.Forms.TextBox();
            this.Tb_t2 = new System.Windows.Forms.TextBox();
            this.Tb_t1 = new System.Windows.Forms.TextBox();
            this.TB_date = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_costs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Gb_result = new System.Windows.Forms.GroupBox();
            this.tb_prof1 = new System.Windows.Forms.TextBox();
            this.tb_prof2 = new System.Windows.Forms.TextBox();
            this.tb_prof3 = new System.Windows.Forms.TextBox();
            this.tb_prof4 = new System.Windows.Forms.TextBox();
            this.tb_profTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Btn_result = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.graphWind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Gb_initVal.SuspendLayout();
            this.Gb_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb1
            // 
            this.Pb1.Image = ((System.Drawing.Image)(resources.GetObject("Pb1.Image")));
            this.Pb1.Location = new System.Drawing.Point(12, 27);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(363, 167);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb1.TabIndex = 0;
            this.Pb1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTest,
            this.openTestData,
            this.saveTestData,
            this.exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // newTest
            // 
            this.newTest.Name = "newTest";
            this.newTest.Size = new System.Drawing.Size(240, 22);
            this.newTest.Text = "Новое испытание";
            this.newTest.Click += new System.EventHandler(this.newTest_Click);
            // 
            // openTestData
            // 
            this.openTestData.Name = "openTestData";
            this.openTestData.Size = new System.Drawing.Size(240, 22);
            this.openTestData.Text = "Открыть данные испытаний";
            this.openTestData.Click += new System.EventHandler(this.openTestData_Click);
            // 
            // saveTestData
            // 
            this.saveTestData.Name = "saveTestData";
            this.saveTestData.Size = new System.Drawing.Size(240, 22);
            this.saveTestData.Text = "Сохранить данные испытаний";
            this.saveTestData.Click += new System.EventHandler(this.saveTestData_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(240, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // Gb_initVal
            // 
            this.Gb_initVal.Controls.Add(this.label16);
            this.Gb_initVal.Controls.Add(this.label15);
            this.Gb_initVal.Controls.Add(this.label14);
            this.Gb_initVal.Controls.Add(this.label8);
            this.Gb_initVal.Controls.Add(this.Tb_costs);
            this.Gb_initVal.Controls.Add(this.label7);
            this.Gb_initVal.Controls.Add(this.TB_date);
            this.Gb_initVal.Controls.Add(this.label6);
            this.Gb_initVal.Controls.Add(this.Tb_price);
            this.Gb_initVal.Controls.Add(this.label5);
            this.Gb_initVal.Controls.Add(this.label4);
            this.Gb_initVal.Controls.Add(this.Tb_v2);
            this.Gb_initVal.Controls.Add(this.Tb_v1);
            this.Gb_initVal.Controls.Add(this.label3);
            this.Gb_initVal.Controls.Add(this.label2);
            this.Gb_initVal.Controls.Add(this.label1);
            this.Gb_initVal.Controls.Add(this.lbl_t1);
            this.Gb_initVal.Controls.Add(this.Tb_t4);
            this.Gb_initVal.Controls.Add(this.Tb_t3);
            this.Gb_initVal.Controls.Add(this.Tb_t2);
            this.Gb_initVal.Controls.Add(this.Tb_t1);
            this.Gb_initVal.Location = new System.Drawing.Point(12, 200);
            this.Gb_initVal.Name = "Gb_initVal";
            this.Gb_initVal.Size = new System.Drawing.Size(363, 181);
            this.Gb_initVal.TabIndex = 20;
            this.Gb_initVal.TabStop = false;
            this.Gb_initVal.Text = "Начальные параметры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Цена изделия=";
            // 
            // Tb_price
            // 
            this.Tb_price.Location = new System.Drawing.Point(217, 101);
            this.Tb_price.Name = "Tb_price";
            this.Tb_price.Size = new System.Drawing.Size(128, 20);
            this.Tb_price.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "v2=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "v1=";
            // 
            // Tb_v2
            // 
            this.Tb_v2.Location = new System.Drawing.Point(49, 127);
            this.Tb_v2.Name = "Tb_v2";
            this.Tb_v2.Size = new System.Drawing.Size(47, 20);
            this.Tb_v2.TabIndex = 29;
            // 
            // Tb_v1
            // 
            this.Tb_v1.Location = new System.Drawing.Point(49, 101);
            this.Tb_v1.Name = "Tb_v1";
            this.Tb_v1.Size = new System.Drawing.Size(47, 20);
            this.Tb_v1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "t4=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "t3=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "t2=";
            // 
            // lbl_t1
            // 
            this.lbl_t1.AutoSize = true;
            this.lbl_t1.Location = new System.Drawing.Point(21, 67);
            this.lbl_t1.Name = "lbl_t1";
            this.lbl_t1.Size = new System.Drawing.Size(22, 13);
            this.lbl_t1.TabIndex = 24;
            this.lbl_t1.Text = "t1=";
            // 
            // Tb_t4
            // 
            this.Tb_t4.Location = new System.Drawing.Point(298, 64);
            this.Tb_t4.Name = "Tb_t4";
            this.Tb_t4.Size = new System.Drawing.Size(47, 20);
            this.Tb_t4.TabIndex = 23;
            // 
            // Tb_t3
            // 
            this.Tb_t3.Location = new System.Drawing.Point(217, 64);
            this.Tb_t3.Name = "Tb_t3";
            this.Tb_t3.Size = new System.Drawing.Size(47, 20);
            this.Tb_t3.TabIndex = 22;
            // 
            // Tb_t2
            // 
            this.Tb_t2.Location = new System.Drawing.Point(130, 64);
            this.Tb_t2.Name = "Tb_t2";
            this.Tb_t2.Size = new System.Drawing.Size(47, 20);
            this.Tb_t2.TabIndex = 21;
            // 
            // Tb_t1
            // 
            this.Tb_t1.Location = new System.Drawing.Point(49, 64);
            this.Tb_t1.Name = "Tb_t1";
            this.Tb_t1.Size = new System.Drawing.Size(47, 20);
            this.Tb_t1.TabIndex = 20;
            // 
            // TB_date
            // 
            this.TB_date.Location = new System.Drawing.Point(170, 19);
            this.TB_date.Name = "TB_date";
            this.TB_date.ReadOnly = true;
            this.TB_date.Size = new System.Drawing.Size(175, 20);
            this.TB_date.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Время проведения тестов:";
            // 
            // Tb_costs
            // 
            this.Tb_costs.Location = new System.Drawing.Point(217, 155);
            this.Tb_costs.Name = "Tb_costs";
            this.Tb_costs.Size = new System.Drawing.Size(128, 20);
            this.Tb_costs.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "1ого изделия=";
            // 
            // Gb_result
            // 
            this.Gb_result.Controls.Add(this.Btn_result);
            this.Gb_result.Controls.Add(this.label13);
            this.Gb_result.Controls.Add(this.label12);
            this.Gb_result.Controls.Add(this.label11);
            this.Gb_result.Controls.Add(this.label10);
            this.Gb_result.Controls.Add(this.label9);
            this.Gb_result.Controls.Add(this.tb_profTotal);
            this.Gb_result.Controls.Add(this.tb_prof4);
            this.Gb_result.Controls.Add(this.tb_prof3);
            this.Gb_result.Controls.Add(this.tb_prof2);
            this.Gb_result.Controls.Add(this.tb_prof1);
            this.Gb_result.Location = new System.Drawing.Point(381, 27);
            this.Gb_result.Name = "Gb_result";
            this.Gb_result.Size = new System.Drawing.Size(345, 167);
            this.Gb_result.TabIndex = 21;
            this.Gb_result.TabStop = false;
            this.Gb_result.Text = "Итоги";
            // 
            // tb_prof1
            // 
            this.tb_prof1.Location = new System.Drawing.Point(174, 13);
            this.tb_prof1.Name = "tb_prof1";
            this.tb_prof1.ReadOnly = true;
            this.tb_prof1.Size = new System.Drawing.Size(114, 20);
            this.tb_prof1.TabIndex = 22;
            // 
            // tb_prof2
            // 
            this.tb_prof2.Location = new System.Drawing.Point(174, 39);
            this.tb_prof2.Name = "tb_prof2";
            this.tb_prof2.ReadOnly = true;
            this.tb_prof2.Size = new System.Drawing.Size(114, 20);
            this.tb_prof2.TabIndex = 23;
            // 
            // tb_prof3
            // 
            this.tb_prof3.Location = new System.Drawing.Point(174, 65);
            this.tb_prof3.Name = "tb_prof3";
            this.tb_prof3.ReadOnly = true;
            this.tb_prof3.Size = new System.Drawing.Size(114, 20);
            this.tb_prof3.TabIndex = 24;
            // 
            // tb_prof4
            // 
            this.tb_prof4.Location = new System.Drawing.Point(174, 91);
            this.tb_prof4.Name = "tb_prof4";
            this.tb_prof4.ReadOnly = true;
            this.tb_prof4.Size = new System.Drawing.Size(114, 20);
            this.tb_prof4.TabIndex = 25;
            // 
            // tb_profTotal
            // 
            this.tb_profTotal.Location = new System.Drawing.Point(174, 117);
            this.tb_profTotal.Name = "tb_profTotal";
            this.tb_profTotal.ReadOnly = true;
            this.tb_profTotal.Size = new System.Drawing.Size(114, 20);
            this.tb_profTotal.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Прибыль на 1ом этапе:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Прибыль на 2ом этапе:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Прибыль на 3ем этапе:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Прибыль на 4ом этапе:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Суммарная прибыль:";
            // 
            // Btn_result
            // 
            this.Btn_result.Location = new System.Drawing.Point(242, 141);
            this.Btn_result.Name = "Btn_result";
            this.Btn_result.Size = new System.Drawing.Size(97, 20);
            this.Btn_result.TabIndex = 39;
            this.Btn_result.Text = "Расчитать";
            this.Btn_result.UseVisualStyleBackColor = true;
            this.Btn_result.Click += new System.EventHandler(this.Btn_result_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(127, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Издержки";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(127, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "на создание";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Длительности этапов ЖЦ:";
            // 
            // graphWind
            // 
            this.graphWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphWind.Location = new System.Drawing.Point(381, 200);
            this.graphWind.Name = "graphWind";
            this.graphWind.Size = new System.Drawing.Size(345, 181);
            this.graphWind.TabIndex = 22;
            this.graphWind.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 393);
            this.Controls.Add(this.graphWind);
            this.Controls.Add(this.Gb_result);
            this.Controls.Add(this.Gb_initVal);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Расчет прибыли";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Gb_initVal.ResumeLayout(false);
            this.Gb_initVal.PerformLayout();
            this.Gb_result.ResumeLayout(false);
            this.Gb_result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTest;
        private System.Windows.Forms.ToolStripMenuItem openTestData;
        private System.Windows.Forms.ToolStripMenuItem saveTestData;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox Gb_initVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_v2;
        private System.Windows.Forms.TextBox Tb_v1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_t1;
        private System.Windows.Forms.TextBox Tb_t4;
        private System.Windows.Forms.TextBox Tb_t3;
        private System.Windows.Forms.TextBox Tb_t2;
        private System.Windows.Forms.TextBox Tb_t1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tb_costs;
        private System.Windows.Forms.GroupBox Gb_result;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_profTotal;
        private System.Windows.Forms.TextBox tb_prof4;
        private System.Windows.Forms.TextBox tb_prof3;
        private System.Windows.Forms.TextBox tb_prof2;
        private System.Windows.Forms.TextBox tb_prof1;
        private System.Windows.Forms.Button Btn_result;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox graphWind;
    }
}

