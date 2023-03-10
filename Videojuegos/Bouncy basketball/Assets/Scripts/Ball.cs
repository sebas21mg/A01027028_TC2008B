using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

  [SerializeField] ScoreManager score;
  public bool isGameOver = false;

  void Start()
  {

  }

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
    if (collider.gameObject.tag == "Basket")
    {
      if (transform.position.y > collider.transform.position.y)
      {
        score.AddPoint(1);

        Destroy(collider.gameObject);
      }
    }
  }

  void GameOver()
  {
    Destroy(this);
    isGameOver = true;
  }
}
