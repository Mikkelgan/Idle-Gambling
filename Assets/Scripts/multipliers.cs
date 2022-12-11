using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class multipliers : MonoBehaviour
{
    public Text chips;
    public Text gems;


    public TextMeshProUGUI bigmult1;
    public TextMeshProUGUI bigmult2;
    public TextMeshProUGUI medmult1;
    public TextMeshProUGUI medmult2;
    public TextMeshProUGUI smallmult;

    // Start is called before the first frame update
    void Start()
    {
        chips.text = Manager.totalClicks.ToString();
        gems.text = gemManager.totalGems.ToString();

        bigmult1.text = $"{plinkoBall.bigMulti.ToString()}x";
        bigmult2.text = $"{plinkoBall.bigMulti.ToString()}x";
        medmult1.text = $"{plinkoBall.medMulti.ToString()}x";
        medmult2.text = $"{plinkoBall.medMulti.ToString()}x";
        smallmult.text = $"{plinkoBall.smallMulti.ToString()}x";
    }

    // Update is called once per frame
    void Update()
    {
        

        float roundedChips = Mathf.Floor(Manager.totalClicks * 1f) / 1f;
        chips.text = roundedChips.ToString();

        Manager.totalClicks += ((StoreManager.assistantLevel * 0.5f * (gemManager.assistantMLevel + 1)) + (StoreManager.addictLevel * 2.5f * (gemManager.addictMLevel + 1)) + (StoreManager.pokerLevel * 10f * (gemManager.pokerMLevel + 1)) + (StoreManager.casinoLevel * 50f * (gemManager.casinoMLevel + 1))) * Time.deltaTime;
    }

 
}
