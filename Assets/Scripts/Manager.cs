using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int clicksForAd = 100;
    bool adPlay;

    public Text totalClicksText;

    public static float totalClicks;


    public GameObject Jeton;
    public GameObject AD;

    private void Start()
    {
        totalClicksText.text = totalClicks.ToString();
    }

    public void AddClicks()
    {
        totalClicks++;
        totalClicksText.text = totalClicks.ToString();
    }

    void Update()
    {
        if (totalClicksText.text == clicksForAd.ToString())
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
            totalClicksText.text = totalClicks.ToString();
        }
    }
}