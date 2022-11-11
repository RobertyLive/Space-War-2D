using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cool : MonoBehaviour
{
    public GameManager gameManager;

    [Header("Time To Destroy")]
    public float timeToDestroy;

    [SerializeField] private SpawnedObjects spawnedObjects;
    GameObject obj;

    void Start()
    {
        Destroy(gameObject, 1f);
        spawnedObjects = GameObject.Find("SpwnedAsteroids").GetComponent<SpawnedObjects>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void ChangePontos(int n)
    {
        gameManager.valorG += n;
    
        gameManager.pontos.text = gameManager.valorG.ToString(); 
    }


    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Meteoro")
        {
            ChangePontos(5);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Vector2 lastPos = other.gameObject.transform.position;
            obj = Instantiate(spawnedObjects.meteorosBrownMEDIUM[Random.Range(0, spawnedObjects.meteorosBrownMEDIUM.Count)], lastPos, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        }

        if(other.gameObject.tag == "MeteoroMedium")
        {
            ChangePontos(2);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Vector2 lastPos = other.gameObject.transform.position;
            obj = Instantiate(spawnedObjects.meteorosBrownSMALL[Random.Range(0, spawnedObjects.meteorosBrownSMALL.Count)], lastPos, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));

            Destroy(obj, 1.5f);
        }

        if(other.gameObject.tag == "MeteoroCinza")
        {
            ChangePontos(5);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Vector2 lastPos = other.gameObject.transform.position;
            obj = Instantiate(spawnedObjects.meteorosGreyMEDIUM[Random.Range(0, spawnedObjects.meteorosGreyMEDIUM.Count)], lastPos, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        }

        if(other.gameObject.tag == "MeteoroMediumCinza")
        {
            ChangePontos(2);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Vector2 lastPos = other.gameObject.transform.position;
            obj = Instantiate(spawnedObjects.meteorosGreySMALL[Random.Range(0, spawnedObjects.meteorosGreySMALL.Count)], lastPos, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));

            Destroy(obj, 1.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "DestroyBullet")
        {
            Destroy(this.gameObject);
        }
    }
}
