using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plinkoBall : MonoBehaviour
{

    public float amount;

    public static float bigMulti = 1.2f;
    public static float medMulti = 1f;
    public static float smallMulti = 0.8f;

    private void Start()
    {
        amount = plinkoDrop.betAmount;
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("big multi"))
        {
            Manager.totalClicks += amount * bigMulti;
            Destroy(this.gameObject);

        }

        else if (other.gameObject.CompareTag("medium multi"))
        {
            Manager.totalClicks += amount * medMulti;
            Destroy(this.gameObject);
        }

        else if (other.gameObject.CompareTag("small multi"))
        {
            Manager.totalClicks += amount * smallMulti;
            Destroy(this.gameObject);
        }
    }

}
