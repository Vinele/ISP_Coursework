using System.ComponentModel.DataAnnotations;

namespace VUK_Manager.Models
{
    public class Prices
    {
        [Key]
        public double Vat { get; set; }
        public double PricePerMeterSling { get; set; }
        public double ThreadPrice { get; set; }
        public double Bag { get; set; }
        public double Webbing { get; set; }
        public double File { get; set; }

        public Prices() { }
        public Prices(double vat, double pricePerMeterSling, double threadPrice, double bag, double webbing, double file)
        {
            Vat = vat;
            PricePerMeterSling = pricePerMeterSling;
            ThreadPrice = threadPrice;
            Bag = bag;
            Webbing = webbing;
            File = file;
        }
    }
}
