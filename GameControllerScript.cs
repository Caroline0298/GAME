using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public int qntInimigo, maxInimigos;
    public GameObject inimigo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(inimigo, new Vector3(Random.Range(-8.3f, 8.3f), 
                                         transform.position.y, 
                                         transform.position.z), 
                                         Quaternion.identity);
        qntInimigo++;
        if(qntInimigo < maxInimigos)
        {
            StartCoroutine(Delay());
        }
    }
}
