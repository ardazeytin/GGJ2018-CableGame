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


    private Vector3 cableClone1LastPosition;

    private int nodeCounter = 1;

    void Start ()
    {
        //centerNodePoint = new Vector3(0, 0, 0);
        //nodePoint1 = new Vector3(-1, 1, 0); //top left
        //nodePoint2 = new Vector3(1, 1, 0); //top right
        //nodePoint3 = new Vector3(0, -1, 0); //bottom center

        cableClone1LastPosition = nodePoint1.transform.position;
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
       GameObject cable1Clone = Instantiate(singleCable1, new Vector3(cableClone1LastPosition.x, cableClone1LastPosition.y, cableClone1LastPosition.z + 8), nodePoint1.rotation);
       cableClone1LastPosition = cable1Clone.transform.position;
       GameObject cable2Clone = Instantiate(singleCable1, new Vector3(nodePoint2.position.x, nodePoint2.position.y, nodePoint2.transform.position.z + nodeCounter * 8), nodePoint2.rotation);
       GameObject cable3Clone = Instantiate(singleCable1, new Vector3(nodePoint3.position.x, nodePoint3.position.y, nodePoint3.transform.position.z + nodeCounter * 8), nodePoint3.rotation);

       GameObject hitboxClone = Instantiate(hitBox, new Vector3(0, 0, hitBox.transform.position.z + 8), hitBox.transform.rotation);
       nodeCounter++;
    }
}
