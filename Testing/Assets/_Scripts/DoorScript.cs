using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {
	public float range;
	public GameObject Player;
	public Transform Target;
	public int layerMask;
	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		layerMask = 1 << 9;
		layerMask = ~layerMask;

	}
	
	// Update is called once per frame
	void Update () {
		Raycasting ();


	}

	void Raycasting () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, Player.transform.position, out hit, range, layerMask) == true) {
			Teleport();
		}
		print (hit.distance.ToString());
	}

	void Teleport() {
		if (Input.GetKeyDown(KeyCode.E)){
		Player.transform.position = Target.position;
		}
	}


}
