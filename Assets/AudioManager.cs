using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private AudioSource player;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;// 方便调用
        player = GetComponent<AudioSource>();
    }

    // 播放音效
    public void Play(string name)
    {   
        // 通过名称获取音频
        AudioClip clip = Resources.Load<AudioClip>(name);
        player.PlayOneShot(clip);
    }
}
