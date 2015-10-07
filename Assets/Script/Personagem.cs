using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Personagem : MonoBehaviour
{
    public GameObject bala;
    GameObject balas;
    float VelAndar = 0.0725f;
    SpriteRenderer spriterenderer;
    bool colisao;
    float time = 0.8f;
    float time2 = 0.3f;
    float time3 = 1.2f;
    float forca = 300f;
    bool pular;
	bool jump;
    bool tiro;
	int impulso;
    int vidas = 4;
    int tiros = 3;
	GameObject espada;
	bool ataque;
	float pqp;
    // Use this for initialization
    void Start()
    {
        balas = GameObject.Find("Canvas/Municao");
        spriterenderer = gameObject.GetComponent<SpriteRenderer>();
		espada = GameObject.Find ("Espada");
		espada.SetActive (false);
	
    }

    // Update is called once per frame
    void FixedUpdate()
    {
	
		
        if (Pause.pause == false || Pause.pause2 == false)
        {
            spriterenderer.sprite = Resources.Load<Sprite>("Personagem/Tião_Sprite_Andando_001");
            if (Input.GetKey(KeyCode.RightArrow) == true || Input.GetAxis("Horizontal") > 0)
            {
                transform.localScale = new Vector2(0.7067133f, 0.7067133f);
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

                    time = 0.8f;
                }

                transform.Translate(VelAndar, 0, 0);
            }
			else if (Input.GetKey(KeyCode.LeftArrow) == true ||Input.GetAxis("Horizontal") < 0 )
            {
                transform.localScale = new Vector2(-0.7067133f, 0.7067133f);
                time -= Time.deltaTime;
                if (time <= 0.75f)
                {
                    spriterenderer.sprite = Resources.Load<Sprite>("Personagem/Tião_Sprite_Andando_002");
                }
                if (time <= 0.5f)
                {
                    spriterenderer.sprite = Resources.Load<Sprite>("Personagem/Tião_Sprite_Andando_003");
                }
                if (time <= 0.25f)
                {
                    spriterenderer.sprite = Resources.Load<Sprite>("Personagem/Tião_Sprite_Andando_004");
                }
                if (time <= 0f)
                {

                    time = 1.0f;
                }
                transform.Translate(-VelAndar, 0, 0);

            }
            /////////////////////////////////////////////////////
            if (transform.position.x <= -8.14f)
            {
                transform.Translate(VelAndar, 0, 0);
            }
            else if (transform.position.x >= 107.3f)
            {
                transform.Translate(-VelAndar, 0, 0);
            }
            if(Input.GetKeyDown(KeyCode.X) == true)
            {

                tiros -= 1;
                tiro = true;
                
            }
            if(tiros > 0 && tiros <= 3 ){
            if(tiro == true)
            {
             
                if (transform.localScale.x >= 0.7067133f)
                {
                    Instantiate(bala, new Vector2(transform.position.x + 1f, transform.position.y), Quaternion.identity);
                }
                else if (transform.localScale.x <= -0.7067133f)
                {
                    Instantiate(bala, new Vector2(transform.position.x - 1f, transform.position.y), Quaternion.identity);
                }
                
                tiro = false;
            }
                
            }
            switch(tiros)
            {
                case 3:
				balas.GetComponent<Image>().sprite = Resources.Load<Sprite>("SpriteBala01");
                    
                    break;
                case 2:
				balas.GetComponent<Image>().sprite = Resources.Load<Sprite>("SpriteB'ala02");
                    break;
                case 1:
				balas.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("SpriteBala03");
                    break;
                case 0:
				balas.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("SpriteBala04");
                    break;
            }

            
           


        }
    }
    void Update() 
	{
		 
		if(Input.GetKey(KeyCode.Z) == true || Input.GetKey(KeyCode.JoystickButton2) == true )
		{	
			
			ataque = true;
			
		}

			
			
		
		if(ataque == true)
		{
			time2 -= Time.deltaTime;
			if(time2 <= 0.2f)
			{
				spriterenderer.sprite = Resources.Load<Sprite>("TiaoSprite_Ataque1");
				
			}
			if(time2 <= 0.1f)
			{ 
				espada.SetActive(true);
				spriterenderer.sprite = Resources.Load<Sprite>("TiaoSprite_Ataque2");
			}
			if(time2 <= 0f)
			{
				spriterenderer.sprite = Resources.Load<Sprite>("TiaoSprite_Ataque3");
				time2 = 0.3f;
				espada.SetActive(false);
				ataque = false;
				
			}
		}
		
        if (pular == true)
		{
            if (Input.GetButton("Jump") == true || Input.GetKey(KeyCode.JoystickButton0) == true)
			{	jump = true;

				
			}
			
		}
		if(jump == true)
		{

			time3 -= Time.deltaTime;
			if (time3 <= 1.1f)
			{

				spriterenderer.sprite = Resources.Load<Sprite>("Tião_Sprite_Pulando_002");
			}
			if (time3 <= 0.95f && time3 >= 0.5f)
			{
				spriterenderer.sprite = Resources.Load<Sprite>("Tião_Sprite_Pulando_003");
				impulso += 1;
				if(impulso == 1) {
					rigidbody2D.gravityScale = 1f;
					rigidbody2D.AddForce(Vector2.up * forca);

				}
			}
			if (time3 <= 0.5f)
			{

				spriterenderer.sprite = Resources.Load<Sprite>("Tião_Sprite_Pulando_004");

				time3 = 1.2f;
				jump = false;
				impulso = 0;
			}
			pular = false;


			
		}
		if (colisao == true)
		{
			Camera.collider = false;
		}
		else { Camera.collider = true; }
		switch(vidas)
		{
		case 3:
                BarraDeVida.barradevida.SetBool("2Vidas", true);
			break;
            case 2 :
            BarraDeVida.barradevida.SetBool("1Vidas", true);
                break;
            case 1:
                BarraDeVida.barradevida.SetBool("0vidas", true);
                break;
		case 0:
			BarraDeVida.barradevida.SetBool("0vidas", true);
			break;
        }

    }
    void OnCollisionStay2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Aranha" || other.gameObject.tag == "Cozinheira" || other.gameObject.tag == "lixo" || other.gameObject.tag == "Carro" || other.gameObject.tag == "Poste" || other.gameObject.tag == "Hidrante")
        {
            Camera.mito = true;
			colisao = true;

		} else
			colisao = false;
       

        
	


}
	void OnCollisionEnter2D(Collision2D other) 
	{

        if (other.gameObject.tag == "Cenario" || other.gameObject.tag == "lixo" || other.gameObject.tag == "Carro" || other.gameObject.tag == "Poste" || other.gameObject.tag == "Hidrante")
		{
			pular = true;
		}
		
		
		
		if (other.gameObject.tag == "Aranha")
		{
			vidas -= 1;

			
		}
		if (other.gameObject.tag == "Cozinheira")
		{
			vidas -= 1;
			
			
		}
	}
        

	
 
}
