using System.Collections.Generic;

namespace Constants
{
    public enum Arcana
    {
        Justice,
        TheEmpress,
        Strength,
        TheHermit,
        TheMagician,
        TheHierophant,
        Death,
        TheHighPriestess,
        TheLovers,
        WheelOfFortune,
        TheSun,
        TheMoon,
        TheHangedMan,
        TheFool,
        Judgement,
        TheEmperor,
        TheChariot,
        Temperance,
        TheDevil,
        TheTower,
        TheStar,
        TheWorld
    }

    public static class MajorArcana
    {
        public static Dictionary<Arcana, string> ArcanaNames = new Dictionary<Arcana, string>()
        {
            { Arcana.TheFool, "0. The Fool" },
            { Arcana.TheMagician, "I. The Magician" },
            { Arcana.TheHighPriestess, "II. The High Priestess" },
            { Arcana.TheEmpress, "III. The Empress" },
            { Arcana.TheEmperor, "IV. The Emperor" },
            { Arcana.TheHierophant, "V. The Hierophant" },
            { Arcana.TheLovers, "VI. The Lovers" },
            { Arcana.TheChariot, "VII. The Chariot" },
            { Arcana.Justice, "VIII. The Justice" },
            { Arcana.TheHermit, "IX. The Hermit" },
            { Arcana.WheelOfFortune, "X. Wheel Of Fortune" },
            { Arcana.Strength, "XI. Strength" },
            { Arcana.TheHangedMan, "XII. The Hanged Man" },
            { Arcana.Death, "XIII. Death" },
            { Arcana.Temperance, "XIV. Temperance" },
            { Arcana.TheDevil, "XV. The Devil" },
            { Arcana.TheTower, "XVI. The Tower" },
            { Arcana.TheStar, "XVII. The Star" },
            { Arcana.TheMoon, "XVIII. The Moon" },
            { Arcana.TheSun, "XIX. The Sun" },
            { Arcana.Judgement, "XX. Judgement" },
            { Arcana.TheWorld, "XXI. The World" }
        };
    }
}