using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VUK_Manager.Services;
using VUK_Manager.Context;
using VUK_Manager.Models;
using System.Linq;

namespace VUK_Manager.View
{
    public partial class MainSelector : Form
    {
        private bool twoSlings = false;
        private bool finalCalc = false;
        private double finalPrice = 0;
        ConstEditorServices constEditorServices;
        Calculations calculations;
        ReportModel conteinerParameters;
        ReportServices reportServices;
        VUKContext context; 

        
        public MainSelector()
        {
            InitializeComponent();
            topConfigBox.SelectedIndex = 0;
            bottomConfigBox.SelectedIndex = 0;
            threadBox.SelectedIndex = 0;
            densityTopBox.SelectedIndex = 0;
            fullPriceLabel.Text = "";
            wrongValueLabel.Text = "";

            context = new VUKContext();
            conteinerParameters = new ReportModel();
            reportServices = new ReportServices(conteinerParameters);
            constEditorServices = new ConstEditorServices(context);
            calculations = new Calculations(constEditorServices);


            //просто большой кусок выходящий за грани массива, тк не чистился список
            calculations.PrefferedSleeveTop = 50;
            calculations.PrefferedSleeveBottom = 50;
        }

        private void lengthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            widthBox.SelectedItem = lengthBox.SelectedItem;

            try
            {
                CheckHeight();
            }
            catch
            {
                return;
            }

        }
        private void widthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lengthBox.SelectedItem = widthBox.SelectedItem;
            try
            {
                CheckHeight();
            }
            catch
            {
                return;
            }
        }
        private void heightBox_Click(object sender, EventArgs e)
        {
            CarriageReturn(heightBox);
        }
        private void priceBox_Click(object sender, EventArgs e)
        {
            CarriageReturn(clothPriceBox);
        }
        private void slingLenghtBox_Click(object sender, EventArgs e)
        {
            CarriageReturn(slingLenghtBox);
        }
        private void heightBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (wrongValueLabel.Text != "Введена некорректная высота")
                {
                    slingLenghtBox.Text = (int.Parse(heightBox.Text) + 50).ToString();
                }
                CheckHeight();
            }
            catch
            {
                return;
            }

        }
        private void CheckHeight()
        {
            string str = heightBox.Text.Replace(".", "").Replace(",", "");
            if (str[0].ToString() == "0")
            {
                wrongValueLabel.Text = "Введена некорректная высота";
                return;
            }
            else
                wrongValueLabel.Text = "";
        }
        private void CheckThread()
        {
            if (topConfigBox.SelectedIndex == 0 && bottomConfigBox.SelectedIndex == 0)
                threadBox.SelectedIndex = 0;
            else
                threadBox.SelectedIndex = 1;
        }

        private void topConfigBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckThread();
            if (topConfigBox.SelectedIndex == 0 || topConfigBox.SelectedIndex == 2)
                densityTopBox.Enabled = false;
            else
                densityTopBox.Enabled = true;
        }

        private void bottomConfigBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckThread();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (wrongValueLabel.Text != "Введена некорректная высота")
            {

                try
                {
                    RefreshDataForReport();
                    double price = UpdatePriceShow();
                    finalPrice = price;
                    ReportForm reportForm = new ReportForm(reportServices, calculations, price, finalCalc, conteinerParameters);
                    if (reportForm.ShowDialog() == DialogResult.OK)
                    {
                        finalPrice = UpdatePriceShow();
                        finalCalc = true;
                        ReportForm finalreport = new ReportForm(reportServices, calculations, finalPrice, finalCalc, conteinerParameters);
                        finalreport.ShowDialog();
                    }
                    if (!finalCalc)
                        fullPriceLabel.Text = $@"Авто. цена: {Math.Round(price, 2)} руб.";
                    else
                    {
                        fullPriceLabel.Text = $@"Итого: {Math.Round(finalPrice, 2)} руб.";
                    }
                }
                catch
                {
                    MessageBox.Show("Заполните корректно все поля. \n\n\n●Возможно требуется сброс значений. \n●Проверьте соединение с базой данных и правильности значений.",
                                    "Неверные параметры", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                fullPriceLabel.Text = "";
        }

        //обновляет данные контейнера для модели отчета.
        private void RefreshDataForReport()
        {
            conteinerParameters.Length = int.Parse(lengthBox.Text);
            conteinerParameters.Width = int.Parse(widthBox.Text);
            conteinerParameters.Height = int.Parse(heightBox.Text);
            conteinerParameters.TwoSlings = twoSlings;
            conteinerParameters.BottomConfigIndex = bottomConfigBox.SelectedIndex;
            conteinerParameters.TopConfigIndex = topConfigBox.SelectedIndex;
            conteinerParameters.DensityCloth = int.Parse(densityBox.Text);
            conteinerParameters.DensityBottom = int.Parse(densityBottomBox.Text);
            conteinerParameters.DensityTop = int.Parse(densityTopBox.Text);
            conteinerParameters.ClothPrice = int.Parse(clothPriceBox.Text);
            conteinerParameters.ThreadPrice = double.Parse(threadBox.Text);
            conteinerParameters.SlingLength = double.Parse(slingLenghtBox.Text);
        }

        //метод для обновления конечной цены.
        private double UpdatePriceShow()
        {
            double slingLenght = 0;
            if (twoSlings == false)
                slingLenght = double.Parse(slingLenghtBox.Text);


            double price = calculations.GetPrice(double.Parse(lengthBox.Text) / 100,
                                                 double.Parse(widthBox.Text) / 100,
                                                 double.Parse(heightBox.Text) / 100,
                                                 double.Parse(densityBox.Text) / 1000,
                                                 int.Parse(clothPriceBox.Text),
                                                 twoSlings, int.Parse(workBox.Text),
                                                 slingLenght,
                                                 topConfigBox.SelectedIndex,
                                                 bottomConfigBox.SelectedIndex,
                                                 double.Parse(densityBottomBox.Text) / 1000,
                                                 double.Parse(densityTopBox.Text) / 1000,
                                                 double.Parse(threadBox.Text));
            return price;
        }

        private void weightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            densityBox.SelectedIndex = weightBox.SelectedIndex;
        }

        private void twoSlingsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (twoSlingsCheckBox.Checked == true)
            {
                twoSlings = true;
            }
            else
            {
                twoSlings = false;
            }
            slingLenghtBox.Enabled = !twoSlings;
        }

        private void densityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            densityBottomBox.SelectedIndex = densityBox.SelectedIndex;
        }

        private void CarriageReturn(MaskedTextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text) || textBox.Text == " ," || textBox.Text == "   ,")
                textBox.SelectionStart = 0;
        }
        private void constantsEditButton_Click(object sender, EventArgs e)
        {
            ConstEditorForm constEditorForm = new ConstEditorForm(constEditorServices);
            constEditorForm.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            finalCalc = false;
            finalPrice = 0;
            ReportServices.LengthSleeveTop = 0;
            ReportServices.LengthSleeveBottom = 0;
            ReportServices.LengthSleeve = null;
            ReportServices.TopPrice = null;
            ReportServices.BottomPrice = null;
            calculations.PrefferedSleeveTop = 50;
            calculations.PrefferedSleeveBottom = 50;
            fullPriceLabel.Text = "";
        }

        private void MainSelector_Load(object sender, EventArgs e)
        {
            //List<Prices> prices = context.Prices.ToList();
        }
    }
}
