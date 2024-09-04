using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Remitentes
{
    private int id = 0;
    private string nombre = "";
    private string direcc_rem = "";

    public int Id { get => this.id; set => this.id = value; }
    public string Nombre { get => this.nombre; set => this.nombre = value; }
    public string Direcc_rem { get => this.direcc_rem; set => this.direcc_rem = value; }
}
