using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketsGenerator : MonoBehaviour
{
  [SerializeField] float spawnRate;
  [SerializeField] GameObject basket;
  [SerializeField] float xRange;
  [SerializeField] float yPosition;
  [SerializeField] FollowPad followPad;

  void Start()
  {
    generateBasket();
  }

  void Update()
  {

  }

  void generateBasket()
  {
    float yBasketPosition = yPosition + followPad.referencePosition;
    float xBasketPosition = Random.Range(-xRange, xRange);
    Instantiate(basket, new Vector3(xBasketPosition, yBasketPosition), transform.rotation);
  }
}
