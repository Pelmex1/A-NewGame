using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    [SerializeField] private GameObject Firewood;
    private int[] prefab = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < prefab.Length; i++)
        { 
            float randomX = Random.Range(1, 10);
            float randomZ = Random.Range(-10, 10);
            Instantiate(Firewood, new Vector3(randomX, 1 , randomZ), Firewood.GetComponent<Transform>().rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
