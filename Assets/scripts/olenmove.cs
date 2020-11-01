using UnityEngine;
using System.Collections;

public class olenmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * Time.deltaTime * 10, Space.World);
	}
}
