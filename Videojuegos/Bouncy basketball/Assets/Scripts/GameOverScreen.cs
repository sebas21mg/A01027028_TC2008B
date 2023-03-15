// Sebastian Moncada y Samuel Acevedo
// Pantalla para reiniciar el juego

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    [SerializeField] private AudioSource gameOverSound;
    public TextMeshProUGUI ScoreText;

    // * Configurar la pantalla de reinicio
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

    // * Cuando se pulse el botón para reiniciar el juego
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

}
