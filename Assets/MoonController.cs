using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonController : MonoBehaviour
{

    public float MoonDistance = 1000.0f;
    public float Moonsize = 15.0f; 

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y, MoonDistance);
        transform.localScale = new Vector3 (Moonsize, Moonsize, Moonsize);
    }

    
}
