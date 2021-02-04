using System.Collections.Generic;

namespace Constants {
    public enum BloodType
    {
        ONegative,
        OPositive,
        ANegative,
        APositive,
        BNegative,
        BPositive,
        ABNegative,
        ABPositive
    }

    public static class BloodTypes
    {
        public static Dictionary<BloodType, string> bloodTypeIcons = new Dictionary<BloodType, string>()
        {
            { BloodType.ONegative, "🅾-" },
            { BloodType.OPositive, "🅾+" },
            { BloodType.ANegative, "🅰-" },
            { BloodType.APositive, "🅰+" },
            { BloodType.BNegative, "🅱-" },
            { BloodType.BPositive, "🅱+" },
            { BloodType.ABNegative, "🆎-" },
            { BloodType.ABPositive, "🆎+" },
        };

        /**
         * First key is the donor blood type,
         * Second is the recipient's blood type
         */
        public static Dictionary<BloodType, Dictionary<BloodType, bool>> bloodTypeCompatibilityTable = new Dictionary<BloodType, Dictionary<BloodType, bool>>()
        {
            [BloodType.ABPositive] = new Dictionary<BloodType, bool>()
            {
                { BloodType.ONegative, false },
                { BloodType.OPositive, false },
                { BloodType.ANegative, false },
                { BloodType.APositive, false },
                { BloodType.BNegative, false },
                { BloodType.BPositive, false },
                { BloodType.ABNegative, false },
                { BloodType.ABPositive, true },
            },
            [BloodType.ABNegative] = new Dictionary<BloodType, bool>()
            {
                { BloodType.ONegative, false },
                { BloodType.OPositive, false },
                { BloodType.ANegative, false },
                { BloodType.APositive, false },
                { BloodType.BNegative, false },
                { BloodType.BPositive, false },
                { BloodType.ABNegative, true },
                { BloodType.ABPositive, true },
            },
            [BloodType.BPositive] = new Dictionary<BloodType, bool>()
            {
                { BloodType.ONegative, false },
                { BloodType.OPositive, false },
                { BloodType.ANegative, false },
                { BloodType.APositive, false },
                { BloodType.BNegative, false },
                { BloodType.BPositive, true },
                { BloodType.ABNegative, false },
                { BloodType.ABPositive, true },
            },
            [BloodType.BNegative] = new Dictionary<BloodType, bool>()
            {
                { BloodType.ONegative, false },
                { BloodType.OPositive, false },
                { BloodType.ANegative, false },
                { BloodType.APositive, false },
                { BloodType.BNegative, true },
                { BloodType.BPositive, true },
                { BloodType.ABNegative, true },
                { BloodType.ABPositive, true },
            },
            [BloodType.APositive] = new Dictionary<BloodType, bool>()
            {
                { BloodType.ONegative, false },
                { BloodType.OPositive, false },
                { BloodType.ANegative, false },
                { BloodType.APositive, true },
                { BloodType.BNegative, false },
                { BloodType.BPositive, false },
                { BloodType.ABNegative, false },
                { BloodType.ABPositive, true },
            },
            [BloodType.ANegative] = new Dictionary<BloodType, bool>()
            {
                { BloodType.ONegative, false },
                { BloodType.OPositive, false },
                { BloodType.ANegative, true },
                { BloodType.APositive, true },
                { BloodType.BNegative, false },
                { BloodType.BPositive, false },
                { BloodType.ABNegative, true },
                { BloodType.ABPositive, true },
            },
            [BloodType.OPositive] = new Dictionary<BloodType, bool>()
            {
                { BloodType.ONegative, false },
                { BloodType.OPositive, true },
                { BloodType.ANegative, false },
                { BloodType.APositive, true },
                { BloodType.BNegative, false },
                { BloodType.BPositive, true },
                { BloodType.ABNegative, false },
                { BloodType.ABPositive, true },
            },
            [BloodType.ONegative] = new Dictionary<BloodType, bool>()
            {
                { BloodType.ONegative, true },
                { BloodType.OPositive, true },
                { BloodType.ANegative, true },
                { BloodType.APositive, true },
                { BloodType.BNegative, true },
                { BloodType.BPositive, true },
                { BloodType.ABNegative, true },
                { BloodType.ABPositive, true },
            }
        };
    }
}
