using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class CadastroHistoria : MonoBehaviour
{
    private string filePath;

    public TMP_InputField TituloIF;
    public TMP_InputField releaseIF;
    public TMP_InputField iteracaoIF;
    public TMP_InputField pontosIF;
    public TMP_InputField descricaoIF;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/HistoriaData.txt";
    }

    public void SalvarBut()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(TituloIF.text);
            writer.WriteLine(releaseIF.text);
            writer.WriteLine(iteracaoIF.text);
            writer.WriteLine(pontosIF.text);
            writer.WriteLine(descricaoIF.text);
        }
    }
}
