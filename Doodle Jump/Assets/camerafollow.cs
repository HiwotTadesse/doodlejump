using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {


    public Transform target;

    public float smooth = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(transform.position.y < target.transform.position.y)
        {

            Vector3 vec = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(this.transform.position, vec, smooth);
        }
	}
}
