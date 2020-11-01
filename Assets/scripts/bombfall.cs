using UnityEngine;
using System.Collections;

public class bombfall : MonoBehaviour {
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D col)
	{
		//if (col.gameObject.tag=="Player") {
		//	rb.isKinematic = false;
		//}

	}
}
