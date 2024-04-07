using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class ReleaseTextOutput : MonoBehaviour
{
    public struct release
    {
        public string nomeR;
        public string ordemR;
        public string iniR;
        public string fimR;
    }

    private string filePath;
    public TMP_Text nome;
    public TMP_Text ordem;
    public TMP_Text inicio;
    public TMP_Text fim;

    public List<release> releaseList = new List<release>();

    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/ReleaseData.txt";
        ReadFromFile();
        setDropdown();
        if (releaseList.Count > 0)
        {
            nome.text = "Nome: " + releaseList[dropdown.value].nomeR;
            ordem.text = "Ordem: " + releaseList[dropdown.value].ordemR;
            inicio.text = "Data Inicio: " + releaseList[dropdown.value].iniR;
            fim.text = "Data Fim: " + releaseList[dropdown.value].fimR;
        }
    }

    private void setDropdown()
    {
        dropdown.options.Clear();
        foreach (release release in releaseList)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(release.nomeR));
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
                    releaseList.Add(new release { nomeR = line, ordemR = reader.ReadLine(), iniR = reader.ReadLine(), fimR = reader.ReadLine() });
                }
            }
        }
    }

    public void onChangeDropdown()
    {
        nome.text = "Nome: " + releaseList[dropdown.value].nomeR;
        ordem.text = "Ordem: "+ releaseList[dropdown.value].ordemR;
        inicio.text = "Data Inicio: "+ releaseList[dropdown.value].iniR;
        fim.text = "Data Fim: "+ releaseList[dropdown.value].fimR;
    }


}
