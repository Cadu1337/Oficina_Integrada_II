using UnityEngine;
using System.Collections;

public class FantasmaScript : MonoBehaviour {
    GameObject[] fantasmas = new GameObject[2];
    SpriteRenderer sprite;
    public Color cores;
    float tempo = 1f;
    bool invisible;
    float tempo2 = 5f;
    float tempo3 = 4f;
    float speed = 0.035f;
    float speed2 = 0.035f;
    bool matar;
	// Use this for initialization
	void Start () {
        
        fantasmas[0] = GameObject.Find("Monstros_Cozinheira");
        fantasmas[1] = GameObject.Find("Monstros_Cozinheira1");
       sprite = gameObject.GetComponent<SpriteRenderer>();
       fantasmas[0].renderer.material.color = new Color(1, 1, 1, 1);
       fantasmas[1].renderer.material.color = new Color(1, 1, 1, 1);
       
      
      
	}
	
	// Update is called once per frame
	void Update () {
        if (Espada.vidasfantasma[0] > 0)
        {
            fantasmas[0].transform.Translate(speed, 0, 0);
        }
       if(Espada.vidasfantasma[1] > 0){
        fantasmas[1].transform.Translate(speed2, 0, 0);
		}

        tempo2 -= Time.deltaTime;
        if(tempo2 <= 0f){
            tempo3 -= Time.deltaTime;
        if (invisible == false) 
        {
            tempo -= Time.deltaTime;
           if(Espada.vidasfantasma[0] > 0){
            fantasmas[0].renderer.material.color = new Color(1, 1, 1, tempo);
            }
				if(Espada.vidasfantasma[1] > 0){
            fantasmas[1].renderer.material.color = new Color(1, 1, 1, tempo);
				}
        }

        
       // fantasmas[0].renderer.material.color =  new Color(1,1,1,tempo);
        if(tempo <= 0f)
        {
           
            invisible = true;
        }
        else if(tempo >= 1f)
        {
            invisible = false;
        }
        if(invisible == true)
        {
            if(Espada.vidasfantasma[0] > 0){
            fantasmas[0].renderer.material.color = new Color(1, 1, 1, tempo);
            }
				if(Espada.vidasfantasma[1] > 0){
            fantasmas[1].renderer.material.color = new Color(1, 1, 1, tempo);
				}
            tempo += Time.deltaTime;
        }
  //sprite.color = ;
        
        }
        if(tempo3 <= 0  )
        {
            tempo2 = 5f;
            tempo3 = 4f;
       }
        /////////////////
        /////////////
        //////////////
        if (Espada.vidasfantasma [0] > 0) {
			if (fantasmas [0].transform.position.x >= 36.81f) {
				fantasmas [0].transform.localScale = new Vector2 (-0.5075561f, 0.5075561f);
				speed *= -1f;
			} else if (fantasmas [0].transform.position.x <= 31.88f) {
				fantasmas [0].transform.localScale = new Vector2 (0.5075561f, 0.5075561f);
				speed *= -1f;
			}
		}
        
        ///////////////
		if(Espada.vidasfantasma[1] > 0){
        if (fantasmas[1].transform.position.x >= 82.39f)
        {
            fantasmas[1].transform.localScale = new Vector2(-0.5075561f, 0.5075561f);
            speed2 *= -1f;
        }
        else if (fantasmas[1].transform.position.x <= 75.49f)
        {
            fantasmas[1].transform.localScale = new Vector2(0.5075561f, 0.5075561f);
            speed2 *= -1f;
        }
		}
       
        
	
	}
  
}
