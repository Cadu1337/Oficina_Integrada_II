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
			if(Espada.vidasaranha[0] == 4)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_01");

			}
            else if(Espada.vidasaranha[0] == 3)
            {
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_02");
            }
            else if(Espada.vidasaranha[0] == 2)
            {
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_03");
            }
            else if(Espada.vidasaranha[0] == 1)
            {
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_04");
            }
			else if(Espada.vidasaranha[0] == 0)
			{

				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_05");
			}
		}
		if(monstroativo == "Aranha1")
		{
			if(Espada.vidasaranha[1] == 4)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_01");
				
			}
			else if(Espada.vidasaranha[1] == 3)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_02");
			}
			else if(Espada.vidasaranha[1] == 2)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_03");
			}
			else if(Espada.vidasaranha[1] == 1)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_04");
			}
			else if(Espada.vidasaranha[1] == 0)
			{
				
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_05");
			}
		}	if(monstroativo == "Aranha2")
		{
			if(Espada.vidasaranha[2] == 4)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_01");
				
			}
			else if(Espada.vidasaranha[2] == 3)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_02");
			}
			else if(Espada.vidasaranha[2] == 2)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_03");
			}
			else if(Espada.vidasaranha[2] == 1)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_04");
			}
			else if(Espada.vidasaranha[2] == 0)
			{
				
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_05");
			}
		}

		if(monstroativo == "Coelho1")
		{
			if(Espada.vidascoelho[0] == 4)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaTraveco_01");
				
			}
			else if(Espada.vidascoelho[0] == 3)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaTraveco_02");
			}
			else if(Espada.vidascoelho[0] == 2)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaTraveco_03");
			}
			else if(Espada.vidascoelho[0] == 1)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaTraveco_04");
			}
			else if(Espada.vidascoelho[0] == 0)
			{
				
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_05");
			}
		}
		if(monstroativo == "Coelho2")
		{
			if(Espada.vidascoelho[1] == 4)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaTraveco_01");
				
			}
			else if(Espada.vidascoelho[1] == 3)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaTraveco_02");
			}
			else if(Espada.vidascoelho[1] == 2)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaTraveco_03");
			}
			else if(Espada.vidascoelho[1] == 1)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaTraveco_04");
			}
			else if(Espada.vidascoelho[1] == 0)
			{
				
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_05");
			}
		}
		if(monstroativo == "Fantasma1")
		{
			if(Espada.vidasfantasma[0] == 4)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaDementador_01");
				
			}
			else if(Espada.vidasfantasma[0] == 3)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaDementador_02");
			}
			else if(Espada.vidasfantasma[0] == 2)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaDementador_03");
			}
			else if(Espada.vidasfantasma[0] == 1)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaDementador_04");
			}
			else if(Espada.vidasfantasma[0] == 0)
			{
				
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_05");
			}
		}
		if(monstroativo == "Fantasma2")
		{
			if(Espada.vidasfantasma[1] == 4)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaDementador_01");
				
			}
			else if(Espada.vidasfantasma[1] == 3)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaDementador_02");
			}
			else if(Espada.vidasfantasma[1] == 2)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaDementador_03");
			}
			else if(Espada.vidasfantasma[1] == 1)
			{
				spritesenemy.sprite = Resources.Load<Sprite>("VidaDementador_04");
			}
			else if(Espada.vidasfantasma[1] == 0)
			{
				
				spritesenemy.sprite = Resources.Load<Sprite>("BarradeVida_05");
			}
		}

	
	}
}
