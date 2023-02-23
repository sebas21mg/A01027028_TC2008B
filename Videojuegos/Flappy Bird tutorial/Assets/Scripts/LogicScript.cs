using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
  public int playerScore;
  public Text scoreText;
  public GameObject gameOverScreen;
  public BirdScript bird;
  public PipeSpawnerScript pipeSpawner;
  public PipeMoveScript pipeMove;

  void Start()
  {
    enableScripts(true);
  }

  public void addScore(int scoreToAdd)
  {
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
  }

  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    enableScripts(true);
  }

  public void gameOver()
  {
    gameOverScreen.SetActive(true);

    bird.birdIsAlive = false;
    bird.myRigidBody.gravityScale = 0;
    bird.myRigidBody.velocity = Vector2.zero;

    enableScripts(false);
  }

  private void enableScripts(bool enabling)
  {
    pipeSpawner.enable = enabling;
    pipeMove.enable = enabling;
  }
}
