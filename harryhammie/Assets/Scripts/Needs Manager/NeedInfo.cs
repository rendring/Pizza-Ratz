using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "Current Needs", menuName ="Feelings Bar")]
public class NeedInfo : ScriptableObject
{
    public int Hunger;
    public int Hygiene;
    public int Happiness;
}
