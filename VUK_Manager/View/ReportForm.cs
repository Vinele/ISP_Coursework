using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VUK_Manager.Models;
using VUK_Manager.Services;

namespace VUK_Manager.View
{
    public partial class ReportForm : Form
    {
        ReportServices _reportServices;
        Calculations _calculations;
        private double _fullPrice;
        ReportModel _conteinerParameters;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        public ReportForm(ReportServices reportServices, Calculations calculations, double fullPrice, bool finalCalc, ReportModel conteinerParameters)
        {
            InitializeComponent();
            _reportServices = reportServices;
            _calculations = calculations;
            _conteinerParameters = conteinerParameters;
            fullPriceLabel.Text = "";
            _fullPrice = fullPrice;

            bool tempStatus = false;
            if (finalCalc)
                tempStatus = false;
            else
                tempStatus = true;
            topListBox.Enabled = tempStatus;
            bottomListBox.Enabled = tempStatus;
            acceptButton.Enabled = tempStatus;
            printButton.Visible = !tempStatus;
            customerTextBox.Visible = !tempStatus;
            percentTextBox.Visible = !tempStatus;
            dividingPanel.Visible = !tempStatus;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            _reportServices.GetStructureInfo(reportTextBox, _fullPrice, fullPriceLabel);
            _reportServices.UpdateTopList(topListBox);
            _reportServices.UpdateBottomList(bottomListBox);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _calculations.PrefferedSleeveTop = topListBox.SelectedIndex;
            _calculations.PrefferedSleeveBottom = bottomListBox.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            _reportServices.IndexBottom = bottomListBox.SelectedIndex;
            _reportServices.IndexTop = topListBox.SelectedIndex;

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            
            _reportServices.WrapPercent = GetWrapPercent();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageTitleHandler;
            printDocument.PrintPage += PrintPageNomenclaturaHandler;
            printDocument.PrintPage += PrintPageConfigHandler;
            printDocument.PrintPage += PrintPagePriceHandler;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }
        //имя
        void PrintPageTitleHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(customerTextBox.Text, new Font("Arial", 18), Brushes.Black, 0, 70);
        }
        //номенклатура
        void PrintPageNomenclaturaHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(_reportServices.GetInfoForPrint(reportTextBox, 0), new Font("Arial", 16), Brushes.Black, 0, 110);
        }
        //конфиг
        void PrintPageConfigHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(_reportServices.GetInfoForPrint(reportTextBox, 1), new Font("Arial", 14), Brushes.Black, 0, 150);
        }
        //цена
        void PrintPagePriceHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(_reportServices.GetInfoForPrint(reportTextBox, 2, _fullPrice),
                                  new Font("Arial", 14), Brushes.Black, 0, 375);
        }

        private void customerTextBox_Click(object sender, EventArgs e)
        {
            if (customerTextBox.Text == "Наименование заказчика")
                customerTextBox.Text = "";
        }

        private void percentTextBox_Click(object sender, EventArgs e)
        {
            if (percentTextBox.Text == "Процент накрутки")
                percentTextBox.Text = "";
        }

        private void percentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (percentTextBox.Text.Contains("."))
            {
                percentTextBox.Text = percentTextBox.Text.Replace(".", ",");
                percentTextBox.SelectionStart = percentTextBox.Text.Length;
            }
            if (percentTextBox.Text.Contains(","))
            {
                if ((percentTextBox.Text.IndexOf(",") != percentTextBox.Text.Length - 1) &&
                    (percentTextBox.Text[percentTextBox.Text.Length - 1].ToString() == ","))
                {
                    percentTextBox.Text = percentTextBox.Text.Remove(percentTextBox.Text.IndexOf(","), 1);
                }
            }
                

            double tempPercent = GetWrapPercent();
            fullPriceLabel.Text = $"Цена: {(Math.Round(_fullPrice * ((100.0 + tempPercent) / 100.0), 2)).ToString()} руб. ({tempPercent}%)";
        }

        private double GetWrapPercent()
        {
            double wrapPercent = 0;
            if (double.TryParse(percentTextBox.Text, out double result))
                wrapPercent = result;
            return wrapPercent;

        }
    }
}
