using UnityEngine;

public class dontTurnOn : MonoBehaviour
{
    [SerializeField] Vector3 destination;
    [SerializeField] Vector3 rotation;
    [SerializeField] GameObject arrow;
    public void interact()
    {
        transform.position = destination;
        transform.eulerAngles = rotation;
        arrow.SetActive(false);
        transform.tag = "Untagged";
    }
}
