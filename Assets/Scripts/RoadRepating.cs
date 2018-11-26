using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadRepating : MonoBehaviour {

//	private BoxCollider2D groundCollider;      
//	private float groundHorizontalLength;       

	public GameObject[] RoadPieces = new GameObject[3];
	const float RoadLength = 100f; 
	const float RoadSpeed = 1.2f;
	void Update ()
	{
		foreach (GameObject road in RoadPieces)
		{
			Vector3 newRoadPos = road.transform.position;
			newRoadPos.z += RoadSpeed * Time.deltaTime;
			if (newRoadPos.z < -RoadLength / 3)
			{
				newRoadPos.z += RoadLength;
			}
			road.transform.position = newRoadPos;
		}
	}


//	private void Awake ()
//	{
//		
//		groundCollider = GetComponent<BoxCollider2D> ();
//
//		groundHorizontalLength = groundCollider.size.x;
//	}
//
//
//	private void Update()
//	{
//		
//		if (transform.position.x < -groundHorizontalLength)
//		{
//
//			RepositionBackground ();
//		}
//	}
//
//
//	private void RepositionBackground()
//	{
//		
//		Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
//
//
//		transform.position = (Vector2) transform.position + groundOffSet;
//	}
}
