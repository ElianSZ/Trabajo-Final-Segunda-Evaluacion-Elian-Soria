using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject enemyPrefab;

    private float spawnRate = 3f;
    private float startDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawnRandomTarget");
    }

    // Update is called once per frame
    void Update()
    {
        // Invoca repetidamente la funci�n spawnRandomTarget
        InvokeRepeating("spawnRandomTarget", startDelay, spawnRate);
    }

    // Controlador de spawnear los obst�culos
    private IEnumerator spawnRandomTarget()
    {
        // while (!gameOver)
        // {
        // Cada 3s se spawnea un obst�culo
        yield return new WaitForSeconds(spawnRate);

        // Instancia los obst�culos
        Instantiate(enemyPrefab, spawnPosition.transform.position, spawnPosition.transform.rotation);
        // }
    }
}
