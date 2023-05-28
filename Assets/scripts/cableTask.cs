using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cableTask : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    public void interact()
    {
        transform.tag = "Untagged";
        if (arrow != null)
            arrow.SetActive(false);
    }
}
