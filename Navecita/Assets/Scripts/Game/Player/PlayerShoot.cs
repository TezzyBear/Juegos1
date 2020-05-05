using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : Shooter {
    
	void Start () {        
        totalShooter = 0.1f;
        ySpeed = 8f;        
	}

    override protected void Update()
    {
        if(Input.GetKey(KeyCode.Space)) {
            spawnBullet();
        }
    }
}
