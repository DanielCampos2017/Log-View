using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using Microsoft.VisualBasic;



namespace log_
{
    public partial class Form1 : Form
    {
        bool senha_correta = false;
               
        private Thread ThreadExecultar;
        ClassPacote_Log Pacote_Log;


        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

          //  return;

            string resultado = Interaction.InputBox("Digite a senha", "titulo", " ", 150, 150);
            if (resultado != "")
            {
                resultado = resultado.TrimStart();
                if (resultado != "102030")
                {
                    MessageBox.Show("Senha Incorreta !");
                }
                else
                {
                    senha_correta = true;
                }  
            }
            else
            {
                MessageBox.Show("Senha Incorreta !");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (senha_correta == false)
            {
                Application.Exit();
            }
        }
          


        #region Função de Eventos - arquivos escluidos
        
        private void btnListar_Click(object sender, EventArgs e)
        {
            btnListar.Enabled = false;
            ThreadExecultar = new Thread(Lista_Filtro);
            ThreadExecultar.Start();               
        }


     


        void Lista_Filtro()
        {
            // EventLog log = EventLog.GetEventLogs().First(o => o.Log == "Security");
            try
            {
                listView1.Items.Clear(); // limpa a lista
                Pacote_Log = new ClassPacote_Log();   // cria uma instancia
               
                this.Text = "Listando Eventos..";
                int EventosEncontrados = 0;
                int EventosTotal = 0;
                int EventosProcessados = 0;
                string NomePC = Environment.MachineName;

                EventLog Eventos;

                Eventos = new EventLog();
               

                Eventos = (EventLog)EventLog.GetEventLogs().First(o => o.Log == "Security");


                Eventos.MaximumKilobytes = 2048;
                List<EventLogEntry> lista = Eventos.Entries.Cast<EventLogEntry>().ToList();

             

                // var listaOrdernadaInverso = lista.OrderByDescending(d => d.EventID); // orderna pelo eventID
                var listaOrdernadaInverso = lista.OrderByDescending(d => d.Index); // ordena pelo index

                //Lista.Whete(d => codigo == 4656)
               // var listaOrdernadaInverso2 = lista.Where(d => d.EventID == 4656);
                var listaOrdernadaInverso2 = lista.Where(d => d.EventID == 4656);



                EventosTotal = Eventos.Entries.Count;

                foreach (EventLogEntry Evento in listaOrdernadaInverso)
                {
                    EventosProcessados++;

                    this.Text = "Processado " + EventosProcessados +@"\" + EventosTotal + " Eventos";

                    if (Evento.EventID.ToString() == "4656") // filtra pelo ID
                    {
                        #region Eventos Diretorio

                        if (radioButtonDiretorio.Checked == true)
                        {
                            if (Pesquisa(Evento.ReplacementStrings[6], textBoxDiretorio.Text) == true)
                            {
                                // # faço esse tipo de filtro pq o windos faz varias exclusões de arquivos e coloca o usuario como o Nome do computador
                                if (Evento.ReplacementStrings[1] != NomePC + "$")
                                {
                                    // # verifico se o arquivo tem o codigo de exclusão confirmado
                                    if (Tipo_Log(Evento.ReplacementStrings[9]) == true)
                                    {
                                        // mota o pacote para exibir no listView
                                        Pacote_Log.data = Evento.TimeWritten.ToString();
                                        Pacote_Log.Mensagem = Evento.Message;
                                        Pacote_Log.Arquivo = Evento.ReplacementStrings[6];
                                        Pacote_Log.Usuario = Evento.ReplacementStrings[1];

                                        EventosEncontrados++;
                                        AddList(Pacote_Log); // adiciona no listView1
                                        labelQTD.Text = "Total Eventos encontrados: " + EventosEncontrados.ToString();
                                    }
                                }                                
                            }
                            continue;
                        }
                        #endregion

                        #region Eventos Data
                        // filtro por Data
                        if (radioButtonData.Checked == true)
                        {
                            if (DataLogs(textBoxDataInicio.Text, textBoxDataFim.Text, Evento.TimeWritten.ToShortDateString()) == true)
                            {
                                // # faço esse tipo de filtro pq o windos faz varias exclusões de arquivos e coloca o usuario como o Nome do computador
                                if (Evento.ReplacementStrings[1] != NomePC + "$")
                                {
                                    // # verifico se o arquivo tem o codigo de exclusão confirmado
                                    if (Tipo_Log(Evento.ReplacementStrings[9]) == true)
                                    {
                                        // mota o pacote para exibir no listView
                                        Pacote_Log.data = Evento.TimeWritten.ToString();
                                        Pacote_Log.Mensagem = Evento.Message;
                                        Pacote_Log.Arquivo = Evento.ReplacementStrings[6];
                                        Pacote_Log.Usuario = Evento.ReplacementStrings[1];

                                        EventosEncontrados++;
                                        AddList(Pacote_Log); // adiciona no listView1
                                        labelQTD.Text = "Total Eventos encontrados: " + EventosEncontrados.ToString();
                                    }
                                }
                            }
                            continue;
                        }

                        #endregion

                        #region Eventos Null

                        if (radioButtonNull.Checked == true)
                        {
                            // # faço esse tipo de filtro pq o windos faz varias exclusões de arquivos e coloca o usuario como o Nome do computador
                            if (Evento.ReplacementStrings[1] != NomePC + "$")
                            {       
                                // # verifico se o arquivo tem o codigo de exclusão confirmado
                                if (Tipo_Log(Evento.ReplacementStrings[9]) == true)
                                {
                                    // mota o pacote para exibir no listView
                                    Pacote_Log.data = Evento.TimeWritten.ToString();
                                    Pacote_Log.Mensagem = Evento.Message;
                                    Pacote_Log.Arquivo = Evento.ReplacementStrings[6];
                                    Pacote_Log.Usuario = Evento.ReplacementStrings[1];

                                    EventosEncontrados++;
                                    AddList(Pacote_Log); // adiciona no listView1
                                    labelQTD.Text = "Total Eventos encontrados: " + EventosEncontrados.ToString();
                                }
                            }
                        }

                        #endregion
                    }


                }


                if (EventosEncontrados == 0)
                {
                    MessageBox.Show("Nenhum evento de exclusão foi encontrado !");
                }
                btnListar.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: Lista_Filtro() \n\r" + e.Message);
            }
        }


    


        //# Filtra os Log por Dada
        bool DataLogs(string DadaInicio, string DataFim, string DataLog)
        {
            DateTime Inicio = Convert.ToDateTime(DadaInicio);
            DateTime Fim = Convert.ToDateTime(DataFim);
            DateTime DataAtual = Convert.ToDateTime(DataLog);
            bool retorno = false;
            
            if (DataAtual.Year >= Inicio.Year && DataAtual.Month >= Inicio.Month && DataAtual.Day >= Inicio.Day)
            {
                if (DataAtual.Year <= Fim.Year && DataAtual.Month <= Fim.Month && DataAtual.Day <= Fim.Day)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        bool Pesquisa(string Dados, string pesquisa)
        {
            bool retono = false;
            if (Dados.Contains(pesquisa) == true)
            { 
                retono = true;
            }
            return retono;
        }


        // # adiciona no listView1
        void AddList(ClassPacote_Log dados)
        {
            ListViewItem item = new ListViewItem(new[] {dados.data, dados.Usuario, dados.Arquivo ,dados.Mensagem });
            listView1.Items.Add(item);
        }

        // # Class
        public class ClassPacote_Log 
        {
           public string data;
           public string Usuario;
           public string Arquivo;
           public string Mensagem; 
        }

        // # faz a verificação se o log é de um ARQUIVO deletado
        public bool Tipo_Log(string dado)
        {
            string[] caracteres = new string[] { "\r\n\t\t\t\t","%","%" };
            string[] Objetos = dado.Split(caracteres, StringSplitOptions.RemoveEmptyEntries);

            //1538
            //1541
            bool retorno = false;

            foreach (string obj in Objetos)
            {
                if (obj == "1541")
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
                   
        #endregion
        
        #region Eventos do listView

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.FocusedItem.SubItems[3].Text;
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Text = listView1.FocusedItem.SubItems[3].Text;
            }
        }
    


        #endregion


       
  

     
       

    }
}
