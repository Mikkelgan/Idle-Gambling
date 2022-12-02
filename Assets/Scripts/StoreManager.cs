using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public Text Chips;
    
    public static float assistantLevel = 0;
    public static float assistantCost = 10;
    public Text assistantText;
    public Text assistantCostText;

    public static float addictLevel = 0;
    public static float addictCost = 125;
    public Text addictText;
    public Text addictCostText;

    public static float pokerLevel = 0;
    public static float pokerCost = 750;
    public Text pokerText;
    public Text pokerCostText;

    public static float casinoLevel = 0;
    public static float casinoCost = 2500;
    public Text casinoText;
    public Text casinoCostText;

    public static int chipLevel = 1;
    public static float[] chipCost = new float[] { 0, 500, 2000, 7500, 50000, 150000, 750000, 1500000, 4000000, 10000000 };
    public static float[] chipMulti = new float[] { 0, 1, 2, 5, 10, 20, 50, 100, 200, 500 };
    public Text chipText;
    public Text chipCostText;

    
    void Start()
    {
        Chips.text = Manager.totalClicks.ToString();
        
    }
    
    void Update()
    {
        float roundedChips = Mathf.Floor(Manager.totalClicks * 1f) / 1f;
        Chips.text = roundedChips.ToString();

        //assistant text
        float roundedAsCost = Mathf.Round(assistantCost * 1f) / 1f;
        assistantText.text = $" Lv. {assistantLevel} assistant";
        assistantCostText.text = $"{roundedAsCost}$ ";
        assistantCost = 10 + assistantLevel * assistantLevel * 0.7f;

        //gambling addict text
        float roundedAdCost = Mathf.Round(addictCost * 1f) / 1f;
        addictText.text = $" Lv. {addictLevel} gambling addict";
        addictCostText.text = $"{roundedAdCost}$ ";
        addictCost = 125 + addictLevel * addictLevel * 2.3f;

        //poker player text
        float roundedPCost = Mathf.Round(pokerCost * 1f) / 1f;
        pokerText.text = $" Lv. {pokerLevel} poker player";
        pokerCostText.text = $"{roundedPCost}$ ";
        pokerCost = 750 + pokerLevel * pokerLevel * 11.2f;

        //casino text
        float roundedCCost = Mathf.Round(casinoCost * 1f) / 1f;
        casinoText.text = $" Lv. {casinoLevel} casino";
        casinoCostText.text = $"{roundedCCost}$ ";
        casinoCost = 2500 + casinoLevel * casinoLevel * 34.8f;

        //chip text
        chipText.text = $" Lv. {chipLevel} casino";
        chipCostText.text = $"{chipCost[chipLevel]}$ ";

        //passive income
        Manager.totalClicks += ((assistantLevel * 0.5f) + (addictLevel * 2.5f) + (pokerLevel * 10f) + (casinoLevel * 50f)) * Time.deltaTime;
    }

    public void Assistant()
    {
        if (Manager.totalClicks >= assistantCost)
        {
            assistantLevel++;
            Manager.totalClicks -= assistantCost;
            
        }
    }

    public void Addict()
    {
        if (Manager.totalClicks >= addictCost)
        {
            addictLevel++;
            Manager.totalClicks -= addictCost;

        }
    }

    public void Poker()
    {
        if (Manager.totalClicks >= pokerCost)
        {
            pokerLevel++;
            Manager.totalClicks -= pokerCost;

        }
    }

    public void Casino()
    {
        if (Manager.totalClicks >= casinoCost)
        {
            casinoLevel++;
            Manager.totalClicks -= casinoCost;

        }
    }

    public void Chip()
    {
        if (Manager.totalClicks >= chipCost[chipLevel])
        {
            Manager.totalClicks -= chipCost[chipLevel];
            chipLevel++;
        }
    }
}
