using System.ComponentModel;

namespace Supermarket.Domain.Models
{
    public enum EMeasureUnity : byte
    {
        [Description("UN")]
        Unity = 1,

        [Description("MG")]
        Milligram = 2,

        [Description("G")]
        Gram = 3,

        [Description("KG")]
        Kilogram = 4,

        [Description("L")]
        liter = 5
    }
}