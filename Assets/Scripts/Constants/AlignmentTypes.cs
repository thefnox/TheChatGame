using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Constants
{
    public enum Alignments
    {
        LawfulGood,
        NeutralGood,
        ChaoticGood,
        LawfulNeutral,
        TrueNeutral,
        ChaoticNeutral,
        LawfulEvil,
        NeutralEvil,
        ChaoticEvil
    }

    public static class AlignmentTypes
    {
        public static bool IsEvil(Alignments alignment)
        {
            return  alignment == Alignments.ChaoticEvil ||
                    alignment == Alignments.LawfulEvil ||
                    alignment == Alignments.NeutralEvil;
        }

        public static bool IsGood(Alignments alignment)
        {
            return alignment == Alignments.ChaoticGood ||
                    alignment == Alignments.LawfulGood ||
                    alignment == Alignments.NeutralGood;
        }

        public static bool IsCombinationAllowed(List<Alignments> list)
        {
            int evil = 0;
            int good = 0;
            int total = list.Count;
            int halfTotal = total / 2;
            foreach (Alignments alignment in list)
            {
                if (IsGood(alignment))
                {
                    good++;
                } else if (IsEvil(alignment))
                {
                    evil++;
                }
            }
            if (evil >= halfTotal || good >= halfTotal)
            {
                return (Mathf.Max(evil, good) - Mathf.Min(evil, good)) < halfTotal;
            } else
            {
                return true;
            }
        }
    }
}
