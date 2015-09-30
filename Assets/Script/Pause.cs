using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
    public static bool pause;
	public static bool pause2;
    public static GameObject canvas;
    public static bool pausetutorial;
    public static AudioSource audio;
    public static float Volume;
    void Start() 
    {

        canvas = GameObject.Find("Pause");
		pause = true;
		pause2 = true;
        canvas.SetActive(false);
        audio = gameObject.GetComponent<AudioSource>();
        Volume = 1f;
    }
    void Update()
    {
        audio.volume = Volume;
        //Debug.Log(audio);



        if (pausetutorial == false)
        {

			if (Input.GetButtonDown("Pause") != pause  )
            {

                //audio.volume = Volume.sliderzinho.value;
                //Volume = 0f;


                canvas.SetActive(true);
                pause = true;
				pause2 = false;

                Time.timeScale = 0.0f;
            }
			else if (Input.GetButtonDown("Pause") == pause   )
            {
                //audio.volume = Volume.sliderzinho.value;
                //Volume = 1f;


                canvas.SetActive(false);
                Time.timeScale = 1.0f;
                pause = false;
				pause2 = true;


            }
			if(Input.GetKeyDown(KeyCode.JoystickButton7) != pause2)
			{
				canvas.SetActive(true);
				pause2 = true;
				pause = false;
				
				Time.timeScale = 0.0f;
			}
			else if(Input.GetKeyDown(KeyCode.JoystickButton7) == pause2)
			{
				canvas.SetActive(false);
				Time.timeScale = 1.0f;
				pause2 = false;
				pause = true;
			}

        }
    }
}
