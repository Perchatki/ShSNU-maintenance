using UnityEngine;

public class wearForm : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    public void interact()
    {
        transform.tag = "Untagged";
        if (arrow != null)
            arrow.SetActive(false);
    }
}
