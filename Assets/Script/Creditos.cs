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
        //time2 = 1f;
        if(time <= 8f)
        {
            if (A2 <= 255 && A2 >= 17)
            {
                A2 -= 17;
            }
            
                
                FadeCreditos.fader.GetComponent<Image>().color = new Color32(1, 1, 1, A2);
            
            //A = 0;
            time3 -= Time.deltaTime;
          
           
            creditos.sprite = Resources.Load<Sprite>("Creditos_02");
            
            
        }
        if(time <= 4f)
        {
            if (A3 <= 255 && A3 >= 17)
            {
                A3 -= 17;
            }


            FadeCreditos.fader.GetComponent<Image>().color = new Color32(1, 1, 1, A3);
            time4 -= Time.deltaTime;
            
            creditos.sprite = Resources.Load<Sprite>("Creditos_03");
        }
        if(time <= 0f)
        {
            time = 12f;
            FadeCreditos.fader.SetActive(false);
            
            button.SetActive(true);
        }
        Debug.Log(time);
	
	}
}
