using System.Collections.Generic;
using System.Linq;
using VUK_Manager.Context;
using VUK_Manager.Models;

namespace VUK_Manager.Services
{
    public class Calculations
    {
        ConstEditorServices _services;
        public Calculations(ConstEditorServices services)
        {
            _services = services;
        }
        public int PrefferedSleeveBottom { get; set; }
        public int PrefferedSleeveTop { get; set; }
        public double GetPrice(double a, double b, double h, double densityTube, int clothPrice,
                               bool twoSlings, int priceOfWork, double slingWidth, int topIndex, int bottomIndex,
                               double densityBottom, double densityTop, double thread)
        {
            double result = 0;

            ReportServices.TopPrice = null;
            ReportServices.BottomPrice = null;
            //константы
            List<Prices> tempConsts = _services.GetConsts();
            double threadPrice = tempConsts[0].ThreadPrice;
            double pricePerMeterSling = tempConsts[0].PricePerMeterSling;
            double VAT = tempConsts[0].Vat;
            double bag = tempConsts[0].Bag;
            double webbing = tempConsts[0].Webbing;
            double file = tempConsts[0].File;

            // данные для отчета
            ReportServices.PricePerMeterSling = pricePerMeterSling;
            ReportServices.BagPrice = bag;
            ReportServices.WebbingPrice = webbing;
            ReportServices.ThreadPrice = threadPrice;
            ReportServices.WorkPrice = priceOfWork * ((100.0 + VAT) / 100.0);
            ReportServices.FilePrice = file;

            List<double> pricesOfTops = new List<double>();
            List<double> pricesOfBottoms = new List<double>();
            //расчет трубы
            double tubePrice = CalculatePriceOfSide(a, b, h, densityTube, clothPrice, twoSlings);
            result += tubePrice;
            //отправка данных для отчета
            ReportServices.TubePrice = tubePrice;
            //расчет крышки
            if (topIndex == 1 || topIndex == 3)
            {
                if (topIndex == 1)
                    result += 0.5 * bag;
                pricesOfTops = CalculatePriceOfBottomAndTop(a, b, densityTop, clothPrice, true, PrefferedSleeveTop);
                result += pricesOfTops.Min();
                result += webbing;
            }
            else if (topIndex == 2)
            {
                double tempMarkup = 0;
                if (a == 0.75)
                    tempMarkup = 3;
                else if (a == 0.80)
                    tempMarkup = 3.5;
                else if (a > 0.80)
                    tempMarkup = 4;
                result += bag * tempMarkup + webbing;

                ReportServices.NumberOfBags = tempMarkup;
            }
            // расчет дна
            pricesOfBottoms = CalculatePriceOfBottomAndTop(a, b, densityBottom, clothPrice, false, PrefferedSleeveBottom);
            if (bottomIndex == 1)
                result += (0.5 * bag) + (2 * webbing);
            result += pricesOfBottoms.Min();
            //прочие надбавки
            result += file + (priceOfWork * ((100.0 + VAT) / 100.0)) + (thread * threadPrice);

            //расчет цены за стропы
            if (!twoSlings)
                result += CalculatePriceOfSlings(slingWidth, pricePerMeterSling);
            return result;
        }
        private static double CalculatePriceOfSlings(double slingWidth, double pricePerMeterSling)
        {
            return (slingWidth * 4) * pricePerMeterSling;
        }
        private static double CalculatePriceOfSide(double a, double b, double h, double clothDensity, int clothPrice, bool twoSlings)
        {
            double addCloth = 0.05;
            if (twoSlings)
                addCloth = 0.6;
            h += addCloth;
            //вес 1 погонного метра
            double meterWeight = (a + b) * 2 * clothDensity;
            double temp = h * meterWeight * clothPrice;
            return h * meterWeight * clothPrice;
        }
        private static List<double> CalculatePriceOfBottomAndTop(double a, double b, double clothDensity, int clothPrice,
                                                                 bool top, int prefferedSleeve)
        {
            List<double> sleevesLength = new List<double>() { 1.5, 1.6, 1.8, 1.9, 2.0 };
            if (prefferedSleeve != 50)
            {
                double temp = sleevesLength[prefferedSleeve];
                sleevesLength.Clear();
                sleevesLength.Add(temp);
            }

            double rawPiece = 0;
            double addCloth = 0;
            if (top)
                addCloth = 0.05;
            else
                addCloth = 0.10;

            //разметка рукавов на донышки
            List<double> tempRemainder = new List<double>();
            for (int i = 0; i < sleevesLength.Count; i++)
            {
                tempRemainder.Add((sleevesLength[i] * 2.0) / ((double)b + addCloth));
            }
            rawPiece = (a + addCloth) * (b + addCloth) * clothDensity * clothPrice;
            List<int> usefulBottoms = new List<int>();
            for (int i = 0; i < tempRemainder.Count; i++)
            {
                usefulBottoms.Add((int)tempRemainder[i]);
            }
            //расчет куска на выброс в процентном соотношении
            List<double> trashPercent = new List<double>();
            for (int i = 0; i < sleevesLength.Count; i++)
            {
                trashPercent.Add(tempRemainder[i] - usefulBottoms[i]);
            }
            List<double> prices = new List<double>();

            for (int i = 0; i < tempRemainder.Count; i++)
            {
                prices.Add(rawPiece + ((rawPiece * (trashPercent[i] * 100) / 100) / usefulBottoms[i]));
            }

            if (top)
                ReportServices.TopPrice = prices;
            else
                ReportServices.BottomPrice = prices;
            ReportServices.LengthSleeve = sleevesLength;
            if (prefferedSleeve != 0)
            {
                if (top)
                {
                    ReportServices.LengthSleeveTop = (int)(sleevesLength[0] * 100);
                    ReportServices.TopRemainder = tempRemainder[0];
                }
                else
                { 
                    ReportServices.LengthSleeveBottom = (int)(sleevesLength[0] * 100);
                    ReportServices.BottomRemainder = tempRemainder[0];
                }
            }

            return prices;
        }
    }
}
