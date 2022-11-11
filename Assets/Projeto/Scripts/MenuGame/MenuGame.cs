using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuGame : MonoBehaviour
{
    [SerializeField] private bool canStart = true;
    public List<GameObject> texts;
    public GameObject textPlayer;
    public float time;
    public string nameScene;
    public GameObject txtPontos;
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canStart || Input.anyKeyDown)
        {
            canStart = false;
            StartCoroutine(StartScene());
        }

        if(Input.anyKeyDown)
        {
            Debug.Log("Apertado");
        }
    }

    IEnumerator StartScene()
    {
        foreach(GameObject i in texts)
        {
            i.SetActive(false);
        }
        yield return new WaitForSeconds(time);
        textPlayer.SetActive(true);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(nameScene);
    }
}
