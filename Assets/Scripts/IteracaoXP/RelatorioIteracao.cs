using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class RelatorioIteracao : MonoBehaviour
{
    public struct iteracao
    {
        public string nomeR;
        public string releaseR;
        public string iniR;
        public string fimR;
    }

    private string filePath;
    public TMP_Text nome;
    public TMP_Text release;
    public TMP_Text inicio;
    public TMP_Text fim;

    public List<iteracao> iteracaoList = new List<iteracao>();

    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/iteracaoData.txt";
        ReadFromFile();
        setDropdown();
        if (iteracaoList.Count > 0)
        {
            nome.text = "Nome: " + iteracaoList[dropdown.value].nomeR;
            release.text = "release: " + iteracaoList[dropdown.value].releaseR;
            inicio.text = "Data Inicio: " + iteracaoList[dropdown.value].iniR;
            fim.text = "Data Fim: " + iteracaoList[dropdown.value].fimR;
        }
    }

    private void setDropdown()
    {
        dropdown.options.Clear();
        foreach (iteracao iteracao in iteracaoList)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(iteracao.nomeR));
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
                    iteracaoList.Add(new iteracao { nomeR = line, releaseR = reader.ReadLine(), iniR = reader.ReadLine(), fimR = reader.ReadLine() });
                }
            }
        }
    }

    public void onChangeDropdown()
    {
        nome.text = "Nome: " + iteracaoList[dropdown.value].nomeR;
        release.text = "release: " + iteracaoList[dropdown.value].releaseR;
        inicio.text = "Data Inicio: " + iteracaoList[dropdown.value].iniR;
        fim.text = "Data Fim: " + iteracaoList[dropdown.value].fimR;
    }
}
