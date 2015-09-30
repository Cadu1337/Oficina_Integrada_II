using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BotoesTutorial : MonoBehaviour {
    GameObject tutorial;
    public static int avancarimage = 0;
   
	// Use this for initialization
	void Start () {
        tutorial = GameObject.Find("Tutorial");
        
        
	
	}
    public void avancar() 
    {
        avancarimage += 1;
    }
    
    public void retroceder() 
    {
        avancarimage -= 1;
    }

    public void sairDoTutorial() 
    {
        tutorial.SetActive(false);
        Pause.pausetutorial = false;
    }
	
	// Update is called once per frame
	void Update () {

        
        if(avancarimage == 1)
        {

            ImagemTutorial.imagemtutorial.sprite = Resources.Load<Sprite>("Tutorial_2");

        }
        if(avancarimage == 2)
        {
            ImagemTutorial.imagemtutorial.sprite = Resources.Load<Sprite>("Tutorial_3");
           
        }
        if(avancarimage == 0)
        {
            ImagemTutorial.imagemtutorial.sprite = Resources.Load<Sprite>("Tutorial_1");
        }
        if(avancarimage == 3)
        {
            avancarimage = 2;
        }
        if(avancarimage == -1)
        {
            avancarimage = 0;
        }
	
	}
}
