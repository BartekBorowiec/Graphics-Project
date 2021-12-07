using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    public float RotationSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down, RotationSpeed * Time.deltaTime);
    }
}
