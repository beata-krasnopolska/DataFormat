using System;

namespace DataTypes
{
    class DataDifferencer
    {
        public  string Differencer(string dataType)
        {
            int tryInt;
            decimal tryDec;
            string result;
            if (Int32.TryParse(dataType, out tryInt))
            {
                result = "The data type is integer";
            }
            else if (Decimal.TryParse(dataType, out tryDec))
            {
                result = "The data type is decimal";
            }
            else if (dataType == "a" || dataType == "e" || dataType == "i" || dataType == "o" || dataType == "u" || dataType == "y")
            {
                result = "The entered data type is a vovel";
            }
            else
            {
                result = "There is other data type";
            }
            return result;
        }

    }
}
