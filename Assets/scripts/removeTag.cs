using UnityEngine;

public class removeTag : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    public void interact()
    {
        tag = "Untagged";
        arrow.SetActive(false);
    }
}
