using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class CadastroTarefaScrum : MonoBehaviour
{
    private string filePath;

    public TMP_InputField nome;
    public TMP_InputField sprint;
    public TMP_InputField duracao;
    public TMP_InputField descricao;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/TarefaScrumData.txt";
    }

    public void SalvarBut()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(nome.text);
            writer.WriteLine(sprint.text);
            writer.WriteLine(duracao.text);
            writer.WriteLine(descricao.text);
        }
    }
}
