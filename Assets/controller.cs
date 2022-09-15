using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 2.0f;

    public Camera pbCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCtrl();
        RotateCtrl();
    }
    void MoveCtrl()
    {
        if (Input.GetMouseButton(0))
        {
            this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
    void RotateCtrl()
    { 
        if(Input.GetMouseButton(1)){
           float rotX = Input.GetAxis("Mouse Y") * rotateSpeed;
           float rotY = Input.GetAxis("Mouse X") * rotateSpeed;
           this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);
            pbCam.transform.localRotation *= Quaternion.Euler(rotX, 0, 0);
        }
        
    }
}
