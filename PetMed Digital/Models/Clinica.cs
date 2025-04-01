using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetMed_Digital.Models
{
    [Table("Clinica")]
    public class Clinica
    {
        public Clinica() {
            CasosGraves = 0;
            CasosMedios = 0;
            CasosLeves = 0;
            QntdAtendimentos = 0;
            VacinasAplicadas = 0;
            ValorBruto = 0;
            ValorLiquido = 0;
            EstoqueMedicamento = 0;
            EstoqueVacina = 0;
            DespesasClinica = 0;
            DespesasFuncionarios = 0;
        }
        public int QntdAtendimentos {  get; set; }
        public float ValorLiquido {  get; set; }
        public float ValorBruto { get; set; }
        public float DespesasClinica {  get; set; }
        public int DespesasFuncionarios {  get; set; }
        public int CasosGraves { get; set; }
        public int CasosMedios { get; set; }
        public int CasosLeves {  get; set; }
        public int VacinasAplicadas { get; set; }
        public int EstoqueVacina {  get; set; }
        public int EstoqueMedicamento { get; set; }
        public int? ListaMateriais { get; set; }



    }
}
