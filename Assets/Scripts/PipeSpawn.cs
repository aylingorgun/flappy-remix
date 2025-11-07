using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float heightOffset = 1;
    public float timer = 0;
    public float spawnRate = 1;

    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heightPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heightPoint), 0), transform.rotation);
    }
}
