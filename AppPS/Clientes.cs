﻿using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class Clientes
{

    private int id = 0;
    private string cedula = "";
    private string nombre = "";
    private string telefono = "";
    private string direcc = "";

    public int Id { get => this.id; set => this.id = value; }
    public string Nombre { get => this.nombre; set => this.nombre = value; }
    public string Cedula { get => this.cedula; set => this.cedula = value; }
    public string Telefono { get => this.telefono; set => this.telefono = value; }
    public string Direcc { get => this.direcc; set => this.direcc = value; }

}