using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    //cable spawn center points
    public Vector3 centerNodePoint;
    public Vector3 nodePoint1;
    public Vector3 nodePoint2;
    public Vector3 nodePoint3;

    //cable prefabs
    public Transform singleCable1;


    void Start ()
    {
        centerNodePoint = new Vector3(0, 0, 0);
        nodePoint1 = new Vector3(-1, 1, 0); //top left
        nodePoint2 = new Vector3(1, 1, 0); //top right
        nodePoint3 = new Vector3(0, -1, 0); //bottom center
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        SpawnCable();
    }

    void SpawnCable()
    {
        //vector3 position will change
        Instantiate(singleCable1, new Vector3(0, 0, transform.parent.position.z + 154f), singleCable1.rotation);
    }
}
