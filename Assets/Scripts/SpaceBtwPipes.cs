using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBtwPipes : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            gameManager.AddPoints();
        }
    }
}
