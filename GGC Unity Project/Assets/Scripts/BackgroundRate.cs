using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRate : MonoBehaviour
{
    public Vector3 rotateDirection = Vector3.forward;
    public float rotateSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateDirection * rotateSpeed * Time.deltaTime);   
    }
}
