using System.Collections.Generic;
using System.Linq;
using VUK_Manager.Context;
using VUK_Manager.Models;


namespace VUK_Manager.Services
{
    public class ConstEditorServices
    {
        VUKContext _context;
        public ConstEditorServices(VUKContext context)
        {
            _context = context;

        }
        public List<Prices> GetConsts()
        {
            _context = new VUKContext();
            List<Prices> values = _context.Prices.ToList();
            return values;
        }

        private string ValueNormalization(double value)
        {
            string newValue = value.ToString().Replace(",", ".");
            return newValue;
        }
        public void SetConsts(Prices newPrices)
        {
            _context.Database.ExecuteSqlCommand($"UPDATE Prices " +
                                                $"SET ThreadPrice = {ValueNormalization(newPrices.ThreadPrice)}," +
                                                    $"PricePerMeterSling = {ValueNormalization(newPrices.PricePerMeterSling)}, " +
                                                    $"Vat = {ValueNormalization(newPrices.Vat)}," +
                                                    $"Bag = {ValueNormalization(newPrices.Bag)}," +
                                                    $"Webbing = {ValueNormalization(newPrices.Webbing)}," +
                                                    $"File = {ValueNormalization(newPrices.File)};");
            _context.SaveChanges();

        }
    }
}
