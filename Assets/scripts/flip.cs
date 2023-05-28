using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    [SerializeField] Transform trans;
    [SerializeField] GameObject arrow;
    [SerializeField] Animator anim;
    [SerializeField] rotateWheel wheel;
    bool stop = false;

    public void interact()
    {
        trans.localEulerAngles = -trans.localEulerAngles;
        arrow.SetActive(false);
        transform.tag = "Untagged";
        stop = true;
    }

    private void Update()
    {
        if (stop)
        {
            if (anim.speed > 0)
            {
                anim.speed -= .2f * Time.deltaTime;
            }
            else
            {
                anim.speed = 0;
            }
            if (wheel.rpm > 0)
            {
                wheel.rpm -= 10f * Time.deltaTime;
            }
        }
    }
}
