using UnityEngine;

public class InfiniteMotion : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        print($"speed:{gameManager.speed}");
        transform.position += Vector3.left * gameManager.speed * Time.deltaTime;
    }
}
