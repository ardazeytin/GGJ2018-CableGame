using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotSpeed;
    public float moveSpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //int random = Random.Range(1, 4);

            //if (random==1)
            //{
            //    this.transform.position = new Vector3(-2, 0, 0);
            //}
            //else if (random==2)
            //{
            //    this.transform.position = new Vector3(2, 0, 0);
            //}
            //else if (random==3)
            //{
            //    this.transform.position = new Vector3(0, 2, 0);
            //}

            CheckAvailableNode();
        }

        
        Debug.DrawRay(transform.position + transform.forward, transform.forward * 3, Color.red);
    }

    void CheckAvailableNode()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.GetChild(0).transform.position, transform.GetChild(0).transform.forward, out hit))
        {
            Debug.Log("Line hit object name: " + hit.collider.gameObject.name);
            transform.position = hit.collider.gameObject.transform.position;
        }
    }

}
