using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public Text Chips;
    
    public static float assistantLevel = 1;
    public static float assistantCost = 10;
    public Text assistantText;
    public Text assistantCostText;

    

    // Start is called before the first frame update
    void Start()
    {
        Chips.text = Manager.totalClicks.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        assistantText.text = $" Lv. {assistantLevel} assistant";
        assistantCostText.text = $"{assistantCost}$ ";
    }
    public void Assistant()
    {
        assistantCost = 10 + assistantLevel * assistantLevel * 0.15f;
        if (Manager.totalClicks >= assistantCost)
        {
            assistantLevel++;
            Manager.totalClicks -= assistantCost;
            Chips.text = Manager.totalClicks.ToString();
            
        }
    }
}
