using UnityEngine;
using System.Collections;

public class strelka : MonoBehaviour {

	public Vector3 pointB;
	public Vector3 pointA;
	// Use this for initialization

	IEnumerator Start()
	{
		var pointA = transform.position;
		while (true) {
			yield return StartCoroutine(MoveObject(transform, pointA, pointB, 1.0f));
			yield return StartCoroutine(MoveObject(transform, pointB, pointA, 1.0f));
		}
	}

	IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		var i= 0.0f;
		var rate= 5.0f/time;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return null; 
		}
	}
	// Update is called once per frame
	void Update () {
		StartCoroutine ("Start");
		//StartCoroutine (MoveObject(gameObject.transform,pointA,pointB,10));
	}
}
