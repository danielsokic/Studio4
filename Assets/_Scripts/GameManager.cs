using TMPro;
using UnityEngine;

public class GameManager : SingletonMonoBehavior<GameManager>
{
    [SerializeField] private CoinCounterUI coinCounter;
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    protected override void Awake()
    {
        base.Awake();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void IncreaseScore()
    {
         score++;
    if (coinCounter != null)
    {
        coinCounter.UpdateScore(score);
    }
    else
    {
        Debug.LogError("coinCounter reference is missing in GameManager!");
    }

    }
}
