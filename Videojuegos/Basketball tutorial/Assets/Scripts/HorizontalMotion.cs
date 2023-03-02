// Move a GameObject horizontally using the arrow keys or AD
// Sebastian Moncada 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMotion : MonoBehaviour
{

  [SerializeField] float speed;
  Vector2 move;
  double limit = 8.1;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    move.x = Input.GetAxis("Horizontal");
    // Debug.Log("X motion: " + move.x);

    if (transform.position.x <= -limit && move.x < 0)
      move.x = 0;
    else if (transform.position.x >= limit && move.x > 0)
      move.x = 0;

    transform.Translate(move * speed * Time.deltaTime);
  }

}
