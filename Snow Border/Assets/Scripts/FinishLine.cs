using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEfect;
    private float delay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"&& !FindObjectOfType<Die>().getDead())
        {
            finishEfect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delay);
            
        }
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
