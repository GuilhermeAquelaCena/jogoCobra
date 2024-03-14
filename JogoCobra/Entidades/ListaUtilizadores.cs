using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JogoCobra.Entidades
{
    internal class ListaUtilizadores
    {
        private List<Utilizador> ListaUtilizador;
        private string jsonFilePath = "fjsjc.json";

        public ListaUtilizadores()
        {
            ListaUtilizador = new List<Utilizador>();
        }

        public void AdicionarJogador(String username, String password)
        {
            if (ListaUtilizador.Exists(j => j.Username == username))
            {
                MessageBox.Show("Opss!! Jogador com username ja existe!");
                return;
            }
            Utilizador nvJogador = new Utilizador(username, password);
            ListaUtilizador.Add(nvJogador);
            MessageBox.Show($"jogador{nvJogador.Username}criado com sucesso!!");
        }
        public void AtualizarDadosJogador(string user, byte nivel,int pontos)
        {
            Utilizador nJogador = ListaUtilizador.Find(J=>J.Username == user);
            if (nJogador != null)
            {
                nJogador.Level = nivel;
                nJogador.Score = pontos;
                MessageBox.Show($"Dados do jogador{nJogador.Username} atualizados com sucesso!!!");
            }
            else
                MessageBox.Show("Opss! Jogador nao encontrado!!");            
        }
       public void GuardarDados()
        {
            string json=JsonConvert.SerializeObject(ListaUtilizador);
            File.WriteAllText(jsonFilePath, json);
        }
           
        public void CarregarDados()
        {
            if (File.Exists(jsonFilePath))
            {

            }
        }
       

    }
}
