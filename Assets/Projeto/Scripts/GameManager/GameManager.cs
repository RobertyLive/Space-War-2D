using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text pontos, pontosText, pontosCount;
    public GameObject endGame, player, playerDestroy;

    public int valorG, valorM;

    bool isDone;

    private void Update() {
        
        if(player == null)
        {
            endGame.SetActive(true);
            if(isDone)
            {
                var obj = Instantiate(playerDestroy, player.transform.position, Quaternion.identity);
                Destroy(obj, 0.3f);
                isDone =false;
            }
            StartCoroutine(ReturnScene());
        }
    }

    IEnumerator ReturnScene()
    {
        yield return new WaitForSeconds(1.5f);
        pontos.gameObject.SetActive(false);
        pontosCount.text = pontos.text;

        yield return new WaitForSeconds(2f);
        
        SceneManager.LoadScene(0);
    }
}
