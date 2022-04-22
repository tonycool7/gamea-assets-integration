using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float velocity = 2;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            rigidBody.velocity += Vector2.up * velocity;
        }
    }
}
