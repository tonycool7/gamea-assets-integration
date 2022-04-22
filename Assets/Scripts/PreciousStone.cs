using UnityEngine;

public class PreciousStone : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null) gameManager.WonGame();
    }
}
