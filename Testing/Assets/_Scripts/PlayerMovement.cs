using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector3 (Input.GetAxis("Vertical") * speed, 0, Input.GetAxis("Horizontal") * -speed);
	}
}
