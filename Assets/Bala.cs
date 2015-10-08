using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {
    float vel = 0.2f;
    float vel2 = 0.2f;
	float posicaoPersonagem;
    float posicaoPersonagem2;
    GameObject personagem;
    GameObject fanstama;
	// Use this for initialization
	void Start () {
	
        fanstama = GameObject.Find("Monstros_Cozinheira");
        personagem = GameObject.Find("Personagem");
		posicaoPersonagem = personagem.transform.localScale.x;
	
	}
	
	// Update is called once per frame
	void Update () {
        posicaoPersonagem2 = personagem.transform.position.x;
        
        if (posicaoPersonagem >= 0.7067133f) 
        {
            transform.localScale = new Vector2(0.1748332f, 0.1748332f);
            transform.Translate(vel,0,0);
        }
        else if(  posicaoPersonagem <= -0.7067133f)
        {
            transform.localScale = new Vector2(-0.1748332f, 0.1748332f);
            transform.Translate(-vel2, 0, 0);
        }


        
	
	}
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Cozinheira")
        {
            
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Aranha")
        {
			Espada.vidasaranha[0] -= 1;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Poste")
        {

            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Carro")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "lixo")
        {

            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Hidrante")
        {
            Destroy(this.gameObject);
        }
    
    }
}
