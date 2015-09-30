using UnityEngine;
using System.Collections;

public class TutorialScript : MonoBehaviour {
    public static GameObject tutorail;
	// Use this for initialization
	void Start () {
        tutorail = GameObject.Find("Tutorial");
        tutorail.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
