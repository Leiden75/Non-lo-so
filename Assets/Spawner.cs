using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
 public GameObject oggettoDaSpawnare;
 public float intervalloDiSpawn = 2f;
 public Transform posizioneDiSpawn;
    void Start()
    {
        {
            InvokeRepeating("SpawnOggetto", 0f, intervalloDiSpawn);
        }
        void SpawnOggetto()
        {
            GameObject oggettoSpawnato = Instantiate(oggettoDaSpawnare, posizioneDiSpawn.position, posizioneDiSpawn.rotation);

        }
    }

    void Update()
    {

    }
}
