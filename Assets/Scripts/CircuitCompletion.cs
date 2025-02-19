using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircuitCompletion : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Bille"))
        {

            StartCoroutine(ReloadSceneAfterDelay(5f));
        }
    }


    IEnumerator ReloadSceneAfterDelay(float delay)
    {

        yield return new WaitForSeconds(delay);


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}