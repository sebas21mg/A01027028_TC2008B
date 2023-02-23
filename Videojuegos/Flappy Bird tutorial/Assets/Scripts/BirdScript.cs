using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
  public Rigidbody2D myRigidBody;
  public float flapStrenght;
  public LogicScript logic;
  public bool birdIsAlive;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive && transform.position.y <= 16)
      myRigidBody.velocity = Vector2.up * flapStrenght;

    if (transform.position.y <= -16)
      logic.gameOver();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    logic.gameOver();
  }

}
