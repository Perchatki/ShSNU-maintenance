using UnityEngine;
using TMPro;

public class loginManager : MonoBehaviour
{
    [SerializeField] clickHandle x;
    [SerializeField] TMP_InputField login, password;

    public void checkPassword()
    {
        if (login.text == "asd" && password.text == "asd")
        {
            x.menu();
        }
        if (login.text == "login" && password.text == "password")
        {
            x.menu();
        }
        if (login.text == "worker" && password.text == "123qwe")
        {
            x.menu();
        }
    }
    public void reset()
    {
        login.text = "";
        password.text = "";
    }
}
