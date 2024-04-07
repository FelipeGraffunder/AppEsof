using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void MenuInicialButton()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    #region MainMenu
    public void ScrumBut()
    {
        SceneManager.LoadScene("Scrum");
    }
    public void XpBut()
    {
        SceneManager.LoadScene("XP");
    }
    public void QuitBut()
    {
        Application.Quit();
    }
    #endregion

    #region XP
    public void CadastroXPButton()
    {
        SceneManager.LoadScene("CadastrosXP");
    }
    #region CadastroXP
    public void CadastroReleaseXPButton()
    {
        SceneManager.LoadScene("CadastroReleaseXP");
    }
    public void CadastroIteracaoXPButton()
    {
        SceneManager.LoadScene("CadastroIteracaoXP");
    }
    public void CadastroHistoriaXPButton()
    {
        SceneManager.LoadScene("CadastroHistoriaXP");
    }
    public void CadastroTarefaXPButton()
    {
        SceneManager.LoadScene("CadastroTarefaXP");
    }






    #endregion

    public void RelatoriosXPButton()
    {
        SceneManager.LoadScene("RelatoriosXP");
    }
    #region relatorioXP
    public void RelatorioReleaseXPButton()
    {
        SceneManager.LoadScene("RelatorioReleaseXP");
    }
    public void RelatorioIteracaoXPButton()
    {
        SceneManager.LoadScene("RelatorioIteracaoXP");
    }
    public void RelatorioHistoriaXPButton()
    {
        SceneManager.LoadScene("RelatorioHistoriaXP");
    }
    public void RelatorioTarefaXPButton()
    {
        SceneManager.LoadScene("RelatorioTarefaXP");
    }

    #endregion

    #endregion

    #region Scrum
    public void CadastroScrumButton()
    {
        SceneManager.LoadScene("CadastroScrum");
    }
    #region Cadastro
    public void CadastroBacklogProdutoScrumButton()
    {
        SceneManager.LoadScene("CadastroBacklogProdutoScrum");
    }
    public void CadastroSprintScrumButton()
    {
        SceneManager.LoadScene("CadastroSprintScrum");
    }
    public void CadastroTarefaScrumButton()
    {
        SceneManager.LoadScene("CadastroTarefaScrum");
    }


    #endregion

    public void RelatoriosScrumButton()
    {
        SceneManager.LoadScene("Relatorios");
    }
    #region Relatorio
    public void RelatorioBacklogProdutoScrumButton()
    {
        SceneManager.LoadScene("RelatorioBacklogProdutoScrum");
    }
    public void RelatorioBacklogSprintScrumButton()
    {
        SceneManager.LoadScene("RelatorioBacklogSprintScrum");
    }
    public void RelatorioTarefaScrumButton()
    {
        SceneManager.LoadScene("RelatorioTarefaScrum");
    }
    #endregion

    public void BurndownScrumButton()
    {
        SceneManager.LoadScene("BurndownScrum");
    }

    #endregion
}
