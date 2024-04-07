using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class RelatorioTarefaScrum : MonoBehaviour
{
    public struct tarefa
    {
        public string nome;
        public string sprint;
        public string duracao;
        public string descricao;
    }

    private string filePath;
    public TMP_Text duracao;
    public TMP_Text descricao;

    public List<tarefa> tarefaList = new List<tarefa>();

    public TMP_Dropdown dropdownSprint;
    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/TarefaScrumData.txt";
        ReadFromFile();
        setSprintDropdown();
        setDropdown();
        if (tarefaList.Count > 0)
        {
            duracao.text = "Data duracao: " + tarefaList[dropdown.value].duracao;
            descricao.text = "Data descricao: " + tarefaList[dropdown.value].descricao;
        }
    }
    private void setSprintDropdown()
    {
        List<string> sprints = new List<string>();
        dropdownSprint.options.Clear();

        foreach (tarefa tarefa in tarefaList)
        {
            // Converte para minúsculas para evitar problemas de diferenciação de maiúsculas e minúsculas
            string sprintLower = tarefa.sprint.ToLower();

            // Verifica se o valor da sprint ainda não está na lista sprints
            if (!sprints.Contains(sprintLower))
            {
                // Adiciona o valor à lista sprints e ao dropdown
                sprints.Add(sprintLower);
                dropdownSprint.options.Add(new TMP_Dropdown.OptionData(tarefa.sprint));
            }
        }
    }

    public void setDropdown()
    {
        dropdown.options.Clear();
        foreach (tarefa tarefa in tarefaList)
        {
            if(dropdownSprint.options[dropdownSprint.value].text == tarefa.sprint)
            dropdown.options.Add(new TMP_Dropdown.OptionData(tarefa.nome));
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
                    tarefaList.Add(new tarefa { nome = line, sprint = reader.ReadLine(), duracao = reader.ReadLine(), descricao = reader.ReadLine() });
                }
            }
        }
    }

    public void onChangeDropdown()
    {
        foreach (tarefa tarefa in tarefaList)
        {
            string nomeLow = tarefa.nome.ToLower();
            string nomeDropLow = dropdown.options[dropdown.value].text;
            if (tarefa.nome == nomeDropLow) {
                duracao.text = "Duracao: " + tarefa.duracao;
                descricao.text = "Descricao: " + tarefa.descricao;
            }
        }

    }
}
