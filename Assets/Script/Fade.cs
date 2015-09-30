using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fade : MonoBehaviour {
	Image fade;
	public static bool jogar = false;
private byte R;
	private byte G;
	private byte B;
	private byte A;
	float time = 1f;
    public static GameObject fader;
	// Use this for initialization
	void Start () {
		A = 0;
        fader = GameObject.Find("Canvas/Fade");
		fade = gameObject.GetComponent<Image>();
		//fade.canvasRenderer.SetAlpha (0f);
        //fader.SetActive(false);
		//this.GetComponent<Image>().color = new Color32 (1,1,1,255);

	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (A);
		if(jogar == true){
		if (A < 255) 
		{
			A += 17;
		}

		this.GetComponent<Image>().color = new Color32 (1,1,1,A);
		}
		if(A == 255)
		{
			A= 0;
			jogar = false;
			Application.LoadLevel("Game");
		}
        
	


	
	}
}
