using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaracontroller : MonoBehaviour

    
{

    public GameObject bolitaloca;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - bolitaloca.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = bolitaloca.transform.position + offset;
    }
}
