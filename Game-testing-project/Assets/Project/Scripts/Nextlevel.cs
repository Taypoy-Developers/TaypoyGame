using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Nextlevel : MonoBehaviour
{
    public GameObject follow;

    public string levelName;
    private bool Puerta = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Puerta= true ;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Puerta = true ;
    }
    // Update is called once per frame
    private void Update()
    {
        if (Puerta && follow.transform.childCount == 0 )
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
