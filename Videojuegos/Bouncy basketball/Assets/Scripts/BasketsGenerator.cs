// Sebastian Moncada y Samuel Acevedo
// Generador de canastas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketsGenerator : MonoBehaviour
{
    [SerializeField] float spawnRate;
    [SerializeField] GameObject Basket;
    [SerializeField] float right;
    [SerializeField] float fallSpeed;
    [SerializeField] Ball Ball;

    GameObject[] BasketInstances;

    // * Generar las canastas constántemente
    void Start()
    {
        InvokeRepeating("GenerateBasket", 0f, spawnRate);
    }

    // * Mover las canastas y borrarlas cuando salgan del área de juego
    void Update()
    {
        BasketInstances = GameObject.FindGameObjectsWithTag("Basket");

        foreach (GameObject BasketInstance in BasketInstances)
        {
            // Mover las canastas
            if (!Ball.isGameOver)
                BasketInstance.transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

            // Destruir las canastas cuando salgan del área de juego
            if (BasketInstance.transform.position.y < -20)
                Destroy(BasketInstance);
        }

    }

    // * Generar las canastas
    void GenerateBasket()
    {
        if (!Ball.isGameOver)
        {
            float xBasketPosition = Random.Range(-right, right);

            GameObject BasketInstance = Instantiate(
              Basket,
              new Vector3(xBasketPosition, transform.position.y),
              transform.rotation
            );
        }
    }
}