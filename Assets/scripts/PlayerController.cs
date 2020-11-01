using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 10.0f;
	public float jumpForce = 700f;
	public float move;
	public bool jump = false;//nado li hero prigat
	public bool slide= false;
	public bool dead = false;
	public float targetTime=5.0f;
	public Texture texture;
	Animator anim;
	public GameObject cam;
	public GameObject hole;
	public GameObject hole2;
	private float s;
	///private bool slide=false;
	public LayerMask whatIsGround;
	GameObject body;
	BoxCollider2D bx;
	public AudioClip sound1;
	public AudioClip sound2;
	public AudioClip jump1;
	public AudioClip jump2;
	public AudioClip slide1;
	public AudioClip slide2;
	public AudioClip death;
	public AudioClip collect;
	public TextMesh txt;
	public TextMesh txtTotal;
	//AudioListener al;
//	SpriteRenderer sp;
	//GameObject go;

	public Transform groundcheck;
	private bool grounded=false;
	private string jmpButton = "Jump";
	private string slideButton = "Slide";
	private string stdButton="Stand";

	void Awake()
	{
		groundcheck = transform.Find ("groundcheck");
		anim = GetComponent<Animator> ();
		bx = GetComponent<BoxCollider2D> ();
		var cam = GameObject.Find ("MainCamera");
		var hole = GameObject.Find ("hole");
		var hole2=GameObject.Find ("hole2");
		var txt = GameObject.Find ("ScorePoints");
		var txtTotal = GameObject.Find("heroPoints");
	}

	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		if (anim.GetBool("isDead")) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);
			jumpForce = 0;
			//soundControl.instanse.Stop (death);
		}
        if (move==0)
        {
            anim.SetBool("isDead", true);
        }
		//if (jumpForce!=0) {
		//	s += 1;
		//}

		if (grounded) 
		{
			
			if (Input.GetButtonDown (slideButton)&&!jump&&!dead) {
				
				bx.offset = new Vector2 (0.001770737f, 0.5940651f);
				bx.size = new Vector2 (1.847992f, 1.167073f);
				anim.SetBool ("isSlide", true);
				soundControl.instanse.RandomizeSfx (slide1, slide2);
			
				slide = true;
			}

			if (Input.GetButtonDown (jmpButton) && !slide&&!dead) {				
				jump = true;
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, jumpForce));
				soundControl.instanse.RandomizeSfx (jump1, jump2);

			} 
			jump = false;
			if (Input.GetButtonDown (stdButton)) {
				anim.SetBool ("isSlide", false);
				bx.offset = new Vector2 (0.116951f, 1.050457f);
				bx.size = new Vector2 (1.24426f, 2.045601f);			
				slide=false;
			
			}

		}


		}

	
	void FixedUpdate()
	{
		grounded = Physics2D.Linecast (transform.position, groundcheck.position,whatIsGround);
		move = 1;

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//for death
        if (col.gameObject.tag == "END")
        {
            
            jumpForce = 0;
			txtTotal.fontSize = 35;
			txtTotal.text = string.Format("ShiGAME Over {0}",s.ToString ());

            dead = true;
			StartCoroutine ("CompleteGame");
        }

		if (col.gameObject.tag == "death") {
			anim.SetBool("isDead",true);
			dead = true;
			soundControl.instanse.PlaySingle (death);
			txt.text = "";
			txtTotal.text = s.ToString ();
			txtTotal.fontSize = 300;

			soundControl.instanse.musicSource.Stop ();
			GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
			//Pause ();
			StartCoroutine ("ReloadGame");

		}
			//for camera rotate
		if (col.gameObject.tag=="hole") {
			if (cam!=null) {
				cam.GetComponent<Camera>().transform.Rotate (0, 0, 180);//	camera
				if (hole!=null) {
					Destroy (col.gameObject);
				}
			}

		}
		if (col.gameObject.tag=="hole_back") {
			if (cam!=null) {
				cam.GetComponent<Camera>().transform.Rotate (0, 0, 180);//	camera
				if (hole2!=null) {
					Destroy (col.gameObject);
				}
			}

		}
		//for jump
		if (col.gameObject.tag=="spring") {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, 1900));
		}
		if (col.gameObject.tag=="spring_1") {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, 4000));
		}
		if (col.gameObject.tag=="spring_2") {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, 3100));
		}
		if (col.gameObject.tag=="spring_3") {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, 1700));
		}
		////////////
		if (col.gameObject.tag == "star") { 
			s++; 
			soundControl.instanse.PlaySingle (collect);
		Destroy (col.gameObject);

	}
		if (col.gameObject.tag=="bread") {
			s = s + 10;
			soundControl.instanse.PlaySingle (collect);
			Destroy (col.gameObject);
		}

	}

	IEnumerator ReloadGame()
	{			
		
		// ... pause briefly
		yield return new WaitForSeconds(2);
		// ... and then reload the level.
		//Application.LoadLevel(Application.loadedLevel);
		soundControl.instanse.musicSource.Play ();
	
		UnityEngine.SceneManagement.SceneManager.LoadScene (2);

	
	}
	IEnumerator CompleteGame()
	{			
		// ... pause briefly
		yield return new WaitForSeconds(3);
		soundControl.instanse.musicSource.Play ();
		UnityEngine.SceneManagement.SceneManager.LoadScene (0);

	}
	void OnGUI()
	{
		txt.text=s.ToString();
	}

	IEnumerator pauseForAudio()
	{
		yield return new WaitForSeconds (1);
		soundControl.instanse.efxSource.mute = true;
	}


}
