using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){//public because it needs to be called outside the class as well
		Debug.Log("Level Load requested for: " + name);
		Application.LoadLevel (name);
	}
	public void QuitRequest(){
		Debug.Log("I want to quit!");
		Application.Quit ();
	}

}
