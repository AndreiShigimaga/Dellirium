using UnityEngine;
using System.Collections;

public class spring : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator> ();
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag=="Player") {
			anim.SetBool ("isPushed", true);

		}

	}
}
