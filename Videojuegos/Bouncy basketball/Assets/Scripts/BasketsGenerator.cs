using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketsGenerator : MonoBehaviour
{
  [SerializeField] float spawnRate;
  [SerializeField] GameObject basket;
  [SerializeField] float right;
  [SerializeField] float fallSpeed;
  [SerializeField] Ball ball;

  GameObject[] basketInstances;

  void Start()
  {
    if (!ball.isGameOver)
      InvokeRepeating("GenerateBasket", 0f, spawnRate);
  }

  void Update()
  {
    basketInstances = GameObject.FindGameObjectsWithTag("Basket");

    foreach (GameObject basketInstance in basketInstances)
    {
      if (!ball.isGameOver)
        basketInstance.transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
      if (basketInstance.transform.position.y < -20)
        Destroy(basketInstance);
    }

  }

  void GenerateBasket()
  {
    float xBasketPosition = Random.Range(-right, right);

    GameObject basketInstance = Instantiate(
      basket,
      new Vector3(xBasketPosition, transform.position.y),
      transform.rotation
    );

  }
}