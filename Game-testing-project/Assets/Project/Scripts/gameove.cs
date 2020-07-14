using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameove : MonoBehaviour
{

    public GameObject Persona;
    public GameObject Game; 
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Persona.transform.childCount == 0)
        {
            Game.SetActive(true);
            Time.timeScale = 1f;
        }
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel1");
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu1");
    }
}
