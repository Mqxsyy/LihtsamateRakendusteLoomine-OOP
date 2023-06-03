using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Collections
{
    public class ExchangeRatesList : IList<ExchangeRate>
    {
        private readonly List<ExchangeRate> _exchangeRates;

        public ExchangeRatesList()
        {
            _exchangeRates = new List<ExchangeRate>();
        }

        public ExchangeRate this[int index]
        {
            get
            {
                return _exchangeRates[index];
            }
            set
            {
                _exchangeRates[index] = value;
            }
        }

        public int Count => _exchangeRates.Count;

        public bool IsReadOnly => false;

        public void Add(ExchangeRate item)
        {
            if(_exchangeRates.Any(er => er.Time == item.Time && er.From == item.From && er.To == item.To))
            {
                throw new Exception("Rate already exists in collection");
            }

            _exchangeRates.Add(item);
        }

        public void Clear()
        {
            _exchangeRates.Clear();
        }

        public bool Contains(ExchangeRate item)
        {
            return _exchangeRates.Contains(item);
        }

        public void CopyTo(ExchangeRate[] array, int arrayIndex)
        {
            _exchangeRates.CopyTo(array, arrayIndex);
        }

        public IEnumerator<ExchangeRate> GetEnumerator()
        {
            return _exchangeRates.GetEnumerator();
        }

        public int IndexOf(ExchangeRate item)
        {
            return _exchangeRates.IndexOf(item);
        }

        public void Insert(int index, ExchangeRate item)
        {
            _exchangeRates.Insert(index, item);
        }

        public bool Remove(ExchangeRate item)
        {
            return _exchangeRates.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _exchangeRates.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _exchangeRates.GetEnumerator();
        }
    }
}
