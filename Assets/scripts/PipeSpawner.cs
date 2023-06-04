using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject u_pipe;
    public GameObject d_pipe;
    public GameObject sc;
    public GameObject gb;
    public GameObject buff;
    public GameObject slow;
    public GameObject ds;
    public float cooldown;
    private float timer;

    void Update()
    {
        if (timer <= 0)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(-1.5f, 2.3f), 0);
            int idk = Random.Range(1, 60);
            if (idk == 1)
            {
                Instantiate(buff, new Vector3(transform.position.x, transform.position.y, -0.1f), Quaternion.identity);
            }
            if (idk == 2)
            {
                Instantiate(slow, new Vector3(transform.position.x, transform.position.y, -0.1f), Quaternion.identity);
            }
            if (idk == 3)
            {
                Instantiate(ds, new Vector3(transform.position.x, transform.position.y, -0.1f), Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("gb") == 0)
            {
                idk = Random.Range(1, 250);
                if (idk == 1)
                {
                    Instantiate(gb, new Vector3(transform.position.x, transform.position.y, -0.1f), Quaternion.identity);
                }
            }
            Instantiate(d_pipe, new Vector3(transform.position.x, transform.position.y - 4f, -0.1f), Quaternion.identity);
            Instantiate(sc, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            Instantiate(u_pipe, new Vector3(transform.position.x, transform.position.y + 4f, -0.1f), Quaternion.identity);
            timer = cooldown / difficulty.value;
        }
        timer -= Time.deltaTime;
    }
}
