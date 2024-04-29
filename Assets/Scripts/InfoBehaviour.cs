using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{
    const float SPEED = 6f;

    [SerializeField]
    Transform SectionInfo;
    [SerializeField] public AudioSource voiceOver;
    [SerializeField] Animator anim;

    Vector3 desiredScale = Vector3.zero;
    void Update()
    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, SPEED * Time.deltaTime);
    }
    public void OpenInfo()
    {
        desiredScale = Vector3.one;
        //test voiceover stop
        anim.SetBool("isTalking", false);
        //voiceOver.Stop();
    }
    public void CloseInfo()
    {
        anim.SetBool("isTalking", true);
        desiredScale = Vector3.zero;
        voiceOver.Play();
    }
}
