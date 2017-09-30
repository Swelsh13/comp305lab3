using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float speed = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float xInput = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		//print (xInput);
		transform.position = new Vector3 (transform.position.x + xInput,0,0);

	}
}
