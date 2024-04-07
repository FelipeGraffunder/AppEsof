using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class RelatorioHistoriaXP : MonoBehaviour
{
    public struct historia
    {
        public string nomeR;
        public string releaseR;
        public string iteracao;
        public string pontos;
        public string descricao;
    }

    private string filePath;
    public TMP_Text nome;
    public TMP_Text release;
    public TMP_Text iteracao;
    public TMP_Text pontos;
    public TMP_Text descricao;

    public List<historia> historiaList = new List<historia>();

    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/HistoriaData.txt";
        ReadFromFile();
        setDropdown();
        if (historiaList.Count > 0)
        {
            nome.text = "Nome: " + historiaList[dropdown.value].nomeR;
            release.text = "Release: " + historiaList[dropdown.value].releaseR;
            iteracao.text = "Iteracao: " + historiaList[dropdown.value].iteracao;
            pontos.text = "Pontos: " + historiaList[dropdown.value].pontos;
            descricao.text = "Descrição: " + historiaList[dropdown.value].descricao;
        }
    }

    private void setDropdown()
    {
        dropdown.options.Clear();
        foreach (historia historia in historiaList)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(historia.nomeR));
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
                    historiaList.Add(new historia { nomeR = line, releaseR = reader.ReadLine(), iteracao = reader.ReadLine(), pontos = reader.ReadLine(), descricao = reader.ReadLine() });
                }
            }
        }
    }

    public void onChangeDropdown()
    {
        nome.text = "Nome: " + historiaList[dropdown.value].nomeR;
        release.text = "Release: " + historiaList[dropdown.value].releaseR;
        iteracao.text = "Iteracao: " + historiaList[dropdown.value].iteracao;
        pontos.text = "Pontos: " + historiaList[dropdown.value].pontos;
        descricao.text = "Descrição: " + historiaList[dropdown.value].descricao;
    }
}
