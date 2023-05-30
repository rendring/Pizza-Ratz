using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExampleScript : MonoBehaviour
{
    int myNumber;
    public Text numberText;

    void Start()
    {
        myNumber = 0;
        numberText.text = myNumber.ToString();
    }

    public void IncreaseNumber()
    {
        myNumber += 1;
        numberText.text = myNumber.ToString();
    }
}
