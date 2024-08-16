using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public bool Kendrick = false;
    public bool Nikhil = false;

    public GameObject KendrickPlayer;
    public GameObject NikhilPlayer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KendrickSelect()
    {
        Kendrick = true;
        Nikhil = false;
    }

    public void NikhilSelect()
    {
        Kendrick = false;
        Nikhil = true;
    }

    public void LoadPlayer()
    {
        if (Kendrick)
        {
            Instantiate(KendrickPlayer, new Vector3(0, 0, -2), Quaternion.identity);
        }
        else
        {
            Instantiate(NikhilPlayer, new Vector3(0, 0, -2), Quaternion.identity);
        }
    }
}
