using UnityEngine;

public class Lixeira_red : MonoBehaviour
{
    public Sprite newSprite; // O novo sprite que será usado após a colisão
    private Sprite originalSprite; // O sprite original do objeto "lixo"

    private void Start()
    {
        // Armazene o sprite original
        originalSprite = GetComponent<SpriteRenderer>().sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifique se o objeto com o qual colidiu tem a tag "garrafa"
        if (collision.CompareTag("garrafa"))
        {
            // Mude o sprite do objeto "lixo"
            GetComponent<SpriteRenderer>().sprite = newSprite;

            // Destroi a garrafa
            //Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Verifique se o objeto com o qual colidiu tem a tag "garrafa"
        if (collision.CompareTag("garrafa"))
        {
            // Restaure o sprite original do objeto "lixo"
            GetComponent<SpriteRenderer>().sprite = originalSprite;
        }
    }
}
