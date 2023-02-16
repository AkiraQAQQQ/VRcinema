using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class FaceUIManager : MonoBehaviour
{
    public GameObject []iSSelect;
    public Button[] bt;
    public GameObject[] ShowFace;
    public int CurrentID=-1;
    //สำฦต
    public VideoPlayer v;
    //
    public Button PlayBt, StopBt;
    // Start is called before the first frame update
    void Start()
    {
        bt[0].onClick.AddListener(Bt1);
        bt[1].onClick.AddListener(Bt2);
        bt[2].onClick.AddListener(Bt3);
        bt[3].onClick.AddListener(Bt4);
        bt[4].onClick.AddListener(Bt5);
        bt[5].onClick.AddListener(Bt6);
        bt[6].onClick.AddListener(Bt7);
        bt[7].onClick.AddListener(Bt8);
        bt[8].onClick.AddListener(Fire);
        PlayBt.onClick.AddListener(PlayVideo);
        StopBt.onClick.AddListener(StopVideo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Bt1()
    {
        ShowSl(0);
    }
    public void Bt2()
    {
        ShowSl(1);
    }
    public void Bt3()
    {
        ShowSl(2);
    }
    public void Bt4()
    {
        ShowSl(3);
    }
    public void Bt5()
    {
        ShowSl(4);
    }
    public void Bt6()
    {
        ShowSl(5);
    }
    public void Bt7()
    {
        ShowSl(6);
    }
    public void Bt8()
    {
        ShowSl(7);
    }
    public void Fire()
    {
        ShowSl(10);
        for(int i=0;i<ShowFace.Length;i++)
        {
            if(i==CurrentID)
            {
                ShowFace[i].SetActive(true);

            }
            else
            {
                ShowFace[i].SetActive(false);
            }
        }
    }
    public void PlayVideo()
    {
        PlayBt.gameObject.SetActive(false);
        StopBt.gameObject.SetActive(true);
        v.Play();
    }

    public void StopVideo()
    {
        StopBt.gameObject.SetActive(false);
        PlayBt.gameObject.SetActive(true);
        if (v.isPlaying)
            v.Pause();

    }
    public void ShowSl(int n)
    {
        for (int i = 0; i < iSSelect.Length; i++)
        {
            if (i == n)
            {
                CurrentID = n;
                iSSelect[i].SetActive(true);
            }
            else
                iSSelect[i].SetActive(false);
        }
    }
}
