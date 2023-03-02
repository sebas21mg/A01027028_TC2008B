using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIn : MonoBehaviour
{
  [SerializeField] Score score;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void OnTriggerEnter2D(Collider2D other)
  {
    score.AddPoints(1);
    Debug.Log(score.score);
  }
}
