using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 1;
    private float deadZone = -3;
 
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
            Destroy(this.gameObject);
    }
}
