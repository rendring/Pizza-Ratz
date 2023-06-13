using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VariableInfo", menuName = "ScriptableObjects/VariableInfo")]
public class PermaStates : ScriptableObject
{

    //mini game
    public float SuperAwesomeHighScore;

    public float SuperDuperAwesomeHighScore;

    public float CouponBarProgression;

    //coupon pref

    public bool produce;

    public bool others;

    public bool meat;

    public bool dairy;

    public bool vegan;

    public bool cannedFood;

    public bool beverages;

    public bool bakery;

    public bool baking;

   

    //feeling bars
    public float HungerBarSlider;

    public float HygieneBarSlider;

    public float HappinessBarSlider;


}

    
