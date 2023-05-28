using UnityEngine;
using UnityEngine.SceneManagement;

public class workerTalk : MonoBehaviour
{
    int i = 0;
    public int workIndex = 0;
    [SerializeField] TMPro.TMP_Text text;
    [SerializeField] GameObject menu;
    [SerializeField] Collider shed;
    [SerializeField] Collider tablet, _switch;
    [SerializeField] Collider wire;
    [SerializeField] Collider[] check;
    [SerializeField] GameObject shedArrow;
    [SerializeField] GameObject tabletArrow, _switchArrow;
    [SerializeField] GameObject wireArrow;
    [SerializeField] GameObject[] checkArrow;
    public void interact()
    {

        if (i == 0)
        {
            menu.SetActive(true);
            text.text = "Привет! ты новенький? Давай\nя объясню тебе суть работы\nи дам пару уроков";
            i = 1;
        }
        else if (i == 1)
        {
            text.text = "Сперва надень спец одежду и\nвозьми ящик с инструментами,\nони лежат в будке!";
            shed.tag = "interactable";
            shedArrow.SetActive(true);
            i = 10;
        }
        else if (i == 3)
        {
            text.text = "Выключи питание качалки, нажав\nна кнопку на трансформаторе\nтак же нужно повесить\nпредупреждающую табличку";
            tablet.tag = "interactable";
            _switch.tag = "interactable";
            _switchArrow.SetActive(true);
            tabletArrow.SetActive(true);
            i = 9;
        }

        if (workIndex == 4 && i != 9)
        {
            text.text = "Твое задание - это\nпроверить станок на\nналичие неисправностей";
            i = 3;
        }
        else if (workIndex == 6)
        {
            text.text = "После этого проверь заземление,\nосмотрев провод, идущий\nот основания качалки";
            wire.tag = "interactable";
            wireArrow.SetActive(true);
        }
        else if (workIndex == 7)
        {
            text.text = "Теперь нужно проверить\nналичие шумов, треснутых\nсварочных швов и\nнерабочих элементов";
            int j = 0;
            foreach (Collider i in check)
            {
                i.tag = "interactable";
                checkArrow[j].SetActive(true);
                j++;
            }
        }
        else if (workIndex > 10)
        {
            if (i == 4)
            {
                SceneManager.LoadScene(0);
            }
            text.text = "Молодец, ты справился со всеми\nзаданиями, поговори со мной\nещё раз, чтобы закончить обучение";
            i = 4;
        }
    }
}
