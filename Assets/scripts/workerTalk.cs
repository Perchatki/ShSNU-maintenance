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
            text.text = "������! �� ���������? �����\n� ������� ���� ���� ������\n� ��� ���� ������";
            i = 1;
        }
        else if (i == 1)
        {
            text.text = "������ ������ ���� ������ �\n������ ���� � �������������,\n��� ����� � �����!";
            shed.tag = "interactable";
            shedArrow.SetActive(true);
            i = 10;
        }
        else if (i == 3)
        {
            text.text = "������� ������� �������, �����\n�� ������ �� ��������������\n��� �� ����� ��������\n��������������� ��������";
            tablet.tag = "interactable";
            _switch.tag = "interactable";
            _switchArrow.SetActive(true);
            tabletArrow.SetActive(true);
            i = 9;
        }

        if (workIndex == 4 && i != 9)
        {
            text.text = "���� ������� - ���\n��������� ������ ��\n������� ��������������";
            i = 3;
        }
        else if (workIndex == 6)
        {
            text.text = "����� ����� ������� ����������,\n�������� ������, ������\n�� ��������� �������";
            wire.tag = "interactable";
            wireArrow.SetActive(true);
        }
        else if (workIndex == 7)
        {
            text.text = "������ ����� ���������\n������� �����, ���������\n��������� ���� �\n��������� ���������";
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
            text.text = "�������, �� ��������� �� �����\n���������, �������� �� ����\n��� ���, ����� ��������� ��������";
            i = 4;
        }
    }
}
