using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour
{
  [SerializeField] GameObject ball;
  [SerializeField] float delay;

  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("DropBall", 0.5f, delay);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void DropBall()
  {
    Vector2 pos = new Vector2(Random.Range(-8.5f, 8.5f), transform.position.y);
    GameObject obj = Instantiate(ball, pos, Quaternion.identity);
    Destroy(obj, 5);
  }
}
