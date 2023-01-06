using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenneskeListe : MonoBehaviour
{
    
    public List<GameObject> Mennesker = new List<GameObject>();
    public GameObject Menneske;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("AddHumanToList", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mennesker.Count==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("Scene reset");
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Mennesker.Remove(Menneske);
        }
    }


    public void AddHumanToList()
    {
        GameObject[] objs= GameObject.FindGameObjectsWithTag("Menneske");
        foreach( GameObject men in objs)
        {
            Mennesker.Add(men);
        }
        
    }

}
