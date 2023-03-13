using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

  [SerializeField] private AudioSource gameOverSound;
  public TextMeshProUGUI ScoreText;

  public void Setup(int score)
  {
    gameOverSound.Play();

    gameObject.SetActive(true);

    // Cambiar el texto del score para que esté en el centro
    ScoreText.rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
    ScoreText.rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
    ScoreText.rectTransform.sizeDelta = new Vector2(200f, 45f);
    ScoreText.rectTransform.pivot = new Vector2(0.5f, 0.5f);
    ScoreText.rectTransform.anchoredPosition = new Vector2(0f, 0f);
    ScoreText.fontSize = 28;

    ScoreText.text = score.ToString() + " POINTS";
  }

  public void RestartGame()
  {
    SceneManager.LoadScene("Game");
  }

}
