using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPad : MonoBehaviour
{
  [SerializeField] GameObject pad;
  public float referencePosition;

  void Start()
  {
    referencePosition = 0;
  }

  void LateUpdate()
  {
    if (pad.transform.position.y >= referencePosition)
    {
      transform.position = new Vector3(transform.position.x, pad.transform.position.y, transform.position.z);
      referencePosition = pad.transform.position.y;
    }
  }
}
