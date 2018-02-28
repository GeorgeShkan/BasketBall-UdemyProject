using UnityEngine;
using System.Collections;

public class BallSpawn : MonoBehaviour {

    public GameObject ballPrefab;
    public float speed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //  float speed = 5.0f;
        Camera camera = GetComponentInChildren<Camera>();

        if (Input.GetButtonDown("Fire1"))
            {
            GameObject instance = Instantiate(ballPrefab);
            instance.transform.position = transform.position;
            Rigidbody rigidBody = instance.GetComponent<Rigidbody>();
            rigidBody.velocity = camera.transform.rotation * Vector3.forward * speed;
            }
        }
    }
