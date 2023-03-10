using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI scoreText;

  int score = 0;

  void Start()
  {
    scoreText.text = score.ToString();
  }

  public void AddPoint(int amount)
  {
    score += amount;
    scoreText.text = score.ToString();
  }
}
