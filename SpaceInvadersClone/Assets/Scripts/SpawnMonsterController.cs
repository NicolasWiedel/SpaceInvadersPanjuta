using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterController : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public float interval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);
    }

    private void SpawnMonster()
    {
        float value = Random.value;

        if(value < 0.2f)
        {
            GameObject go = (GameObject)Instantiate(monster1, transform.position, Quaternion.identity);
        }
        else if (value < 0.4f)
        {
            GameObject go = (GameObject)Instantiate(monster2, transform.position, Quaternion.identity);
        }
    }
}
