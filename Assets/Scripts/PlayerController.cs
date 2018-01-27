using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotSpeed;
    public float moveSpeed;
    private GameObject mainCamera;

    void Start ()
    {
        mainCamera = Camera.main.gameObject;
    }
	
	void Update ()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckNodeAndJump();
        }

        //Draw line from electron parent
        Debug.DrawRay(transform.position + transform.forward, transform.forward * 3, Color.red);
    }

    void LateUpdate()
    {
        mainCamera.transform.position = new Vector3(0, 9, gameObject.transform.position.z - 8);
    }

    //if ray hit a node, jump on
    void CheckNodeAndJump()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.GetChild(0).transform.position, transform.GetChild(0).transform.forward, out hit))
        {
            Debug.Log("Line hit object name: " + hit.collider.gameObject.name);
            transform.position = hit.collider.gameObject.transform.position;
        }
    }

    void Move()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }

}
