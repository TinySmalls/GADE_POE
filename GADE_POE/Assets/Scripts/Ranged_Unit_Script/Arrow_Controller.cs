﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Controller : MonoBehaviour
{
    public float arrowSpeed = 2;
    float currentTime = 0;
    public bool fire = false;
    public bool inMotion = false;
    GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        fire = false;
        gameManager = GameObject.FindGameObjectWithTag("Game Manager");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(this.gameObject.tag == "Blue Arrow")
        {
            if (gameObject.GetComponentInParent<Ranged_Unit_Blue>().canFire == true)
            {
                inMotion = true;
            }
            else
            {
                //inMotion = false;
            }

            if (currentTime >= gameManager.GetComponent<Game_Engine>().arrowFireInterval && inMotion == true)
            {
                transform.Translate(Vector3.forward * arrowSpeed * Time.deltaTime);

            }

            if (currentTime >= 7 && inMotion == true)
            {
                Destroy(this.gameObject);
            }
        }
        else if(this.gameObject.tag == "Red Arrow")
        {
            if (gameObject.GetComponentInParent<Ranged_Unit_Red>().canFire == true)
            {
                inMotion = true;
            }
            else
            {
                //inMotion = false;
            }

            if (currentTime >= gameManager.GetComponent<Game_Engine>().arrowFireInterval && inMotion == true)
            {
                transform.Translate(Vector3.forward * arrowSpeed * Time.deltaTime);

            }

            if (currentTime >= 7 && inMotion == true)
            {
                Destroy(this.gameObject);
            }
        }

       

    }

}