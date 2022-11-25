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
        float roundedChips = Mathf.Floor(totalClicks * 1f) / 1f;
        totalClicksText.text = roundedChips.ToString();

        totalClicks += ((StoreManager.assistantLevel * 0.1f) + (StoreManager.addictLevel * 0.5f)) * Time.deltaTime;

    }
}