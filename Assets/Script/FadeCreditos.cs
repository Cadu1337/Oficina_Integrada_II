using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeCreditos : MonoBehaviour {
    public static GameObject fader;
    public static Image imagem;
	// Use this for initialization
	void Start () {
        fader = GameObject.Find("Canvas/Fade");
     
        imagem = gameObject.GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
