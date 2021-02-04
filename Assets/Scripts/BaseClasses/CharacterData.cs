using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine.UIElements;

namespace BaseClasses
{
    public class CharacterData
    {

        public List<StatusData> activeStatus = new List<StatusData>();

        public int baseStrength { get; set; } = 10;
        public int baseConstitution { get; set; } = 10;
        public int baseDexterity { get; set; } = 10;
        public int baseSpeed { get; set; } = 10;
        public int baseWits { get; set; } = 10;
        public int baseIntelligence { get; set; } = 10;

        public int baseWisdom { get; set; } = 10;

        public int baseCharisma { get; set; } = 10;

        public int baseLuck { get; set; } = 10;

        public BloodType bloodType { get; set; } = BloodType.ONegative;

        public ElementType baseElement1 { get; set; } = ElementType.Generic;

        public ElementType baseElement2 { get; set; } = ElementType.Unset;

        public ElementType elementOverride1 { get; set; } = ElementType.Unset;

        public ElementType elementOverride2 { get; set; } = ElementType.Unset;

        public ElementType elementOverride3 { get; set; } = ElementType.Unset;

        public ZodiacSign zodiacSign { get; set; } = ZodiacSign.Aries;

        public Arcana arcana { get; set; } = Arcana.TheFool;

        public Alignments alignment { get; set; } = Alignments.TrueNeutral;

        public int strength
        {
            get
            {
                return baseStrength;
            }
        }

        public int constitution
        {
            get
            {
                return baseConstitution;
            }
        }

        public int dexterity
        {
            get
            {
                return baseDexterity;
            }
        }

        public int speed
        {
            get
            {
                return baseSpeed;
            }
        }

        public int wits
        {
            get
            {
                return baseWits;
            }
        }

        public int intelligence
        {
            get
            {
                return baseIntelligence;
            }
        }

        public int wisdom
        {
            get
            {
                return baseWisdom;
            }
        }

        public int charisma
        {
            get
            {
                return baseCharisma;
            }
        }

        public int luck
        {
            get
            {
                return baseLuck;
            }
        }

        public int horny { get; set; } = 0;
    }
}
