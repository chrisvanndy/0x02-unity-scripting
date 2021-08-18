using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public Rigidbody player;
	private int score = 0;

	public float speed = 2000f;
	
	// Use this for initialization
	/*	void Start () 
	{
		
	}*/
	
  // Update is called once per frame
	void Update () 
	{
		 if (Input.GetKey("a") || Input.GetKey("left")) 
		 {
			  player.AddForce(-speed * Time.deltaTime, 0, 0);
		 }
		 if (Input.GetKey("d") || Input.GetKey("right"))
		 {
			  player.AddForce(speed * Time.deltaTime, 0, 0);
		 }
		 if (Input.GetKey("w") || Input.GetKey("up"))
		 {
			  player.AddForce(0, 0, speed * Time.deltaTime);
		 }
		 if (Input.GetKey("s") || Input.GetKey("down"))
		 {
			  player.AddForce(0, 0, -speed * Time.deltaTime);
		 
		 }
	}

		void OnTriggerEnter(Collider other)
		{
			Debug.Log(other.collider.name);
		}
}
