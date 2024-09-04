using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Detalles
{
    private int id = 0;
    private Productos? producto = null;
    private Pedidos? pedido = null;

    public int Id { get => this.id; set => this.id = value; }
    public Productos? Producto { get => this.producto; set => this.producto = value; }
    public Pedidos? Pedido { get => this.pedido; set => this.pedido = value; }
}
