using Unity.Collections;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitNumber = 0;
    void OnCollisionEnter(Collision other)
    {   
        if(other.gameObject.tag != "Hit")
        {
            hitNumber++;
            Debug.Log("Hit for " + hitNumber + " times"); 
        }
        
    }
}
