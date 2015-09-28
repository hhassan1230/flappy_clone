using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnBullet : MonoBehaviour {
	public List<GameObject> levels;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("createBullet", 3, 3);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void createBullet () {
		Instantiate (levels[0], (transform.position), transform.rotation);
	}
}
