using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObjects : MonoBehaviour
{
    [Header("Meteoro Marrom")]
    public List<GameObject> meteorosBrownBIG;
    public List<GameObject> meteorosBrownMEDIUM;
    public List<GameObject> meteorosBrownSMALL;

    [Header("Meteoro Cinza")]
    public List<GameObject> meteorosGreyBIG;
    public List<GameObject> meteorosGreyMEDIUM;
    public List<GameObject> meteorosGreySMALL;

    [Header("Posicoes")]
    public Transform[] posicoes;

    
    [Header("Settigs")]
    public float speed;

    [Header("Player")]
    public Transform player;

    public float time, timeSpawn = 2f, size;

    private GameObject obj, obj2;


    public void Update()
    {
        

        time = Time.time;
        if(time > timeSpawn)
        {
            obj = Instantiate(meteorosBrownBIG[Random.Range(0, meteorosBrownBIG.Count)], posicoes[Random.Range(0, posicoes.Length)].position, Quaternion.identity);
            obj2 = Instantiate(meteorosGreyBIG[Random.Range(0, meteorosGreyBIG.Count)], posicoes[Random.Range(0, posicoes.Length)].position, Quaternion.identity);
            
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)) * speed * Time.deltaTime;
            obj2.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)) * speed * Time.deltaTime;

            timeSpawn = time + size;

            if(time >= 10 && time <= 20)
            {
                size = 1;
            }
            else if(time >= 20 && time <= 30)
            {
                size = 0.5f;
            }
            else if(time >= 30)
            {
                size = 0.1f;
            }
        }
    }

}
