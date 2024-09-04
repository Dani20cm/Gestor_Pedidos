using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class Productos
{

    private int id_prod = 0;
    private string nom_prod = "";
    private double precio = 0.0;
    private int cantidad = 0;
    private double iva = 0.0;

    public int Id_prod { get => this.id_prod; set => this.id_prod = value; }
    public int Cantidad { get => this.cantidad; set => this.cantidad = value; }
    public double Precio { get => this.precio; set => this.precio = value; }
    public double Iva { get => this.iva; set => this.iva = value; }
    public string Nom_prod { get => this.nom_prod; set => this.nom_prod = value; }

}