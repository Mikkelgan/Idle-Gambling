using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class plinkoDrop : MonoBehaviour
{

    public GameObject ballPrefab;
    public TMP_InputField betInput;
    public static float betAmount;


    private void Start()
    {
        
    }


    //hjælp fra unity til at instantiate https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
    public void ballDrop()
    {
        betAmount = float.Parse(betInput.text);
        if (Manager.totalClicks >= betAmount)
        {
            Manager.totalClicks -= betAmount;
            float randomX = Random.Range(-0.4f, 0.4f);
            float randomY = Random.Range(1.8f, 1.9f);
            float randomZ = Random.Range(0f, 0.1f);

            Instantiate(ballPrefab, new Vector3(randomX, randomY, randomZ), Quaternion.identity);
        }



    }

    

}
