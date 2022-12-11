using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    public Text totalClicksText;
    public static float totalClicks;
    public Text gems;

    private void Start()
    {
        totalClicksText.text = totalClicks.ToString();
        gems.text = gemManager.totalGems.ToString();
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

        totalClicks += ((StoreManager.assistantLevel * 0.5f * (gemManager.assistantMLevel + 1)) + (StoreManager.addictLevel * 2.5f * (gemManager.addictMLevel + 1)) + (StoreManager.pokerLevel * 10f * (gemManager.pokerMLevel + 1)) + (StoreManager.casinoLevel * 50f * (gemManager.casinoMLevel + 1))) * Time.deltaTime;

    }

}