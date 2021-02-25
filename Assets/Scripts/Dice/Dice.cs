using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice
{
    public readonly int size;

    public DiceResult Roll(int modifier)
    {
        return new DiceResult(size, modifier);
    }

    public Dice(int size)
    {
        this.size = size;
    }
}
