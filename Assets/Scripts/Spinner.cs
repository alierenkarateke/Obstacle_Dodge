using System.Diagnostics;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] Vector3 values;
    [SerializeField] float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(values * speed * Time.deltaTime);
    }
}
