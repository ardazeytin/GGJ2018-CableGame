using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StartCoroutine("DestroyObject");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(18);
        Destroy(gameObject);
    }
}
