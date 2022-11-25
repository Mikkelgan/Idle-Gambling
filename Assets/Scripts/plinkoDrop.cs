using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plinkoDrop : MonoBehaviour
{

    public GameObject ballPrefab;
    

    //hjælp fra unity til at instantiate https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
    public void ballDrop()
    {
        float randomX = Random.Range(-0.4f, 0.4f);
        float randomY = Random.Range(1.8f, 1.9f);
        float randomZ = Random.Range(0f, 0.1f);

        Instantiate(ballPrefab,new Vector3(randomX,randomY,randomZ),Quaternion.identity);
    }  
    

}
