using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int clicksForAd = 20;
    
    public Text TotalClicksText;

    float totalClicks;


    public GameObject Jeton;
    public GameObject AD;


    public void AddClicks()
    {
        totalClicks++;
        TotalClicksText.text = totalClicks.ToString("0");
    }

    void Update()
    {
        if (TotalClicksText.text == clicksForAd.ToString())
        {

            Jeton.SetActive(false);
            AD.SetActive(true);
        }
    }
}
