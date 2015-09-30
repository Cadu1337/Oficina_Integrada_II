using UnityEngine;
using System.Collections;

public class AbrirTutorial : MonoBehaviour {

	// Use this for initialization
    public void abrirtutorial()
    {
        TutorialScript.tutorail.SetActive(true);
        Pause.pausetutorial = true;
    }
}
