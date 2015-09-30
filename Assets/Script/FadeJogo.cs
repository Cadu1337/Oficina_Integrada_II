using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeJogo : MonoBehaviour {
    Image fade;
    float time = 1f;
	// Use this for initialization
	void Start () {
        fade = gameObject.GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time <= 0.9f)
        {
            fade.canvasRenderer.SetAlpha(0.9f);
        }
        if (time <= 0.8f)
        {
            fade.canvasRenderer.SetAlpha(0.9f);
        }
        if (time <= 0.7f)
        {
            fade.canvasRenderer.SetAlpha(0.8f);
        }
        if (time <= 0.6f)
        {
            fade.canvasRenderer.SetAlpha(0.7f);
        }
        if (time <= 0.5f)
        {
            fade.canvasRenderer.SetAlpha(0.6f);
        }
        if (time <= 0.4f)
        {
            fade.canvasRenderer.SetAlpha(0.5f);
        }
        if (time <= 0.3f)
        {
            fade.canvasRenderer.SetAlpha(0.4f);
        }
        if (time <= 0.2f)
        {
            fade.canvasRenderer.SetAlpha(0.3f);
        }
        if (time <= 0.1f)
        {
            fade.canvasRenderer.SetAlpha(0.2f);
        }
        if (time <= 0.0f)
        {
            fade.canvasRenderer.SetAlpha(0.1f);

            //Application.LoadLevel("Game");
        }
	
	}
}
