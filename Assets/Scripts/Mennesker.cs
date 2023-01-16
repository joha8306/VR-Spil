using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mennesker : MonoBehaviour
{
    public List<GameObject> mennesker = new List<GameObject>();
    public GameObject Menneske;
    void Start()
    {
        Invoke("AddHumanToList", 0);
    }

    void Update()
    {
        if (mennesker.Count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("Scene reset");
        }


    }




    public void AddHumanToList()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Menneske");
        foreach (GameObject men in objs)
        {
            mennesker.Add(men);
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Wall")
        {
            Destroy(gameObject);
        }

        if (collision.collider.tag == "CannonBall")
        {
            Destroy(gameObject);
        }
        mennesker.Remove(this.gameObject);
    }

}
