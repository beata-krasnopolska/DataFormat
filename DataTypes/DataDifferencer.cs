using System;
using System.Collections.Generic;

namespace DataTypes
{
    class DataDifferencer
    {
        private List<string> _vovels = new List<string>() { "a", "e", "i", "o", "u", "y" };

        public string Differ(string dataType)
        {
            if (int.TryParse(dataType, out int tryInt))
            {
                return "The data type is integer";
            }

            if (decimal.TryParse(dataType, out decimal tryDec))
            {
                return "The data type is decimal";
            }

            if (_vovels.Contains(dataType))
            {
                return "The entered data type is a vovel";
            }

            return "There is other data type";            
        }
    }
}
