using LiteDB;

namespace Modelos;

public class Fornecedor : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string CNPJ {get; set ;}
  public string NomeEmpresa { get; set; }
  public string Telefone { get; set; }

}