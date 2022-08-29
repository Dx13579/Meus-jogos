using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroler : MonoBehaviour
{
    [SerializeField] float tork;
    private Rigidbody2D rb2d;
    private SurfaceEffector2D surfaceEffector;
    private float boostSpeed =  15f;
    private bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            BostPlayer();
        }
       

    }
    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(tork);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-tork);
        }
    }

    public void DisebleControls()
    {
        canMove = false;
    }
    private void BostPlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow)&& surfaceEffector.speed < 20)
        {
            surfaceEffector.speed = surfaceEffector.speed + boostSpeed;
        }else if (Input.GetKey(KeyCode.DownArrow) &&  surfaceEffector.speed > 5)
        {
            surfaceEffector.speed = surfaceEffector.speed - boostSpeed;
        }
        
    }
}
