using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersonagemTutorial : MonoBehaviour {
    float VelAndar = 0.0425f;
    float time = 0.8f;
     Image spriterenderer;
	// Use this for initialization
	void Start () {
        spriterenderer = gameObject.GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Debug.Log(time);
        //spriterenderer.sprite = Resources.Load<Sprite>("Personagem/Tião_Sprite_Andando_001");
        if (Input.GetKey(KeyCode.RightArrow) == true)
		{transform.Translate(VelAndar,0,0);
           // transform.localScale = new Vector2(0.7067133f, 0.7067133f);
            time -= Time.deltaTime;
            if (time <= 0.6f)
            {
                spriterenderer.sprite = Resources.Load<Sprite>("Personagem/Tião_Sprite_Andando_002");
            }
            if (time <= 0.4f)
            {
                spriterenderer.sprite = Resources.Load<Sprite>("Personagem/Tião_Sprite_Andando_003");
            }
            if (time <= 0.2f)
            {
                spriterenderer.sprite = Resources.Load<Sprite>("Personagem/Tião_Sprite_Andando_004");
            }
            if (time <= 0f)
            {

                //time = 0.8f;
            }

           
        }
	
	}
}
