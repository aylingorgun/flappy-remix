using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public Manager managerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        managerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        managerScript.addScore();
    }
}
