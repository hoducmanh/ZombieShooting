using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private float xBound, zBound;
    private float yBound = 0f;
    public float xMin;
    public float xMax;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy());
    }
    IEnumerator spawnEnemy()
    {
        float dis = Random.Range(xMin, xMax);
        xBound = Random.Range(0, dis);
        zBound = Mathf.Sqrt(dis*dis -xBound*xBound);

        xBound = Random.Range(0, 2) > 0 ? xBound : -xBound;
        zBound = Random.Range(0, 2) > 0 ? zBound : -zBound;
        
        yield return new WaitForSeconds(Random.Range(1, 3));
        Instantiate(enemy, new Vector3(xBound, yBound, zBound), Quaternion.identity);
        StartCoroutine(spawnEnemy());
    }
}
