using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Feelings", menuName = "NeedsBars")]
public class Bar : ScriptableObject
{
   public GameObject Feelings;
   public int CurrentValue;
}
