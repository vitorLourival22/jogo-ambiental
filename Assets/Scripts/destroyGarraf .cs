using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class destroyGarraf : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifique se o objeto com o qual colidiu tem a tag "garrafa"
        if (collision.CompareTag("garrafa"))
        {
            // Mude o sprite do objeto "lixo"

            // Destroi a garrafa
            Destroy(collision.gameObject);
        }
    }
}