using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI ()
		{
			GUI.Box (new Rect (Screen.width - 110, 10, 100, 90), "Change Motion");
            bool nextButtonClicked = GUI.Button (new Rect (Screen.width - 100, 40, 80, 20), "Start");
            bool backButtonClicked = GUI.Button (new Rect (Screen.width - 100, 70, 80, 20), "Next");

            if (nextButtonClicked){
                print("Next Button is Clicked!");
            }

            if (backButtonClicked){
                print("Back Button is Clicked!");
            }
		}
}
