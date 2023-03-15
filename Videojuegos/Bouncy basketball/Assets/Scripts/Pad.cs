// Sebastian Moncada y Samuel Acevedo
// Comportamiento del pad (capibara)

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    [SerializeField] float verticalSpeed;
    [SerializeField] float horizontalSpeed;
    [SerializeField] float bounciness;
    [SerializeField] Ball Ball;
    [SerializeField] float verticalLimit;
    [SerializeField] float horizontalLimit;

    // * Mover el pad (capibara) cuando cumpla ciertas condiciones
    void Update()
    {
        // No se ha terminado el juego
        if (!Ball.isGameOver)
        {

            float verticalMove = Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime;
            float horizontalMove = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;

            // El pad está dentro de los límites del juego
            if ((transform.position.y <= -verticalLimit && verticalMove < 0) || (transform.position.y >= verticalLimit && verticalMove > 0))
                verticalMove = 0;

            if ((transform.position.x <= -horizontalLimit && horizontalMove < 0) || (transform.position.x >= horizontalLimit && horizontalMove > 0))
                horizontalMove = 0;

            transform.Translate(horizontalMove, verticalMove, 0);
        }
    }

    // * Cuando el balón (fruta) choque con el pad
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar que sea el balón
        if (collision.gameObject.tag == "Ball")
        {
            // Comportamiento de que si el balón está a la derecha del centro del pad, salga a la derecha y 
            // viceversa y que sólo sea si el balón está arriba del pad
            float ballOffset = transform.position.x - collision.rigidbody.position.x;
            float xBounce = -ballOffset * (bounciness / 3);

            if (transform.position.y < collision.rigidbody.position.y)
                collision.rigidbody.velocity = new Vector3(xBounce, bounciness);
        }
    }
}
