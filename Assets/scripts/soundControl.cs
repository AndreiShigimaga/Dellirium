using UnityEngine;
using System.Collections;

public class soundControl : MonoBehaviour {

	public AudioSource efxSource;
	public AudioSource musicSource;
	public static soundControl instanse = null;

	public float lowPitch = 0.95f;
	public float maxPitch = 1.05f;

	void Awake(){
		if (instanse==null) 
			instanse = this;
		else if (instanse!=this) 
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	
	}

	public void PlaySingle(AudioClip clip)
	{
		efxSource.clip = clip;
		efxSource.Play ();
	
	}

	public void RandomizeSfx(params AudioClip[]clips)
	{
		int rIndex = Random.Range (0, clips.Length);
		float rPitch = Random.Range (lowPitch, maxPitch);

		efxSource.pitch = rPitch;
		efxSource.clip = clips [rIndex];
		efxSource.Play ();
	}
	public void Stop (AudioClip clip)
	{
		efxSource.clip = clip;
		efxSource.Stop ();
	}

}
