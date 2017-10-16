using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess = 1000;
	int MaxGuessesAllowed = 12;
	public Text message;
	public Text guessCount;
	
	
	


	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame(){
		max = 3000;
		min = 1;
		max = max+1;
		
		

		}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			//print("Up arrow was pressed");
			GuessHigher ();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Down arrow was pressed");
			GuessLower ();
		}	
		//else if (Input.GetKeyDown(KeyCode.Return)){
			//print("I Won");
			//StartGame ();
		//}
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess ();
	
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess ();
		
	}
	
	void NextGuess(){
		guess = (max+min)/2;
		message.text = guess.ToString ();
		MaxGuessesAllowed = MaxGuessesAllowed-1;
		guessCount.text = MaxGuessesAllowed.ToString ();
		if(MaxGuessesAllowed==0){
			Application.LoadLevel ("Win");
		}

	}
}
