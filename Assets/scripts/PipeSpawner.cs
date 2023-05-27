using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject u_pipe;
    public GameObject d_pipe;
    public GameObject sc;
    public float cooldown;
    private float timer;
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(-1.5f, 2.3f), 0);

            Instantiate(d_pipe, new Vector3(transform.position.x, transform.position.y - 4f, 0), Quaternion.identity);
            Instantiate(sc, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            Instantiate(u_pipe, new Vector3(transform.position.x, transform.position.y + 4f, 0), Quaternion.identity);
            timer = cooldown;
        }
        timer -= Time.deltaTime;
    }
}
