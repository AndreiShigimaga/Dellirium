using UnityEngine;
using System.Collections;

public class hummer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, 1 * Time.deltaTime*4000);
		transform.Translate (Vector3.left * Time.deltaTime*20, Space.World);
	}
}
