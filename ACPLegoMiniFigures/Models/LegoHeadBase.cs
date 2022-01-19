namespace ACPLegoMiniFigures.Models
{
internal class LegoHeadBase
{
        public string Color { get; set; }
        public string Theme { get; set; }
        public string Expression { get; set; }

        public string FacialHair { get; set; }
    }

    public enum LegoColors
    {
        None,
        Yellow,
        Orange,
        Red,
        Green,
        Blue,
        Indigo,
        Violet,
        Grey
    }

}