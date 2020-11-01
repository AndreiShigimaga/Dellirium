using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.right*Time.deltaTime*22, Space.World);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (25, GetComponent<Rigidbody2D> ().velocity.y);
	}
}
