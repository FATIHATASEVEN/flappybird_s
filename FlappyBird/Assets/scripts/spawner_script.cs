using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_script : MonoBehaviour
{
    public Bird_scripts birdd;
    public GameObject barriers;
    public float height;
    public float time;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time )
    {
        while(!birdd.isDead)
        {
            Instantiate(barriers, new Vector3(3, Random.Range(-height,height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
