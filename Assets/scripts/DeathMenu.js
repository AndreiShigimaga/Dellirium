var isTryAgainButton = false;
var isMainMenuButton = false;



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
 	if ( isTryAgainButton )
		UnityEngine.SceneManagement.SceneManager.LoadScene (1);

				
		if ( isMainMenuButton )
		UnityEngine.SceneManagement.SceneManager.LoadScene (0);

}