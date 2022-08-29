using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    [SerializeField] ParticleSystem dieEffect;
    [SerializeField] AudioClip dieSound;
    private float delay = 5f;
    bool dead = false;

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
        if(gameObject.tag== "HeadPlayer"&& other.tag=="Ground"&& !dead)
        {
            dead = true;
            FindObjectOfType<PlayerConroler>().DisebleControls();
            dieEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(dieSound);
            Invoke("ReloadScene", delay);
        }
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    public bool getDead()
    {
        return dead;
    }
}

