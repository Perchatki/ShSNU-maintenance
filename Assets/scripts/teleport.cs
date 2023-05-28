using UnityEngine;

public class teleport : MonoBehaviour
{
    [SerializeField] Vector3 point;
    [SerializeField] Vector3 rotation;
    [SerializeField] Transform player;
    [SerializeField] GameObject arrow;

    public void interact()
    {
        player.transform.position = point;
        player.transform.eulerAngles = rotation;
        transform.tag = "Untagged";
        if (arrow != null)
            arrow.SetActive(false);
    }
}
