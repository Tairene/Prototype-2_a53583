using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCooldown = 1.0f; // Tempo de espera entre as gerações de cão
    private float lastSpawnTime; // Tempo da última geração de cão

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime >= spawnCooldown)
        {
            SpawDog();
        }
    }
    void SpawDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        lastSpawnTime = Time.time; // Atualiza o tempo da última geração de cão
    }
}
