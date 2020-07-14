using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colided : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool suelover;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        suelover = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        suelover = false;
    }
}
