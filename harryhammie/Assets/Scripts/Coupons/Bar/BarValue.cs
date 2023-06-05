using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarValue : MonoBehaviour
{

    public Slider CouponBar;
    public GameObject Hunger, Hygiene, Happy;
    public PermaStates BarProgression;
    public Animator BarAppears;
    bool NoSpam = false;

    private float PointModifierHu;
    //private float PointModifierHy;
    private float Exp = 100;
    
    void Start()
    {
        BarAppears = gameObject.GetComponent<Animator>();
        CouponBar.value = BarProgression.CouponBarProgression;
        
    }

    // Update is called once per frame
    void Update()
    {

        PointModifierHu = (float) (Hunger.GetComponent<HungerBar>().timeSlider.value * 100 / 90 * 0.01);
        PointModifierHu = 1 - PointModifierHu + 1;
        //PointModifierHy = (float)(Hygiene.GetComponent<HygieneBar>().timeSlider.value * 100 / 90 * 0.01);
        //PointModifierHy = 1 - PointModifierHy + 1;



        if (Hunger.GetComponent<hungerControl>().FeedActive && Hunger.GetComponent<HungerBar>().timeSlider.value < 80)
        {
            //I tried adding it so you can't spam the animation and it kind of works so i'm keeping it in -C
            if (NoSpam == false)
            {
                NoSpam = true;
                BarAppears.SetTrigger("Active");
                NoSpam = false;
            }
            
                Exp = Exp * PointModifierHu;
                CouponBar.value = (float)(CouponBar.value + Exp);
                Hunger.GetComponent<hungerControl>().FeedActive = false;
                Debug.Log(PointModifierHu);
           
            
        }
        BarProgression.CouponBarProgression = CouponBar.value;

        //Basis for the added coupon when you get a full bar -C
        if (CouponBar.value == 1000)
        {
            BarProgression.CouponBarProgression = 0;
            CouponBar.value = 0;
        }
        //if (Hygiene.GetComponent<BathScr>().OnlyOnce == true)
        //{
        //    Exp = Exp * PointModifierHy;
        //    CouponBar.value = (float)(CouponBar.value + Exp);
        //    Hygiene.GetComponent<BathScr>().OnlyOnce = false;
        //}
    }
}
