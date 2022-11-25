using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public Text Chips;
    
    float assistantLevel = 0;
    float assistantCost;
    public Text assistantText;

    

    // Start is called before the first frame update
    void Start()
    {
        Chips.text = Manager.totalClicks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Assistant()
    {
        assistantCost = 10 + assistantLevel * 1.15f;
        if (Manager.totalClicks >= assistantCost)
        {
            assistantLevel++;
            Manager.totalClicks -= assistantCost;
            Chips.text = Manager.totalClicks.ToString();
        }
    }
}
