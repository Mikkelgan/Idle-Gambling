using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text TotalClicksText;

    float totalClicks;

    public void AddClicks()
    {
        totalClicks++;
        TotalClicksText.text = totalClicks.ToString("0");
    }
}
