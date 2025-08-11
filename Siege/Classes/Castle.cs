using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siege
{
    internal class Castle
    {
        private int vidaAtual { get; set; }
        private int vidaMaxima { get; set; }
        private int NivelDeCastelo { get; set; }
        private int TaxaDeConversao { get; set; } = 2;


        // ----- Construtor -----
        public Castle(int nivel, int proficiencia, int fortificacao)
        {
            this.NivelDeCastelo = nivel;
            UpdateTaxaDeConversao(proficiencia);
            SetVidaAtual(fortificacao);
        }

        // ----- Setup -----

        // Aumenta a taxa de conversão de acordo com a proficiência do heroi com o castelo
        private void UpdateTaxaDeConversao(int proficiencia)
        {
            if (NivelDeCastelo >= proficiencia)
            {
                for (int i = 0; i < proficiencia; i++)
                {
                    TaxaDeConversao += 1;
                }
            }
        }

        // Calcula a vida no inicio de uma batalha
        private void SetVidaAtual(int fortificacao)
        {
            vidaAtual = SetVidaBase() + (fortificacao * TaxaDeConversao);
            vidaMaxima = vidaAtual; // Define a vida máxima como a vida atual calculada
        }

        // Calcula o minimo de vida que um castelo deve ter
        private int SetVidaBase()
        {
            return 20 * NivelDeCastelo;
        }

        // ----- Chamados -----

        // Chamado de dano do castelo
        public bool PerderVida(int dano)
        {
            vidaAtual -= dano;
            if (vidaAtual <= 0) 
            { 
                vidaAtual = 0; 
                return true; // Retorna se castelo foi destruido
            }
            return false; // Retorna se castelo não foi destruido
        }

        // Chamado de reparo do castelo
        public void GanharVida(int reparo)
        {
            vidaAtual += reparo;
            if (vidaAtual >= vidaMaxima)
            {
                vidaAtual = vidaMaxima; // Garante que a vida não ultrapasse o máximo
            }
        }
    }
}
