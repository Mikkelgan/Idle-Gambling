using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class minigameUnlock : MonoBehaviour
{
    public Sprite unlocked;

    float plinkoCost = 2500;
    public TextMeshProUGUI plinkoText;
    public Button plinkoBtn;
    bool plinko = false;

    float diceCost = 10000;
    public TextMeshProUGUI diceText;
    public Button diceBtn;
    bool dice = false;

    float crashCost = 50000;
    public TextMeshProUGUI crashText;
    public Button crashBtn;
    bool crash = false;

    float rouletteCost = 150000;
    public TextMeshProUGUI rouletteText;
    public Button rouletteBtn;
    bool roulette = false;

   
    public void Plinko()
    {
        if (plinko)
        {
            SceneManager.LoadScene("Plinko");
        }
        else if (Manager.totalClicks >= plinkoCost)
        {
            Manager.totalClicks -= plinkoCost;
            plinko = true;
            plinkoText.color = new Color(255f, 255f, 255f);
            plinkoBtn.GetComponent<Image>().sprite = unlocked;

        }
    }

    public void Dice()
    {
        if (dice)
        {
            SceneManager.LoadScene("Dice");
        }
        else if (Manager.totalClicks >= diceCost)
        {
            Manager.totalClicks -= diceCost;
            dice = true;
            diceText.color = new Color(255f, 255f, 255f);
            diceBtn.GetComponent<Image>().sprite = unlocked;
        }
    }

    public void Crash()
    {
        if (crash)
        {
            SceneManager.LoadScene("Crash");
        }
        else if (Manager.totalClicks >= crashCost)
        {
            Manager.totalClicks -= crashCost;
            crash = true;
            crashText.color = new Color(255f, 255f, 255f);
            crashBtn.GetComponent<Image>().sprite = unlocked;
        }
    }

    public void Roulette()
    {
        if (roulette)
        {
            SceneManager.LoadScene("Roulette");
        }
        else if (Manager.totalClicks >= rouletteCost)
        {
            Manager.totalClicks -= rouletteCost;
            roulette = true;
            rouletteText.color = new Color(255f, 255f, 255f);
            rouletteBtn.GetComponent<Image>().sprite = unlocked;
        }
    }
}
