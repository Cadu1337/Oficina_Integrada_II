using UnityEngine;
using System.Collections;

public class Espada : MonoBehaviour {
    AudioSource audio;
	GameObject[] aranha = new GameObject[3];
	public static int[]vidasaranha = new int[3];
	GameObject personagem;
	float positionplayer;
    GameObject[] fantasma = new GameObject[3];
    public static int[] vidasfantasma = new int[3];
    GameObject[] coelho = new GameObject[2];
    public static int[] vidascoelho = new int[2];
	
	
	// Use this for initialization
	void Start () {
        audio = gameObject.GetComponent<AudioSource>();
		personagem = GameObject.Find ("Personagem");
		vidasaranha [0] = 4;
        vidasaranha[1] = 4;
        vidasaranha[2] = 4;
        vidasfantasma[0] = 4;
        vidasfantasma[1] = 4;
        vidasfantasma[2] = 3;
		aranha [0] = GameObject.Find ("aranha");
        aranha[1] = GameObject.Find("aranha1");
        aranha[2] = GameObject.Find("aranha2");
        fantasma[0] = GameObject.Find("Monstros_Cozinheira");
        fantasma[1] = GameObject.Find("Monstros_Cozinheira1");
        coelho[0] = GameObject.Find("Coelho");
        coelho[1] = GameObject.Find("Coelho2");
        vidascoelho[0] = 4;
        vidascoelho[1] = 4;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (vidasfantasma[0]);
	
		if(Input.GetKeyDown(KeyCode.Z) == true)
        {
            audio.playOnAwake = true;
        }
        if (personagem.transform.localScale.x >= 0.7067133)
        {
            positionplayer = personagem.transform.position.x + 1.5f;
        }
        else if (personagem.transform.localScale.x <= -0.7067133)
        {
        positionplayer = personagem.transform.position.x - 1.5f;
        }
		this.transform.position = new Vector2 (positionplayer, this.transform.position.y);
		
		if(vidasaranha[0] == 0){
		
			Destroy(aranha[0]);

         
			
		}
        if (vidasaranha[1] == 0)
        {
            Destroy(aranha[1]);

        }
        if (vidasaranha[2] == 0)
        {
            Destroy(aranha[2]);

        }
        if (vidasfantasma[0] == 0)
        {
            Destroy(fantasma[0]);

        }
        if (vidasfantasma[1] == 0)
        {
            Destroy(fantasma[1]);

        }
        if(vidascoelho[0] == 0)
        {
            Destroy(coelho[0]);
        }
        if (vidascoelho[1] == 0)
        {
            Destroy(coelho[1]);
        }
		
		
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{	
		
		if(other.gameObject == aranha[0])
		{
			VidasPersonagem.monstroativo = "Aranha0";
		
			
			vidasaranha[0] -= 1;
			
		}
        if (other.gameObject == aranha[1])
        {
			VidasPersonagem.monstroativo = "Aranha1";

            vidasaranha[1] -= 1;

        }
        if (other.gameObject == aranha[2])
        {
			VidasPersonagem.monstroativo = "Aranha2";

            vidasaranha[2] -= 1;

        }
        if (other.gameObject == fantasma[0])
        {
			VidasPersonagem.monstroativo = "Fantasma1";

            vidasfantasma[0] -= 1;

        }
        if (other.gameObject == fantasma[1])
        {
			VidasPersonagem.monstroativo = "Fantasma2";

            vidasfantasma[1] -= 1;

        }
        if(other.gameObject == coelho[0])
        {
			VidasPersonagem.monstroativo = "Coelho1";
            vidascoelho[0] -= 1;
        }
        if (other.gameObject == coelho[1])
        {
			VidasPersonagem.monstroativo = "Coelho2";
            vidascoelho[1] -= 1;
        }
	}
}
