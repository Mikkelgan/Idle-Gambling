using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Text totalClicksText;
    public static float totalClicks;

    public GameObject Jeton;

    float plinkoCost = 2500;
    public TextMeshPro plinkoText;
    bool plinko = false;

    float diceCost = 10000;
    public TextMeshPro diceText;
    bool dice = false;

    float crashCost = 50000;
    public TextMeshPro crashText;
    bool crash = false;

    float rouletteCost = 150000;
    public TextMeshPro rouletteText;
    bool roulette = false;

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

    public void Plinko()
    {
        if (plinko)
        {
            SceneManager.LoadScene("Plinko");
        }
        else if (totalClicks >= plinkoCost)
        {
            totalClicks -= plinkoCost;
            plinko = true;

        }
    }

    public void Dice()
    {
        if (dice)
        {
            SceneManager.LoadScene("Dice");
        }
        else if (totalClicks >= diceCost)
        {
            totalClicks -= diceCost;
            dice = true;

        }
    }

    public void Crash()
    {
        if (crash)
        {
            SceneManager.LoadScene("Crash");
        }
        else if (totalClicks >= crashCost)
        {
            totalClicks -= crashCost;
            crash = true;

        }
    }

    public void Roulette()
    {
        if (roulette)
        {
            SceneManager.LoadScene("Roulette");
        }
        else if (totalClicks >= rouletteCost)
        {
            totalClicks -= rouletteCost;
            roulette = true;

        }
    }
}