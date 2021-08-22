using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] section;
    public int zpos = 401;
    public bool creatingsection = false;
    public int secNum;


    // Update is called once per frame
    void Update()
    {
        if (creatingsection == false)
        {
            creatingsection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 1);
        Instantiate(section[secNum], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += 401;
        yield return new WaitForSeconds(10);
        creatingsection = false;
    }
}
