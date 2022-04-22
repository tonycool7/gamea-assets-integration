using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Button restartBtn;
    public GameObject UiMenu;
    public GameObject pointGameObject;
    public GameObject gameStateTextObj;

    private TextMeshProUGUI pointText;
    private TextMeshProUGUI gameStateText;
    private float _pointCount = 0;
    private float _speed = 2f;
    private float _spawnTime = 4.5f;

    public float speed { get { return _speed; } private set { _speed = value; } }
    public float spawnTime { get { return _spawnTime; } private set { _spawnTime = value; } }
    public float pointCount { get { return _pointCount; } private set { _pointCount = value; } }

    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        else Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1;
        restartBtn.onClick.AddListener(RestartGame);
        pointText = pointGameObject.GetComponent<TMPro.TextMeshProUGUI>();
        gameStateText = gameStateTextObj.GetComponent<TMPro.TextMeshProUGUI>();
    }

    public void AddPoints()
    {
        pointCount += 1;
        pointText.text = pointCount.ToString();
        if (pointCount == 5) increaseDifficulty("normal");
        if (pointCount == 10) increaseDifficulty("hard");
        if (pointCount == 20) increaseDifficulty("difficult");
    }

    private void increaseDifficulty(string difficultyType)
    {
        switch (difficultyType)
        {
            case "normal":
                this.spawnTime -= 1f;
                break;
            case "hard":
                this.speed += 1.2f;
                this.spawnTime -= 1f;
                break;
            case "difficult":
                this.speed += 1.2f;
                this.spawnTime -= 1f;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    public void WonGame()
    {
        gameStateText.text = "You Win!";
    }

    void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        UiMenu.SetActive(true);
    }
}
