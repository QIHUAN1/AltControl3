using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AvatarHP : MonoBehaviour
{
    public int health = 2;

    [SerializeField] TextMeshProUGUI hp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hp.text = "HP:" + health.ToString("0");

        if (health <= 0)
        {
            health = 0;
        }
        
        if(health == 0)
        {
            SceneManager.LoadScene(2);
        }

    }
}
