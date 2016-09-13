using UnityEngine;
using System.Collections;

public class CharacterBehaviour : MonoBehaviour {

	public float force = 10f;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			anim.SetBool ("isJumping", true);
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * force);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.gameObject.tag == "Hill")
			anim.SetBool ("isJumping", false);

	}
}
