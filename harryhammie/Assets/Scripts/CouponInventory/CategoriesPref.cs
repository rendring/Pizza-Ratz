using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoriesPref : MonoBehaviour
{
    public GameObject T, NonT;
    public PermaStates CategoryPref;
    bool Activated;

    

    bool modifier;
    void Start()
    {
        

        if (gameObject.name == "ProduceB")
        {
            modifier = CategoryPref.produce;
            Activated = CategoryPref.produce;
            
            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }


        if (gameObject.name == "oTHERSB")
        {
            modifier = CategoryPref.others;
            Activated = CategoryPref.others;

            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }

        if (gameObject.name == "MeatB")
        {
            modifier = CategoryPref.meat;
            Activated = CategoryPref.meat;

            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }

        if (gameObject.name == "DairyB")
        {
            modifier = CategoryPref.dairy;
            Activated = CategoryPref.dairy;

            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }

        if (gameObject.name == "VEGANB")
        {
            modifier = CategoryPref.vegan;
            Activated = CategoryPref.vegan;

            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }

        if (gameObject.name == "CannedFoodB")
        {
            modifier = CategoryPref.cannedFood;
            Activated = CategoryPref.cannedFood;

            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }

        if (gameObject.name == "BeveragesB")
        {
            modifier = CategoryPref.beverages;
            Activated = CategoryPref.beverages;

            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }

        if (gameObject.name == "BakeryB")
        {
            modifier = CategoryPref.bakery;
            Activated = CategoryPref.bakery;

            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }
        
        if (gameObject.name == "BakingB")
        {
            modifier = CategoryPref.baking;
            Activated = CategoryPref.baking;

            if (Activated == true)
            {
                T.SetActive(false);
                NonT.SetActive(true);
                modifier = true;
                Activated = false;

            }

            else
            {
                T.SetActive(true);
                NonT.SetActive(false);
                modifier = false;
                Activated = true;

            }
        }

    }


    public void TorNonT()
    {
        if (Activated == true)
        {
            T.SetActive(false);
            NonT.SetActive(true);
            modifier = true;
            Activated = false;
            
        }

        else
        {
            T.SetActive(true);
            NonT.SetActive(false);
            modifier = false;
            Activated = true;
            
        }
        
    }
    
    void Update()
    {
        if (gameObject.name == "ProduceB")
        {
            CategoryPref.produce = modifier;
        }

        if (gameObject.name == "oTHERSB")
        {
            CategoryPref.others = modifier;
        }
        
        if (gameObject.name == "MeatB")
        {
            CategoryPref.meat = modifier;
        }

        if (gameObject.name == "DairyB")
        {
            CategoryPref.dairy = modifier;
        }

        if (gameObject.name == "VEGANB")
        {
            CategoryPref.vegan = modifier;
        }

        if (gameObject.name == "CannedFoodB")
        {
            CategoryPref.cannedFood = modifier;
        }

        if (gameObject.name == "BeveragesB")
        {
            CategoryPref.beverages = modifier;
        }

        if (gameObject.name == "BakeryB")
        {
            CategoryPref.bakery = modifier;
        }

        if (gameObject.name == "BakingB")
        {
            CategoryPref.baking = modifier;
        }


    }
}
