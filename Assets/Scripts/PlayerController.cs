using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rb2d;

	public float speed;

	void Start(){
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 vec2 = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (vec2 * speed);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("PickUp")){
			other.gameObject.SetActive(false);
		}
	}
}
