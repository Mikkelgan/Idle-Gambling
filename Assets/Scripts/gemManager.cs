using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gemManager : MonoBehaviour
{
    public static float totalGems;
    public Text gems;
    public Text chips;

    public static float assistantMLevel = 0;
    public static float assistantMCost = 10;
    public Text assistantMText;
    public Text assistantMCostText;

    public static float addictMLevel = 0;
    public static float addictMCost = 125;
    public Text addictMText;
    public Text addictMCostText;

    public static float pokerMLevel = 0;
    public static float pokerMCost = 750;
    public Text pokerMText;
    public Text pokerMCostText;

    public static float casinoMLevel = 0;
    public static float casinoMCost = 2500;
    public Text casinoMText;
    public Text casinoMCostText;


    private void Update()
    {
        gems.text = totalGems.ToString();

        float roundedChips = Mathf.Floor(Manager.totalClicks * 1f) / 1f;
        chips.text = roundedChips.ToString();

        Manager.totalClicks += ((StoreManager.assistantLevel * 0.5f * (assistantMLevel + 1)) + (StoreManager.addictLevel * 2.5f * (addictMLevel + 1)) + (StoreManager.pokerLevel * 10f * (pokerMLevel + 1)) + (StoreManager.casinoLevel * 50f * (casinoMLevel + 1))) * Time.deltaTime;

        //assistant text
        float roundedAsCost = Mathf.Round(assistantMCost * 1f) / 1f;
        assistantMText.text = $" Lv. {assistantMLevel} assistant";
        assistantMCostText.text = $"{roundedAsCost}G ";
        assistantMCost = 5 + assistantMLevel * 5;

        //gambling addict text
        float roundedAdCost = Mathf.Round(addictMCost * 1f) / 1f;
        addictMText.text = $" Lv. {addictMLevel} gambling addict";
        addictMCostText.text = $"{roundedAdCost}G ";
        addictMCost = 25 + addictMLevel * 25;

        //poker player text
        float roundedPCost = Mathf.Round(pokerMCost * 1f) / 1f;
        pokerMText.text = $" Lv. {pokerMLevel} poker player";
        pokerMCostText.text = $"{roundedPCost}G ";
        pokerMCost = 75 + pokerMLevel * 75;

        //casino text
        float roundedCCost = Mathf.Round(casinoMCost * 1f) / 1f;
        casinoMText.text = $" Lv. {casinoMLevel} casino";
        casinoMCostText.text = $"{roundedCCost}G ";
        casinoMCost = 250 + casinoMLevel * 250;

        
    }

    public void AssistantM()
    {
        if (totalGems >= assistantMCost)
        {
            assistantMLevel++;
            totalGems -= assistantMCost;

        }
    }

    public void AddictM()
    {
        if (totalGems >= addictMCost)
        {
            addictMLevel++;
            totalGems -= addictMCost;

        }
    }

    public void PokerM()
    {
        if (totalGems >= pokerMCost)
        {
            pokerMLevel++;
            totalGems -= pokerMCost;

        }
    }

    public void CasinoM()
    {
        if (totalGems >= casinoMCost)
        {
            casinoMLevel++;
            totalGems -= casinoMCost;

        }
    }
}
