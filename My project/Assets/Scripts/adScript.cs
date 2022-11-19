using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adScript : MonoBehaviour
{

    public Text Clicks;

    public GameObject Jeton;
    public GameObject AD;

    // Update is called once per frame
    void Update()
    {
        if (Clicks.text == "100")
        {
            Jeton.SetActive(false);
            AD.SetActive(true);
        }
    }
}
