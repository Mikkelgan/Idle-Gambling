using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    public Text totalClicksText;
    public static float totalClicks;

    public GameObject Jeton;

  
    private void Start()
    {
        totalClicksText.text = totalClicks.ToString();
    }

    public void AddClicks()
    {
        totalClicks += 1 * StoreManager.chipMulti[StoreManager.chipLevel];
        totalClicksText.text = totalClicks.ToString();
    }

    void Update()
    {
        float roundedChips = Mathf.Floor(totalClicks * 1f) / 1f;
        totalClicksText.text = roundedChips.ToString();

        totalClicks += ((StoreManager.assistantLevel * 0.5f) + (StoreManager.addictLevel * 2.5f) + (StoreManager.pokerLevel * 10f) + (StoreManager.casinoLevel * 50f)) * Time.deltaTime;

    }

}