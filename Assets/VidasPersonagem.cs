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
			if(Espada.vidasaranha[0] == 2)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("SpriteVidasAranha_1");

			}
		}

	
	}
}
