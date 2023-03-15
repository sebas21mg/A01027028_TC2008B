// Sebastian Moncada y Samuel Acevedo
// Comportamiento del balón (fruta)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] ScoreManager ScoreManager;
    [SerializeField] GameOverScreen GameOverScreen;
    public bool isGameOver = false;

    // * Cuando la fruta (balón) se caiga (salga de la pantalla) se acaba el juego
    void Update()
    {
        if (transform.position.y < -9.5)
        {
            GameOver();
        }

    }

    // * El jugador la encesta
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Verificar que sí haya sido el balón
        if (collider.gameObject.tag == "Basket")
        {
            // Verificar que el balón pase por arriba del trigger y no por abajo
            if (transform.position.y > collider.transform.position.y)
            {
                ScoreManager.AddPoint(1);

                Destroy(collider.gameObject);
            }
        }
    }

    // * Se acaba el juego
    void GameOver()
    {
        Destroy(this); // Se destruye el balón
        isGameOver = true;
        GameOverScreen.Setup(ScoreManager.score); // Se muestra la pantalla para reiniciar el juego
    }
}
