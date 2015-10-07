using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VidasPersonagem : MonoBehaviour {
	public static Image spritesenemy;
	public static string monstroativo;
	// Use this for initialization
	void Start () {
		spritesenemy = gameObject.GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//spritesenemy.sprite = Resources.Load<Sprite>("SpriteVidasAranha");
		if(monstroativo == "Aranha0")
		{
			if(Espada.vidasaranha[0] == 3)
			{
                spritesenemy.sprite = Resources.Load<Sprite>("Cópia de Bara de vida_001");

			}
            else if(Espada.vidasaranha[0] == 2)
            {
                spritesenemy.sprite = Resources.Load<Sprite>("Cópia de Bara de vida_002");
            }
            else if(Espada.vidasaranha[0] == 1)
            {
                spritesenemy.sprite = Resources.Load<Sprite>("Cópia de Bara de vida_003");
            }
            else if(Espada.vidasaranha[0] == 0)
            {
                spritesenemy.sprite = Resources.Load<Sprite>("Cópia de Bara de vida_004");
            }
		}

	
	}
}
