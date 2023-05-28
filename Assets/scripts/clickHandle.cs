using UnityEngine;
using UnityEngine.SceneManagement;
public class clickHandle : MonoBehaviour
{
    [SerializeField] GameObject _menu, _levels, _exam, _about, _login;

    public void menu()
    {
        _levels.SetActive(false);
        _menu.SetActive(true);
        _exam.SetActive(false);
        _about.SetActive(false);
        _login.SetActive(false);
    }
    public void Levels()
    {
        _levels.SetActive(true);
        _menu.SetActive(false);
        _exam.SetActive(false);
        _about.SetActive(false);
    }
    public void exam()
    {
        _levels.SetActive(false);
        _menu.SetActive(false);
        _exam.SetActive(true);
        _about.SetActive(false);
    }
    public void about()
    {
        _levels.SetActive(false);
        _menu.SetActive(false);
        _exam.SetActive(false);
        _about.SetActive(true);
    }
    public void tutorial()
    {
        SceneManager.LoadScene(1);
    }
}
