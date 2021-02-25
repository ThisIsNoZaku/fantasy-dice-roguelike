using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceResult
{
    public readonly int modifier;
    public readonly int rolledValue;
    public readonly int total;

    public DiceResult(int rolled, int modifier)
    {
        this.rolledValue = rolled;
        this.modifier = modifier;
        this.total = rolled + modifier;
    }
}
