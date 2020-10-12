using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    public GameObject finishedCanvas;
    private Health healthPlayer;

    public enum GameStates
    {
        Playing,
        GameOver
    }
    public GameStates gameState = GameStates.Playing;


    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();

        gameOverCanvas.SetActive(false);
        finishedCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }else if(healthPlayer.finishReached)
                {
                    gameState = GameStates.GameOver;
                    finishedCanvas.SetActive(true);
                    Destroy(player);
                }
                break;
        }
    }

}
