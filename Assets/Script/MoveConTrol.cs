using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LaserPointer;

public class MoveConTrol : MonoBehaviour
{
    public OVRInput.Button joyPadClickButton,X,Y;
    public Animator ani;
    public bool iSOpen = false,iSOpenLaser=false;
    public GameObject FaceUI;
    public LaserPointer laser;
    // Start is called before the first frame update
    void Start()
    {
        laser.laserBeamBehavior = LaserBeamBehavior.Off;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(Y))
        {
            iSOpenLaser = !iSOpenLaser;
            if (iSOpenLaser)
            {
                laser.laserBeamBehavior = LaserBeamBehavior.On;
            }
            else
                laser.laserBeamBehavior = LaserBeamBehavior.Off;
        }
        if (OVRInput.Get(joyPadClickButton))
        {
            ani.SetTrigger("Walk");
        }
        else
            ani.SetTrigger("idle");
        if (OVRInput.GetDown(X))
        {
            iSOpen = !iSOpen;
            if (iSOpen == true)
                FaceUI.SetActive(true);
            else FaceUI.SetActive(false);
        }
    }
}
