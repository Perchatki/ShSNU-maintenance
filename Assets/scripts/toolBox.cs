using UnityEngine;

public class toolBox : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    public void interact()
    {
        gameObject.SetActive(false);
        transform.tag = "Untagged";
        if (arrow != null)
            arrow.SetActive(false);
    }
}
