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
    public GameObject singleCable2;
    public GameObject singleCable3;
    public GameObject singleCable4;
    public GameObject singleCable5;
    public GameObject hitBox;

    //spawn counter
    public static int spawnCounter = 0;

    void Start ()
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
        int random = Random.Range(1, 6);

       GameObject hitboxClone = Instantiate(hitBox, new Vector3(0, 0, hitBox.transform.position.z + 20), hitBox.transform.rotation);
       GameObject cable1Clone = Instantiate(singleCable1, new Vector3(nodePoint1.position.x, nodePoint1.position.y, hitboxClone.transform.position.z ), Quaternion.Euler(0,0,0));
       GameObject cable2Clone = Instantiate(singleCable2, new Vector3(nodePoint2.position.x, nodePoint2.position.y, hitboxClone.transform.position.z ), Quaternion.Euler(0, 0, 0));
       GameObject cable3Clone = Instantiate(singleCable3, new Vector3(nodePoint3.position.x, nodePoint3.position.y, hitboxClone.transform.position.z ), Quaternion.Euler(0, 0, 0));

        spawnCounter++;

        //difficulty increase
        //PlayerController.moveSpeed++;
        //PlayerController.rotSpeed += 10; 
    }
}
