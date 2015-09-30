using UnityEngine;
using System.Collections;

public class SomGame : MonoBehaviour {
    int audio = 0;
	// Use this for initialization
    public void om() 
    {
        audio += 1;
    }

    void Update() 
    {
        Debug.Log(audio);
    if(audio == 1)
    {
        Pause.Volume = 0f;
    }
     if(audio == 2)
    {
            Pause.Volume = 1f;
            audio = 0;
    }
    }
}
