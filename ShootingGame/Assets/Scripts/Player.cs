using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	// speed
	public float speed = 5 ;

	// Direction
	public	Vector2 direction = new Vector2(0,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// LR
		float x = Input.GetAxisRaw ("Horizontal");
		// UD
		float y = Input.GetAxisRaw ("Vertical");

		direction = new Vector2 (x, y).normalized;

		rigidbody2D.velocity = direction * speed;
	}
}
