namespace Modelos;

public class Registro
{
    [BsonId]
  public int Id { get; set; }
  public string NomeCompleto{get; set ;}
  public string Email { get; set; }
  public string Telefone { get; set; }
  public string CNPJ {get; set ;}
  public string Senha { get; set; }
  public string Telefone { get; set; }
}

