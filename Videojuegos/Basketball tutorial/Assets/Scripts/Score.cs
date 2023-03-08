using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
  public int score;
  public Text scoreText;
  [SerializeField] TMP_Text tmpObj;


  // Start is called before the first frame update
  void Start()
  {
    score = 0;
  }

  // Update is called once per frame
  public void AddPoints(int amount)
  {
    score += amount;
    scoreText.text = score.ToString();
  }
}
