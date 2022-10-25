using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    
    public static AudioManager Instance;
    public GameObject audioSourcePrefab;


    void Awake()
    {
        

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound (AudioClip clip, GameObject objectToPlayOn)
    {
        AudioSource.PlayClipAtPoint(clip, objectToPlayOn.transform.position);
    }

    public void PlaySound (AudioClip clip, GameObject objectToPlayOn, float pitch, float spatialBlend = 1f)
    {
        AudioSource mySource = Instantiate(audioSourcePrefab).GetComponent<AudioSource>();
        mySource.pitch = pitch;
        mySource.spatialBlend = spatialBlend;
        mySource.clip = clip;
        mySource.Play();


        Destroy(mySource.gameObject, mySource.clip.length);
    }
}
