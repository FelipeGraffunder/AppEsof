using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class CadastroIteracao : MonoBehaviour
{
    private string filePath;

    public TMP_InputField TituloIF;
    public TMP_InputField releaseIF;
    public TMP_InputField dataIniIF;
    public TMP_InputField dataFimIF;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/iteracaoData.txt";
    }

    public void SalvarBut()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(TituloIF.text);
            writer.WriteLine(releaseIF.text);
            writer.WriteLine(dataIniIF.text);
            writer.WriteLine(dataFimIF.text);
        }
    }

}
