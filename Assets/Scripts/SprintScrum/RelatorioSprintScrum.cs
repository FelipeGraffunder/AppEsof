using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class RelatorioSprintScrum : MonoBehaviour
{
    public struct sprint
    {
        public string nome;
        public string goal;
        public string ini;
        public string fim;
    }

    private string filePath;
    public TMP_Text nome;
    public TMP_Text goal;
    public TMP_Text inicio;
    public TMP_Text fim;

    public List<sprint> sprintList = new List<sprint>();

    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/SprintData.txt";
        ReadFromFile();
        setDropdown();
        if (sprintList.Count > 0)
        {
            nome.text = "Nome: " + sprintList[dropdown.value].nome;
            goal.text = "goal: " + sprintList[dropdown.value].goal;
            inicio.text = "Inicio: " + sprintList[dropdown.value].ini;
            fim.text = "Fim: " + sprintList[dropdown.value].fim;
        }
    }

    private void setDropdown()
    {
        dropdown.options.Clear();
        foreach (sprint sprint in sprintList)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(sprint.nome));
        }
    }

    private void ReadFromFile()
    {
        // Verifique se o arquivo existe
        if (File.Exists(filePath))
        {
            // Abra o arquivo para leitura
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Leia cada linha do arquivo e adicione à lista
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sprintList.Add(new sprint { nome = line, goal = reader.ReadLine(), ini = reader.ReadLine(), fim = reader.ReadLine() });
                }
            }
        }
    }

    public void onChangeDropdown()
    {
        nome.text = "Nome: " + sprintList[dropdown.value].nome;
        goal.text = "goal: " + sprintList[dropdown.value].goal;
        inicio.text = "Inicio: " + sprintList[dropdown.value].ini;
        fim.text = "Fim: " + sprintList[dropdown.value].fim;
    }
}
