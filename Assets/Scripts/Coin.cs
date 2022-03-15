using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private SFXManager sfxManager;
    private GameManager gamemanager;
    // Start is called before the first frame update
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("MuereMario"))
        {
            Destroy(this.gameObject);
            sfxManager.CoinSound();
            gamemanager.ContadorMonedas();
            
        }

    }
}

