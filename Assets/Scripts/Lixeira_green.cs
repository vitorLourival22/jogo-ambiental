using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixeira_green : MonoBehaviour
{
    public Sprite newSpri;
    private Sprite original;
    
    private void Start()
    {
        original = GetComponent<SpriteRenderer>().sprite;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("metal"))
        {
            GetComponent<SpriteRenderer>().sprite = newSpri;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("metal"))
        {
            GetComponent<SpriteRenderer>().sprite = original;
        }
    }

    // Start is called before the first frame update
    
}
