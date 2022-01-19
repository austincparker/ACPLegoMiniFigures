namespace ACPLegoMiniFigures.Models
{
internal class LegoHeadBase
{
        public LegoColor Color { get; set; }
        public string Theme { get; set; }
        public string Expression { get; set; }

        public string FacialHair { get; set; }
    }

    public enum LegoColor //struct
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