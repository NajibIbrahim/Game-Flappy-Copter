using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacieinAct : MonoBehaviour {

public Vector2 veloc = new Vector2(-4,0);
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = veloc;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
