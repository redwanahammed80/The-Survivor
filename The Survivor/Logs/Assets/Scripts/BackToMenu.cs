using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(Abc());
    }
    IEnumerator Abc()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(4);
    }
}
