using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneParentTrigger : MonoBehaviour
{

    public GameObject Plane;
    public GameObject Pivot1;
    public GameObject Pivot2;

    public bool Pivot1Parent = true; 
    public bool Pivot2Parent = false; 

    public float rotationSpeed; 

    void OnTriggerEnter(Collider other){

        
        if (Pivot1Parent == true){
            Pivot2Parent = true;
            Pivot1Parent = false;
        }
        else if(Pivot2Parent == true){
            Pivot1Parent = true; 
            Pivot2Parent = false;
            
            
        }
        
        
    }

    void Update()
    {
        if (Pivot2Parent == true){
            Plane.transform.parent = Pivot2.transform; 
        }
        if(Pivot1Parent == true){
            Plane.transform.parent = Pivot1.transform; 
        }
        
    }

    
}
