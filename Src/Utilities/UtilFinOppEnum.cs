using EnumFinType;

namespace UtilFinOppEnum
{
    public class FinOppEnumUtil
    {
        public static string FromEnumToString(FinTypeEnum finType)
        {
            return finType switch
            {
                FinTypeEnum.EXPRESS => "Express",
                FinTypeEnum.INCOME => "Income",
                _ => "Unknown"
            };
        }

        public static FinTypeEnum FromStringToEnum(string finType)
        {
            return finType switch
            {
                "Express" => FinTypeEnum.EXPRESS,
                "Income" => FinTypeEnum.INCOME,
                _ => FinTypeEnum.UNKNOWN
            };
        }
    }
}