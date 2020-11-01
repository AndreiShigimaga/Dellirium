var isNewGameButton = false;
var isOptionButton = false;
var isAuthorButton = false;
var isQuitButton = false;
var isCancelButton = false;
var isVolumeButton = false;
var isVolumeButton2 = false;
var camera1 : Camera;
var camera2 : Camera;
var camera3 : Camera;
var camera4 : Camera;

function OnMouseEnter()
{
GetComponent.<Renderer>().material.color = Color.yellow;
//GetComponent.<Renderer>().material.color = Color.Black;

}

function OnMouseExit()
{
GetComponent.<Renderer>().material.color = Color.white;
//GetComponent.<Renderer>().material.color = Color.White;

}

function OnMouseUp()
{

	if (isOptionButton)
	{camera1.enabled = false;
	camera2.enabled = true;
	camera3.enabled = false;
	camera4.enabled = false;}
	 if( isAuthorButton )
		{camera1.enabled = false;
		camera2.enabled = false;
		camera3.enabled = true;
		camera4.enabled = false;}
		if ( isCancelButton )
		{
			camera1.enabled = true;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled = false;
		}
			if ( isVolumeButton )
			{
			//DontDestroyOnLoad(gameObject);
				camera1.enabled = false;
				camera2.enabled = false;
				camera3.enabled = false;
				camera4.enabled = true;
				//GetComponent.<SoundManager>().AudioListener.mute=true;
				AudioListener.volume=0.0f;
			//	GetComponent.<Settings1>().NewText ="";
			}
			if ( isVolumeButton2 )
			{
				camera1.enabled = false;
				camera2.enabled = true;
				camera3.enabled = false;
				camera4.enabled = false;
				AudioListener.volume=1.0f;
			}
			if ( isNewGameButton ){
			UnityEngine.SceneManagement.SceneManager.LoadScene (1);
			}
				
		if ( isQuitButton )
		Application.Quit();
}