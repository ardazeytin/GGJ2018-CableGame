using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    //cable spawn center points
    //public Vector3 centerNodePoint;
    public Transform nodePoint1;
    public Transform nodePoint2;
    public Transform nodePoint3;

    //cable prefabs
    public GameObject singleCable1;
    public GameObject hitBox;

    void Start ()
    {
        //centerNodePoint = new Vector3(0, 0, 0);
        //nodePoint1 = new Vector3(-1, 1, 0); //top left
        //nodePoint2 = new Vector3(1, 1, 0); //top right
        //nodePoint3 = new Vector3(0, -1, 0); //bottom center

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SpawnCable();
        }
    }

    void SpawnCable()
    {
        //vector3 position will change

       GameObject hitboxClone = Instantiate(hitBox, new Vector3(0, 0, hitBox.transform.position.z + 8), hitBox.transform.rotation);
       GameObject cable1Clone = Instantiate(singleCable1, new Vector3(nodePoint1.position.x, nodePoint1.position.y, hitboxClone.transform.position.z ), nodePoint1.rotation);
       GameObject cable2Clone = Instantiate(singleCable1, new Vector3(nodePoint2.position.x, nodePoint2.position.y, hitboxClone.transform.position.z ), nodePoint2.rotation);
       GameObject cable3Clone = Instantiate(singleCable1, new Vector3(nodePoint3.position.x, nodePoint3.position.y, hitboxClone.transform.position.z ), nodePoint3.rotation);
    }
}
