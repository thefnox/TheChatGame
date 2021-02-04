using System.Collections.Generic;

namespace Constants
{
    public enum ZodiacSign
    {
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn,
        Aquarius,
        Pisces
    }
    public static class ZodiacSigns
    {
        public static Dictionary<ZodiacSign, string> ZodiacSignIcons = new Dictionary<ZodiacSign, string>()
        {
            { ZodiacSign.Aries, "♈︎" },
            { ZodiacSign.Taurus, "♉︎" },
            { ZodiacSign.Gemini, "♊︎" },
            { ZodiacSign.Cancer, "♋︎" },
            { ZodiacSign.Leo, "♌︎" },
            { ZodiacSign.Virgo, "♍︎" },
            { ZodiacSign.Libra, "♎︎" },
            { ZodiacSign.Scorpio, "♏︎" },
            { ZodiacSign.Sagittarius, "♐︎" },
            { ZodiacSign.Capricorn, "♑︎" },
            { ZodiacSign.Aquarius, "♒︎" },
            { ZodiacSign.Pisces, "♓︎" },
        };
    }
}