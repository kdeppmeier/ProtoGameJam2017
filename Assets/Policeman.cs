using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Policeman : MonoBehaviour {
	private Vector2 MovingDirection = Vector2.left;	//initial movement direction

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		UpdateMovement ();
	}

	void UpdateMovement(){
		if (this.transform.position.x > 3.5f) {
			MovingDirection = Vector2.left;
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;

		} else if (this.transform.position.x < -3.5f) {
			MovingDirection = Vector2.right;
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;

		}
		this.transform.Translate (MovingDirection * Time.smoothDeltaTime);	
	}
}