using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenneskeListe : MonoBehaviour
{
    public List<GameObject> gameObjects;
    public GameObject[] array;

    // Start is called before the first frame update
    void Start()
    {
        array = GameObject.FindGameObjectsWithTag("Menneske");
        foreach (GameObject mennekse in array)
        {
            gameObjects.Add(mennekse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject mennekse in array)
        {
            if(mennekse == null)
            {
                gameObjects.Remove(mennekse);
            }
        }
        print(gameObjects.Count);
        if(gameObjects.Count == 1)
        {
            Invoke("Restart", 3);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
