using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Creditos : MonoBehaviour {
    Image creditos;
    public static float time = 12f;
    float time2 = 1f;
    float time3 = 1f;
    float time4 = 1f;
    private byte A;
    private byte A2;
    private byte A3;
    GameObject button;
	// Use this for initialization
	void Start () {
        A = 255;
        A2 = 255;
        A3 = 255;
        
        creditos = gameObject.GetComponent<Image>();
        button = GameObject.Find("Canvas/Button");
        button.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
    
        time -= Time.deltaTime;
        
        time2 -= Time.deltaTime;
        
		if (A <= 255 && A >= 17) 
		{
			A -= 17;
        }
       
        FadeCreditos.fader.GetComponent<Image>().color = new Color32(1, 1, 1, A);
		
           //.GetComponent<Image>().color = new Color32 (1,1,1,A);
        //time2 = 1
        if(time <= 9f)
        {
            button.SetActive(true);
            FadeCreditos.fader.SetActive(false);
        }

        
        
        Debug.Log(time);
	
	}
}
