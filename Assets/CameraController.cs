using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    public float cameraSens;
    [SerializeField]
    public float NormalSpeed;
    [SerializeField]
    public float FastSpeed;
    
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * cameraSens * Time.deltaTime;
        rotationY += Input.GetAxis("Mouse Y") * cameraSens * Time.deltaTime;
        rotationY = Mathf.Clamp (rotationY, -90, 90);

        transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
        transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);

        if(Input.GetKey (KeyCode.LeftShift)){
            transform.position += transform.forward * (FastSpeed) * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.position += transform.right * (FastSpeed) * Input.GetAxis("Horizontal") * Time.deltaTime;

        }else
        {
            transform.position += transform.forward * (NormalSpeed) * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.position += transform.right * (NormalSpeed) * Input.GetAxis("Horizontal") * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.Space)){
            transform.position += transform.up * NormalSpeed * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.Space) && Input.GetKey(KeyCode.LeftShift)){
            transform.position += transform.up * FastSpeed * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.LeftControl)){
            transform.position -= transform.up * NormalSpeed * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftShift)){
            transform.position -= transform.up * FastSpeed * Time.deltaTime;
        }
        
        if (Input.GetKeyDown (KeyCode.Escape)){
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Locked;
           
        }

        
       
        
    }
    }
