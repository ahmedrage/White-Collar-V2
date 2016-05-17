using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	public Vector3 forward;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		move ();

	}

	void move () {
		
		rb.velocity = Vector3.zero;
		rb.velocity = new Vector3 (Input.GetAxis("Vertical") * speed * transform.forward.x, 0, Input.GetAxis("Vertical") * speed * transform.forward.z);
		rb.velocity += new Vector3 (Input.GetAxis("Horizontal") * speed * transform.right.x, 0, Input.GetAxis("Horizontal") * speed * transform.right.z);

	}
}
