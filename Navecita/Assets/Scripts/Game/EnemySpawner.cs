using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> enemiesToCreate;
    private List<GameObject> poolEnemies;

    public static EnemySpawner instance;

    private float elapsedGeneration = 9f;
    private float totalGeneration = 10f;

    private float minX;
    private float maxX;

    private void Awake()
    {
        instance = this;
        poolEnemies = new List<GameObject>();
        SetMinAndMax();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedGeneration += Time.deltaTime;
        if (elapsedGeneration >= totalGeneration) {
            elapsedGeneration = 0f;
            generateEnemy();
        }
    }

    void generateEnemy()
    {
        int index = 0;
        float posX = Random.Range(minX, maxX);
        if (poolEnemies.Count == 0) {
            index = Random.Range(0, enemiesToCreate.Count - 1);
            Vector3 temp = transform.position;
            temp.x = posX;
            GameObject ga = Instantiate(enemiesToCreate[index], temp, Quaternion.identity);
            poolEnemies.Add(ga);
        } else {
            while (true) {
                index = Random.Range(0, poolEnemies.Count - 1);
                if (!poolEnemies[index].activeInHierarchy) {
                    Vector3 temp = transform.position;
                    temp.x = posX;
                    poolEnemies[index].transform.position = temp;
                    poolEnemies[index].SetActive(true);
                    break;
                } else {
                    index = Random.Range(0, enemiesToCreate.Count - 1);
                    Vector3 temp = transform.position;
                    temp.x = posX;
                    GameObject ga = Instantiate(enemiesToCreate[index], temp, Quaternion.identity);
                    poolEnemies.Add(ga);
                    break;
                }
            }
        }   
    }

    void SetMinAndMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        minX = -bounds.x;
        maxX = bounds.x;
    }

    public void addToPool(GameObject ga) {
        poolEnemies.Add(ga);
    }
}
