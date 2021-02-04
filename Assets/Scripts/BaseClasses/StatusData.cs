using System;
using System.Collections.Generic;
using System.Linq;
using BaseClasses;
using Constants;

public class StatusData
{
    public int duration { get; set; } = 10000000;

    public bool active { get; set; } = true;

    public CharacterData character;

    public List<Tuple<StatNames,int>> activeStatIncrements = new List<Tuple<StatNames, int>>();

    public List<Tuple<StatNames, int>> activeStatValues = new List<Tuple<StatNames, int>>();

    public StatusData(CharacterData character)
    {
        this.character = character;
    }

    public int GetStatValue(StatNames name, int baseValue)
    {
        if (activeStatValues.Any(tuple => tuple.Item1 == name))
        {
            return (from tuple in activeStatValues where tuple.Item1 == name select tuple.Item2).FirstOrDefault();
        } else
        {
            return baseValue + (from tuple in activeStatValues where tuple.Item1 == name select tuple.Item2).Sum();
        }
    }


    public virtual void OnTurnStart()
    {

    }

    public virtual void OnTurnEnd()
    {
        if (!isPermanent())
        {
            duration--;
        }

        if (duration <= 0)
        {
            OnElapse();
        }
    }

    public virtual void OnElapse()
    {
        active = false;
    }

    public bool isPermanent() { return duration > 5000; }


}
