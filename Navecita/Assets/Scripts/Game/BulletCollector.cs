using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollector : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet") {
            other.gameObject.SetActive(false);
            BulletController.instance.bulletPool.Enqueue(other.gameObject);
        }
    }
}
