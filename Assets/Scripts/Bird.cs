using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    public float flapSpeed = 3;
    public Manager managerScript;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        managerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && birdIsAlive)
            this.GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * flapSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        managerScript.gameOver();
        birdIsAlive = false;
    }
}
