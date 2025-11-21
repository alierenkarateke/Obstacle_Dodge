using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 0f;

    Vector3 targetPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        
        targetPosition = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }
    
    void MoveToPlayer()
    {
       transform.position = 
       Vector3.MoveTowards(transform.position,targetPosition,speed * Time.deltaTime); 
    }
    
    void DestroyWhenReached()
    {
     if(transform.position == targetPosition)
        {
            Destroy(gameObject);
        }   
    }
}
