using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    public float delaySpawn = 2f;
    public float intervalSpawn = 2f;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", delaySpawn, intervalSpawn);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SpawnObject()
    {
        Instantiate(prefab, transform);
    }
}
