using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public Text Chips;
    float Amount = Manager.totalClicks;
    

    // Start is called before the first frame update
    void Start()
    {
        Chips.text = Amount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
