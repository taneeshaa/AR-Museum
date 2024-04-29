using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuseumGuide : MonoBehaviour
{
    [SerializeField] AudioSource introAudio;
    [SerializeField] GameObject Artefacts;
    void Start()
    {
        introAudio.Play();
        Invoke("EnableArtefacts", 35);
    }

    void Update()
    {

    }
    
    private void EnableArtefacts()
    {
        Instantiate(Artefacts);
    }
}