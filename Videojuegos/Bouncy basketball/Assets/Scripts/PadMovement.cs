using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadMovement : MonoBehaviour
{
  [SerializeField] float upSpeed;
  [SerializeField] float horizontalSpeed;

  void Start()
  {

  }

  void Update()
  {
    float upMove = Input.GetAxis("Vertical") * upSpeed * Time.deltaTime;
    float horizontalMove = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;

    transform.Translate(horizontalMove, upMove, 0);
  }
}
