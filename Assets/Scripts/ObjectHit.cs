using UnityEngine;

public class HitObject : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.tag = "Hit";
            GetComponent<MeshRenderer>().material.color = Color.magenta;
            //Debug.Log("Hit");
        }
    }
}
