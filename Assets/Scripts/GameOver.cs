using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public TMP_Text  seconds;
    public bool isGameOver;
    void Start()
    {
        isGameOver = false;
        FindFirstObjectByType<Movement>().playerDeath +=onGameOver;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene(0);
            }
        }
    }
    public void onGameOver()
{
    if (isGameOver) return;  

    gameOver.SetActive(true);
    seconds.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
    isGameOver = true;
}
}
