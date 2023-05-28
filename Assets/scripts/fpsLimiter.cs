using UnityEngine;
[ExecuteAlways]
public class fpsLimiter : MonoBehaviour
{
    private void Update()
    {
        Application.targetFrameRate = 60;
    }
}
