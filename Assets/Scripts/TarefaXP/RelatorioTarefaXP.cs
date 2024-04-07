using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class RelatorioTarefaXP : MonoBehaviour
{
    public struct tarefa
    {
        public string titulo;
        public string historia;
        public string dev;
        public string descricao;
    }

    private string filePath;
    public TMP_Text nome;
    public TMP_Text historia;
    public TMP_Text dev;
    public TMP_Text descricao;

    public List<tarefa> tarefaList = new List<tarefa>();

    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/TarefaData.txt";
        ReadFromFile();
        setDropdown();
        if (tarefaList.Count > 0)
        {
            nome.text = "Nome: " + tarefaList[dropdown.value].titulo;
            historia.text = "Historia: " + tarefaList[dropdown.value].historia;
            dev.text = "Dev: " + tarefaList[dropdown.value].dev;
            descricao.text = "Descricao: " + tarefaList[dropdown.value].descricao;
        }
    }

    private void setDropdown()
    {
        dropdown.options.Clear();
        foreach (tarefa tarefa in tarefaList)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(tarefa.titulo));
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
                    tarefaList.Add(new tarefa { titulo = line, historia = reader.ReadLine(), dev = reader.ReadLine(), descricao = reader.ReadLine() });
                }
            }
        }
    }

    public void onChangeDropdown()
    {
        nome.text = "Nome: " + tarefaList[dropdown.value].titulo;
        historia.text = "Historia: " + tarefaList[dropdown.value].historia;
        dev.text = "Dev: " + tarefaList[dropdown.value].dev;
        descricao.text = "Descricao: " + tarefaList[dropdown.value].descricao;
    }
}
