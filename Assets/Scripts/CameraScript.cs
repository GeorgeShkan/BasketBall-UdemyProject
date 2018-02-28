using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    //mera camera;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Camera camera = GetComponentInChildren<Camera>();

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);
        camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler(-mouseY,0, 0);
        
    }
}
