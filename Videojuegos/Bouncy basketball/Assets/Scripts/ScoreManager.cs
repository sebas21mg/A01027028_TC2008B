using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
  [SerializeField] private AudioSource scoreSoundEffect;
  [SerializeField] TextMeshProUGUI ScoreText;

  public int score = 0;

  void Start()
  {
    ScoreText.text = score.ToString();
  }

  public void AddPoint(int amount)
  {
    scoreSoundEffect.Play();
    score += amount;
    ScoreText.text = score.ToString();
  }
}
