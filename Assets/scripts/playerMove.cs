using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMove : MonoBehaviour {

	private Rigidbody2D playerRigidbody;
	private int currentScore = 0;
	public Text scoreTextUI;

	// Use this for initialization
	void Start () {
		currentScore = 0;
		scoreTextUI.text = "Score: " + currentScore;

		playerRigidbody = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			print("I AM SPACEBAR");

			playerRigidbody.velocity = new Vector2(0,0);

			Vector2 tempForce = new Vector2(0,200);

			playerRigidbody.AddForce(tempForce);
		}
	}

	void OnCollisionEnter2D(Collision2D thingIAmCollidingWith){

		if (thingIAmCollidingWith.gameObject.tag == "obstacle") {

			print(thingIAmCollidingWith.gameObject.tag);
			Application.LoadLevel (Application.loadedLevel);
		};
	
	}
	void OnTriggerEnter2D(Collider2D thingIAmCollidingWith){
		if (thingIAmCollidingWith.gameObject.tag == "coin") {

			currentScore = currentScore + 1;
			scoreTextUI.text = "Score: " + currentScore;
			print("Got Money! Now I have " +  currentScore);
			Destroy(thingIAmCollidingWith.gameObject);
		};
	}
}
