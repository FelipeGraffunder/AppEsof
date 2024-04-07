using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class RelatorioBacklogProdutoScrum : MonoBehaviour
{
    public struct historia
    {
        public string nome;
        public string prioridade;
        public string descricao;
    }

    private string filePath;
    public TMP_Text nome;
    public TMP_Text prioridade;
    public TMP_Text descricao;

    public List<historia> historiaList = new List<historia>();

    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/BacklogProdutoData.txt";
        ReadFromFile();
        setDropdown();
        if (historiaList.Count > 0)
        {
            nome.text = "Nome: " + historiaList[dropdown.value].nome;
            prioridade.text = "Prioridade: " + historiaList[dropdown.value].prioridade;
            descricao.text = "Descricao: " + historiaList[dropdown.value].descricao;
        }
    }

    private void setDropdown()
    {
        dropdown.options.Clear();
        foreach (historia historia in historiaList)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(historia.nome));
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
                    historiaList.Add(new historia { nome = line, descricao = reader.ReadLine(), prioridade = reader.ReadLine()});
                }
            }
        }
    }

    public void onChangeDropdown()
    {
        nome.text = "Nome: " + historiaList[dropdown.value].nome;
        prioridade.text = "Prioridade: " + historiaList[dropdown.value].prioridade;
        descricao.text = "Descricao: " + historiaList[dropdown.value].descricao;
    }
}
