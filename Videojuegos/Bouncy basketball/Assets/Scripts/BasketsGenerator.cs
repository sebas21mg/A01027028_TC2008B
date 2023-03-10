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

  void Start()
  {
    InvokeRepeating("GenerateBasket", 0f, spawnRate);
  }

  void Update()
  {
    BasketInstances = GameObject.FindGameObjectsWithTag("Basket");

    foreach (GameObject BasketInstance in BasketInstances)
    {
      if (!Ball.isGameOver)
        BasketInstance.transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
      if (BasketInstance.transform.position.y < -20)
        Destroy(BasketInstance);
    }

  }

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