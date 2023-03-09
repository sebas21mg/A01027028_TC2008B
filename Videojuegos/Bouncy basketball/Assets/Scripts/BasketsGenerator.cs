using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class BasketsGenerator : MonoBehaviour
// {
//   [SerializeField] float spawnRate;
//   [SerializeField] GameObject basket;
//   [SerializeField] float right;
//   [SerializeField] float top;
//   [SerializeField] CameraFollowPad cam;

//   float lastMid;

//   void Start()
//   {
//     lastMid = cam.referencePosition;
//     generateBasket(cam.referencePosition, top);
//     generateBasket(top * 1.5f, top * 2f);
//   }

//   void Update()
//   {
//     if (cam.referencePosition >= lastMid)
//     {
//       lastMid += top;
//       generateBasket(lastMid + top * 1.5f, lastMid + top * 2f);
//     }
//   }

//   void generateBasket(float minYRange, float maxYRange)
//   {
//     float xBasketPosition = Random.Range(-right, right);
//     float yBasketPosition = Random.Range(minYRange, maxYRange);

//     Instantiate(basket, new Vector3(xBasketPosition, yBasketPosition), transform.rotation);
//   }
// }

public class BasketsGenerator : MonoBehaviour
{
  [SerializeField] float spawnRate;
  [SerializeField] GameObject basket;
  [SerializeField] float right;
  [SerializeField] float top;
  [SerializeField] float fallSpeed;

  GameObject[] basketInstances;

  void Start()
  {
    InvokeRepeating("GenerateBasket", 0f, spawnRate);
  }

  void Update()
  {
    basketInstances = GameObject.FindGameObjectsWithTag("Basket");

    foreach (GameObject basketInstance in basketInstances)
    {
      basketInstance.transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
      if (basketInstance.transform.position.y < -20)
        Destroy(basketInstance);
    }

  }

  void GenerateBasket()
  {
    float xBasketPosition = Random.Range(-right, right);

    GameObject basketInstance = Instantiate(basket, new Vector3(xBasketPosition, top), transform.rotation);

  }
}