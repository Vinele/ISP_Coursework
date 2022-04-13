using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VUK_Manager.Models;

namespace VUK_Manager.Services
{
    public class ReportServices
    {
        private List<int> prefix = new List<int>() { 150, 160, 180, 190, 200 };
        static public int LengthSleeveTop { get; set; }
        static public int LengthSleeveBottom { get; set; }
        static public List<double> LengthSleeve{ get; set; }
        static public double TubePrice { get; set; }
        static public List<double> TopPrice { get; set; }
        static public List<double> BottomPrice { get; set; }
        public int IndexBottom { get; set; }
        public int IndexTop { get; set; }

        // данные для отчета из calculations
        static public double BottomRemainder { get; set; }
        static public double TopRemainder { get; set; }
        static public double PricePerMeterSling { get; set; }
        static public double NumberOfBags { get; set; }
        static public double BagPrice { get; set; }
        static public double WebbingPrice { get; set; }
        static public double ThreadPrice { get; set; }
        static public double WorkPrice { get; set; }
        static public double FilePrice { get; set; }

        //процент накрутки из ReportForm
        public double WrapPercent { get; set; }

        ReportModel _containerParameters;

        public ReportServices(ReportModel containerParameters)
        {
            _containerParameters = containerParameters;
        }

        public void GetStructureInfo(TextBox reportTextBox, double fullPrice, Label fullPriceLabel)
        {
            if(BottomPrice.Count > 1)
            {
                for (int i = 0; i < BottomPrice.Count; i++)
                {
                    reportTextBox.Text += $"Рукав: {LengthSleeve[i] * 100}" + Environment.NewLine;
                    if (TopPrice != null)
                        reportTextBox.Text += $"Цена Крышки {Math.Round(TopPrice[i],2)} руб." + Environment.NewLine;
                    reportTextBox.Text += $"Цена дна {Math.Round(BottomPrice[i],2)} руб." + Environment.NewLine;
                    reportTextBox.Text += $"________________________________" + Environment.NewLine + Environment.NewLine;
                }
                fullPriceLabel.Text = $"Автоматическая цена: {Math.Round(fullPrice,2)} руб.";
            }
            else
            {
                for (int i = 0; i < BottomPrice.Count; i++)
                {
                    if (TopPrice != null)
                    {
                        reportTextBox.Text += $"Рукав для крышки: {LengthSleeveTop}" + Environment.NewLine;
                        reportTextBox.Text += $"Цена Крышки {Math.Round(TopPrice[i],2)} руб." + Environment.NewLine;
                       
                        reportTextBox.Text += $"________________________________" + Environment.NewLine + Environment.NewLine;
                        
                    }
                    reportTextBox.Text += $"Рукав для дна: {LengthSleeveBottom}" + Environment.NewLine;
                    reportTextBox.Text += $"Цена дна: {Math.Round(BottomPrice[i], 2)} руб." + Environment.NewLine;
                    reportTextBox.Text += $"________________________________" + Environment.NewLine + Environment.NewLine;
                    
                }
                fullPriceLabel.Text = $"Цена: {Math.Round(fullPrice,2)} руб.";
                GetAdvancedInformation(reportTextBox, fullPrice);
            }
        }

        public void GetAdvancedInformation(TextBox reportTextBox, double fullPrice)
        {
            CheckAndCorrectionContainerParameters();
            int AddCloth = 5;
            if (_containerParameters.SlingsConfigText == "С2")
                AddCloth = 60;
            reportTextBox.Text += $"МКР {_containerParameters.SlingsConfigText}  {_containerParameters.Length}x{_containerParameters.Width}x{_containerParameters.Height} " +
                                  $" {_containerParameters.TopConfigText}+{_containerParameters.BottomConfigText}" + Environment.NewLine;
            reportTextBox.Text += $"Труба: {_containerParameters.Length+ _containerParameters.Width}/{_containerParameters.DensityCloth} -" +
                                  $" {_containerParameters.Height+ AddCloth} x {_containerParameters.ClothPrice} [{Math.Round(TubePrice, 2)}руб.]" + Environment.NewLine;
            reportTextBox.Text += $"Дно: {LengthSleeveBottom}/{_containerParameters.DensityBottom} - {_containerParameters.Length + 10}" +
                                  $" x {_containerParameters.Width + 10} x {_containerParameters.ClothPrice} ({Math.Round(BottomRemainder,2)}) " +
                                  $"[{Math.Round(BottomPrice[0], 2)} руб.]" + Environment.NewLine;

            if (_containerParameters.SlingsConfigText == "Л4")
                reportTextBox.Text += $"Стропа: {_containerParameters.SlingLength.ToString().Remove(1,1)} x 4 x {PricePerMeterSling} " +
                                      $"[{(_containerParameters.Height + 50)*4*PricePerMeterSling/100} руб.]" + Environment.NewLine;

            switch (_containerParameters.TopConfigText)
            {
                case "ВК":
                case "ВЛ":
                    reportTextBox.Text += $"Крышка: {LengthSleeveTop}/{_containerParameters.DensityTop} - {_containerParameters.Length + 5}" +
                                          $" x {_containerParameters.Width + 5} x {_containerParameters.ClothPrice} ({Math.Round(TopRemainder, 2)}) " +
                                          $"[{Math.Round(TopPrice[0],2)} руб.]" + Environment.NewLine;
                    if (_containerParameters.TopConfigText == "ВК")
                    {
                        reportTextBox.Text += $"Верх. клапан: 0.5 x {BagPrice} [{Math.Round(0.5 * BagPrice, 2)} руб.]"
                                           + Environment.NewLine;
                    }
                    break;
                case "ВС":
                    reportTextBox.Text += $"ВС: {NumberOfBags} x {BagPrice} [{Math.Round(NumberOfBags*BagPrice,2)} руб.]" + Environment.NewLine;
                    break;
            }
            if(_containerParameters.BottomConfigText == "НК")
                reportTextBox.Text += $"Нижн. клапан: 0.5 x {BagPrice} [{Math.Round(0.5 * BagPrice, 2)} руб.]" + Environment.NewLine;

            if(_containerParameters.TopConfigText != "ОВ" || _containerParameters.BottomConfigText == "НК")
            {
                int tempWebbing = 0;
                if (_containerParameters.TopConfigText != "ОВ")
                    tempWebbing += 1;
                if (_containerParameters.BottomConfigText == "НК")
                    tempWebbing += 2;
                reportTextBox.Text += $"Тесьма: {tempWebbing} x {WebbingPrice}  [{tempWebbing * WebbingPrice} руб.]" + Environment.NewLine;
            }
            reportTextBox.Text += $"Нить: {_containerParameters.ThreadPrice} x {ThreadPrice} " +
                                  $"[{Math.Round(_containerParameters.ThreadPrice * ThreadPrice, 2)} руб.]" + Environment.NewLine;
            reportTextBox.Text += $"Работа: [{WorkPrice} руб.]" + Environment.NewLine;
            reportTextBox.Text += $"Файл: [{FilePrice} руб.]" + Environment.NewLine + 
                                   "▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪" + Environment.NewLine;
            reportTextBox.Text += $"Себестоимость: [{Math.Round(fullPrice, 2)} руб.]" + Environment.NewLine + 
                                   "▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪" + Environment.NewLine;
        }
        
        public string GetInfoForPrint(TextBox reportTextBox, int reportStatus, double fullPrice = 0)
        {
            string tempText = reportTextBox.Text;

            int tempIndex = tempText.LastIndexOf("_");
            tempText = tempText.Remove(0, tempIndex + 5);

            switch (reportStatus)
            {
                //номенклатура
                case 0:
                    tempIndex = tempText.IndexOf("Труба");
                    tempText = tempText.Remove(tempIndex);
                    break;
                //конфиг
                case 1:
                    tempIndex = tempText.IndexOf("Труба");
                    tempText = tempText.Remove(0, tempIndex);
                    tempIndex = tempText.IndexOf("▪");
                    tempText = tempText.Remove(tempIndex);
                    break;
                //цена
                case 2:
                    tempIndex = tempText.IndexOf("▪");
                    tempText = tempText.Remove(0, tempIndex);
                    double tempCustomerPrice = Math.Round(fullPrice * ((100.0 + WrapPercent) / 100.0), 2);
                    tempText += $"Цена для клиента: [{tempCustomerPrice} руб.] ({WrapPercent}%)"
                             + Environment.NewLine + "▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪" + Environment.NewLine;
                    tempText += $"Прибыльность: [{Math.Round((tempCustomerPrice - fullPrice)/1.2,2)} руб.]"
                             + Environment.NewLine + "▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪";
                    tempText += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy | HH:mm");
                    break;
            }
            return tempText;
        }
        public void UpdateTopList(ListBox topListBox)
        {
            if (TopPrice != null)
            {
                for (int i = 0; i < TopPrice.Count; i++)
                {
                    int tempIndex = i;
                    if (TopPrice.Count == 1)
                        tempIndex = IndexTop;
                    topListBox.Items.Add($"({prefix[tempIndex]}) " + Math.Round(TopPrice[i],2).ToString());
                }
            }
        }
        public void UpdateBottomList(ListBox bottomListBox)
        {
            for (int i = 0; i < BottomPrice.Count; i++)
            {
                int tempIndex = i;
                if (BottomPrice.Count == 1)
                    tempIndex = IndexBottom;
                bottomListBox.Items.Add($"({prefix[tempIndex]}) " + Math.Round(BottomPrice[i],2).ToString());
            }
        }

        private void CheckAndCorrectionContainerParameters()
        {
            //стропы
            if (_containerParameters.TwoSlings == true)
                _containerParameters.SlingsConfigText = "С2";
            else
                _containerParameters.SlingsConfigText = "Л4";

            //конфиг дна
            if (_containerParameters.BottomConfigIndex == 0)
                _containerParameters.BottomConfigText = "ПД";
            else
                _containerParameters.BottomConfigText = "НК";

            //конфиг крышки
            switch (_containerParameters.TopConfigIndex)
            {
                case 0:
                    _containerParameters.TopConfigText = "ОВ";
                    break;
                case 1:
                    _containerParameters.TopConfigText = "ВК";
                    break;
                case 2:
                    _containerParameters.TopConfigText = "ВС";
                    break;
                case 3:
                    _containerParameters.TopConfigText = "ВЛ";
                    break;
            }
        }
    }
}
