using System;
using System.Collections.Generic;

namespace PrivateSale.Models
{
    public class SalePeriod : ValueObject
    {
        public DateTime StartAt { get; }
        public DateTime EndAt { get; }
        public Sale Sale { get; }

        private SalePeriod(DateTime start, DateTime end, Sale sale)
        {
            StartAt = start;
            EndAt = end;
            Sale = sale;
        }

        private SalePeriod() {
            
        }

        public static SalePeriod NewSalePeriod(DateTime start, DateTime end, Sale sale)
        {
            if (sale == null)
                throw new ArgumentNullException("Sale");

            SalePeriod period = new SalePeriod(start, end, sale);
            sale.SalePeriod = period;
            return period;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return StartAt;
            yield return EndAt;
            yield return Sale;
        }
    }
}