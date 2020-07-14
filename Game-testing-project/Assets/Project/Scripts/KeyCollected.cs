using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollected : MonoBehaviour

{
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DissapearKey();  
        }
    }

    public void DissapearKey()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        Destroy(gameObject, 0.5f);
        
    }
}
