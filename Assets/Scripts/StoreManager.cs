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
    public static float pokerCost = 300;
    public Text pokerText;
    public Text pokerCostText;

    public static float casinoLevel = 0;
    public static float casinoCost = 1500;
    public Text casinoText;
    public Text casinoCostText;

    
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
        pokerCost = 300 + pokerLevel * pokerLevel * 11.2f;

        //casino text
        float roundedCCost = Mathf.Round(casinoCost * 1f) / 1f;
        casinoText.text = $" Lv. {casinoLevel} casino";
        casinoCostText.text = $"{roundedCCost}$ ";
        casinoCost = 1500 + casinoLevel * casinoLevel * 34.8f;

        //passive income
        Manager.totalClicks += ((assistantLevel * 0.1f) + (addictLevel * 0.5f) + (pokerLevel * 2.5f) + (casinoLevel * 10f)) * Time.deltaTime;
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
}
