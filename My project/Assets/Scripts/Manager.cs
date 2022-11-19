using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int clicksForAd = 100;
    bool adPlay;

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

            adPlay = true;
        }

        if (Input.GetMouseButtonDown(0) && adPlay == true)
        {
            Jeton.SetActive(true);
            AD.SetActive(false);
            adPlay = false;
            totalClicks = totalClicks + 1;
            TotalClicksText.text = totalClicks.ToString();
        }
    }
}