using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayHid : MonoBehaviour
{
    public void OnEnable()
    {
        Invoke("HidGame", 3f);
    }
    public void HidGame() => gameObject.SetActive(false);
}
