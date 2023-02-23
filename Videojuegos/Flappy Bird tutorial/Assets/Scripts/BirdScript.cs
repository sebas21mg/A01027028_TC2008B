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
    // logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
      myRigidBody.velocity = Vector2.up * flapStrenght;
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    logic.gameOver();
    birdIsAlive = false;
  }

}
