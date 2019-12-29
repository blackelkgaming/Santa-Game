using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelObjects : MonoBehaviour
{
    public GameObject house;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (int i in Enumerable.Range(1, 45))
        {
            Instantiate(house, new Vector3(i*8, 2, 7), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
