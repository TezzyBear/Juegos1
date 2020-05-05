using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    protected float elapsedShooter;
    protected float totalShooter = 1f;
    protected float ySpeed;

    protected List<GameObject> bullets;

    public GameObject bulletControler;

    [SerializeField]
    protected GameObject bulletPrefab;
	
	// Update is called once per frame
	virtual protected void Update () {
        spawnBullet();   
	}

    protected void spawnBullet() {
        elapsedShooter += Time.deltaTime;
        if (elapsedShooter >= totalShooter) {
            elapsedShooter = 0;
            generateBullet();
        }
    }

    protected void generateBullet() {        
        GameObject bullet;      
        if (BulletController.instance.bulletPool.Count == 0) {
            bullet = Instantiate(bulletPrefab, new Vector3(0f,0f,0f), Quaternion.identity);                       
        } else {
            bullet = BulletController.instance.bulletPool.Dequeue();            
            bullet.SetActive(true);
        }
        bullet.transform.position = transform.position;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, ySpeed);
    }
}
