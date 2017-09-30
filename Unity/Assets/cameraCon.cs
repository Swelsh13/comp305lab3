using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCon : MonoBehaviour {
	public Transform Player; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.position.x < -3.04f && Player.position.x > -9.69f) {
		//green
			transform.position = new Vector3(Player.position.x, transform.position.y,transform.position.z);
			Camera.main.orthographicSize = 3;
		}else if(Player.position.x < 3.71f && Player.position.x > -2.93f){
			//black
			transform.position = new Vector3(0,0,transform.position.z);
			Camera.main.orthographicSize = 5;
		}else if(Player.position.x < 10.11f && Player.position.x > 3.71f){
			//red
			transform.position = new Vector3(Player.position.x, transform.position.y,transform.position.z);

			float distance = Player.position.x - 3.73f;
			float amount = distance / 6;
			print (amount);
			Camera.main.orthographicSize = (amount * 4) + 1 ;
		}
	}
}
