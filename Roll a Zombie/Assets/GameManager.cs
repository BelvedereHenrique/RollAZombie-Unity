using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject SelectedZombie;
    public List<GameObject> Zombies;
    public Vector3 SelectedSize;
    public Vector3 DefaultSize;
    public Text ScoreText;
    private int Score = 0;
    private int SelectedZombieIndex = 0;
    // Use this for initialization
    void Start()
    {
        SelectZombie(SelectedZombie);
        ScoreText.text = "Score: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            GetLeftZombie();
        }
        if (Input.GetKeyDown("right"))
        {
            GetRightZombie();
        }
        if (Input.GetKeyDown("up"))
        {
            PushUp();
        }
    }

    void PushUp()
    {
        Rigidbody rigidBody = SelectedZombie.GetComponent<Rigidbody>();
        rigidBody.AddForce(0, 0, 8, ForceMode.Impulse);
    }

    void GetLeftZombie()
    {
        if (SelectedZombieIndex == 0)
        {
            SelectedZombieIndex = 3;
            SelectZombie(Zombies[3]);
        }
        else
        {
            SelectedZombieIndex = SelectedZombieIndex - 1;
            SelectZombie(Zombies[SelectedZombieIndex]);
        }
    }
    void GetRightZombie()
    {
        if (SelectedZombieIndex == 3)
        {
            SelectedZombieIndex = 0;
            SelectZombie(Zombies[0]);
        }
        else
        {
            SelectedZombieIndex = SelectedZombieIndex + 1;
            SelectZombie(Zombies[SelectedZombieIndex]);
        }
    }

    void SelectZombie(GameObject newZombie)
    {
        SelectedZombie.transform.localScale = DefaultSize;
        SelectedZombie = newZombie;
        newZombie.transform.localScale = SelectedSize;
    }

    public void AddPoint()
    {
        Score +=1;
        ScoreText.text = "Score : " + Score;
    }
}
