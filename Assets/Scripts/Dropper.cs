using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float waitTime = 0f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
    }
    
    void Update()
    {
        //Debug.Log(Time.time);

        if(Time.time > waitTime)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
