using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubemove : MonoBehaviour {
	public GameObject p1, p2, p3,Gameover;
	public bool LeftRotateActive,RightRotateActive;

	public float TurnSpeed = 1f;
	private float leftRight = 1f;
	private float forward = 1f;
	int Speed;
	// Use this for initialization
	void Start () {
		Gameover.SetActive (false);
		Speed = 20;
	}
	void ProcessInput()
	{
		leftRight = Input.GetAxis("Horizontal");
		//forward = Input.GetAxis("Vertical");
	}
	// Update is called once per frame
	void Update () {
		ProcessInput ();
		ConrolPlayer ();
		PathGeneration ();
		GameOverCalling ();
	}
	void OnCollisionEnter(Collision Col)
	{
		if (Col.gameObject.tag == "Enemy") {
			Speed = 0;
			Gameover.SetActive (true);
		}
	}
	public void ConrolPlayer()
	{
		transform.Translate(Vector3.forward * Time.deltaTime*Speed);
		transform.RotateAroundLocal(Vector3.up, leftRight * TurnSpeed * Time.deltaTime);
	}

	public void PathGeneration()
	{
		if (transform.position.z - p1.transform.position.z >= 70) {
			Vector3 Temp = new Vector3(0, 0, 300);
			p1.transform.position += Temp;
		}

		if (transform.position.z - p2.transform.position.z >= 70) {
			Vector3 Temp = new Vector3(0, 0, 300);
			p2.transform.position += Temp;
		}
		if (transform.position.z - p3.transform.position.z >= 70) {
			Vector3 Temp = new Vector3(0, 0, 300);
			p3.transform.position += Temp;
		}
	   }
	  public void GameOverCalling()
	  {
		
		if (transform.position.x >= 5) {
			Speed = 0;
			//Destroy (gameObject);
			Debug.Log ("GameOver1");
			Gameover.SetActive (true);
		}
		if (transform.position.x <= -5) {
			Speed = 0;
			Debug.Log ("GameOver2");
			//Destroy (gameObject);
			Gameover.SetActive (true);
		}
	  }
}
