using UnityEngine;
using System.Collections;

public class sawscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, 1 * Time.deltaTime*90);

	}
}
