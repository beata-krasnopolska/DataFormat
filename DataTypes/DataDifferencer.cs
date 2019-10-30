using System;
using System.Collections.Generic;

namespace DataTypes
{
    class DataDifferencer
    {
        private List<string> _vovels = new List<string>() { "a", "e", "i", "o", "u", "y" };

        public string Differ(string dataType)
        {
            if (IsInt(dataType))
            {
                return "The data type is integer";
            }

            if (IsDecimal(dataType))
            {
                return "The data type is decimal";
            }

            if (IsVovel(dataType))
            {
                return "The entered data type is a vovel";
            }

            return "There is other data type";            
        }

        private bool IsInt(string dataType)
        {
            return int.TryParse(dataType, out int _);
        }

        private bool IsDecimal(string dataType)
        {
            return decimal.TryParse(dataType, out decimal _);
        }

        private bool IsVovel(string dataType)
        {
            return _vovels.Contains(dataType);
        }
    }
}
