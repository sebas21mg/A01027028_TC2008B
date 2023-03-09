using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
  [SerializeField] float verticalSpeed;
  [SerializeField] float horizontalSpeed;
  [SerializeField] float bounciness;

  void Start()
  {

  }

  void Update()
  {
    float upMove = Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime;
    float horizontalMove = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;

    transform.Translate(horizontalMove, upMove, 0);
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
