using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnBullet : MonoBehaviour {
	public List<GameObject> levels;
	private Vector3 tmpPosition;
	private float xPosition;
	private float h = 1.0f;
	private float g;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("createBullet", 3, 3);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void createBullet () {
//		g = ;
		xPosition = transform.position.x - 1.0f;
//		Vector3 rowX = new Vector3 (i,0,0)
		Vector3 tmpPosition = new Vector3 (xPosition, transform.position.y, transform.position.z);
		Instantiate (levels[0], (tmpPosition), transform.rotation);
	}
}
