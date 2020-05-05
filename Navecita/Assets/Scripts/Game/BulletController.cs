using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public static BulletController instance;
    public Queue<GameObject> bulletPool;

    private void Awake()
    {
        if (instance != this || instance != null) {
            Destroy(gameObject);
        }
        instance = this;
        bulletPool = new Queue<GameObject>();
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
