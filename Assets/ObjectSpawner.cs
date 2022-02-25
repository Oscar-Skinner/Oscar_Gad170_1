using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject prefab;

    public int amountToSpawn = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        //  variable,  compare to spawn,  increase value
        for(int i = 0; i < amountToSpawn; i++)
        {
            //create random position to spawn at
            Vector3 pos = new Vector3(transform.position.x + Random.Range(-20f, 20f),
                                      transform.position.y,
                                      transform.position.z + Random.Range(-20f, 20f));

        //Spawn object at our location.
            Instantiate(prefab, pos, transform.rotation);
        }
        


    }
    
    
    
}
