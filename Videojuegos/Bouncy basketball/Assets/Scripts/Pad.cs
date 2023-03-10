using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
  [SerializeField] float verticalSpeed;
  [SerializeField] float horizontalSpeed;
  [SerializeField] float bounciness;
  [SerializeField] Ball ball;
  [SerializeField] float verticalLimit;
  [SerializeField] float horizontalLimit;

  void Start()
  {

  }

  void Update()
  {
    if (!ball.isGameOver)
    {

      float verticalMove = Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime;
      float horizontalMove = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;

      if ((transform.position.y <= -verticalLimit && verticalMove < 0) || (transform.position.y >= verticalLimit && verticalMove > 0))
        verticalMove = 0;

      if ((transform.position.x <= -horizontalLimit && horizontalMove < 0) || (transform.position.x >= horizontalLimit && horizontalMove > 0))
        horizontalMove = 0;

      transform.Translate(horizontalMove, verticalMove, 0);
    }
  }

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Ball")
    {
      float ballOffset = transform.position.x - collision.rigidbody.position.x;
      float xBounce = -ballOffset * (bounciness / 2);

      if (transform.position.y < collision.rigidbody.position.y)
        collision.rigidbody.velocity = new Vector3(xBounce, bounciness);
    }
  }
}
