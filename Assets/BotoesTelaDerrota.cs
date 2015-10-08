using UnityEngine;
using System.Collections;

public class BotoesTelaDerrota : MonoBehaviour {

	// Use this for initialization
    public void TentarNovamete() 
    {
        Application.LoadLevel("Game");
    }
    public void Menu()
    {
        Application.LoadLevel("Menu");
    }
}
