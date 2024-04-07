using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class CadastroTarefasXP : MonoBehaviour
{
    private string filePath;

    public TMP_InputField TituloIF;
    public TMP_InputField historiaIF;
    public TMP_InputField devIF;
    public TMP_InputField descricaoIF;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/TarefaData.txt";
    }

    public void SalvarBut()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(TituloIF.text);
            writer.WriteLine(historiaIF.text);
            writer.WriteLine(devIF.text);
            writer.WriteLine(descricaoIF.text);
        }
    }
}
