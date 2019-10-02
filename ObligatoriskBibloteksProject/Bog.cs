using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatoriskBibloteksProject
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sideTal;
        private string _lsbn13;

        public string Titel
        {
            get => _titel;
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                    _titel = value;
            }
        }

        public string Forfatter
        {
            get => _forfatter;
            set => _forfatter = value;
        }

        public int SideTal
        {
            get => _sideTal;
            set
            {
                if (value < 10 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException();   
                }
                _sideTal = value;
            } 
        }

        public string Lsbn13
        {
            get => _lsbn13;
            set
            {
                if (value.Length != 13)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _lsbn13 = value;
            } 
        }

        public Bog()
        {

        }

        public Bog(string titel, string forfatter, int sideTal, string lsbn13)
        {
            _titel = titel;
            _forfatter = forfatter;
            _sideTal = sideTal;
            _lsbn13 = lsbn13;
        }
    }
}
