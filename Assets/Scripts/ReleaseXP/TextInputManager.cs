using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class TextInputManager : MonoBehaviour
{
    private string filePath;

    public TMP_InputField TituloIF;
    public TMP_InputField ordemIF;
    public TMP_InputField dataIniIF;
    public TMP_InputField dataFimIF;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/releaseData.txt";
    }

    public void SalvarBut()
    {
        //releaseList.Add(new Release {titulo = TituloIF.text,ordem = ordemIF.text, dataIni = dataIniIF.text, dataFim = dataFimIF.text });
        using (StreamWriter writer = new StreamWriter(filePath,true))
        {
            writer.WriteLine(TituloIF.text);
            writer.WriteLine(ordemIF.text);
            writer.WriteLine(dataIniIF.text);
            writer.WriteLine(dataFimIF.text);
        }
    }



}
