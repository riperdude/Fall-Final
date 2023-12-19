using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = false;

    public Button replayBotton;
    public Button startButton;
    public GameObject coinText;

    // Start is called before the first frame update
    void Start()
    {
        replayBotton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        coinText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GameOver()
    {
        isGameActive = false;
        replayBotton.gameObject.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PressReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PressStartButton()
    {
        isGameActive = true;
        coinText.SetActive(true);
        startButton.gameObject.SetActive(false);
        GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().SpawnCollectableObject();
        GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().SpawnCollectableObject();
    }
}
