using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnController : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", interval, interval);
    }

    private void ShootBullet()
    {
        if(bullet != null)
        {
            GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
        }
            
    }
}
