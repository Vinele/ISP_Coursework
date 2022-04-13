using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VUK_Manager.Context;
using VUK_Manager.Models;
using VUK_Manager.Services;

namespace VUK_Manager.View
{
    public partial class ConstEditorForm : Form
    {
        ConstEditorServices _services;
        public ConstEditorForm(ConstEditorServices services)
        {
            InitializeComponent();
            statusLabel.Text = "";
            statusLabel.TextAlign = ContentAlignment.BottomRight;
            _services = services;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if ((statusLabel.Text == "Были внесены изменения") || (statusLabel.Text == null))
            {
                _services.SetConsts(GetValues());
                ConstEditorForm_Load(sender, e);
                statusLabel.ForeColor = Color.DarkGreen;
                statusLabel.Text = "Изменения применены";
            }
            else
            {
                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = "Изменений не было. Конфигурация не обновилась";
            }
        }

        private Prices GetValues()
        {
            Prices newPrices = new Prices()
            {
                ThreadPrice = double.Parse(threadPriceBox.Text),
                PricePerMeterSling = double.Parse(pricePerMeterTextBox.Text),
                Vat = double.Parse(vatTextBox.Text),
                Bag = double.Parse(bagTextBox.Text),
                Webbing = double.Parse(webbingTextBox.Text),
                File = double.Parse(fileTextBox.Text)
            };
            return newPrices;
        }

        private void WarningText()
        {
            statusLabel.ForeColor = Color.DarkRed;
            statusLabel.Text = "Были внесены изменения";
        }

        private void ConstEditorForm_Load(object sender, EventArgs e)
        {
            try
            {
                //List<Prices> prices = _services.GetConsts();
                VUKContext vUKContext = new VUKContext();
                List<Prices> prices = vUKContext.Prices.ToList();
                threadPriceBox.Text = prices[0].ThreadPrice.ToString();
                pricePerMeterTextBox.Text = prices[0].PricePerMeterSling.ToString();
                vatTextBox.Text = prices[0].Vat.ToString();
                bagTextBox.Text = prices[0].Bag.ToString();
                webbingTextBox.Text = prices[0].Webbing.ToString();
                fileTextBox.Text = prices[0].File.ToString();
                statusLabel.Text = "";
            }
            catch { statusLabel.Text = "Связь с базой данных не удалось установить."; }
        }

        private void TextCorrection(MaskedTextBox textbox)
        {
            textbox.Text = textbox.Text.Replace(".", ",");
            textbox.SelectionStart = textbox.Text.Length;
        }
        private void webbingTextBox_TextChanged(object sender, EventArgs e)
        {
            WarningText();
            try
            {
                if (webbingTextBox.Text[webbingTextBox.Text.Length - 1].ToString() == ".")
                    TextCorrection(webbingTextBox);
            }
            catch { }
        }

        private void threadPriceBox_TextChanged(object sender, EventArgs e)
        {
            WarningText();
            try
            {
                if (threadPriceBox.Text[threadPriceBox.Text.Length - 1].ToString() == ".")
                    TextCorrection(threadPriceBox);
            }
            catch { }

        }

        private void fileTextBox_TextChanged(object sender, EventArgs e)
        {
            WarningText();
            try
            {
                if (fileTextBox.Text[fileTextBox.Text.Length - 1].ToString() == ".")
                    TextCorrection(fileTextBox);
            }
            catch { }

        }

        private void bagTextBox_TextChanged(object sender, EventArgs e)
        {
            WarningText();
            try
            {
                if (bagTextBox.Text[bagTextBox.Text.Length - 1].ToString() == ".")
                    TextCorrection(bagTextBox);
            }
            catch { }

        }

        private void pricePerMeterTextBox_TextChanged(object sender, EventArgs e)
        {
            WarningText();
            try
            {
                if (pricePerMeterTextBox.Text[pricePerMeterTextBox.Text.Length - 1].ToString() == ".")
                    TextCorrection(pricePerMeterTextBox);
            }
            catch { }
        }

        private void vatTextBox_TextChanged(object sender, EventArgs e)
        {
            WarningText();
            try
            {
                if (vatTextBox.Text[vatTextBox.Text.Length - 1].ToString() == ".")
                    TextCorrection(vatTextBox);
            }
            catch { }
        }
    }
}
