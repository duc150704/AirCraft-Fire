using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enermy;

    float spawnTime;
    [SerializeField] float m_spawnTime;

    [SerializeField] float xRightPos, xLeftPos, yUpPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnermyCtrl();
    }

    private void SpawnEnermyCtrl()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            SpawnEnermy();
            spawnTime = m_spawnTime;
        }

        
    }
    private void SpawnEnermy()
    {
        float ranXpos = Random.Range(xRightPos, xLeftPos);
        Vector2 spawnPos = new Vector2 (ranXpos, yUpPos);
        if (enermy)
        {
            GameObject SpawnedEnermy = Instantiate(enermy,spawnPos,Quaternion.identity);

            if (SpawnedEnermy)
            {
                Destroy(SpawnedEnermy,4f);
            }
        }
    }
}
