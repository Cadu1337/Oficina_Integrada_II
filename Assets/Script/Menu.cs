using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
    int hue = 0;
	// Use this for initialization
    public void IrParaGame() 
    {
        hue += 1;
        
        //Application.LoadLevel("Game");
        
    }

    public void IrParaCreditos() 
    {
        Application.LoadLevel("Creditos");
    }
    void Update() 
    {
        if(hue == 1){
        //Fade.fader.SetActive(true);
        Fade.jogar = true;
      
       hue = 0;
        }
        
    }

    public void sair() 
    {

        Application.Quit();
    }
}
