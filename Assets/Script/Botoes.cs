using UnityEngine;
using System.Collections;

public class Botoes : MonoBehaviour {
    int ativar = 0;
    bool ativar2 = false;

    void Update() 
    {
        
    }

    public void VoltarAoJogo() 
    {
        Pause.pause = false;
    }
   
    public void VoltarAoMenu()
    {
        
        Application.LoadLevel("Menu");

    }

   
}
