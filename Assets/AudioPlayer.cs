using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public List<AudioClip> sources = new List<AudioClip>();

    public void OnUi()
    {
        AudioManager.Instance.PlaySound(sources[0], this.gameObject, 1f , 0f);
    }
    public void OnU()
    {
        AudioManager.Instance.PlaySound(sources[1], this.gameObject, 1.5f);
    }

    public void OnD()
    {
        AudioManager.Instance.PlaySound(sources[2], this.gameObject);
    }
    public void OnDi()
    {
        AudioManager.Instance.PlaySound(sources[3], this.gameObject);
    }
    public void OnL()
    {
        AudioManager.Instance.PlaySound(sources[4], this.gameObject);
    }

    public void OnLi()
    {
        AudioManager.Instance.PlaySound(sources[5], this.gameObject);
    }
    public void OnR()
    {
        AudioManager.Instance.PlaySound(sources[6], this.gameObject);
    }

    public void OnRi()
    {
        AudioManager.Instance.PlaySound(sources[7], this.gameObject);
    }

    public void OnF()
    {
        AudioManager.Instance.PlaySound(sources[8], this.gameObject);
    }

    public void OnFi()
    {
        AudioManager.Instance.PlaySound(sources[9], this.gameObject);
    }

}
