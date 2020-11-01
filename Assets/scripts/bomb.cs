using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {
	Animator anim;
	public Rigidbody2D rb;
	public GameObject bm;

	public AudioClip fall;
	public AudioClip boom;
	//public GameObject rocket;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		var bm = GameObject.Find ("Rocket");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		
	
		if (col.gameObject.tag == "Player") {
			

			soundControl.instanse.RandomizeSfx (fall, fall);

			

				anim.SetBool ("isBombFall", true);
				//if (GetComponent<AudioClip>().name=="death") {
			//	soundControl.instanse.Stop (GetComponent<AudioClip> ().name == "death");
			//	}
			  
				soundControl.instanse.PlaySingle( boom);
			
				StartCoroutine ("pause");


			}

	}
	IEnumerator pause()
	{
		yield return new WaitForSeconds (0.5f);

		Destroy (bm.gameObject);

	}
}
