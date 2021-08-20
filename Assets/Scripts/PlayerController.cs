using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour 
{
	private Scene scene;
	public Rigidbody player;
	private int score = 0;
	public int health = 5;

	public float speed = 2000f;
	
	// Use this for initialization
	void Start () 
	{
		scene = SceneManager.GetActiveScene();
	}

  // Update is called once per frame
	void Update () 
	{
		 if (health == 0)
		 {
			 Debug.Log("Game Over!");
			 SceneManager.LoadScene(scene.name);
		 }
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
			if (other.GetComponent<Collider>().tag == "Pickup")
			{
				score++;
				Destroy(other);
				other.GetComponent<MeshRenderer>().enabled = false;
				Debug.Log("Score: " + score);
			}
			if (other.GetComponent<Collider>().tag == "Trap")
			{
				health--;
				Debug.Log("Health: " + health);
			}

			if (other.GetComponent<Collider>().tag == "Goal")
			{
				Debug.Log("You Win!");
			}


			// Debug.Log(other.GetComponent<Collider>().name);
		}
}
